using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using SysPark.Controler;
using SysPark.Properties;

namespace SysPark.View
{
    public partial class frmcadFuncionarios : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLCargo objBlCargo = new BLCargo();
        BLFuncionario objBlFuncionario = new BLFuncionario();
        BLContato objBlContato = new BLContato();
        BLEndereco objBlEndereco = new BLEndereco();
        BLGeral objBlGeral = new BLGeral();
        ModCargo objModCargo = new ModCargo();
        ModFuncionario objModFuncionario = new ModFuncionario();
        ModPessoas objModPessoas = new ModPessoas();
        public string usuario, senha;
        private int opcao;
        private string[] estados = new string[]
        {
             "AL",
             "AP",
             "AM",
             "BA",
             "CE",
             "DF",
             "ES",
             "GO",
             "MA",
             "MT",
             "MS",
             "MG",
             "PA",
             "PB",
             "PR",
             "PE",
             "PI",
             "RJ",
             "RN",
             "RS",
             "RO",
             "RR",
             "SC",
             "SP",
             "SE",
             "TO"
        };

        public frmcadFuncionarios(int Opcao)
        {
            InitializeComponent();

            this.opcao = Opcao;

            foreach (string element in estados)
            {
                cmbUfFuncionarios.Items.Add(new ComboBoxMod.ComboBoxItem(element));
            }

            pnlcadFuncionarios.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlcadFuncionarios.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlcadFuncionarios.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblcadFuncionarios.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblcadFuncionarios.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblcadFuncionarios.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                    return;

                var codigo = objBlFuncionario.VerificaCodigoFuncionarioExiste(Convert.ToInt64(txtCodFunc.Text));

                if (codigo.IdcpfcnpjPessoa != Convert.ToInt64(mskcpfFuncionarios.Text) && codigo.CodFunc != Convert.ToInt64(txtCodFunc.Text))
                {
                    carregaDados();

                    if (!objBlFuncionario.VerificaFuncionarioExiste(Convert.ToInt64(mskcpfFuncionarios.Text)))
                    {
                        objBlFuncionario.InsereFuncionario(objModFuncionario, objModCargo, objModPessoas); 

                        var Mensagem = new frmMessage_Box("Funcionário cadastrado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        if (opcao == 2)
                        {
                            Mensagem = new frmMessage_Box("É preciso cadastrar o usuário e senha para esse funcionário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();

                            frmcadLogin objLogin = new frmcadLogin(txtnomeFuncionarios.Text, Convert.ToInt64(mskcpfFuncionarios.Text), usuario, senha);
                            objLogin.ShowDialog();
                        }

                        btnCancelar_Click(sender, e);
                    }
                    else
                    {
                        var Mensagem = new frmMessage_Box("Já existe um funcionário cadastrado com esse CPF. \r Digite outro número de CPF", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        mskcpfFuncionarios.Clear();
                        mskcpfFuncionarios.Focus();
                    }
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Já existe um funcionário cadastrado com esse Código. \r Digite outro Código", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();
                    txtCodFunc.Clear();
                    txtCodFunc.Focus();
                }

            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void gbAssinadas_Enter(object sender, EventArgs e)
        {

        }

        private void btncadLogin_Click(object sender, EventArgs e)
        {
            frmcadLogin objLogin = new frmcadLogin(txtnomeFuncionarios.Text, Convert.ToInt64(mskcpfFuncionarios.Text), usuario, senha);
            objLogin.ShowDialog();
        }

        private void txtSalario_Enter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Enter(sender, e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.txtMoeda_KeyDown(sender, e);
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Leave(sender, e);
        }

        private void startLeft_Click(object sender, EventArgs e)
        {
            var startLeft = (sender as MaskedTextBox);
            startLeft.SelectionStart = Padding.Left;
        }

        private void mskcpfFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.ValidaCamposNumerico(e);
        }

        private void mskcpfFuncionarios_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskcpfFuncionarios.Text))
                return;

            if (!objBlFuncionario.VerificaFuncionarioExiste(Convert.ToInt64(mskcpfFuncionarios.Text)))
            {
                var dados = new ModPessoas();
                bool resultado = false;

                objBLFuncoesGenerica.CPF_CNPJ(sender, ref resultado, ref dados);

                if (resultado == true)
                {
                    txtnomeFuncionarios.Text = dados.NomePessoa;
                    txtrgFuncionarios.Text = dados.Rg;
                    mskdataNasc.Text = dados.DataNascimento.ToShortDateString();
                    pcbimagenFuncionario.Image = objBLFuncoesGenerica.ConverteByte_Imagem(dados.ImagemPessoa);
                    txtendFuncionarios.Text = dados.Logradouro;
                    txtnumFuncionarios.Text = dados.NumeroEnd.ToString();
                    txtbairroFuncionarios.Text = dados.Bairro;
                    txtcidadeFuncionarios.Text = dados.Cidade;
                    cmbUfFuncionarios.Text = dados.UF;
                    mskcepFuncionarios.Text = dados.Cep;
                    mskcelularFuncionarios.Text = dados.Celular;
                    msktelefoneFuncionarios.Text = dados.Telefone;
                    txtemailFuncionarios.Text = dados.Email;
                }
            }
            else
            {
                var Mensagem = new frmMessage_Box("Já existe um funcionário cadastrado com esse CPF. \r Digite outro número de CPF", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskcpfFuncionarios.Clear();
                mskcpfFuncionarios.Focus();
            }            
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmcadFuncionarios_Load(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            pcbimagenFuncionario.Image = Resources.Imagem_50;
            pcbimagenFuncionario.SizeMode = PictureBoxSizeMode.CenterImage;

            if (opcao == 1)
            {
                HabilitaCampos();
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btncadLogin.Enabled = true;
                btnPesquisar.Enabled = false;
                mskdataDemissao.ReadOnly = false;

                MontaDados();
            }
            else if (opcao == 2)
            {
                HabilitaCampos();
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btncadLogin.Enabled = true;
                btnPesquisar.Enabled = false;
                mskdataDemissao.ReadOnly = false;

                txtnomeFuncionarios.Select();
            }
            else
            {
                DesabilitaCampos();
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btncadLogin.Enabled = false;
            }
        }

        public void listaCargo()
        {
            try
            {
                cmbcargoFuncionarios.Items.Clear();

                var cmbItem = objBlCargo.ListaCargoAtivos();
                foreach (DataRow row in cmbItem.Rows)
                {
                    cmbcargoFuncionarios.Items.Add(new ComboBoxMod.ComboBoxItem(
                        row["NomeCargo"].ToString(),
                        Convert.ToInt32(row["IdCargo"])
                        ));
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                    return;

                var codigo = objBlFuncionario.VerificaCodigoFuncionarioExiste(Convert.ToInt64(txtCodFunc.Text));

                if (codigo.CodFunc == Convert.ToInt64(txtCodFunc.Text) && codigo.IdcpfcnpjPessoa != Convert.ToInt64(mskcpfFuncionarios.Text))
                {
                    var Mensagem = new frmMessage_Box("Já existe um funcionário cadastrado com esse Código. \r Digite outro Código", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();
                    txtCodFunc.Clear();
                    txtCodFunc.Focus();
                }
                else
                {
                    carregaDados();

                    objBlFuncionario.AtualizaFuncionario(objModFuncionario, objModCargo, objModPessoas);                    

                    var Mensagem = new frmMessage_Box("Funcionário atualizado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();

                    btnCancelar_Click(sender, e);
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            DesabilitaCampos();
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btncadLogin.Enabled = false;
            cmbUfFuncionarios.Text = "PR";
        }

        public void DesabilitaCampos()
        {
            foreach (Control ctl in pnlDados2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
                if (ctl is Button) ctl.Enabled = false;
            }
            foreach (Control ctl in pnlImagem2.Controls)
            {
                if (ctl is PictureBox) ctl.Enabled = false;
                if (ctl is Button) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
            }
            foreach (Control ctl in pnlValores2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
            }
            foreach (Control ctl in pnlEndereco2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
                if (ctl is Button) ctl.Enabled = false;
            }
            foreach (Control ctl in pnlContato2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;
                if (ctl is ComboBox) ctl.Enabled = false;
                if (ctl is CheckBox) ctl.Enabled = false;
            }
        }

        public void HabilitaCampos()
        {
            foreach (Control ctl in pnlDados2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
                if (ctl is Button) ctl.Enabled = true;
            }
            foreach (Control ctl in pnlImagem2.Controls)
            {
                if (ctl is PictureBox) ctl.Enabled = true;
                if (ctl is Button) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
            }
            foreach (Control ctl in pnlValores2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
            }
            foreach (Control ctl in pnlEndereco2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
                if (ctl is Button) ctl.Enabled = true;
            }
            foreach (Control ctl in pnlContato2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            listaCargo();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            mskdataDemissao.ReadOnly = true;
            mskdataAdmissao.Text = DateTime.Now.ToString();
            mskcpfFuncionarios.Focus();
            cmbUfFuncionarios.Text = "PR";
        }

        private bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txtnomeFuncionarios.Text))
            {
                var Mensagem = new frmMessage_Box("Insira o nome do Funcionário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                txtnomeFuncionarios.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodFunc.Text) || txtCodFunc.Text == "000000")
            {
                var Mensagem = new frmMessage_Box("Insira o Código do Funcionário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                txtnomeFuncionarios.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(mskcpfFuncionarios.Text))
            {
                var Mensagem = new frmMessage_Box("Insira o CPF", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskcpfFuncionarios.Focus();
                return false;
            }
            if (mskdataNasc.Text == "  /  /")
            {
                var Mensagem = new frmMessage_Box("Insira o a data de nascimento do funcionário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskdataNasc.Focus();
                return false;
            }
            if (cmbcargoFuncionarios.Text == string.Empty)
            {
                var Mensagem = new frmMessage_Box("Insira o cargo do funcionário.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                cmbcargoFuncionarios.Focus();
                return false;
            }
            return true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaFuncionario buscaFuncionario = new frmBuscaFuncionario(this, null, null);
            buscaFuncionario.ShowDialog();
        }

        private void carregaDados()
        {
            objModPessoas.IdcpfcnpjPessoa = Convert.ToInt64(mskcpfFuncionarios.Text);
            objModPessoas.NomePessoa = txtnomeFuncionarios.Text;
            objModPessoas.Rg = txtrgFuncionarios.Text;
            objModPessoas.DataNascimento = Convert.ToDateTime(mskdataNasc.Text);
            objModFuncionario.Salario = Convert.ToDecimal(txtSalario.Text);
            objModFuncionario.Comissao = Convert.ToInt64(txtComissao.Text);
            objModFuncionario.CarteiraTrabalho = txtcartTrabalho.Text.Length > 6 ? Convert.ToInt32(txtcartTrabalho.Text.Substring(0,6)) : Convert.ToInt32(txtcartTrabalho.Text);
            objModPessoas.SituacaoPessoa = chkSituacao.Checked;
            objModFuncionario.DataAdimissao = Convert.ToDateTime(mskdataAdmissao.Text);

            objModFuncionario.DataDemissao = mskdataDemissao.Text == "  /  /" ? (DateTime?)null : Convert.ToDateTime(mskdataDemissao.Text);

            objModPessoas.NomeAtualiza = lblnomeUsuario.Text;
            objModCargo.IdCargo = Convert.ToInt32(cmbcargoFuncionarios.SelectedValue);

            objModPessoas.Logradouro = txtendFuncionarios.Text;
            objModPessoas.NumeroEnd = Convert.ToInt32(txtnumFuncionarios.Text);
            objModPessoas.UF = cmbUfFuncionarios.SelectedText;
            objModPessoas.Bairro = txtbairroFuncionarios.Text;
            objModPessoas.Cep = mskcepFuncionarios.Text;
            objModPessoas.Cidade = txtcidadeFuncionarios.Text;

            objModPessoas.Celular = mskcelularFuncionarios.Text;
            objModPessoas.Email = txtemailFuncionarios.Text;
            objModPessoas.Telefone = msktelefoneFuncionarios.Text;
            objModPessoas.Website = string.Empty;

            objModFuncionario.ImagemPessoa = objBLFuncoesGenerica.ConverteImagem_Byte(pcbimagenFuncionario.Image);
            objModFuncionario.CodFunc = Convert.ToInt64(txtCodFunc.Text);
        }

        public void MontaDados()
        {
            txtnomeFuncionarios.Text = objModFuncionario.NomePessoa;
            mskcpfFuncionarios.Text = objModFuncionario.IdcpfcnpjPessoa.ToString().Length == 11 ? objModFuncionario.IdcpfcnpjPessoa.ToString() : "0" + objModFuncionario.IdcpfcnpjPessoa.ToString();
            txtrgFuncionarios.Text = objModFuncionario.Rg;
            mskdataNasc.Mask = string.IsNullOrEmpty(objModFuncionario.DataNascimento.ToShortDateString()) ? "00/00/0000" : "";
            mskdataNasc.Text = objModFuncionario.DataNascimento.ToString();
            txtendFuncionarios.Text = objModFuncionario.Logradouro;
            txtnumFuncionarios.Text = objModFuncionario.NumeroEnd.ToString();
            txtbairroFuncionarios.Text = objModFuncionario.Bairro;
            cmbUfFuncionarios.Text = objModFuncionario.UF;
            txtcidadeFuncionarios.Text = objModFuncionario.Cidade;
            mskcepFuncionarios.Text = objModFuncionario.Cep;
            msktelefoneFuncionarios.Text = objModFuncionario.Telefone;
            mskcelularFuncionarios.Text = objModFuncionario.Celular;
            txtemailFuncionarios.Text = objModFuncionario.Email;
            listaCargo();
            cmbcargoFuncionarios.Text = objModCargo.NomeCargo;
            txtcartTrabalho.Text = objModFuncionario.CarteiraTrabalho.ToString();
            chkSituacao.Checked = objModFuncionario.SituacaoPessoa;
            mskdataAdmissao.Mask = string.IsNullOrEmpty(objModFuncionario.DataAdimissao.ToShortDateString()) ? "00/00/0000" : "";
            mskdataAdmissao.Text = objModFuncionario.DataAdimissao.ToString();
            mskdataDemissao.Mask = string.IsNullOrEmpty(objModFuncionario.DataDemissao.ToString()) ? "00/00/0000" : "";
            mskdataDemissao.Text = objModFuncionario.DataDemissao.ToString();
            lblnomeAtualizacao.Text = objModFuncionario.NomeAtualiza;
            lbldataAtualizacao.Text = objModFuncionario.DataAtualiza.ToString();
            txtSalario.Text = objModFuncionario.Salario.ToString();
            txtvalorComissao.Text = objModFuncionario.Comissao.ToString();
            usuario = objModFuncionario.Usuario;
            senha = objModFuncionario.Senha;

            pcbimagenFuncionario.Image = objBLFuncoesGenerica.ConverteByte_Imagem(objModFuncionario.ImagemPessoa);
            pcbimagenFuncionario.SizeMode = PictureBoxSizeMode.CenterImage;
            txtCodFunc.Text = string.Format("{0:000000}", objModFuncionario.CodFunc);
        }      

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.MinimizarAzul(sender);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.MinimizarBranco(sender);
        }

        private void btnbuscarFoto_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.BuscaImagem_Redimencionada(pcbimagenFuncionario);
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Enter(sender, e);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Leave(sender, e);
        }

        private void btnaddCargo_Click(object sender, EventArgs e)
        {
            frmcadCargo cadCargo = new frmcadCargo(0);
            cadCargo.ShowDialog();
            listaCargo();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.ValidaCamposNumerico(e);
        }

        private void ButtonAdd_Enter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.BordaAzul(sender, e);
        }

        private void buttonAdd_Leave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.BordaBranca(sender, e);
        }

        private void mskcepFuncionarios_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Enter(sender, e);
        }

        private void mskcepFuncionarios_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Leave(sender, e);
        }

        private void btnbuscaCep_Click(object sender, EventArgs e)
        {
            frmBuscaEndereco buscaEndereco = new frmBuscaEndereco(mskcepFuncionarios.Text, txtendFuncionarios, txtbairroFuncionarios, txtcidadeFuncionarios, cmbUfFuncionarios, mskcepFuncionarios);
            buscaEndereco.ShowDialog();
        }

        private void txtCodFunc_Enter(object sender, EventArgs e)
        {
            try
            {
                var tbMoeda = sender as TextBox;

                if (tbMoeda != null && tbMoeda.Text == "000000")
                {
                    tbMoeda.Text = string.Empty;
                }
                else
                {
                    if (tbMoeda == null)
                        return;
                    tbMoeda.SelectionStart = 0;
                    tbMoeda.SelectionLength = tbMoeda.Text.Length;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void txtCodFunc_Leave(object sender, EventArgs e)
        {
            try
            {
                var tbMoeda = (sender as TextBox);

                if (tbMoeda != null)
                {
                    tbMoeda.Text = tbMoeda.Text == string.Empty
                                       ? "000000"
                                       : string.Format("{0:000000}", double.Parse(tbMoeda.Text));
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        
        private void chkSituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSituacao.Checked)
            {
                chkSituacao.BackColor = Color.MediumSeaGreen;
                chkSituacao.Text = "Ativo";
            }
            else
            {
                chkSituacao.BackColor = Color.IndianRed;
                chkSituacao.Text = "Inativo";
            }
        }

        private void btntirarFoto_Click(object sender, EventArgs e)
        {
            frmTirarFoto foto = new frmTirarFoto(pcbimagenFuncionario);
            foto.ShowDialog();
        }

        private void btnSalvar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }      

        private void btngeraCodigo_Click(object sender, EventArgs e)
        {
            Random codRandom = new Random();

            txtCodFunc.Text = string.Format("{0:000000}", codRandom.Next(0, 1000000));
        }
    }
}
