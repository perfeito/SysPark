namespace SysPark
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pcbLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.Black;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.lblLoading);
            this.pnlLogin.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(573, 190);
            this.pnlLogin.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Controls.Add(this.pcbLoading);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 157);
            this.panel1.TabIndex = 4;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.LightGray;
            this.lblMensagem.Location = new System.Drawing.Point(163, 3);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(401, 150);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Aguarde um momento";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbLoading
            // 
            this.pcbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pcbLoading.Image")));
            this.pcbLoading.Location = new System.Drawing.Point(7, 3);
            this.pcbLoading.Name = "pcbLoading";
            this.pcbLoading.Size = new System.Drawing.Size(150, 150);
            this.pcbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLoading.TabIndex = 2;
            this.pcbLoading.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.LightGray;
            this.lblLoading.Location = new System.Drawing.Point(216, 4);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(140, 25);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "SysPark\r\n";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 190);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pcbLoading;
    }
}