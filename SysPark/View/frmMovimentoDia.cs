using SysPark.Controler;
using System;
using System.Windows.Forms;


namespace SysPark.View
{
    public partial class frmMovimentoDia : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();        
        BLGeral objBlGeral = new BLGeral();
        BLTerminal objBlTerminal = new BLTerminal();
        

        public frmMovimentoDia()
        {
            InitializeComponent();

            pnlmovimentoDia.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlmovimentoDia.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlmovimentoDia.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblmovimentoDia.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblmovimentoDia.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblmovimentoDia.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
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

        private void frmMovimentoDia_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaCpfUsuario_Load(lblidOperador, ref falha);
            if (falha == true)
                Application.Exit();
            lblexibeData.Text = DateTime.Now.ToShortDateString();

            VerificaMovimentoDia();
        }

        private void HabilitaCampos()
        {
            foreach (Control ctl in pnlCampos.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = true;
            }
        }

        private void DesabilitaCampos()
        {
            foreach (Control ctl in pnlCampos.Controls)
            {
                if (ctl is TextBox) ctl.Enabled = false;
            }
        }

        private void VerificaMovimentoDia()
        {
            var dtAntigo = objBlGeral.VerificaMovimentoDiaAntigoAberto();

            if (dtAntigo.Rows.Count > 0)
            {
                var Mensagem = new frmMessage_Box("Exite um MOVIMENTO DIA anterior a data de hoje aberto. Ele PRECISA ser FECHADO primeiro, para que o de hoje possa ser aberto.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();

                var row = dtAntigo.Rows[0];

                txtMovimento.Text = row["IdMovimentoDia"].ToString();
                txtdataAbertura.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Parse(row["DataAbertura"].ToString()));
                txtTerminal.Text = row["NomeTerminal"].ToString();
                txtusuarioAbertura.Text = row["NomePessoa"].ToString();

                HabilitaCampos();
                btnfecharMovimento.Enabled = true;
                btniabreMovimento.Enabled = false;
            }
            else
            {
                    var dtAtual = objBlGeral.VerificaMovimentoDiaAberto();

                    if (dtAtual.Rows.Count > 0)
                    {
                        var Mensagem1 = new frmMessage_Box("O MOVIMENTO DIA de hoje já foi aberto.\rNão é possivel abrir 2 MOVIMENTO DIA com a mesma data.\rDeseja continuar e fechar o MOVIMENTO DIA atual?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                        if (Mensagem1.ShowDialog() == DialogResult.No)
                            this.Close();

                        var row = dtAtual.Rows[0];

                        txtMovimento.Text = row["IdMovimentoDia"].ToString();
                        txtdataAbertura.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Parse(row["DataAbertura"].ToString()));
                        txtTerminal.Text = row["NomeTerminal"].ToString();
                        txtusuarioAbertura.Text = row["NomePessoa"].ToString();

                        HabilitaCampos();
                        btnfecharMovimento.Enabled = true;
                        btniabreMovimento.Enabled = false;
                    }
                    else
                    {
                        DesabilitaCampos();
                        btniabreMovimento.Enabled = true;
                        btnfecharMovimento.Enabled = false;
                    }              
            }
        }

        private void AbreMovimentoDia()
        {
            var  terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);            
            objBlGeral.AbreMovimentoDia(Convert.ToInt64(lblidOperador.Text), terminal, Convert.ToDateTime(lblexibeData.Text));
            try
            {
                BLGeral objBLGeral = new BLGeral();
                objBLGeral.BackupBanco();
            }
            catch (Exception ex)
            {
                var Mensagem1 = new frmMessage_Box("Backup não efetuado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem1.ShowDialog();
            }
            var Mensagem = new frmMessage_Box("Movimento Dia aberto com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
            Mensagem.ShowDialog();
            this.Close();
        }

        private void FechaMovimentoDia()
        {
            if(lblexibeData.Text == txtdataAbertura.Text)
            {
                var Mensagem1 = new frmMessage_Box("Deseja mesmo fechar o MOVIMENTO DIA atual?\rEle só poderá ser aberto novamente na próxima data.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OKCancel, frmMessage_Box.enumMessageIcon.Question);
                if (Mensagem1.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    var terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
                    objBlGeral.FechaMovimentoDia(Convert.ToInt64(lblidOperador.Text), terminal, Convert.ToDateTime(lblexibeData.Text), Convert.ToInt64(txtMovimento.Text));

                    try
                    {
                        BLGeral objBLGeral = new BLGeral();
                        objBLGeral.BackupBanco();
                    }
                    catch (Exception ex)
                    {
                        var Mensagem11 = new frmMessage_Box("Backup não efetuado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                        Mensagem11.ShowDialog();
                    }

                    var Mensagem = new frmMessage_Box("Movimento Dia fechado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem.ShowDialog();
                    this.Close();
                }                    
            }   
            else
            {
                var terminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
                objBlGeral.FechaMovimentoDia(Convert.ToInt64(lblidOperador.Text), terminal, Convert.ToDateTime(lblexibeData.Text), Convert.ToInt64(txtMovimento.Text));

                var Mensagem = new frmMessage_Box("Movimento Dia fechado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                Mensagem.ShowDialog();
                this.Close();
            }
        }

        private void btniabreMovimento_Click(object sender, EventArgs e)
        {
            AbreMovimentoDia();
        }

        private void btnfecharMovimento_Click(object sender, EventArgs e)
        {
            if (objBlGeral.VerificaCaixaAberto() == true)
            {
                var Mensagem = new frmMessage_Box("Não é possivel fechar o MOVIMENTO DIA com o caixa aberto.\rAinda existe no mínimo um caixa aberto.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
                return;
            } 
            else
            {
                FechaMovimentoDia();
            }            
        }

        private void btnfecharMovimento_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }
    }
}
