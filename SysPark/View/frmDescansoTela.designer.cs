namespace SysPark
{
    partial class frmDescansoTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescansoTela));
            this.pnlDescanso = new System.Windows.Forms.Panel();
            this.labelShadow1 = new LabelShadow.LabelShadow(this.components);
            this.lbldiaSemana = new LabelShadow.LabelShadow(this.components);
            this.lblHora = new LabelShadow.LabelShadow(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.timerDescanso = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlDescanso.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescanso
            // 
            this.pnlDescanso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescanso.BackColor = System.Drawing.Color.Transparent;
            this.pnlDescanso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDescanso.Controls.Add(this.labelShadow1);
            this.pnlDescanso.Controls.Add(this.lbldiaSemana);
            this.pnlDescanso.Controls.Add(this.lblHora);
            this.pnlDescanso.Controls.Add(this.btnFechar);
            this.pnlDescanso.Location = new System.Drawing.Point(1, 1);
            this.pnlDescanso.Name = "pnlDescanso";
            this.pnlDescanso.Size = new System.Drawing.Size(1022, 766);
            this.pnlDescanso.TabIndex = 51;
            this.pnlDescanso.Click += new System.EventHandler(this.pnlDescanso_Click);
            // 
            // labelShadow1
            // 
            this.labelShadow1.Angle = 0F;
            this.labelShadow1.DrawGradient = false;
            this.labelShadow1.EndColor = System.Drawing.Color.LightSkyBlue;
            this.labelShadow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShadow1.ForeColor = System.Drawing.Color.LightGray;
            this.labelShadow1.Location = new System.Drawing.Point(40, 483);
            this.labelShadow1.Name = "labelShadow1";
            this.labelShadow1.ShadowColor = System.Drawing.Color.Black;
            this.labelShadow1.Size = new System.Drawing.Size(454, 48);
            this.labelShadow1.StartColor = System.Drawing.Color.White;
            this.labelShadow1.TabIndex = 10;
            this.labelShadow1.Text = "S  y  s   P  a  r  k";
            this.labelShadow1.XOffset = 3F;
            this.labelShadow1.YOffset = 1F;
            // 
            // lbldiaSemana
            // 
            this.lbldiaSemana.Angle = 0F;
            this.lbldiaSemana.AutoSize = true;
            this.lbldiaSemana.DrawGradient = false;
            this.lbldiaSemana.EndColor = System.Drawing.Color.LightSkyBlue;
            this.lbldiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiaSemana.ForeColor = System.Drawing.Color.LightGray;
            this.lbldiaSemana.Location = new System.Drawing.Point(37, 618);
            this.lbldiaSemana.Name = "lbldiaSemana";
            this.lbldiaSemana.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lbldiaSemana.Size = new System.Drawing.Size(96, 55);
            this.lbldiaSemana.StartColor = System.Drawing.Color.White;
            this.lbldiaSemana.TabIndex = 9;
            this.lbldiaSemana.Text = "Dia";
            this.lbldiaSemana.XOffset = 3F;
            this.lbldiaSemana.YOffset = 2F;
            // 
            // lblHora
            // 
            this.lblHora.Angle = 0F;
            this.lblHora.AutoSize = true;
            this.lblHora.DrawGradient = false;
            this.lblHora.EndColor = System.Drawing.Color.LightSkyBlue;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(25, 507);
            this.lblHora.Name = "lblHora";
            this.lblHora.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblHora.Size = new System.Drawing.Size(320, 120);
            this.lblHora.StartColor = System.Drawing.Color.White;
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00";
            this.lblHora.XOffset = 5F;
            this.lblHora.YOffset = 3F;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(959, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 60);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Tag = "";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // timerDescanso
            // 
            this.timerDescanso.Enabled = true;
            this.timerDescanso.Interval = 1000;
            this.timerDescanso.Tick += new System.EventHandler(this.timerDescanso_Tick);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pnlDescanso);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 768);
            this.panel5.TabIndex = 52;
            // 
            // frmDescansoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDescansoTela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDescansoTela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDescansoTela_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDescansoTela_KeyDown);
            this.pnlDescanso.ResumeLayout(false);
            this.pnlDescanso.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescanso;
        private System.Windows.Forms.Timer timerDescanso;
        public System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel5;
        private LabelShadow.LabelShadow lbldiaSemana;
        private LabelShadow.LabelShadow lblHora;
        private LabelShadow.LabelShadow labelShadow1;
    }
}