using SysPark.Controler;
using SysPark.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmBuscaCliente : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        ModSeguranca Seg;
        private long idOperador;
        BLCliente objCliente = new BLCliente();
        ModCliente objModCliente = new ModCliente();
        readonly private frmcadClientes clientes;       
        private int opcao;
        

        public frmBuscaCliente(frmcadClientes formClientes, int Opcao)
        {
            InitializeComponent();

            this.clientes = formClientes;
            this.opcao = Opcao;            

            pnlpesquisaCliente.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlpesquisaCliente.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlpesquisaCliente.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblpesquisaCliente.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblpesquisaCliente.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblpesquisaCliente.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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
        }   */ 

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            objModCliente.IdcpfcnpjPessoa = 0;

            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength > 2)
            {
                try
                {
                    dgvPesquisa.DataSource = objCliente.BuscaClienteNome(txtPesquisa.Text);

                    if (dgvPesquisa.Rows.Count <= 0)
                    {
                        dgvPesquisa.DataSource = null;                  
                    }
                    else
                    {
                        dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
                        Alinhamento();                     
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
                dgvPesquisa.DataSource = objCliente.BuscaClienteTodos();

                if (dgvPesquisa.Rows.Count <= 0)
                {
                    dgvPesquisa.DataSource = null;        
                }
                else
                {
                    dgvPesquisa.Columns["ImagemPessoa"].Visible = false;
                    Alinhamento();
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
            
            objModCliente.DataCadCliente = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Data de Cadastro"].Value.ToString());
            objModCliente.DataNascimento = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Data Nascimento"].Value.ToString());
            objModCliente.NomePessoa = dgvPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            objModCliente.IdcpfcnpjPessoa = Convert.ToInt64(dgvPesquisa.Rows[e.RowIndex].Cells["CPF"].Value.ToString());
            objModCliente.Rg = dgvPesquisa.Rows[e.RowIndex].Cells["RG"].Value.ToString();
            objModCliente.SituacaoPessoa = Convert.ToBoolean(dgvPesquisa.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());
            objModCliente.Logradouro = dgvPesquisa.Rows[e.RowIndex].Cells["Endereço"].Value.ToString();
            objModCliente.NumeroEnd = Convert.ToInt32(dgvPesquisa.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
            objModCliente.Bairro = dgvPesquisa.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
            objModCliente.UF = dgvPesquisa.Rows[e.RowIndex].Cells["UF"].Value.ToString();
            objModCliente.Cidade = dgvPesquisa.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
            objModCliente.Cep = dgvPesquisa.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
            objModCliente.Celular = dgvPesquisa.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
            objModCliente.Telefone = dgvPesquisa.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            objModCliente.Email = dgvPesquisa.Rows[e.RowIndex].Cells["Email"].Value.ToString();        
            objModCliente.NomeAtualiza = dgvPesquisa.Rows[e.RowIndex].Cells["Atualizado Por"].Value.ToString();
            objModCliente.DataAtualiza = Convert.ToDateTime(dgvPesquisa.Rows[e.RowIndex].Cells["Data Atualização"].Value.ToString());
            objModCliente.ImagemPessoa = (byte[])dgvPesquisa.Rows[e.RowIndex].Cells["ImagemPessoa"].Value;

            if (clientes == null && opcao == 0)
            {                
                if (Seg.CadClientes == true)
                {
                    frmcadClientes formClientes = new frmcadClientes(1);
                    formClientes.ShowDialog();
                    dgvPesquisa.DataSource = null;
                    frmBuscaCliente_Load(sender, e);
                }
                else
                {
                    var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                    return;
                }
            }
            else if(clientes != null && opcao == 0)
            {
                clientes.HabilitaCampos();
                clientes.btnCancelar.Enabled = true;
                clientes.btnEditar.Enabled = true;
                clientes.btnNovo.Enabled = false;
                clientes.btnSalvar.Enabled = false;
                clientes.btnPesquisar.Enabled = false;
                clientes.MontaDados();
                
                this.Close();
            }
            else if (clientes == null && opcao == 1)
            {               
                this.Close();
            }            
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

        private void frmBuscaCliente_Load(object sender, EventArgs e)
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

        private void Alinhamento()
        {
            dgvPesquisa.Columns["Nº Visitas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
        }
    }
}
