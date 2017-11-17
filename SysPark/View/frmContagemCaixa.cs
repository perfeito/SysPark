using SysPark.Controler;
using SysPark.Model;
using System;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmContagemCaixa : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        ModCaixa objModCaixa = new ModCaixa();
        long idConferente,
             idcaixa;


        public frmContagemCaixa()
        {
            InitializeComponent();

            pnlContagem.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlContagem.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlContagem.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblContagem.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblContagem.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblContagem.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void frmContagemCaixa_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            Label label = new Label();
            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaCpfUsuario_Load(label, ref falha);
            if (falha == true)
                Application.Exit();

            idConferente = Convert.ToInt64(label.Text);

            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            DesabilitaCampos();
        }

        public void DesabilitaCampos()
        {
            foreach (Control ctl in pnlDados2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
                if (ctl is MaskedTextBox) ctl.Enabled = false;                
            }            

            txtCheque.Enabled = false;
            txtCredito.Enabled = false;
            txtDebito.Enabled = false;
            txtDinheiro.Enabled = false;
            txtTicket.Enabled = false;
            txtVale.Enabled = false;
        }

        public void HabilitaCampos()
        {
            foreach (Control ctl in pnlDados2.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
                if (ctl is MaskedTextBox) ctl.Enabled = true;                
            }            

            txtCheque.Enabled = true;
            txtCredito.Enabled = true;
            txtDebito.Enabled = true;
            txtDinheiro.Enabled = true;
            txtTicket.Enabled = true;
            txtVale.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPesquisa.DataSource = objBlCaixa.ListaCaixasParaContagem(Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFim.Text));
                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                    var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Cancel)
                        this.Close();                    
                }
                else
                {
                    dgvPesquisa.Columns["Idcaixa"].Visible = false;
                    HeaderDataGrid();
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTerminal.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Terminal"].Value.ToString();
            txtOperador.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Operador"].Value.ToString();
            mskData.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Data"].Value.ToString();
            mskHora.Text = dgvPesquisa.Rows[e.RowIndex].Cells["Hora"].Value.ToString();
            idcaixa = (long)dgvPesquisa.Rows[e.RowIndex].Cells["IdCaixa"].Value;

            HabilitaCampos();
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);

            dgvPesquisa.DataSource = null;

            frmContagemCaixa_Load(sender, e);
        }        

        private void txtMoeda_Leave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Leave(sender, e);
        }

        private void txtMoeda_Enter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.txtMoeda_Enter(sender, e);
        }

        private void txtMoeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            objBLFuncoesGenerica.txtMoeda_KeyDown(sender, e);
        }

        private void HeaderDataGrid()
        {
            dgvPesquisa.Columns[1].Width = 215;
            dgvPesquisa.Columns[2].Width = 100;
            dgvPesquisa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns[3].Width = 100;
            dgvPesquisa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisa.Columns[4].Width = 300;
        }

        private void CarregaDados()
        {
            objModCaixa.IdcpfcnpjPessoa = idConferente;
            objModCaixa.IdCaixa = idcaixa;
            objModCaixa.DinheiroContado = Convert.ToDecimal(txtDinheiro.Text);
            objModCaixa.CreditoContado = Convert.ToDecimal(txtCredito.Text);
            objModCaixa.DebitoContado = Convert.ToDecimal(txtDebito.Text);
            objModCaixa.ChequeContado = Convert.ToDecimal(txtCheque.Text);
            objModCaixa.OutrosContado = Convert.ToDecimal(txtTicket.Text);
        }

        private void btnPesquisar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaDados();

                objBlCaixa.ContagemDeCaixa(objModCaixa);

                var Mensagem = new frmMessage_Box("Valores contados lançados com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                btnCancelar_Click(sender, e);
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
    }
}
