using SysPark.Controler;
using System;
using System.Windows.Forms;

namespace SysPark
{
    public partial class frmTerminal : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLTerminal objTerminal = new BLTerminal();
        private int idTerminal;

        public frmTerminal()
        {
            InitializeComponent();

            pnlTerminal.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlTerminal.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlTerminal.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblformTerminal.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblformTerminal.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblformTerminal.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void frmTerminal_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            dgvTerminal.DataSource = objTerminal.ListaTerminal();

            if (dgvTerminal.RowCount > 0)
            {
                dgvTerminal.Columns[0].Visible = false;
            }

            btnPegaMac.Enabled = true;
            btnSalvarTerminal.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelarTerminal.Enabled = false;
            txtTerminal.Enabled = false;
            rbAtivo.Enabled = false;
            rbInativo.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharRed(sender);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.FecharBranco(sender);
        }

        private void btnPegaMac_Click(object sender, EventArgs e)
        {
            try
            {
                txtMAC.Text = BLNetworkAdapter.Mac;
            }
            catch (Exception ex)
            {                
                var Mensagem = new frmMessage_Box(ex.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }

            btnCancelarTerminal.Enabled = true;
            btnSalvarTerminal.Enabled = true;
            btnPegaMac.Enabled = false;
            rbAtivo.Enabled = true;
            rbInativo.Enabled = true;
            txtTerminal.Enabled = true;
            txtTerminal.Focus();
        }

        private void btnCancelarTerminal_Click(object sender, EventArgs e)
        {
            txtTerminal.Clear();
            txtMAC.Clear();
            rbAtivo.Checked = false;
            rbInativo.Checked = false;

            frmTerminal_Load(sender, e);
        }

        private void btnSalvarTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificaCamposTerminal())
                    return;

                if (!objTerminal.VerificaTerminalExisteMAC(txtMAC.Text))
                {
                    var Verifica = objTerminal.VerificaTerminalExiste(txtTerminal.Text);


                    if (Verifica.NomeTerminal != txtTerminal.Text && Verifica.Mac != txtMAC.Text)
                    {
                        objTerminal.InsereTerminal(txtTerminal.Text, txtMAC.Text, rbAtivo.Checked);

                        dgvTerminal.DataSource = objTerminal.ListaTerminal();
                        if (dgvTerminal.RowCount > 0)
                        {
                            dgvTerminal.Columns[0].Visible = false;
                        }

                        var Mensagem = new frmMessage_Box("Terminal cadastrado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                        Mensagem.ShowDialog();

                        btnCancelarTerminal_Click(sender, e);
                    }
                    else
                    {
                        var Mensagem = new frmMessage_Box("Já existe um Terminal com este nome.\rDigite outro nome.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();

                        txtTerminal.Clear();
                        txtTerminal.Focus();
                    }
                }
                else
                {                   
                    var Mensagem = new frmMessage_Box("Já existe um Terminal com este MAC.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    this.Close();
                }
            }
            catch (Exception erro)
            {               
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public bool VerificaCamposTerminal()
        {
            if (string.IsNullOrEmpty(txtMAC.Text))
            {                
                var Mensagem = new frmMessage_Box("Mac não informado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                return false;
            }
            if (string.IsNullOrEmpty(txtTerminal.Text))
            {                
                var Mensagem = new frmMessage_Box("Descrição do Terminal não informado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                txtTerminal.Focus();

                return false;
            }
            if (rbAtivo.Checked == false && rbInativo.Checked == false)
            {                
                var Mensagem = new frmMessage_Box("Nenhuma situação foi selecionada.\rÉ necessário escolher uma opção.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                return false;
            }
            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificaCamposTerminal())
                    return;

                var Verifica = objTerminal.VerificaTerminalExiste(txtTerminal.Text);

                if (Verifica.NomeTerminal == txtTerminal.Text && Verifica.Mac != txtMAC.Text && Verifica.IdTerminal == idTerminal)
                {
                    var Mensagem = new frmMessage_Box("Já existe um Terminal com este nome.\rDigite outro nome.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                    Mensagem.ShowDialog();

                    txtTerminal.Clear();
                    txtTerminal.Focus();
                }
                else
                {
                    objTerminal.AtualizaTerminal(txtTerminal.Text, idTerminal, rbAtivo.Checked);

                    dgvTerminal.DataSource = objTerminal.ListaTerminal();

                    if (dgvTerminal.RowCount > 0)
                    {
                        dgvTerminal.Columns[0].Visible = false;
                    }

                    var Mensagem = new frmMessage_Box("Terminal editado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();

                    btnCancelarTerminal_Click(sender, e);
                }
            }
            catch (Exception erro)
            {               
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void dgvTerminal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTerminal.Text = dgvTerminal.Rows[e.RowIndex].Cells["Terminal"].Value.ToString();
            txtMAC.Text = dgvTerminal.Rows[e.RowIndex].Cells["MAC"].Value.ToString();
            idTerminal = Convert.ToInt32(dgvTerminal.Rows[e.RowIndex].Cells["IdTerminal"].Value.ToString());
            if (Convert.ToBoolean(dgvTerminal.Rows[e.RowIndex].Cells["Situacao"].Value.ToString()) == true)
            {
                rbAtivo.Checked = true;
                rbInativo.Checked = false;
            }
            else
            {
                rbAtivo.Checked = false;
                rbInativo.Checked = true;
            }

            btnPegaMac.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelarTerminal.Enabled = true;
            txtTerminal.Enabled = true;
            rbAtivo.Enabled = true;
            rbInativo.Enabled = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
        }
    }
}
