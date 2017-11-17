using SysPark.Controler;
using SysPark.Model;
using System;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmBuscaTipoVeiculo : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        ModSeguranca Seg;
        private Int64 idOperador;
        BLTipoVeiculo objBLTipoVeiculo = new BLTipoVeiculo();
        ModTipoVeiculo objModTipoVeiculo = new ModTipoVeiculo();

        public frmBuscaTipoVeiculo()
        {
            InitializeComponent();

            pnlpesquisaGrupo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlpesquisaGrupo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlpesquisaGrupo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblpesquisaGrupo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblpesquisaGrupo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblpesquisaGrupo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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
                    dgvPesquisa.DataSource = objBLTipoVeiculo.BuscaTipoVeiculo(txtPesquisa.Text);

                    if (dgvPesquisa.Rows.Count <= 0)
                    {
                        dgvPesquisa.DataSource = null;
                        var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                        if (Mensagem.ShowDialog() == DialogResult.Cancel)
                            this.Close();
                        txtPesquisa.Clear();
                        txtPesquisa.Focus();                        
                    }
                    else
                    {
                        dgvPesquisa.Columns["ID"].Visible = false;                       
                    }
                }
                catch (Exception erro)
                {                    
                    var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                }
            }
        }

        private void frmBuscaGrupo_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);
            try
            {
                dgvPesquisa.DataSource = objBLTipoVeiculo.BuscaTipoVeiculoTodos();
                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                    var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Cancel)
                        this.Close();
                    txtPesquisa.Clear();
                    txtPesquisa.Focus();                   
                }
                else
                {
                    dgvPesquisa.Columns["ID"].Visible = false;                    
                }
            }
            catch (Exception erro)
            {                
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPesquisa.DataSource = objBLTipoVeiculo.BuscaTipoVeiculoTodos();
                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;
                    var Mensagem = new frmMessage_Box("Não foram encontrados dados em sua busca.\rDeseja fazer uma nova busca?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Cancel)
                        this.Close();
                    txtPesquisa.Clear();
                    txtPesquisa.Focus();                    
                }
                else
                {
                    dgvPesquisa.Columns["IdGrupo"].Visible = false;                    
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
            try
            {
                objModTipoVeiculo.IdTipo = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                objModTipoVeiculo.Descrição = dgvPesquisa.Rows[e.RowIndex].Cells["Descrição"].Value.ToString();
                objModTipoVeiculo.Ativo = Convert.ToBoolean(dgvPesquisa.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
                objModTipoVeiculo.CortesiaAte = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["Minutos de Cortesia"].Value.ToString());
                objModTipoVeiculo.ValorHora = Convert.ToDecimal(dgvPesquisa.Rows[e.RowIndex].Cells["Valor da hora"].Value.ToString());
                
                        frmCadTipoVeiculo formCadTipoVeiculo = new frmCadTipoVeiculo(1);
                        formCadTipoVeiculo.ShowDialog();
                        dgvPesquisa.DataSource = null;
                        frmBuscaGrupo_Load(sender, e);
            }
            catch (Exception ex)
            {

                throw;
            }
                
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }
    }
}
