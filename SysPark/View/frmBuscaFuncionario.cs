using SysPark.Controler;
using System;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmBuscaFuncionario : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        ModSeguranca Seg;
        private Int64 idOperador;
        BLFuncionario objBlFuncionario = new BLFuncionario();
        ModFuncionario objModFuncionario = new ModFuncionario();
        ModCargo objModCargo = new ModCargo();
        BLSeguranca objBlSeguranca = new BLSeguranca();
        private frmcadFuncionarios funcionarios;
        private frmcadLogin login;
        private frmSeguranca seguranca;



        public frmBuscaFuncionario(frmcadFuncionarios formFuncionario, frmcadLogin formLogin, frmSeguranca formSeguranca)
        {
            InitializeComponent();

            this.funcionarios = formFuncionario;
            this.login = formLogin;
            this.seguranca = formSeguranca;

            pnlpesquisaCargo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlpesquisaCargo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlpesquisaCargo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblpesquisaFuncionario.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblpesquisaFuncionario.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblpesquisaFuncionario.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        /*ivate const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }*/

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength > 2)
            {
                try
                {
                    dgvPesquisa.DataSource = objBlFuncionario.BuscaFuncionarioNome(txtPesquisa.Text);

                    if (dgvPesquisa.Rows.Count <= 0)
                    {
                        dgvPesquisa.DataSource = null;
                        var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                        if (Mensagem.ShowDialog() == DialogResult.Cancel)
                            this.Close();
                        txtPesquisa.Clear();
                        txtPesquisa.Focus();                        
                    }
                    else
                    {
                        dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
                        dgvPesquisa.Columns["Usuario"].Visible = false;
                        dgvPesquisa.Columns["Senha"].Visible = false;                        
                    }
                }
                catch (Exception erro)
                {                    
                    var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPesquisa.DataSource = objBlFuncionario.BuscaFuncionarioTodos();
                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                    var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Cancel)
                        this.Close();
                    txtPesquisa.Clear();
                    txtPesquisa.Focus();                   
                }
                else
                {
                    dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
                    dgvPesquisa.Columns["Usuario"].Visible = false;
                    dgvPesquisa.Columns["Senha"].Visible = false;                    
                }
            }
            catch (Exception erro)
            {                
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            objModFuncionario.NomePessoa = dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            objModFuncionario.IdcpfcnpjPessoa = (Int64)dgvPesquisa.Rows[e.RowIndex].Cells["CPF"].Value;
            objModFuncionario.Rg = dgvPesquisa.Rows[e.RowIndex].Cells["RG"].Value.ToString();
            objModFuncionario.DataNascimento = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Data Nascimento"].Value.ToString());
            objModFuncionario.Logradouro = dgvPesquisa.Rows[e.RowIndex].Cells["Endereço"].Value.ToString();
            objModFuncionario.NumeroEnd = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
            objModFuncionario.Bairro = dgvPesquisa.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
            objModFuncionario.UF = dgvPesquisa.Rows[e.RowIndex].Cells["UF"].Value.ToString();
            objModFuncionario.Cidade = dgvPesquisa.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
            objModFuncionario.Cep = dgvPesquisa.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
            objModFuncionario.Telefone = dgvPesquisa.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            objModFuncionario.Celular = dgvPesquisa.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
            objModFuncionario.Email = dgvPesquisa.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            objModCargo.NomeCargo = dgvPesquisa.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
            objModFuncionario.CarteiraTrabalho = Convert.ToInt64(dgvPesquisa.Rows[e.RowIndex].Cells["Carteira de Trabalho"].Value.ToString());
            objModFuncionario.SituacaoPessoa = Convert.ToBoolean(dgvPesquisa.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
            objModFuncionario.Contas = Convert.ToBoolean(dgvPesquisa.Rows[e.RowIndex].Cells["Contas"].Value.ToString());
            objModFuncionario.DataAdimissao = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Admitido"].Value.ToString());
            objModFuncionario.DataDemissao = string.IsNullOrEmpty(dgvPesquisa.Rows[e.RowIndex].Cells["Demitido"].Value.ToString())
                                             ? (DateTime?)null
                                             : Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Demitido"].Value.ToString());
            objModFuncionario.NomeAtualiza = dgvPesquisa.Rows[e.RowIndex].Cells["Atualizado Por"].Value.ToString();
            objModFuncionario.DataAtualiza = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Data Atualização"].Value.ToString());
            objModFuncionario.Salario = Convert.ToDecimal(dgvPesquisa.Rows[e.RowIndex].Cells["Salário"].Value.ToString());
            objModFuncionario.Comissao = Convert.ToInt64(dgvPesquisa.Rows[e.RowIndex].Cells["Comissão"].Value.ToString());
            objModFuncionario.Usuario = dgvPesquisa.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            objModFuncionario.Senha = dgvPesquisa.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            objModFuncionario.CodFunc = (Int64)dgvPesquisa.Rows[e.RowIndex].Cells["Código"].Value;

            objModFuncionario.ImagemPessoa = (byte[])dgvPesquisa.Rows[e.RowIndex].Cells["ImagemPessoa"].Value;



            if (login != null)
            {
                login.lblnomeFuncionario.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString().Length >= 31
                                                  ? dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString().Substring(0, 31)
                                                  : dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                login.lblcpfFuncionario.Text = dgvPesquisa.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                login.txtnomeUsuario.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                login.txtSenha.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                login.txtconfSenha.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
                if (string.IsNullOrEmpty(login.txtSenha.Text))
                {
                    login.btnCancelar.Enabled = true;
                    login.btnEditar.Enabled = false;
                    login.btnPesquisar.Enabled = false;
                    login.btnSalvar.Enabled = true;
                }
                else
                {
                    login.btnCancelar.Enabled = true;
                    login.btnEditar.Enabled = true;
                    login.btnPesquisar.Enabled = false;
                    login.btnSalvar.Enabled = false;
                }

                this.Close();
            }
            else if (funcionarios != null)
            {
                funcionarios.HabilitaCampos();
                funcionarios.btnCancelar.Enabled = true;
                funcionarios.btnEditar.Enabled = true;
                funcionarios.btnNovo.Enabled = false;
                funcionarios.btnSalvar.Enabled = false;
                funcionarios.btncadLogin.Enabled = true;
                funcionarios.btnPesquisar.Enabled = false;
                funcionarios.mskdataDemissao.ReadOnly = false;

                funcionarios.MontaDados();

                this.Close();
            }
            else if (seguranca != null)
            {                
                if (Seg.Seguranca == true)
                {
                    if (objBlSeguranca.VerificaSegurancaExiste((Int64)dgvPesquisa.Rows[e.RowIndex].Cells["CPF"].Value))
                    {
                        var Mensagem = new frmMessage_Box("Este funcionário já tem um perfil de segurança cadastrado.\rEscolha outro.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        return;
                    }
                    else
                    {
                        seguranca.lblexibeNome.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString().Length >= 31
                                                  ? dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString().Substring(0, 31)
                                                  : dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                        seguranca.lblexibeId.Text = dgvPesquisa.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                        seguranca.lblxibeCargo.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
                        seguranca.pcbimagenFuncionario.Image = objBLFuncoesGenerica.ConverteByte_Imagem((byte[])dgvPesquisa.Rows[e.RowIndex].Cells["ImagemPessoa"].Value);

                        seguranca.VerificaChecks();

                        seguranca.btnPesquisar.Enabled = false;
                        seguranca.btnNovo.Enabled = false;
                        seguranca.btnCancelar.Enabled = true;
                        seguranca.btnEditar.Enabled = false;
                        seguranca.btnSalvar.Enabled = true;

                        this.Close();
                    }
                }
                else
                {
                    var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                    return;
                }
            }
            else
            {                
                if (Seg.CadFuncionarios == true)
                {
                    frmcadFuncionarios formFuncionario = new frmcadFuncionarios(1);
                    formFuncionario.ShowDialog();
                    dgvPesquisa.DataSource = null;
                    frmBuscaFuncionario_Load(sender, e);
                }
                else
                {
                    var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                    return;
                }
            }
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.MinimizarAzul(sender);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.MinimizarBranco(sender);
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        private void frmBuscaFuncionario_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            btnTodos_Click(sender, e);

            objBLFuncoesGenerica.CarregaIdOperador_Load(idOperador);
            Seg = objBlSeg.VerificaPermissaoSeguranca(idOperador);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                objBLFuncoesGenerica.Button_Maximizar(sender, this);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                objBLFuncoesGenerica.Button_Maximizar(sender, this);
            }
            objBLFuncoesGenerica.Refresh_Drop_Shadow();
        }
    }
}
