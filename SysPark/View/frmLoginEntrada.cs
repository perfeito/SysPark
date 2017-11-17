using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using SysPark.Controler;

namespace SysPark
{
    public partial class frmLoginEntrada : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLLogin objBlLogin = new BLLogin();
        BLTerminal objBlTerminal = new BLTerminal();
        private DataTable dt;
        private DataRow row;
        public string usuario, senha;
        public Int64 idcpf;
        public int terminal;      
        

        public frmLoginEntrada()
        {
            InitializeComponent();            

            pnlLogin.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlLogin.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlLogin.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblLogin.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblLogin.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblLogin.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        //private const int CS_DROPSHADOW = 0x00020000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VeificaLogin(txtUsuario.Text))
                return;

            terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

            if (terminal != -1)
            {
                objBlLogin.InsereUsuarioLogado(idcpf, terminal);

                var Mensagem = new frmMessage_Box("LOGIN EFETUADO COM SUCESSO", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();               

                this.Close();
                frmHome objHome = new frmHome();
                objHome.ShowDialog();  
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
                    this.Close();
                }
            }
        }

        private bool VeificaLogin(string Usuario)
        {
            var objLogin = objBlLogin.VerificaLoginEntrada(Usuario);
            idcpf = objLogin.IdcpfcnpjPessoa;

            if (objLogin.Usuario != txtUsuario.Text)
            {
                var Mensagem = new frmMessage_Box("Esse USUÁRIO não existe.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                txtUsuario.Text = "";
                txtUsuario.Focus();
                //txtUsuario.BorderColor = System.Drawing.Color.Red;           
                return false;
            }
            if (objLogin.Senha != txtSenha.Text)
            {
                var Mensagem = new frmMessage_Box("Senha não confere.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                txtSenha.Text = "";
                txtSenha.Focus();
                //txtUsuario.BorderColor = System.Drawing.Color.Red;            
                return false;
            }
            return true;
        }

        private void frmLoginEntrada_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();

            objBLFuncoesGenerica.Drop_Shadow(this);

            SplashScreen.UdpateStatusTextWithStatus("Carregando tela de login...", TypeOfMessage.Process);
            Thread.Sleep(1000);
            SplashScreen.UdpateStatusTextWithStatus("Tela de login carregada com sucesso.", TypeOfMessage.Success);
            Thread.Sleep(1000);
            SplashScreen.CloseSplashScreen();            
        }


        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.BordaBranca(sender, e);
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.SemBorda(sender, e);
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        private void txtUsuario_Load(object sender, EventArgs e)
        {
            var Mensagem = new frmMessage_Box("Senha não confere.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
            Mensagem.ShowDialog();
            txtSenha.Text = "";
            txtSenha.Focus();
        }

        private void frmLoginEntrada_KeyDown(object sender, KeyEventArgs e)
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
                        btnCancelar_Click(sender, e);
                    }
                    break;
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }          
    }
}
