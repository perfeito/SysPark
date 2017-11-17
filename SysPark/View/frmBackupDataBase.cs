using SysPark.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SysPark.View
{
    public partial class frmBackupDataBase : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();


        public frmBackupDataBase()
        {
            InitializeComponent();

            pnlopcaoImpressao.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlopcaoImpressao.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlopcaoImpressao.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblopcaoImpressao.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblopcaoImpressao.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblopcaoImpressao.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOpcaoImpressao_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                BLGeral objBLGeral = new BLGeral();
                objBLGeral.BackupBanco();
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box("Backup não efetuado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
            var Mensagem2 = new frmMessage_Box("Backup efetuado!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
            Mensagem2.ShowDialog();
            Close();
        }
    }
}
