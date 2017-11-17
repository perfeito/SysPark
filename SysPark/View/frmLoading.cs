using System;
using System.Drawing;
using System.Windows.Forms;


namespace SysPark
{
    public partial class frmLoading : Form
    {   
        delegate void StringParameterDelegate(string Text);
        delegate void StringParameterWithStatusDelegate(string Text, TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();

        /// <summary>
        /// To ensure splash screen is closed using the API and not by keyboard or any other things
        /// </summary>
        bool CloseSplashScreenFlag = false;

        /// <summary>
        /// Base constructor
        /// </summary>
        public frmLoading()
        {
            InitializeComponent();
            
            this.lblMensagem.BackColor = Color.Transparent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                objBLFuncoesGenerica.Drop_Shadow(this);
            }
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

        /// <summary>
        /// Displays the splashscreen
        /// </summary>
        public void ShowSplashScreen()
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new SplashShowCloseDelegate(ShowSplashScreen));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        /// <summary>
        /// Closes the SplashScreen
        /// </summary>
        public void CloseSplashScreen()
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new SplashShowCloseDelegate(CloseSplashScreen));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }

        /// <summary>
        /// Update text in default green color of success message
        /// </summary>
        /// <param name="Text">Message</param>
        public void UdpateStatusText(string Text)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterDelegate(UdpateStatusText), new object[] { Text });
                return;
            }
            // Must be on the UI thread if we've got this far            
            lblMensagem.Text = Text;
        }


        /// <summary>
        /// Update text with message color defined as green/yellow/red/ for success/warning/failure
        /// </summary>
        /// <param name="Text">Message</param>
        /// <param name="tom">Type of Message</param>
        public void UdpateStatusTextWithStatus(string Text, TypeOfMessage tom)
        {
            if (InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                BeginInvoke(new StringParameterWithStatusDelegate(UdpateStatusTextWithStatus), new object[] { Text, tom });
                return;
            }
            // Must be on the UI thread if we've got this far
            switch (tom)
            {
                case TypeOfMessage.Error:
                    //lblMensagem.ForeColor = Color.Red;
                    //pnlBarra.BackColor = Color.Red;
                    //pnlLogin.BackColor = Color.Red;
                    break;
                case TypeOfMessage.Warning:
                    //lblMensagem.ForeColor = Color.OrangeRed;
                    //pnlBarra.BackColor = Color.DarkOrange;
                    //pnlLogin.BackColor = Color.DarkOrange;
                    break;
                case TypeOfMessage.Success:
                    //lblMensagem.ForeColor = Color.Green;
                    //pnlBarra.BackColor = Color.SpringGreen;
                    //pnlLogin.BackColor = Color.SpringGreen;
                    break;
                case TypeOfMessage.Process:
                    //lblMensagem.ForeColor = Color.Black;
                    //pnlBarra.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                    //pnlLogin.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                    break;
            }
            lblMensagem.Text = Text;

        }

        /// <summary>
        /// Prevents the closing of form other than by calling the CloseSplashScreen function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseSplashScreenFlag == false)
                e.Cancel = true;
        }       
    }
}
