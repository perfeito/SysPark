using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace SysPark
{
    public partial class frmMessage_Box : Form
    {
        //readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        private string messageText, messageTitle;
        private enumMessageButton messageButton;
        private enumMessageIcon messageIcon;

        public frmMessage_Box(string MessageText, string MessageTitle, enumMessageButton MessageButton, enumMessageIcon MessageIcon)
        {
            InitializeComponent();

             //Rectangle bounds = new Microsoft.VisualBasic.Devices.Computer().Screen.Bounds;
             //this.Size = new Size(bounds.Width, 350);

            this.messageText = MessageText;
            this.messageTitle = MessageTitle;
            this.messageButton = MessageButton;
            this.messageIcon = MessageIcon;

            //pnlTitulo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            //pnlTitulo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            //pnlTitulo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            //lblTitulo.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            //lblTitulo.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            //lblTitulo.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /// <summary>
        /// Here I am overriding Paint method of form object
        /// and set it's background color as gradient. Here I am
        /// using LinearGradientBrush class object to make gradient
        /// color which comes in System.Drawing.Drawing2D namespace.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DarkSlateGray, Color.DimGray, 120);
            e.Graphics.FillRectangle(brush, rect);
            base.OnPaint(e);
        }

        /// <summary>
        /// setMessage method is used to display message
        /// on form and it's height adjust automatically.
        /// I am displaying message in a Label control.
        /// </summary>
        /// <param name="messageText">Message which needs to be displayed to user.</param>
        private void setMessage(string messageText)
        {
            int number = Math.Abs(messageText.Length / 30);
            if (number != 0)
                this.lblMessageText.Height = number * 25;
            this.lblMessageText.Text = messageText;
        }

        private void setMessageTitle(string messageTitle)
        {
            int number = Math.Abs(messageTitle.Length / 30);
            if (number != 0)
                this.lblTitulo.Height = number * 25;
            this.lblTitulo.Text = messageTitle;
        }


        /// <summary>
        /// This method is used to add button on message box.
        /// </summary>
        /// <param name="MessageButton">MessageButton is type of enumMessageButton
        /// through which I get type of button which needs to be displayed.</param>
        public void addButton(enumMessageButton MessageButton)
        {
            switch (MessageButton)
            {
                case enumMessageButton.OK:
                    {
                        //If type of enumButton is OK then we add OK button only.
                        Button btnOk = new Button(); //Create object of Button.
                        btnOk.Text = "OK"; //Here we set text of Button.
                        btnOk.DialogResult = DialogResult.OK; //Set DialogResult property of button.
                        btnOk.FlatStyle = FlatStyle.Flat; //Set flat appearence of button.
                        btnOk.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(50,50,50);
                        btnOk.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnOk.BackColor = Color.FromArgb(15,15,15);
                        btnOk.ForeColor = Color.LightGray;
                        btnOk.SetBounds(pnlShowMessage.ClientSize.Width - 115, 250, 110, 35); // Set bounds of button.
                        pnlShowMessage.Controls.Add(btnOk); //Finally Add button control on panel.
                    }
                    break;
                case enumMessageButton.OKCancel:
                    {
                        Button btnCancel = new Button();
                        btnCancel.Text = "CANCELAR";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Flat;
                        btnCancel.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnCancel.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnCancel.BackColor = Color.FromArgb(15, 15, 15);
                        btnCancel.ForeColor = Color.LightGray;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - 115), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnCancel);

                        Button btnOk = new Button();
                        btnOk.Text = "OK";
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Flat;
                        btnOk.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnOk.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnOk.BackColor = Color.FromArgb(15, 15, 15);
                        btnOk.ForeColor = Color.LightGray;
                        btnOk.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + 120)), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnOk);
                    }
                    break;
                case enumMessageButton.YesNo:
                    {
                        Button btnNo = new Button();
                        btnNo.Text = "NÃO";
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Flat;
                        btnNo.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnNo.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnNo.BackColor = Color.FromArgb(15, 15, 15);
                        btnNo.ForeColor = Color.LightGray;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - 115), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnNo);


                        Button btnYes = new Button();
                        btnYes.Text = "SIM";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Flat;
                        btnYes.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnYes.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnYes.BackColor = Color.FromArgb(15, 15, 15);
                        btnYes.ForeColor = Color.LightGray;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnNo.ClientSize.Width + 120)), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
                case enumMessageButton.YesNoCancel:
                    {
                        Button btnCancel = new Button();
                        btnCancel.Text = "CANCELAR";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Flat;
                        btnCancel.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnCancel.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnCancel.BackColor = Color.FromArgb(15, 15, 15);
                        btnCancel.ForeColor = Color.LightGray;
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - 115), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnCancel);

                        Button btnNo = new Button();
                        btnNo.Text = "NÃO";
                        btnNo.DialogResult = DialogResult.No;
                        btnNo.FlatStyle = FlatStyle.Flat;
                        btnNo.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnNo.FlatAppearance.BorderSize = 0;
                        btnNo.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnNo.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnNo.BackColor = Color.FromArgb(15, 15, 15);
                        btnNo.ForeColor = Color.LightGray;
                        btnNo.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + 120)), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnNo);

                        Button btnYes = new Button();
                        btnYes.Text = "SIM";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Flat;
                        btnYes.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
                        btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                        btnYes.FlatAppearance.MouseDownBackColor = Color.DimGray;
                        btnYes.BackColor = Color.FromArgb(15, 15, 15);
                        btnYes.ForeColor = Color.LightGray;
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + btnNo.ClientSize.Width + 125)), 250, 110, 35);
                        pnlShowMessage.Controls.Add(btnYes);
                    }
                    break;
            }
        }

        /// <summary>
        /// We can use this method to add image on message box.
        /// I had taken all images in ImageList control so that
        /// I can eaily add images. Image is displayed in
        /// PictureBox control.
        /// </summary>
        /// <param name="MessageIcon">Type of image to be displayed.</param>
        public void addIconImage(enumMessageIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case enumMessageIcon.Error:
                    pcbIcon.Image = imageList1.Images["Delete-100.png"];
                    //Error is key name in imagelist control which uniqly identified images in ImageList control.
                    break;
                case enumMessageIcon.Information:
                    pcbIcon.Image = imageList1.Images["Information-100.png"];
                    break;
                case enumMessageIcon.Question:
                    pcbIcon.Image = imageList1.Images["Question Mark-100.png"];
                    break;
                case enumMessageIcon.Warning:
                    pcbIcon.Image = imageList1.Images["Exclamation Mark-100.png"];
                    break;
            }
        }
                
        #region Overloaded Show message to display message box.

        /// <summary>
        /// Show method is overloaded which is used to display message
        /// and this is static method so that we don't need to create
        /// object of this class to call this method.
        /// </summary>
        /// <param name="messageText"></param>
        //internal static void Show(string messageText)
        //{
        //    frmShowMessage frmMessage = new frmShowMessage();
        //    frmMessage.setMessage(messageText);
        //    frmMessage.addIconImage(enumMessageIcon.Information);
        //    frmMessage.addButton(enumMessageButton.OK);
        //    frmMessage.ShowDialog();
        //}

        //internal static void Show(string messageText, string messageTitle)
        //{
        //    frmShowMessage frmMessage = new frmShowMessage();
        //    frmMessage.setMessageTitle(messageTitle);
        //    frmMessage.setMessage(messageText);
        //    frmMessage.addIconImage(enumMessageIcon.Information);
        //    frmMessage.addButton(enumMessageButton.OK);
        //    frmMessage.ShowDialog();
        //}

        //internal static void Show(string messageText, string messageTitle, enumMessageButton messageButton, enumMessageIcon messageIcon)
        //{
        //    frmShowMessage frmMessage = new frmShowMessage();
        //    frmMessage.setMessage(messageText);
        //    frmMessage.setMessageTitle(messageTitle);
        //    frmMessage.addIconImage(messageIcon);
        //    frmMessage.addButton(messageButton);
        //    frmMessage.ShowDialog();
        //}

        #endregion

        #region constant defiend in form of enumration which is used in showMessage class.

        public enum enumMessageIcon
        {
            Error,
            Warning,
            Information,
            Question,
        }

        public enum enumMessageButton
        {
            OK,
            YesNo,
            YesNoCancel,
            OKCancel
        }

        #endregion

        private void Mensagem()
        {
            setMessage(messageText);
            setMessageTitle(messageTitle);
            addIconImage(messageIcon);
            addButton(messageButton);
        }

        private void frmShowMessage_Load(object sender, EventArgs e)
        {
            //objBLFuncoesGenerica.Drop_Shadow(this);

            Mensagem();
            if (messageIcon == enumMessageIcon.Question)
            {
                pnlTitulo.BackColor = Color.DodgerBlue;
                panel1.BackColor = Color.DodgerBlue;
                //pnlMenssage.BackColor = Color.DodgerBlue;
                //pnlIcon.BackColor = Color.DodgerBlue;
                lblMessageText.ForeColor = Color.DodgerBlue;
            }
            if (messageIcon == enumMessageIcon.Error)
            {
                pnlTitulo.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                //pnlMenssage.BackColor = Color.Red;
                //pnlIcon.BackColor = Color.Red;
                lblMessageText.ForeColor = Color.Red;
            }
            if (messageIcon == enumMessageIcon.Information)
            {
                pnlTitulo.BackColor = Color.MediumSeaGreen;
                panel1.BackColor = Color.MediumSeaGreen;
                //pnlMenssage.BackColor = Color.MediumSeaGreen;
                //pnlIcon.BackColor = Color.MediumSeaGreen;
                lblMessageText.ForeColor = Color.MediumSeaGreen;
            }
            if (messageIcon == enumMessageIcon.Warning)
            {
                pnlTitulo.BackColor = Color.FromArgb(255, 90, 30);
                panel1.BackColor = Color.FromArgb(255, 90, 30);
                //pnlMenssage.BackColor = Color.FromArgb(255, 90, 30);
                //pnlIcon.BackColor = Color.FromArgb(255, 90, 30);
                lblMessageText.ForeColor = Color.FromArgb(255, 90, 30);
            }
            pcbIcon.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}

