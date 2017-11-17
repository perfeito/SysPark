using SysPark.Controler;
using System;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmBuscaEndereco : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();        
        string cep;
        TextBox txtrua, txtbairro, txtcidade;
        ComboBox cmbestado;
        MaskedTextBox mskcep;

        public frmBuscaEndereco(string CEP, TextBox Rua, TextBox Bairro, TextBox Cidade, ComboBox Estado, MaskedTextBox MaskCep)
        {
            InitializeComponent();

            this.cep = CEP;
            txtrua = Rua;
            txtbairro = Bairro;
            txtcidade = Cidade;
            cmbestado = Estado;
            mskcep = MaskCep;

            pnlbuscaCep.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlbuscaCep.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlbuscaCep.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblbuscaCep.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblbuscaCep.MouseMove += objBLFuncoesGenerica.Form_MouseMove; 
            lblbuscaCep.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

       /* private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        } */   

        private void frmBuscaEndereco_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            try
            {
                msknumCep.Text = cep;

                Address address = BuscaCep.GetAddress(msknumCep.Text);

                txtnomeRua.Text = address.Street;
                txtnomeBairro.Text = address.District;
                txtnomeCidade.Text = address.City;
                txtnomeEstado.Text = address.State;
            }
            catch(Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
                msknumCep.Focus();
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtrua.Text = txtnomeRua.Text;
            txtbairro.Text = txtnomeBairro.Text;
            txtcidade.Text = txtnomeCidade.Text;
            cmbestado.Text = txtnomeEstado.Text;
            mskcep.Text = msknumCep.Text;

            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            cep = msknumCep.Text;
            frmBuscaEndereco_Load(sender, e);
        }

        private void StartLeft_Click(object sender, EventArgs e)
        {
            var startLeft = (sender as MaskedTextBox);
            startLeft.SelectionStart = Padding.Left;
        }

        private void mskCep_Enter(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Enter(sender, e);
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.txtCep_Leave(sender, e);
        }
    }
}
