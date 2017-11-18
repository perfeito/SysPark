using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SysPark.Controler;

namespace SysPark.View
{
    public partial class frmAberturaCaixa : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        BLLogin objBlLogin = new BLLogin();
        BLTerminal objBlTerminal = new BLTerminal();
        BLCaixa objBlCaixa = new BLCaixa();
        BLGeral objBlGeral = new BLGeral();
        private DataTable dt;
        private DataRow row;
        public string 
            usuario,
            senha,
            textoImpressao,
            operador,
            nomeTerminal,
            marcaImp;
        public long 
            idcpf, 
            idMovimentoDia;
        public int 
            terminal;
        private int
            IRetorno,
            IRetornoSweda,
            IRetornoEpson;

        public frmAberturaCaixa()
        {
            InitializeComponent();

            pnlabreCaixa.MouseDown += objFuncao.Form_MouseDown;
            pnlabreCaixa.MouseMove += objFuncao.Form_MouseMove;
            pnlabreCaixa.MouseUp += objFuncao.Form_MouseUp;

            lblabreCaixa.MouseDown += objFuncao.Form_MouseDown;
            lblabreCaixa.MouseMove += objFuncao.Form_MouseMove;
            lblabreCaixa.MouseUp += objFuncao.Form_MouseUp;
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AbreCaixa();
        }
        

        private void AbreCaixa()
        {
            try
            {
                if (!VeificaLogin(Convert.ToInt64(txtUsuario.Text)))
                    return;

                terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                if (terminal != -1)
                {         
                    Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
                    splashthread.IsBackground = true;
                    splashthread.Start();
                    
                    objBlCaixa.AbreCaixa(Convert.ToDecimal(txtTroco.Text), idcpf, terminal, Convert.ToDateTime(DateTime.Now), idMovimentoDia);

                    var Mensagem = new frmMessage_Box("CAIXA ABERTO COM SUCESSO", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();

                    this.Close();
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Esse TERMINAL não foi cadastrado ainda. Deseja cadastra-lo agora?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Yes)
                    {
                        frmTerminal formTerminal = new frmTerminal();
                        formTerminal.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.ValidaCamposNumerico(e);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength == 6)
                txtSenha.Focus();
            else if (txtUsuario.TextLength > 6)
                objFuncao.BackSpace(sender);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.TextLength == 6)
                txtTroco.Focus();
            else if (txtSenha.TextLength > 6)
                objFuncao.BackSpace(sender);
        }

        private bool VeificaLogin(long codigo)
        {
            var objLogin = objBlLogin.VerificaAutorizacaoFuncionario(codigo);
            idcpf = objLogin.IdcpfcnpjPessoa;
            operador = objLogin.NomePessoa;


            if (objLogin.CodFunc != Convert.ToInt64(txtUsuario.Text))
            {
                var Mensagem = new frmMessage_Box("Esse USUÁRIO não existe.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                txtUsuario.Clear();
                txtUsuario.Focus();
                return false;
            }
            if (objLogin.Senha != txtSenha.Text)
            {
                var Mensagem = new frmMessage_Box("Senha não confere.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                txtSenha.Clear();
                txtSenha.Focus();
                return false;
            }
            if (txtTroco.Text == "0,00")
            {
                var Mensagem = new frmMessage_Box("CONFIRMA A ABERTURA DO CAIXA SEM TROCO (R$ 0,00)?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                if (Mensagem.ShowDialog() == DialogResult.OK)
                    return true;

                txtTroco.Focus();
                return false;
            }
            return true;
        }

        private void txtTroco_Enter(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Enter(sender, e);
        }

        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.ValidaCamposNumerico(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);

            textBox.Clear();
        }

        private void txtTroco_Leave(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Leave(sender, e);
        }

        private void txtTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.txtMoeda_KeyDown(sender, e);
        }

        private void frmAberturaCaixa_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);

            txtUsuario.Select();
            mskdataAbertura.Text = DateTime.Now.ToString();

            terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

            var dtAtual = objBlGeral.VerificaMovimentoDiaAberto();
            var row = dtAtual.Rows[0];
            idMovimentoDia = Convert.ToInt64(row["IdMovimentoDia"].ToString());
        }

        private void frmAberturaCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        btnConfirmar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    {
                        btnFechar_Click(sender, e);
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChamaTeclado_Click(object sender, EventArgs e)
        {
            ChamaTeclado();
        }

        private void ChamaTeclado()
        {
            frmTecladoNumerico teclado = new frmTecladoNumerico();
            teclado.ShowDialog();

            if (txtUsuario.Focused)
                txtUsuario.Text = teclado.txtDado.Text;
            else if (txtSenha.Focused)
                txtSenha.Text = teclado.txtDado.Text;
            else if (txtTroco.Focused)
                txtTroco.Text = teclado.txtDado.Text;
        }
    }
}
