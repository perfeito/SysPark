using SysPark;
using SysPark.Controler;
using System;
using System.Windows.Forms;


namespace SysPark
{
    public partial class frmcadCargo : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        ModCargo objModCargo = new ModCargo();
        BLCargo objBlCargo = new BLCargo();
        private int opcao;
        public int IdCargo = 0;

        public frmcadCargo(int Opcao)
        {
            InitializeComponent();

            this.opcao = Opcao;

            pnlcadCargo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlcadCargo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlcadCargo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblcadCargo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblcadCargo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblcadCargo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            lblnomeAtualizacao.Text = string.Empty;
            lbldataAtualizacao.Text = string.Empty;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCargo.Enabled = true;
            rbAtivo.Enabled = true;
            rbInativo.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
            txtCargo.Focus();
        }

        private void frmcadCargo_Load(object sender, EventArgs e)
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
                txtCargo.Enabled = true;
                rbAtivo.Enabled = true;
                rbInativo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;

                MontaDados();
            }
            else
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCargo.Enabled = false;
                rbAtivo.Enabled = false;
                rbInativo.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCargo.Text))
                {
                    var Mensagem = new frmMessage_Box("Insira o nome do Cargo", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();
                    txtCargo.Focus();
                    return;
                }
                if (rbAtivo.Checked == false && rbInativo.Checked == false)
                {
                    var Mensagem = new frmMessage_Box("Escolha uma situação. Ativo ou Inativo.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();
                    return;
                }
                else
                {
                    try
                    {
                        var objCargo = objBlCargo.VerificaCargoExiste(txtCargo.Text);

                        if (objCargo.NomeCargo != txtCargo.Text && objCargo.IdCargo != IdCargo)
                        {
                            objModCargo.NomeCargo = txtCargo.Text;
                            objModCargo.NomeAtualiza = lblnomeUsuario.Text;
                            if (rbAtivo.Checked == true)
                            {
                                objModCargo.SituacaoCargo = true;
                            }
                            else
                            {
                                objModCargo.SituacaoCargo = false;
                            }

                            objBlCargo.InsereCargo(objModCargo);

                            var Mensagem = new frmMessage_Box("Cargo cadastrado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();
                            btnCancelar_Click(sender, e);
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("Já existe um cargo com este nome.\rDigite outro nome.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                            Mensagem.ShowDialog();
                            txtCargo.Text = "";
                            txtCargo.Focus();
                        }
                    }
                    catch (Exception erro)
                    {
                        var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                        Mensagem.ShowDialog();
                    }
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaCargo objcBuscaCargo = new frmBuscaCargo(this);
            objcBuscaCargo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdCargo != 0)
                {
                    if (string.IsNullOrEmpty(txtCargo.Text))
                    {
                        var Mensagem = new frmMessage_Box("Insira o nome do Cargo", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        txtCargo.Focus();
                    }
                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        var Mensagem = new frmMessage_Box("Escolha uma situação. \rAtivo ou Inativo.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                    }
                    else
                    {
                        var objCargo = objBlCargo.VerificaCargoExiste(txtCargo.Text);

                        if (objCargo.NomeCargo == txtCargo.Text && objCargo.IdCargo != IdCargo)
                        {
                            var Mensagem = new frmMessage_Box("Já existe um cargo com este nome.\rDigite outro nome.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                            Mensagem.ShowDialog();
                            txtCargo.Text = "";
                            txtCargo.Focus();
                        }
                        else
                        {
                            objModCargo.IdCargo = IdCargo;
                            objModCargo.NomeCargo = txtCargo.Text;
                            objModCargo.NomeAtualiza = lblnomeUsuario.Text;
                            if (rbAtivo.Checked == true)
                            {
                                objModCargo.SituacaoCargo = true;
                            }
                            else
                            {
                                objModCargo.SituacaoCargo = false;
                            }

                            objBlCargo.AtualizaCargo(objModCargo);

                            var Mensagem = new frmMessage_Box("Cargo atualizado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                            Mensagem.ShowDialog();
                            btnCancelar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Este Cargo ainda não foi cadastrado./n Deseja cadastra-lo agora?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
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
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void MontaDados()
        {
            IdCargo = objModCargo.IdCargo;
            txtCargo.Text = objModCargo.NomeCargo;
            lblnomeAtualizacao.Text = objModCargo.NomeAtualiza;
            lbldataAtualizacao.Text = objModCargo.DataAtualiza.ToString();
            if (objModCargo.SituacaoCargo == true)
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

        private void btnNovo_EnabledChanged(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SysPark.Controler.Util.SlideMenu(pnlMenu, pnlMenu.Height, 45, 150, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
