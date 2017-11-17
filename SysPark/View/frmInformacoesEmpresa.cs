using SysPark.Controler;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmInformacoesEmpresa : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        ModGeral objModGeral = new ModGeral();
        BLGeral objBlGeral = new BLGeral();        
        Image imageHome, imageCaixa, imagemDescanso;
        DataTable dt;
        private int idInfo = 0;
        private string[] uf = new string[] { "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

        public frmInformacoesEmpresa()
        {
            InitializeComponent();

            foreach(string item in uf)
            {
                cmbUF.Items.Add(new ComboBoxMod.ComboBoxItem(item));
            }

            pnlInformacoes.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlInformacoes.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlInformacoes.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblInformacoes.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblInformacoes.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblInformacoes.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        private void frmInformacoesEmpresa_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);
            cmbUF.Text = "PR";
            dt = objBlGeral.BuscaInformacoes();   
            if(dt.Rows.Count > 0)
            {
                MontaDados();
            }            

            if(idInfo == 0)
            {
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                txtFantasia.Focus();
            }
            else
            {
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        private void btnbuscarHome_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.BuscaImagem_Original(pcbHome);            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {                
                CarregaDados();

                objBlGeral.InsereInformacoes(objModGeral);
                
                var Mensagem = new frmMessage_Box("Informações da Empresa cadastradas com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                frmInformacoesEmpresa_Load(sender, e);
            }
            catch (Exception erro)
            {               
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void CarregaDados()
        {          
            objModGeral.IdInfo = idInfo;
            objModGeral.NomeFantasia = txtFantasia.Text;
            objModGeral.RazaoSocial = txtrazaoSocial.Text;
            objModGeral.Cnpj = Convert.ToInt64(mskCpfCnpj.Text);
            objModGeral.IEstadual = mskIE.Text;
            objModGeral.Logradouro = txtEndereco.Text;
            objModGeral.NumeroEnd = Convert.ToInt32(txtNumero.Text);
            objModGeral.Bairro = txtBairro.Text;
            objModGeral.UF = cmbUF.SelectedText;
            objModGeral.Cidade = txtCidade.Text;
            objModGeral.Cep = mskCep.Text;
            objModGeral.Telefone = mskTelefone.Text;
            objModGeral.Celular = mskCelular.Text;
            objModGeral.Email = txtEmail.Text;
            objModGeral.Website = txtWebsite.Text;
            objModGeral.ImagemHome = objBLFuncoesGenerica.ConverteImagem_Byte(pcbHome.Image);
            objModGeral.ImagemDescanso = objBLFuncoesGenerica.ConverteImagem_Byte(pcbDescanso.Image);
        }

        private void MontaDados()
        {
            
            dt = objBlGeral.BuscaInformacoes();           
            var row = dt.Rows[0];

            idInfo = (int)(row["IdInformacoes"]);
            txtFantasia.Text = (string)row["NomeFantasia"];
            txtrazaoSocial.Text = (string)row["RazaoSocial"];
            mskCpfCnpj.Text = row["Cnpj"].ToString().Length == 14 ? row["Cnpj"].ToString() : "0" + row["Cnpj"].ToString();
            mskIE.Text = (string)row["IEstadual"];
            txtEndereco.Text = (string)row["Logradouro"];
            txtNumero.Text = row["NumeroEnd"].ToString();
            txtBairro.Text = (string)row["BairroEnd"];
            cmbUF.Text = (string)row["UF"];
            txtCidade.Text = (string)row["Cidade"];
            mskCep.Text = (string)row["Cep"];
            mskTelefone.Text = (string)row["Telefone"];
            mskCelular.Text = (string)row["Celular"];
            txtEmail.Text = (string)row["Email"];
            txtWebsite.Text = (string)row["Website"];
            
            pcbHome.Image = objBLFuncoesGenerica.ConverteByte_Imagem((byte[])row["LogoHome"]);
            pcbDescanso.Image = objBLFuncoesGenerica.ConverteByte_Imagem((byte[])row["LogoDescanso"]);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaDados();

                objBlGeral.AtualizaInformacoes(objModGeral);
                
                var Mensagem = new frmMessage_Box("Informações da Empresa editadas com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                frmInformacoesEmpresa_Load(sender, e);
            }
            catch (Exception erro)
            {                
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnbuscarDescanso_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.BuscaImagem_Original(pcbDescanso);
        }

        private void StartLeft_Click(object sender, EventArgs e)
        {
            var startLeft = (sender as MaskedTextBox);
            startLeft.SelectionStart = Padding.Left;
        }

        private void ValidaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.ValidaCamposNumerico(e);
        }

        private void mskCpfCnpj_Leave(object sender, EventArgs e)
        {
            if (clsValidacao.isCPFCNPJ(mskCpfCnpj.Text, false))
                return;
            
            var Mensagem = new frmMessage_Box("Insira um CNPJ válido.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
            Mensagem.ShowDialog();

            mskCpfCnpj.Text = string.Empty;
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Enter(sender, e);
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtNumero_Leave(sender, e);
        }

        private void mskCep_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Enter(sender, e);
        }

        private void btnSalvar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Leave(sender, e);
        }

        private void btnbuscaCep_Click(object sender, EventArgs e)
        {
            frmBuscaEndereco buscaEndereco = new frmBuscaEndereco(mskCep.Text, txtEndereco, txtBairro, txtCidade, cmbUF, mskCep);
            buscaEndereco.ShowDialog();
        }       
    }
}
