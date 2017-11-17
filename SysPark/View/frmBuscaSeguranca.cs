using SysPark.Controler;
using System;
using System.Windows.Forms;


namespace SysPark
{
    public partial class frmBuscaSeguranca : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        ModSeguranca objModSeg = new ModSeguranca();
        ModFuncionario objModFunc = new ModFuncionario();
        ModCargo objModCargo = new ModCargo();
        frmSeguranca seg;



        public frmBuscaSeguranca(frmSeguranca Seg)
        {
            InitializeComponent();

            this.seg = Seg;

            pnlpesquisaSeg.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlpesquisaSeg.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlpesquisaSeg.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblpesquisaSeg.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblpesquisaSeg.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblpesquisaSeg.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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
        }*/

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
                    dgvPesquisa.DataSource = objBlSeg.BuscaFuncionarioSegurancaNome(txtPesquisa.Text);

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
                        dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
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
                dgvPesquisa.DataSource = objBlSeg.BuscaFuncionarioSegurancaTodos();
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
                    dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
                    //dgvPesquisa.Columns["Usuario"].Visible = false;
                    //dgvPesquisa.Columns["Senha"].Visible = false;                   
                }
            }
            catch (Exception erro)
            {                
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void frmBuscaSeguranca_Load(object sender, EventArgs e)
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
        }

        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objModSeg.AbreCaixa = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["AbreCaixa"].Value;
            objModSeg.Cadastro = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Cadastros"].Value;
            objModSeg.CadCargo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadCargos"].Value;
            objModSeg.CadClientes = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadClientes"].Value;
            objModSeg.CadFornecedores = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadFornecedores"].Value;
            objModSeg.CadFuncionarios = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadFuncionarios"].Value;
            objModSeg.CadGrupo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadGrupos"].Value;
            objModSeg.CadLogin = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadLogin"].Value;
            objModSeg.CadProdutos = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadProdutos"].Value;
            objModSeg.CadPromocao = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadPromocao"].Value;
            objModSeg.CadServicos = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadServicos"].Value;
            objModSeg.CadSubGrupo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CadSubGrupos"].Value;
            objModSeg.CancelarItem = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CancelarItem"].Value;
            objModSeg.Configuracoes = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Configuracoes"].Value;
            objModSeg.FechaCaixa = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["FecharCaixa"].Value;
            objModSeg.Home = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Home"].Value;
            objModSeg.Informacoes = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Informacoes"].Value;
            objModSeg.ModificarPreco = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["ModificarPreco"].Value;
            objModSeg.MovimentoDia = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["MovimentoDia"].Value;
            objModSeg.PesCargo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesCargos"].Value;
            objModSeg.PesClientes = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesClientes"].Value;
            objModSeg.PesFornecedor = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesFornecedores"].Value;
            objModSeg.PesFuncionarios = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesFuncionarios"].Value;
            objModSeg.PesGrupo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesGrupos"].Value;
            objModSeg.PesProdutos = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesProdutos"].Value;
            objModSeg.PesPromocao = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesPromocao"].Value;
            objModSeg.Pesquisa = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Pesquisas"].Value;
            objModSeg.PesServicos = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesServicos"].Value;
            objModSeg.PesSubGrupo = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["PesSubGrupos"].Value;
            objModSeg.Procedimento = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Procedimentos"].Value;
            objModSeg.Relatorio = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Relatorios"].Value;
            objModSeg.Terminal = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["Terminal"].Value;
            objModSeg.IdFuncionario = (Int64)dgvPesquisa.Rows[e.RowIndex].Cells["IdcpfcnpjPessoa"].Value;
            objModSeg.IdSeguanca = (Int64)dgvPesquisa.Rows[e.RowIndex].Cells["IdSeguranca"].Value;
            objModFunc.NomePessoa = dgvPesquisa.Rows[e.RowIndex].Cells["NomePessoa"].Value.ToString();
            objModCargo.NomeCargo = dgvPesquisa.Rows[e.RowIndex].Cells["NomeCargo"].Value.ToString();
            objModFunc.ImagemPessoa = (byte[])dgvPesquisa.Rows[e.RowIndex].Cells["ImagemPessoa"].Value;
            objModSeg.AbreDia = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["AbreDia"].Value;
            objModSeg.FechaDia = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["FechaDia"].Value;
            objModSeg.LeituraX = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["LeituraX"].Value;
            objModSeg.ReducaoZ = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["ReducaoZ"].Value;
            objModSeg.ProgAliquota = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["ProgAliquota"].Value;
            objModSeg.CancelUltimoCupom = (bool)dgvPesquisa.Rows[e.RowIndex].Cells["CancelUltimoCupom"].Value;

            seg.MontaDados();
            seg.VerificaChecks();

            seg.btnCancelar.Enabled = true;
            seg.btnEditar.Enabled = true;
            seg.btnSalvar.Enabled = false;
            seg.btnNovo.Enabled = false;
            seg.btnPesquisar.Enabled = false;

            this.Close();
        }
    }
}
