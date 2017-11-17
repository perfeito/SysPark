using SysPark.Controler;
using System;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmBuscaCargo : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        ModSeguranca Seg;
        private Int64 idOperador;
        private frmcadCargo objCargo;
        BLCargo listaCargo = new BLCargo();
        ModCargo objModCargo = new ModCargo();

        public frmBuscaCargo(frmcadCargo objFrmcadCargo )
        {
            this.objCargo = objFrmcadCargo;

            InitializeComponent();

            pnlpesquisaCargo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlpesquisaCargo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlpesquisaCargo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblpesquisaCargo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblpesquisaCargo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblpesquisaCargo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            this.SuspendLayout();
            // 
            // frmBuscaCargo
            // 
            //this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmBuscaCargo";
            this.Load += new System.EventHandler(this.frmBuscaCargo_Load_1);
            this.ResumeLayout(false);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength > 2)
            {
                try
                {                   
                    dgvPesquisa.DataSource = listaCargo.BuscaCargo(txtPesquisa.Text);                    
                   
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
                        dgvPesquisa.Columns["IdCargo"].Visible = false;                       
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
                dgvPesquisa.DataSource = listaCargo.BuscaCargoTodos();  

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
                    dgvPesquisa.Columns["IdCargo"].Visible = false;                    
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
            objModCargo.IdCargo = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["IdCargo"].Value.ToString());
            objModCargo.NomeCargo = dgvPesquisa.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
            objModCargo.SituacaoCargo = Convert.ToBoolean( dgvPesquisa.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
            objModCargo.NomeAtualiza = dgvPesquisa.Rows[e.RowIndex].Cells["Atualizado por"].Value.ToString();
            objModCargo.DataAtualiza = Convert.ToDateTime( dgvPesquisa.Rows[e.RowIndex].Cells["Data Atualização"].Value.ToString());

            if (objCargo == null)
            {                
                if (Seg.CadCargo == true)
                {
                    frmcadCargo formCargo = new frmcadCargo(1);
                    formCargo.ShowDialog();
                    dgvPesquisa.DataSource = null;
                    frmBuscaCargo_Load(sender, e);
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
                objCargo.txtCargo.Enabled = true;
                objCargo.rbAtivo.Enabled = true;
                objCargo.rbInativo.Enabled = true;
                objCargo.btnEditar.Enabled = true;
                objCargo.btnCancelar.Enabled = true;
                objCargo.btnNovo.Enabled = false;
                objCargo.btnPesquisar.Enabled = false;
                objCargo.btnSalvar.Enabled = false;

                objCargo.MontaDados();
                
                this.Close();
            }                      
        }

        private void frmBuscaCargo_Load(object sender, EventArgs e)
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

        private void frmBuscaCargo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
