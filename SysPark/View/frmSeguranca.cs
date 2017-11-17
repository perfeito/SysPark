using SysPark.Controler;
using SysPark.View;
using System;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmSeguranca : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeguranca = new BLSeguranca();
        ModSeguranca objModSeguranca = new ModSeguranca();
        ModFuncionario objModFunc = new ModFuncionario();
        ModCargo objModCargo = new ModCargo();
        public Int64 idSeguranca;


        public frmSeguranca()
        {
            InitializeComponent();

            pnlSeguranca.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlSeguranca.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlSeguranca.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblSeguranca.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblSeguranca.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblSeguranca.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {   
            frmBuscaFuncionario buscaFuncionario = new frmBuscaFuncionario(null, null, this);
            buscaFuncionario.ShowDialog();  
        }

        private void frmSeguranca_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;            

            VerificaChecks();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblexibeId.Text = "";
            lblexibeNome.Text = "";
            lblxibeCargo.Text = "";
            pcbimagenFuncionario.Image = null;

            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;

            foreach (Control ctl in flpPermissao.Controls)
            {
                if (ctl is CheckBox) ((CheckBox)ctl).Checked = false;
                if (ctl is CheckBox) ((CheckBox)ctl).Enabled = false;
                if (ctl is Label)
                    if (((Label)ctl).Tag != null && ((Label)ctl).Tag.ToString() == "A")
                        ((Label)ctl).Text = "";
                    else
                        continue;
            }
            chkTodos.Enabled = false;
            chkTodos.Checked = false;
        }       

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaSeguranca seg = new frmBuscaSeguranca(this);
            seg.ShowDialog();                        
        }

        private void CarregaDados()
        {
            objModSeguranca.IdFuncionario = Convert.ToInt64(lblexibeId.Text);
            objModSeguranca.AbreCaixa = chkabreCaixa.Checked;
            objModSeguranca.Cadastro = chkCadastros.Checked;
            objModSeguranca.CadCargo = chkcadCargo.Checked;
            objModSeguranca.CadClientes = chkcadCliente.Checked;
            objModSeguranca.CadFuncionarios = chkcadFuncionario.Checked;
            objModSeguranca.CadLogin = chkcadLogin.Checked;
            objModSeguranca.Configuracoes = chkConfiguracoes.Checked;
            objModSeguranca.FechaCaixa = chkfechaCaixa.Checked;
            objModSeguranca.Home = chkHome.Checked;
            objModSeguranca.Informacoes = chkInfo.Checked;
            objModSeguranca.MovimentoDia = chkmovDia.Checked;
            objModSeguranca.PesCargo = chkpesCargo.Checked;
            objModSeguranca.PesClientes = chkpesCliente.Checked;
            objModSeguranca.PesFuncionarios = chkpesFuncionario.Checked;
            objModSeguranca.Pesquisa = chkPesquisas.Checked;
            objModSeguranca.Procedimento = chkProcedimento.Checked;
            objModSeguranca.Terminal = chkTerminal.Checked;
            objModSeguranca.IdSeguanca = idSeguranca;
            objModSeguranca.AbreDia = chkabreDia.Checked;
            objModSeguranca.FechaDia = chkfechaDia.Checked;
            objModSeguranca.Backup = chkBackup.Checked;
        }

        public void MontaDados()
        {
            idSeguranca = objModSeguranca.IdSeguanca;
            lblexibeId.Text = objModSeguranca.IdFuncionario.ToString();
            lblexibeNome.Text = objModFunc.NomePessoa;
            lblxibeCargo.Text = objModCargo.NomeCargo;
            chkabreCaixa.Checked = objModSeguranca.AbreCaixa;
            chkCadastros.Checked = objModSeguranca.Cadastro;
            chkcadCargo.Checked = objModSeguranca.CadCargo;
            chkcadCliente.Checked = objModSeguranca.CadClientes;
            chkcadFuncionario.Checked = objModSeguranca.CadFuncionarios;
            chkcadLogin.Checked = objModSeguranca.CadLogin;
            chkConfiguracoes.Checked = objModSeguranca.Configuracoes;
            chkfechaCaixa.Checked = objModSeguranca.FechaCaixa;
            chkHome.Checked = objModSeguranca.Home;
            chkInfo.Checked = objModSeguranca.Informacoes;
            chkmovDia.Checked = objModSeguranca.MovimentoDia;
            chkpesCargo.Checked = objModSeguranca.PesCargo;
            chkpesCliente.Checked = objModSeguranca.PesClientes;
            chkpesFuncionario.Checked = objModSeguranca.PesFuncionarios;
            chkPesquisas.Checked = objModSeguranca.Pesquisa;
            chkProcedimento.Checked = objModSeguranca.Procedimento;
            chkTerminal.Checked = objModSeguranca.Terminal;
            pcbimagenFuncionario.Image = objBLFuncoesGenerica.ConverteByte_Imagem(objModFunc.ImagemPessoa);
            chkabreDia.Checked = objModSeguranca.AbreDia;
            chkfechaDia.Checked = objModSeguranca.FechaDia;
            chkBackup.Checked = objModSeguranca.Backup;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaDados();

                objBlSeguranca.InsereSeguranca(objModSeguranca);

                var Mensagem = new frmMessage_Box("Segurança configurada com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                btnCancelar_Click(sender, e);
            }
            catch(Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaDados();

                objBlSeguranca.AtualizaSeguranca(objModSeguranca);

                var Mensagem = new frmMessage_Box("Segurança editada com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();

                btnCancelar_Click(sender, e);
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTodos.Checked)
            {
                foreach (Control ctl in flpPermissao.Controls)
                {
                    if (ctl is CheckBox) ((CheckBox)ctl).Checked = true;
                }
            }
            else
            {
                foreach (Control ctl in flpPermissao.Controls)
                {
                    if (ctl is CheckBox) ((CheckBox)ctl).Checked = false;
                }
            }
        }

        public void VerificaChecks()
        {
            if(string.IsNullOrEmpty(lblexibeId.Text))
            {
                foreach (Control ctl in flpPermissao.Controls)
                {
                    if (ctl is CheckBox) ((CheckBox)ctl).Enabled = false;
                }
                chkTodos.Enabled = false;
            }
            else
            {
                foreach (Control ctl in flpPermissao.Controls)
                {
                    if (ctl is CheckBox) ((CheckBox)ctl).Enabled = true;
                }
                chkTodos.Enabled = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }
    }
}
