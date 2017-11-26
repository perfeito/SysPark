using SysPark.Controler;
using System;
using System.Data;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmRelatorioVeiculosPatio : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        DataTable dt;


        public frmRelatorioVeiculosPatio()
        {
            InitializeComponent();

            pnlrelDesc.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlrelDesc.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlrelDesc.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblrelDesc.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblrelDesc.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblrelDesc.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void frmRelatorioDescontos_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            Pesquisar();
        }

        private void Pesquisar()
        {
            try
            {
                dgvPesquisa.DataSource = objBlCaixa.Relatorio_Precos_Modificados();

                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                }
                txtTotal.Text = (dgvPesquisa.Rows.Count).ToString();
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void CalculaTotal()
        {
            decimal total = 0.00m;
            foreach(DataRow row in dt.Rows)
            {
                total += (decimal)row["Desconto"];
            }
            txtTotal.Text = total.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
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

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
