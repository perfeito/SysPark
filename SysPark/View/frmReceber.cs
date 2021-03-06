﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SysPark.Model;
using SysPark.Controler;

namespace SysPark.View
{
    public partial class frmReceber : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        ModCaixa objModCaixa = new ModCaixa();
        BLCaixa objBlCaixa = new BLCaixa();
        BLTerminal objBlTerminal = new BLTerminal();
        frmTecladoNumerico teclado = new frmTecladoNumerico();
        frmCaixa caixa;
        decimal 
            dinheiro,
            debito,
            credito,
            cheque,
            totalRecebido,
            totalPagar;
        public string 
            operador,
            marcaImp,
            valorIbpt,
            percIbpt,
            descCliente,
            cliente,
            tributos;


        public frmReceber(frmCaixa Caixa)
        {
            InitializeComponent();

            this.caixa = Caixa;

            pnlReceber.MouseDown += objFuncao.Form_MouseDown;
            pnlReceber.MouseMove += objFuncao.Form_MouseMove;
            pnlReceber.MouseUp += objFuncao.Form_MouseUp;

            lblReceber.MouseDown += objFuncao.Form_MouseDown;
            lblReceber.MouseMove += objFuncao.Form_MouseMove;
            lblReceber.MouseUp += objFuncao.Form_MouseUp;
        }

        /*private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }*/

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceber_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        this.Close();
                    }
                    break;
                case Keys.F2:
                    {
                        Limpar();
                    }
                    break;
                case Keys.F9:
                    {
                        btnCheque_Click(sender, e);
                    }
                    break;
                case Keys.F10:
                    {
                        btnDebito_Click(sender, e);
                    }
                    break;
                case Keys.F11:
                    {
                        btnCredito_Click(sender, e);
                    }
                    break;
                case Keys.F12:
                    {
                        btnDinheiro_Click(sender, e);
                    }
                    break;
                case Keys.Enter:
                    {
                        TerminarRecebimento();
                    }
                    break;
            }
        }       

        private void txtCalculo_TextChanged(object sender, EventArgs e)
        {
            CalculaValores();
        }

        private void txtValores_Enter(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Enter(sender, e);
        }

        private void txtValores_Leave(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Leave(sender, e);
        }

        private void txtValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            //objFuncao.txtMoeda_KeyDown(sender, e);
        }        

        private void frmReceber_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);

            txtTotal.Text = caixa.txtTotal.Text;
            CalculaValores();
            txtPagamento.Select();

            int terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void txtPagamento_Click(object sender, EventArgs e)
        {
            //teclado.ShowDialog();

            //txtPagamento.Text = teclado.txtDado.Text;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            TerminarRecebimento();
        }

        private void TerminarRecebimento()
        {
            if (totalRecebido >= totalPagar)
            {
                CalculaValores();

                Finalizar();

                caixa.LimparTudo();
                caixa.Close();
            }
            else if (totalRecebido == 0)
            {
                var Mensagem = new frmMessage_Box("Insira o valor do recebimento.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
            else if (totalRecebido < totalPagar)
            {
                var Mensagem = new frmMessage_Box("Valor RECEBIDO é menor que o TOTAL.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void CalculaValores()
        {
            try
            {
                txttotalRecebido.Text = (dinheiro + cheque + credito + debito).ToString("N2");

                totalPagar = !string.IsNullOrEmpty(txtTotal.Text)
                                  ? Convert.ToDecimal(txtTotal.Text)
                                  : 0.00m;

                totalRecebido = !string.IsNullOrEmpty(txttotalRecebido.Text)
                                    ? Convert.ToDecimal(txttotalRecebido.Text)
                                    : 0.00m;

                txtTroco.Text = (totalRecebido - totalPagar).ToString("N2");

                var troco = !string.IsNullOrEmpty(txtTroco.Text)
                                  ? Convert.ToDecimal(txtTroco.Text)
                                  : 0.00m;

                if (troco >= 0)
                {
                    lblTroco.Text = "Troco";
                    pnlTroco.BackColor = Color.SeaGreen;
                }
                else
                {
                    lblTroco.Text = "Falta Receber";
                    txtTroco.Text = Math.Abs(troco).ToString();
                    pnlTroco.BackColor = Color.IndianRed;
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void Finalizar()
        {
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            CarregaDadosFinalizar();

            new BLVenda().FechaVendaPorPlaca(new ModVenda
            {
                Placa = caixa.txtPlaca.Text,
                SubTotal = Convert.ToDecimal(caixa.txtsubTotal.Text),
                Desconto = Convert.ToDecimal(caixa.txtDesconto.Text),
                HoraSaida = DateTime.Now,
                Dinheiro = dinheiro,
                Debito = debito,
                Cheque = cheque,
                Credito = credito,
                IdCaixaFechamento = caixa.idcaixa
            }
            );

            objBlCaixa.AtualizaCaixa(objModCaixa);

            SplashScreen.UdpateStatusTextWithStatus("Venda finalizada.", TypeOfMessage.Success);
            Thread.Sleep(1000);

            SplashScreen.UdpateStatusTextWithStatus("TROCO: " + txtTroco.Text, TypeOfMessage.Success);
            Thread.Sleep(1000);

            SplashScreen.CloseSplashScreen();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            BLGeral objBlGeral = new BLGeral();
            var idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
            var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);

            frmCaixa caixa1 = new frmCaixa(dadosCaixa.IdCaixa);
            caixa1.TopMost = true;
            caixa1.Show();
        }

        private void txtPagamento_TextChanged(object sender, EventArgs e)
        {
        }

        private void Limpar()
        {
            txtPagamento.Clear();
            txttotalRecebido.Text = "0,00";
            dinheiro = 0.00m;
            debito = 0.00m;
            credito = 0.00m;
            cheque = 0.00m;
            txtPagamento.Focus();

            CalculaValores();
        }        

        private void CarregaDadosFinalizar()
        {
            objModCaixa.Dinheiro = dinheiro;
            objModCaixa.Credito = credito;
            objModCaixa.Debito = debito;
            objModCaixa.Cheque = cheque;
            objModCaixa.DescontoVenda = Convert.ToDecimal(caixa.txtDesconto.Text);
            objModCaixa.ValorRecebido = Convert.ToDecimal(txttotalRecebido.Text);
            objModCaixa.ValorTotal = Convert.ToDecimal(txtTotal.Text);
            objModCaixa.Troco = Convert.ToDecimal(txtTroco.Text);
            objModCaixa.IdCaixa = caixa.idcaixa;
        }
        
        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            dinheiro += !string.IsNullOrEmpty(txtPagamento.Text)
                      ? Convert.ToDecimal(txtPagamento.Text)
                      : 0.00m;

            CalculaValores();
            txtPagamento.Clear();
            txtPagamento.Focus();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            credito += !string.IsNullOrEmpty(txtPagamento.Text)
                     ? Convert.ToDecimal(txtPagamento.Text)
                     : 0.00m;

            CalculaValores();
            txtPagamento.Clear();
            txtPagamento.Focus();
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Leave(txtPagamento, e);

            debito += !string.IsNullOrEmpty(txtPagamento.Text)
                    ? Convert.ToDecimal(txtPagamento.Text)
                    : 0.00m;

            CalculaValores();
            txtPagamento.Clear();
            txtPagamento.Focus();
        }

        private void btnCheque_Click(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Leave(txtPagamento, e);

            cheque += !string.IsNullOrEmpty(txtPagamento.Text)
                    ? Convert.ToDecimal(txtPagamento.Text)
                    : 0.00m;

            CalculaValores();
            txtPagamento.Clear();
            txtPagamento.Focus();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void DigitaNumero_Click(object sender, EventArgs e)
        { 
            var button = (sender as Button);

            objFuncao.txtMoeda_KeyDown(txtPagamento, new KeyPressEventArgs( Convert.ToChar( button.Tag)));
              
        }
        
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            objFuncao.BackSpace(txtPagamento);            
        }
    }
}
