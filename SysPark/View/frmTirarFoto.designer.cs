using SysPark.Properties;

namespace SysPark.View
{
    partial class frmTirarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTirarFoto));
            this.pnlTirarFoto = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.lblTiraFoto = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.pnlTirarFoto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTirarFoto
            // 
            this.pnlTirarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTirarFoto.BackColor = System.Drawing.Color.Black;
            this.pnlTirarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTirarFoto.Controls.Add(this.panel1);
            this.pnlTirarFoto.Controls.Add(this.lblTiraFoto);
            this.pnlTirarFoto.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTirarFoto.Location = new System.Drawing.Point(0, 0);
            this.pnlTirarFoto.Name = "pnlTirarFoto";
            this.pnlTirarFoto.Size = new System.Drawing.Size(431, 591);
            this.pnlTirarFoto.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnCapturar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 558);
            this.panel1.TabIndex = 77;
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCapturar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCapturar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCapturar.FlatAppearance.BorderSize = 0;
            this.btnCapturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCapturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
            this.btnCapturar.Location = new System.Drawing.Point(244, 460);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCapturar.Size = new System.Drawing.Size(85, 85);
            this.btnCapturar.TabIndex = 127;
            this.btnCapturar.Tag = "";
            this.btnCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMod1.SetToolTip(this.btnCapturar, "Capturar");
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(100, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 85);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Tag = "";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMod1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(13, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 425);
            this.panel3.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(157, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel7.Controls.Add(this.pcbImagem);
            this.panel7.Location = new System.Drawing.Point(1, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 400);
            this.panel7.TabIndex = 0;
            // 
            // pcbImagem
            // 
            this.pcbImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pcbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbImagem.Image = Resources.Imagem_100;
            this.pcbImagem.Location = new System.Drawing.Point(0, 0);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(400, 400);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbImagem.TabIndex = 1;
            this.pcbImagem.TabStop = false;
            // 
            // lblTiraFoto
            // 
            this.lblTiraFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTiraFoto.AutoSize = true;
            this.lblTiraFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblTiraFoto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiraFoto.ForeColor = System.Drawing.Color.LightGray;
            this.lblTiraFoto.Location = new System.Drawing.Point(90, 4);
            this.lblTiraFoto.Name = "lblTiraFoto";
            this.lblTiraFoto.Size = new System.Drawing.Size(251, 25);
            this.lblTiraFoto.TabIndex = 1;
            this.lblTiraFoto.Text = "SysPark - Tirar Foto\r\n";
            this.lblTiraFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMod1
            // 
            this.toolTipMod1.AutoSize = false;
            this.toolTipMod1.BackColor = System.Drawing.Color.Black;
            this.toolTipMod1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolTipMod1.ForeColor = System.Drawing.Color.LightGray;
            this.toolTipMod1.OwnerDraw = true;
            this.toolTipMod1.Size = new System.Drawing.Size(150, 30);
            // 
            // frmTirarFoto
            // 
            this.AcceptButton = this.btnCapturar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(431, 591);
            this.Controls.Add(this.pnlTirarFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTirarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTirarFoto";
            this.Load += new System.EventHandler(this.frmTirarFoto_Load);
            this.pnlTirarFoto.ResumeLayout(false);
            this.pnlTirarFoto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTirarFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTiraFoto;
        public System.Windows.Forms.PictureBox pcbImagem;
        public System.Windows.Forms.Button btnCapturar;
        public System.Windows.Forms.Button btnCancelar;
        private ToolTipMod.ToolTipMod toolTipMod1;
    }
}