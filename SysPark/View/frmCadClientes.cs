using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using SysPark.Controler;
using SysPark.Model;
using SysPark.Properties;

namespace SysPark.View
{
    public partial class frmcadClientes : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        ModPessoas objModPessoas = new ModPessoas();
        ModCliente objModCliente = new ModCliente();
        BLCliente objBlCliente = new BLCliente();
        BLContato objBlContato = new BLContato();
        BLEndereco objBlEndereco = new BLEndereco();
        private int opcao;
        private string[] estados = new string[] { "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };


        public frmcadClientes(int Opcao)
        {
            InitializeComponent();

            this.opcao = Opcao;

            foreach (string element in estados)
            {
                cmbUF.Items.Add(new ComboBoxMod.ComboBoxItem(element));
            }            

            pnlcadClientes.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlcadClientes.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlcadClientes.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblcadCliente.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblcadCliente.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblcadCliente.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaCliente buscaCliente = new frmBuscaCliente(this, 0);
            buscaCliente.ShowDialog();
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                    return;

                carregaDados();

                if (!objBlCliente.VerificaClienteExiste(Convert.ToInt64(mskcpfCliente.Text)))
                {
                    objBlCliente.InsereCliente(objModCliente, objModPessoas);

                    var Mensagem = new frmMessage_Box("Cliente cadastrado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();

                    btnCancelar_Click(sender, e);
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Já existe um cliente cadastrado com esse CPF. \r Digite outro número de CPF", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();
                    mskcpfCliente.Clear();
                    mskcpfCliente.Focus();
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void mskcpfCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskcpfCliente.Text))
                return;

            if (!objBlCliente.VerificaClienteExiste(Convert.ToInt64(mskcpfCliente.Text)))
            {
                var dados = new ModPessoas();
                bool resultado = false;

                objBLFuncoesGenerica.CPF_CNPJ(sender, ref resultado, ref dados);

                if (resultado == true)
                {
                    txtnomeCliente.Text = dados.NomePessoa;
                    txtrgCliente.Text = dados.Rg;
                    mskdataNascimento.Text = dados.DataNascimento.ToShortDateString();
                    pcbCliente.Image = objBLFuncoesGenerica.ConverteByte_Imagem(dados.ImagemPessoa);
                    txtendCliente.Text = dados.Logradouro;
                    txtnumCliente.Text = dados.NumeroEnd.ToString();
                    txtBairro.Text = dados.Bairro;
                    txtCidade.Text = dados.Cidade;
                    cmbUF.Text = dados.UF;
                    mskcepCliente.Text = dados.Cep;
                    mskCelular.Text = dados.Celular;
                    mskTelefone.Text = dados.Telefone;
                    txtEmail.Text = dados.Email;
                }
            }
            else
            {
                var Mensagem = new frmMessage_Box("Já existe um cliente cadastrado com esse CPF. \r Digite outro número de CPF", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskcpfCliente.Clear();
                mskcpfCliente.Focus();
            }
        }

        private void mskcpfCliente_Click(object sender, EventArgs e)
        {
            mskcpfCliente.SelectionStart = Padding.Left;
        }

        private void mskcpfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.ValidaCamposNumerico(e);
        }

        private void tbMoeda_Leave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Leave(sender, e);
        }

        private void tbMoeda_Enter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Enter(sender, e);
        }

        private void tbMoeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.txtMoeda_KeyDown(sender, e);
        }

        private void startLeft_Click(object sender, EventArgs e)
        {
            var startLeft = (sender as MaskedTextBox);
            startLeft.SelectionStart = Padding.Left;
        }

        private void frmcadClientes_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            pcbCliente.Image = Resources.Imagem_50;
            pcbCliente.SizeMode = PictureBoxSizeMode.CenterImage;            
            
            if (opcao == 1)
            {
                HabilitaCampos();
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btnPesquisar.Enabled = false;
                MontaDados();
            }
            else
            {
                DesabilitaCampos();
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;                
            }
        }

        public void DesabilitaCampos()
        {
            foreach (Control ctl in pnlDados2.Controls)
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
            foreach (Control ctl in pnlImagem2.Controls)
            {
                if (ctl is PictureBox) ctl.Enabled = false;
                if (ctl is Button) ctl.Enabled = false;
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
            foreach (Control ctl in pnlImagem2.Controls)
            {
                if (ctl is PictureBox) ctl.Enabled = true;
                if (ctl is Button) ctl.Enabled = true;
                if (ctl is ComboBox) ctl.Enabled = true;
                if (ctl is CheckBox) ctl.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
            btnSalvar.Enabled = true;
            mskdataCadastro.Enabled = false;
            mskdataCadastro.Text = DateTime.Now.ToString();
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            mskcpfCliente.Focus();
            cmbUF.Text = "PR";
        }

        private bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txtnomeCliente.Text))
            {
                var Mensagem = new frmMessage_Box("Insira o nome do Cliente.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                txtnomeCliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(mskcpfCliente.Text))
            {
                var Mensagem = new frmMessage_Box("Insira o CPF do cliente.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskcpfCliente.Focus();
                return false;
            }
            if (mskdataNascimento.Text == "  /  /")
            {
                var Mensagem = new frmMessage_Box("Insira o a data de nascimento do cliente.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                mskdataNascimento.Focus();
                return false;
            }
            return true;
        }

        private void carregaDados()
        {
            objModPessoas.IdcpfcnpjPessoa = Convert.ToInt64(mskcpfCliente.Text);
            objModPessoas.NomePessoa = txtnomeCliente.Text;
            objModPessoas.Rg = txtrgCliente.Text;
            objModPessoas.DataNascimento = Convert.ToDateTime(mskdataNascimento.Text);
            objModPessoas.SituacaoPessoa = chkSituacao.Checked;
            objModPessoas.NomeAtualiza = lblnomeUsuario.Text;
            objModPessoas.ImagemPessoa = objBLFuncoesGenerica.ConverteImagem_Byte(pcbCliente.Image);
            
            objModPessoas.Logradouro = txtendCliente.Text;
            objModPessoas.NumeroEnd = Convert.ToInt32(txtnumCliente.Text);
            objModPessoas.UF = cmbUF.SelectedText;
            objModPessoas.Bairro = txtBairro.Text;
            objModPessoas.Cep = mskcepCliente.Text;
            objModPessoas.Cidade = txtCidade.Text;

            objModPessoas.Celular = mskCelular.Text;
            objModPessoas.Email = txtEmail.Text;
            objModPessoas.Telefone = mskTelefone.Text;
            objModPessoas.Website = string.Empty;
        }

        public void MontaDados()
        {
            mskdataCadastro.Mask = string.IsNullOrEmpty(objModCliente.DataCadCliente.ToShortDateString()) ? "00/00/0000" : "";
            mskdataCadastro.Text = objModCliente.DataCadCliente.ToString();
            mskdataNascimento.Mask = string.IsNullOrEmpty(objModCliente.DataNascimento.ToShortDateString()) ? "00/00/0000" : "";
            mskdataNascimento.Text = objModCliente.DataNascimento.ToString();
            txtnomeCliente.Text = objModCliente.NomePessoa;
            mskcpfCliente.Text = objModCliente.IdcpfcnpjPessoa.ToString();
            txtrgCliente.Text = objModCliente.Rg;
            chkSituacao.Checked = objModCliente.SituacaoPessoa;
            txtendCliente.Text = objModCliente.Logradouro;
            txtnumCliente.Text = objModCliente.NumeroEnd.ToString();
            txtBairro.Text = objModCliente.Bairro;
            cmbUF.Text = objModCliente.UF;
            txtCidade.Text = objModCliente.Cidade;
            mskcepCliente.Text = objModCliente.Cep;
            mskCelular.Text = objModCliente.Celular;
            mskTelefone.Text = objModCliente.Telefone;
            txtEmail.Text = objModCliente.Email;
            txtnomeAtualizado.Text = objModCliente.NomeAtualiza;
            lbldataAtualizacao.Text = objModCliente.DataAtualiza.ToString();
            pcbCliente.Image = objBLFuncoesGenerica.ConverteByte_Imagem(objModPessoas.ImagemPessoa);
            pcbCliente.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                    return;

                carregaDados();

                objBlCliente.AtualizaCliente(objModCliente, objModPessoas);

                var Mensagem = new frmMessage_Box("Cliente atualizado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                btnCancelar_Click(sender, e);
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnContas_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarFoto_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.BuscaImagem_Redimencionada(pcbCliente);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Enter(sender, e);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Leave(sender, e);
        }

        private void btnbuscaCep_Click(object sender, EventArgs e)
        {
            frmBuscaEndereco buscaEndereco = new frmBuscaEndereco(mskcepCliente.Text, txtendCliente, txtBairro, txtCidade, cmbUF, mskcepCliente);
            buscaEndereco.ShowDialog();
        }

        private void mskcepCliente_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Enter(sender, e);
        }

        private void mskcepCliente_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Leave(sender, e);
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
            frmTirarFoto foto = new frmTirarFoto(pcbCliente);
            foto.ShowDialog();
        }

        private void btnContas_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }

        private void btnaddFidel_Click(object sender, EventArgs e)
        {
        }

        private void txtrgCliente_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = string.Empty;
        }
    }
}
