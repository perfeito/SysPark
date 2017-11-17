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
        BLImpressora objBlImp = new BLImpressora();
        ModCaixa objModCaixa = new ModCaixa();        
        Int64 idcaixa;
        private int
            IRetorno,
            IRetornoSweda,
            IRetornoEpson;
        private string
            textoImpressao,
            operador,
            nomeTerminal,
            marcaImp;
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

            var tipo = objBlImp.VerificaImpressoraUsoCaixa(idterminal);
            marcaImp = tipo.Marca;

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

        #region FECHAMENTO IMPRESSORA

        private void MontaTextoImpressaoBematech()
        {            
            string linha = "================================================\n";

            string textOperador = "Operador: " + operador + "\n";
            string textTerminal = "Terminal: " + nomeTerminal + "\n";

            string fundo = "Fundo de Caixa: " + txtTroco.Text + "\n";
            string dinheiro = "Dinheiro: " + txtDinheiro.Text + "\n";
            string credito = "Crédito: " + txtCredito.Text + "\n";
            string debito = "Débito: " + txtDebito.Text + "\n";
            string cheque = "Cheque: " + txtCheque.Text + "\n";
            string textDesconto = "Desconto: " + desconto.ToString() + "\n";
            string total = "Total: " + txtTotal.Text + "\n";
            string valorCancel = "Total Cancelado: " + txtvalorCancel.Text + "\n";
            string sangria = "Sangria: " + txtSangria.Text + "\n";
            string suprimento = "Suprimento: " + txtSuprimento.Text + "\n";
            string valeTroca = "Vale Troca: " + txtVale.Text + "\n";

            textoImpressao = (
                linha 
                + "FECHAMENTO DO CAIXA\n" 
                + linha 
                + textOperador 
                + textTerminal 
                + linha 
                + "\nSaída de Operador\n\n\n" 
                + linha 
                + fundo 
                + dinheiro 
                + credito 
                + debito 
                + cheque 
                + valeTroca 
                + textDesconto 
                + valorCancel 
                + sangria 
                + suprimento 
                + total 
                + linha
                );
        }

        private void MontaTextoImpressaoSweda()
        {           
            string linha = "==========================================\n";

            string textOperador = "Operador: " + operador + "\n";
            string textTerminal = "Terminal: " + nomeTerminal + "\n";

            string fundo = "Fundo de Caixa: " + txtTroco.Text + "\n";
            string dinheiro = "Dinheiro: " + txtDinheiro.Text + "\n";
            string credito = "Crédito: " + txtCredito.Text + "\n";
            string debito = "Débito: " + txtDebito.Text + "\n";
            string cheque = "Cheque: " + txtCheque.Text + "\n";
            string textDesconto = "Desconto: " + desconto.ToString() + "\n";
            string total = "Total: " + txtTotal.Text + "\n";
            string valorCancel = "Total Cancelado: " + txtvalorCancel.Text + "\n";
            string sangria = "Sangria: " + txtSangria.Text + "\n";
            string suprimento = "Suprimento: " + txtSuprimento.Text + "\n";
            string valeTroca = "Vale Troca: " + txtVale.Text + "\n";

            textoImpressao = (
                linha
                + "FECHAMENTO DO CAIXA\n" 
                + linha 
                + textOperador 
                + textTerminal 
                + linha
                + "\nSaída de Operador\n\n\n"
                + linha 
                + fundo 
                + dinheiro 
                + credito 
                + debito 
                + cheque 
                + valeTroca 
                + textDesconto 
                + valorCancel 
                + sangria 
                + suprimento 
                + total 
                + linha
                );
        }

        private void MontaTextoImpressaoEpson()
        {            
            string linha = "========================================================\n";

            string textOperador = "<AN>Operador: " + operador + "\n";
            string textTerminal = "Terminal: " + nomeTerminal + "<DN>\n";

            string fundo = "Fundo de Caixa: " + txtTroco.Text + "\n";
            string dinheiro = "Dinheiro: " + txtDinheiro.Text + "\n";
            string credito = "Crédito: " + txtCredito.Text + "\n";
            string debito = "Débito: " + txtDebito.Text + "\n";
            string cheque = "Cheque: " + txtCheque.Text + "\n";
            string textDesconto = "Desconto: " + desconto.ToString() + "\n";
            string total = "Total: " + txtTotal.Text + "\n";
            string valorCancel = "Total Cancelado: " + txtvalorCancel.Text + "\n";
            string sangria = "Sangria: " + txtSangria.Text + "\n";
            string suprimento = "Suprimento: " + txtSuprimento.Text + "\n";
            string valeTroca = "Vale Troca: " + txtVale.Text + "\n";

            textoImpressao = 
                linha 
                + "FECHAMENTO DO CAIXA\n" 
                + linha 
                + textOperador 
                + textTerminal 
                + linha 
                + "\nSaída de Operador\n\n\n" 
                + linha 
                + fundo 
                + dinheiro 
                + credito 
                + debito
                + cheque 
                + valeTroca
                + textDesconto
                + valorCancel 
                + sangria 
                + suprimento
                + total 
                + linha
                ;
        }

        #endregion

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
            txtvalorCancel.Text = valores.ValorCancelado.ToString();
            txtTicket.Text = valores.Outros.ToString();
            txtQtdCupons.Text = valores.QtdCupom.ToString();
            txtSangria.Text = valores.ValorSangria.ToString();
            txtSuprimento.Text = valores.ValorSuprimento.ToString();

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
