using SysPark.Controler;
using SysPark.Model;
using System;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmCadTipoVeiculo : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        ModTipoVeiculo objModTipoVeiculo = new ModTipoVeiculo();
        BLTipoVeiculo objBLTipoVeiculo = new BLTipoVeiculo();
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
            
            if (opcao == 1)
            {
                panel8.Enabled = true;
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
                panel8.Enabled = false;
            }
        }

        public void MontaDados()
        {
            IdSubGrupo = objModTipoVeiculo.IdTipo;
            txtDescricao.Text = objModTipoVeiculo.Descrição;
            txtCortesia.Text = objModTipoVeiculo.CortesiaAte.ToString();
            txtValorHora.Text = objModTipoVeiculo.ValorHora.ToString();
            if (objModTipoVeiculo.Ativo == true)
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
            panel8.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.LimpaCampos(this);
            panel8.Enabled = false;


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
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    var Mensagem = new frmMessage_Box("Insira a descrição", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    txtDescricao.Focus();
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

                        objModTipoVeiculo.Descrição = txtDescricao.Text;
                        objModTipoVeiculo.Ativo = rbAtivo.Checked;
                        objModTipoVeiculo.CortesiaAte = Convert.ToInt32(txtCortesia.Text);
                        objModTipoVeiculo.ValorHora = Convert.ToDecimal(txtValorHora.Text);

                        objBLTipoVeiculo.InsereTipoVeiculo(objModTipoVeiculo);

                        var Mensagem = new frmMessage_Box("SubGrupo cadastrado com sucesso.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        btnCancelar_Click(sender, e);
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
                    if (string.IsNullOrEmpty(txtDescricao.Text))
                    {
                        var Mensagem = new frmMessage_Box("Insira a descrição", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();

                        txtDescricao.Focus();
                    }
                    if (rbAtivo.Checked == false && rbInativo.Checked == false)
                    {
                        var Mensagem = new frmMessage_Box("Escolha uma situação. \rAtivo ou Inativo.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                    }
                    else
                    {
                        objModTipoVeiculo.IdTipo = IdSubGrupo;
                        objModTipoVeiculo.Descrição = txtDescricao.Text;
                        objModTipoVeiculo.Ativo = rbAtivo.Checked;
                        objModTipoVeiculo.CortesiaAte = Convert.ToInt32(txtCortesia.Text);
                        objModTipoVeiculo.ValorHora = Convert.ToDecimal(txtValorHora.Text);

                        objBLTipoVeiculo.AtualizaTipoVeiculo(objModTipoVeiculo);

                        var Mensagem = new frmMessage_Box("Editado com sucesso.", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        btnCancelar_Click(sender, e);
                    }
                }
                else
                {
                    var Mensagem = new frmMessage_Box("Este Tipo de Veiculo ainda não foi cadastrado./n Deseja cadastra-lo agora?", "SHOP SYSTEM - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
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
