using SysPark.Controler;
using SysPark.Model;
using System;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmCadTipoVeiculo : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        ModGrupo objModGrupo = new ModGrupo();
        BLGrupo objBlGrupo = new BLGrupo();
        private int opcao;
        public int IdSubGrupo = 0;

        public frmCadTipoVeiculo(int Opcao)
        {
            InitializeComponent();

            this.opcao = Opcao;

            pnlcadSubGrupo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlcadSubGrupo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlcadSubGrupo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblcadSubGrupo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblcadSubGrupo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblcadSubGrupo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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
        } */

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
        }

        private void frmCadSubGrupo_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            if (opcao == 1)
            {
                txtSubGrupo.Enabled = true;
                rbAtivo.Enabled = true;
                rbInativo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                btnPesquisar.Enabled = false;

                MontaDados();
            }
            else
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                txtSubGrupo.Enabled = false;
                rbAtivo.Enabled = false;
                rbInativo.Enabled = false;
            }
        }

        public void MontaDados()
        {
            IdSubGrupo = objModGrupo.IdSubGRupo;
            txtSubGrupo.Text = objModGrupo.NomeSubGrupo;
            lblnomeAtualizacao.Text = objModGrupo.NomeAtualiza;
            lbldataAtualizacao.Text = objModGrupo.DataAtualiza.ToString();
            if (objModGrupo.SitSubGrupo == true)
            {
                rbAtivo.Checked = true;
                rbInativo.Checked = false;
            }
            else
            {
                rbAtivo.Checked = false;
                rbInativo.Checked = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtSubGrupo.Enabled = true;
            rbAtivo.Enabled = true;
            rbInativo.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
            txtSubGrupo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            lblnomeAtualizacao.Text = string.Empty;
            lbldataAtualizacao.Text = string.Empty;
            txtSubGrupo.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSubGrupo.Text))
                {
                    var Mensagem = new frmMessage_Box("Insira o nome do SubGrupo", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    txtSubGrupo.Focus();
                    return;
                }
                if (rbAtivo.Checked == false && rbInativo.Checked == false)
                {
                    var Mensagem = new frmMessage_Box("Escolha uma situação. \rAtivo ou Inativo.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    return;
                }

                else
                {
                    try
                    {
                        var objGrupo = objBlGrupo.VerificaSubGrupoExiste(txtSubGrupo.Text);

                        if (objGrupo.NomeSubGrupo != txtSubGrupo.Text && objGrupo.IdSubGRupo == -1)
                        {
                            objModGrupo.NomeSubGrupo = txtSubGrupo.Text;
                            objModGrupo.NomeAtualiza = lblnomeUsuario.Text;
                            if (rbAtivo.Checked == true)
                            {
                                objModGrupo.SitSubGrupo = true;
                            }
                            else
                            {
                                objModGrupo.SitSubGrupo = false;
                            }

                            objBlGrupo.InsereSubGrupo(objModGrupo);

                            var Mensagem = new frmMessage_Box("SubGrupo cadastrado com sucesso.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();

                            btnCancelar_Click(sender, e);
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("Já existe um SubGrupo com este nome.\rDigite outro nome.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();

                            txtSubGrupo.Clear();
                            txtSubGrupo.Focus();
                        }
                    }
                    catch (Exception erro)
                    {
                        var Mensagem = new frmMessage_Box(erro.Message, "SHOP SYSTEM - TENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                        Mensagem.ShowDialog();
                    }
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SHOP SYSTEM \rATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdSubGrupo != 0)
                {
                    if (string.IsNullOrEmpty(txtSubGrupo.Text))
                    {
                        var Mensagem = new frmMessage_Box("Insira o nome do Grupo", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();

                        txtSubGrupo.Focus();
                    }
                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        var Mensagem = new frmMessage_Box("Escolha uma situação. \rAtivo ou Inativo.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                    }
                    else
                    {
                        var objSubGrupo = objBlGrupo.VerificaSubGrupoExiste(txtSubGrupo.Text);

                        if (objSubGrupo.NomeSubGrupo == txtSubGrupo.Text && objSubGrupo.IdSubGRupo != IdSubGrupo)
                        {
                            var Mensagem = new frmMessage_Box("Já existe um SubGrupo com este nome.\rDigite outro nome.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                            Mensagem.ShowDialog();

                            txtSubGrupo.Clear();
                            txtSubGrupo.Focus();
                        }
                        else
                        {
                            objModGrupo.IdSubGRupo = IdSubGrupo;
                            objModGrupo.NomeSubGrupo = txtSubGrupo.Text;
                            objModGrupo.NomeAtualiza = lblnomeUsuario.Text;
                            if (rbAtivo.Checked == true)
                            {
                                objModGrupo.SitSubGrupo = true;
                            }
                            else
                            {
                                objModGrupo.SitSubGrupo = false;
                            }

                            objBlGrupo.AtualizaSubGrupo(objModGrupo);

                            var Mensagem = new frmMessage_Box("SubGrupo editado com sucesso.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();

                            btnCancelar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Este SubGrupo ainda não foi cadastrado./n Deseja cadastra-lo agora?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                    if (Mensagem.ShowDialog() == DialogResult.Yes)
                    {
                        btnSalvar_Click(sender, e);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        
        private void btnCancelar_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }
    }
}
