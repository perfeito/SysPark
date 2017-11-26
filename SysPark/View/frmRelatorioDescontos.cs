using SysPark.Controler;
using System;
using System.Data;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmRelatorioDescontos : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        DataTable dt;


        public frmRelatorioDescontos()
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

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            DateTime primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpInicio.Text = primeiroDia.ToShortDateString();
            DateTime ultimoDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dtpFim.Text = ultimoDia.ToShortDateString();

            Pesquisar();
        }

        private void Pesquisar()
        {
            try
            {
                dt = objBlCaixa.Relatorio_Precos_Modificados(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFim.Text));
                dgvPesquisa.DataSource = objBlCaixa.Relatorio_Precos_Modificados(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFim.Text));

                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                    var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Cancel)
                        this.Close();
                }
                else
                {
                    Cabecalho();
                    CalculaTotal();
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void Cabecalho()
        {
            dgvPesquisa.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Desconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Qtd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Valor Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Vl. Unitário"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Fidelidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Cód. Venda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskData.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Data"].Value.ToString();
            mskHora.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Hora"].Value.ToString();
            txtCodigo.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Código"].Value.ToString();
            txtTerminal.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Terminal"].Value.ToString();
            txtProduto.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
            txtUsuario.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Op. Desconto"].Value.ToString();
            txtDesconto.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Desconto"].Value.ToString();
            txtvalorItem.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Valor Item"].Value.ToString();
            txtvalorUnit.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Vl. Unitário"].Value.ToString();
            txtQtd.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Qtd"].Value.ToString();
            txtvlFidelidade.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Fidelidade"].Value.ToString();
        }

        private void btnPesquisar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }
    }
}
