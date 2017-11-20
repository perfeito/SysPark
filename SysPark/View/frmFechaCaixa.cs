using System;
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
using SysPark.Controler;
using SysPark.Model;

namespace SysPark.View
{
    public partial class frmFechaCaixa : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        BLTerminal objBlTerminal = new BLTerminal();
        ModCaixa objModCaixa = new ModCaixa();        
        Int64 idcaixa;
        private string
            operador,
            nomeTerminal;
        decimal desconto;

        public frmFechaCaixa()
        {
            InitializeComponent();

            pnlfechaCaixa.MouseDown += objFuncao.Form_MouseDown;
            pnlfechaCaixa.MouseMove += objFuncao.Form_MouseMove;
            pnlfechaCaixa.MouseUp += objFuncao.Form_MouseUp;

            lblfechaCaixa.MouseDown += objFuncao.Form_MouseDown;
            lblfechaCaixa.MouseMove += objFuncao.Form_MouseMove;
            lblfechaCaixa.MouseUp += objFuncao.Form_MouseUp;
        }

        private void frmFechaCaixa_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);

            mskdataFechamento.Text = DateTime.Now.ToShortDateString();
            mskHora.Text = DateTime.Now.ToShortTimeString();

            var idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
            var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);
            idcaixa = dadosCaixa.IdCaixa;
            operador = dadosCaixa.NomePessoa.Length >= 30
                                     ? dadosCaixa.NomePessoa.Substring(0, 30)
                                     : dadosCaixa.NomePessoa;
            nomeTerminal = dadosCaixa.NomeTerminal;

            MontaValores();

            pnlfechaCaixa.Select();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                PreparaFechar();        
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void MontaValores()
        {
            var valores = objBlCaixa.BuscaValoresCaixa(idcaixa);

            txtDinheiro.Text = valores.Dinheiro.ToString();
            txtCredito.Text = valores.Credito.ToString();
            txtDebito.Text = valores.Debito.ToString();
            txtCheque.Text = valores.Cheque.ToString();
            txtTroco.Text = valores.Troco.ToString();            
            desconto = valores.DescontoVenda;
            txtDesconto.Text = desconto.ToString();

            txtTotal.Text = (valores.Troco + valores.Dinheiro + valores.Credito + valores.Debito + valores.Cheque + valores.Outros + valores.ValorSuprimento - valores.ValorSangria).ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreparaFechar()
        {
            objModCaixa.IdCaixa = idcaixa;
            objModCaixa.DataFechamento = DateTime.Now;
            objBlCaixa.FechaCaixa(objModCaixa);

            var Mensagem = new frmMessage_Box("CAIXA FECHADO COM SUCESSO", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
            Mensagem.ShowDialog();

            this.Close();
        }

        private void frmFechaCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        this.Close();
                    }
                    break;
                case Keys.Enter:
                    {
                        btnConfirmar_Click(sender, e);
                    }
                    break;
            }
        }
    }
}
