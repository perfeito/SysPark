using SysPark.Controler;
using SysPark.View;
using System;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmcadLogin : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        private string nome, usuario, senha;
        private Int64 cpf;
        ModFuncionario objModFuncionario = new ModFuncionario();
        ModPessoas objModPessoas = new ModPessoas();
        BLLogin objBlLogin = new BLLogin();

        public frmcadLogin(string Nome, Int64 CPF, string Usuario, string Senha)
        {
            InitializeComponent();

            if(!string.IsNullOrEmpty(Nome))
            {
                this.lblnomeFuncionario.Text = Nome.Length >= 31
                                 ? Nome.Substring(0, 31)
                                 : Nome;
            }
            else
            {
                this.lblnomeFuncionario.Text = Nome;
            }
            
            this.lblcpfFuncionario.Text = CPF.ToString();
            txtnomeUsuario.Text = Usuario;
            txtSenha.Text = Senha;
            txtconfSenha.Text = Senha;

            pnlcadLogin.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlcadLogin.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlcadLogin.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblcadLogin.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblcadLogin.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblcadLogin.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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
        } */   

        private void btnFechar_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaFuncionario objBuscaFuncionario = new frmBuscaFuncionario(null, this, null);
            objBuscaFuncionario.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            lblnomeFuncionario.Text = string.Empty;
            lblcpfFuncionario.Text = string.Empty;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void frmcadLogin_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            if (string.IsNullOrEmpty(lblnomeFuncionario.Text))
            {
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                btnPesquisar.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {
                btnCancelar.Enabled = true;
                btnPesquisar.Enabled = false;
                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    btnSalvar.Enabled = true;
                    btnEditar.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                    btnSalvar.Enabled = false;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtnomeUsuario.Text))
                {
                    var login = objBlLogin.VerificaLoginExiste(txtnomeUsuario.Text);

                    if (login.Usuario != txtnomeUsuario.Text && login.IdcpfcnpjPessoa != Convert.ToInt64(lblcpfFuncionario.Text))
                    {
                        if (txtSenha.Text == txtconfSenha.Text)
                        {
                            objModFuncionario.Usuario = txtnomeUsuario.Text;
                            objModFuncionario.Senha = txtSenha.Text;
                            objModPessoas.IdcpfcnpjPessoa = Convert.ToInt64(lblcpfFuncionario.Text);

                            objBlLogin.InsereLogin(objModFuncionario, objModPessoas);
                            
                            var Mensagem = new frmMessage_Box("Login cadastrado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();

                            btnCancelar_Click(sender, e);
                        }
                        else
                        {                            
                            var Mensagem = new frmMessage_Box("As senhas não conferem.\rDigite novamente.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                            Mensagem.ShowDialog();
                            txtSenha.Text = string.Empty;
                            txtconfSenha.Text = string.Empty;
                            txtSenha.Focus();
                        }
                    }
                    else
                    {                        
                        var Mensagem = new frmMessage_Box("Este usuário já existe. \rEscolha outro nome de usuário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        txtnomeUsuario.Text = string.Empty;
                        txtnomeUsuario.Focus();
                    }
                }
                else
                {                    
                    var Mensagem = new frmMessage_Box("Digite um nome de usuário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();
                    txtnomeUsuario.Focus();
                }

            }
            catch(Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            objModFuncionario.Usuario = txtnomeUsuario.Text;
            objModFuncionario.Senha = txtSenha.Text;
            objModPessoas.IdcpfcnpjPessoa = Convert.ToInt64(lblcpfFuncionario.Text);

            if (!string.IsNullOrEmpty(txtnomeUsuario.Text))
            {
                var login = objBlLogin.VerificaLoginExiste(txtnomeUsuario.Text);

                if (login.Usuario == txtnomeUsuario.Text && login.IdcpfcnpjPessoa != Convert.ToInt64(lblcpfFuncionario.Text))
                {
                    var Mensagem = new frmMessage_Box("Este usuário já existe. \rEscolha outro nome de usuário", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    txtnomeUsuario.Text = string.Empty;
                    txtnomeUsuario.Focus();                   
                }
                else
                {
                    if (txtSenha.Text == txtconfSenha.Text)
                    {
                        objBlLogin.AtualizaLogin(objModFuncionario, objModPessoas);
                        
                        var Mensagem = new frmMessage_Box("Login atualizado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        btnCancelar_Click(sender, e);
                    }
                    else
                    {                        
                        var Mensagem = new frmMessage_Box("As senhas não conferem.\nDigite novamente.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        txtSenha.Text = string.Empty;
                        txtconfSenha.Text = string.Empty;
                        txtSenha.Focus();
                    }     
                }
            }
            else
            {                
                var Mensagem = new frmMessage_Box("Digite um nome de usuário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                txtnomeUsuario.Focus();
            }
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        public string GerarSenhas()
        {
            int Tamanho = 16; // Numero de digitos da senha
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122) || (codigo >= 65 && codigo <= 90))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;

        }

        private void btnPesquisar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }

        private void btngeraSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = GerarSenhas();
            txtconfSenha.Text = GerarSenhas();
            txtSenha.UseSystemPasswordChar = false;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }
    }
}
