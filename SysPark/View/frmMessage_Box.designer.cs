namespace SysPark
{
    partial class frmMessage_Box
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage_Box));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlShowMessage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pnlMenssage = new System.Windows.Forms.Panel();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTitulo.SuspendLayout();
            this.pnlShowMessage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.pnlMenssage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTitulo.Controls.Add(this.pnlShowMessage);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(649, 350);
            this.pnlTitulo.TabIndex = 4;
            // 
            // pnlShowMessage
            // 
            this.pnlShowMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlShowMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlShowMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlShowMessage.Controls.Add(this.panel1);
            this.pnlShowMessage.ForeColor = System.Drawing.Color.Transparent;
            this.pnlShowMessage.Location = new System.Drawing.Point(1, 32);
            this.pnlShowMessage.Name = "pnlShowMessage";
            this.pnlShowMessage.Size = new System.Drawing.Size(647, 317);
            this.pnlShowMessage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pnlIcon);
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.Controls.Add(this.pnlMenssage);
            this.panel1.Location = new System.Drawing.Point(5, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 200);
            this.panel1.TabIndex = 69;
            // 
            // pnlIcon
            // 
            this.pnlIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlIcon.Controls.Add(this.pcbIcon);
            this.pnlIcon.Location = new System.Drawing.Point(1, 24);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(155, 175);
            this.pnlIcon.TabIndex = 2;
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcon.Image")));
            this.pcbIcon.Location = new System.Drawing.Point(12, 22);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(130, 130);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbIcon.TabIndex = 1;
            this.pcbIcon.TabStop = false;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Location = new System.Drawing.Point(261, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(114, 23);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "Mensagem";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMenssage
            // 
            this.pnlMenssage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenssage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMenssage.Controls.Add(this.lblMessageText);
            this.pnlMenssage.Location = new System.Drawing.Point(149, 24);
            this.pnlMenssage.Name = "pnlMenssage";
            this.pnlMenssage.Size = new System.Drawing.Size(487, 175);
            this.pnlMenssage.TabIndex = 2;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.ForeColor = System.Drawing.Color.Black;
            this.lblMessageText.Location = new System.Drawing.Point(15, 10);
            this.lblMessageText.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(0, 24);
            this.lblMessageText.TabIndex = 0;
            this.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(124, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SysPark - ATENÇÃO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel-100 (1).png");
            this.imageList1.Images.SetKeyName(1, "Error-100.png");
            this.imageList1.Images.SetKeyName(2, "Info-100.png");
            this.imageList1.Images.SetKeyName(3, "Help-100 (1).png");
            this.imageList1.Images.SetKeyName(4, "Exclamation Mark-100.png");
            this.imageList1.Images.SetKeyName(5, "Delete-100.png");
            this.imageList1.Images.SetKeyName(6, "Information-100.png");
            this.imageList1.Images.SetKeyName(7, "Question Mark-100.png");
            // 
            // frmShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(649, 350);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowMessage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowMessage";
            this.Load += new System.EventHandler(this.frmShowMessage_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlShowMessage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.pnlMenssage.ResumeLayout(false);
            this.pnlMenssage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlShowMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Panel pnlMenssage;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ImageList imageList1;
    }
}