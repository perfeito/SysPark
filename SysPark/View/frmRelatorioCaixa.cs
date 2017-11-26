using SysPark.Controler;
using SysPark.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmRelatorioCaixa : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        ModCaixa objModCaixa = new ModCaixa();       
        DataTable dt;
        string dataInicio,
               dataFim;


        public frmRelatorioCaixa()
        {
            InitializeComponent();

            pnlrelCaixa.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlrelCaixa.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlrelCaixa.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblrelCaixa.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblrelCaixa.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblrelCaixa.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void frmRelatorioCaixa_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            RelatorioUltimoMovimento();            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = objBlCaixa.RelatorioCaixa(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFim.Text));
                dgvPesquisa.DataSource = objBlCaixa.RelatorioCaixa(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFim.Text));

                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                }
                else
                {
                    dataInicio = dtpInicio.Text;
                    dataFim = dtpFim.Text;
                    Cabecalho();
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void RelatorioUltimoMovimento()
        {
            try
            {
                dt = objBlCaixa.RelatorioCaixaUltimoMovimento();
                dgvPesquisa.DataSource = objBlCaixa.RelatorioCaixaUltimoMovimento();

                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                }
                else
                {
                    Cabecalho();
                    dataInicio = dgvPesquisa.Rows[dgvPesquisa.CurrentRow.Index].Cells["Abertura"].Value.ToString();
                    dataFim = dgvPesquisa.Rows[dgvPesquisa.CurrentRow.Index].Cells["Abertura"].Value.ToString();
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
            mskData.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Fechamento"].Value.ToString();
            mskHora.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Hora Fechamento"].Value.ToString();
            txtOperador.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Operador"].Value.ToString();
            txtTerminal.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Terminal"].Value.ToString();
            txtDinheiroRe.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Dinheiro Registrado"].Value.ToString();
            txtCreditoRe.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Crédito Registrado"].Value.ToString();
            txtDebitoRe.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Débito Registrado"].Value.ToString();
            txtChequeRe.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Cheque Registrado"].Value.ToString();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            dgvPesquisa.DataSource = null;
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

        private void btnPesquisar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void Cabecalho()
        {
            dgvPesquisa.Columns["Dinheiro Registrado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Crédito Registrado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Débito Registrado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Cheque Registrado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisa.Columns["Abertura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Hora Abertura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Fechamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Hora Fechamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns["Fundo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
