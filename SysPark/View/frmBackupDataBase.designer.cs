namespace SysPark.View
{
    partial class frmBackupDataBase
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
            this.pnlopcaoImpressao = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEfetuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblopcaoImpressao = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.pnlopcaoImpressao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlopcaoImpressao
            // 
            this.pnlopcaoImpressao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlopcaoImpressao.BackColor = System.Drawing.Color.Black;
            this.pnlopcaoImpressao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlopcaoImpressao.Controls.Add(this.panel2);
            this.pnlopcaoImpressao.Controls.Add(this.btnMinimizar);
            this.pnlopcaoImpressao.Controls.Add(this.btnFechar);
            this.pnlopcaoImpressao.Controls.Add(this.lblopcaoImpressao);
            this.pnlopcaoImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlopcaoImpressao.Location = new System.Drawing.Point(0, 0);
            this.pnlopcaoImpressao.Margin = new System.Windows.Forms.Padding(4);
            this.pnlopcaoImpressao.Name = "pnlopcaoImpressao";
            this.pnlopcaoImpressao.Size = new System.Drawing.Size(656, 298);
            this.pnlopcaoImpressao.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnEfetuar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 257);
            this.panel2.TabIndex = 74;
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEfetuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEfetuar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEfetuar.FlatAppearance.BorderSize = 0;
            this.btnEfetuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEfetuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEfetuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfetuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEfetuar.Location = new System.Drawing.Point(116, 50);
            this.btnEfetuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(434, 92);
            this.btnEfetuar.TabIndex = 129;
            this.btnEfetuar.Text = "Efetuar\r\n(ENTER)";
            this.btnEfetuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEfetuar.UseVisualStyleBackColor = false;
            this.btnEfetuar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(163, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "ao abrir e fechar o movimento do dia.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(153, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 50);
            this.label3.TabIndex = 87;
            this.label3.Text = "\r\nO Backup é realizado automaticamente";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = global::SysPark.Properties.Resources.Minus;
            this.btnMinimizar.Location = new System.Drawing.Point(567, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 69;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::SysPark.Properties.Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(615, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 37);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblopcaoImpressao
            // 
            this.lblopcaoImpressao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblopcaoImpressao.AutoSize = true;
            this.lblopcaoImpressao.BackColor = System.Drawing.Color.Transparent;
            this.lblopcaoImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopcaoImpressao.ForeColor = System.Drawing.Color.LightGray;
            this.lblopcaoImpressao.Location = new System.Drawing.Point(52, 4);
            this.lblopcaoImpressao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblopcaoImpressao.Name = "lblopcaoImpressao";
            this.lblopcaoImpressao.Size = new System.Drawing.Size(468, 31);
            this.lblopcaoImpressao.TabIndex = 1;
            this.lblopcaoImpressao.Text = "SysPark - Backup Banco de Dados";
            this.lblopcaoImpressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMod1
            // 
            this.toolTipMod1.AutoSize = false;
            this.toolTipMod1.BackColor = System.Drawing.Color.Black;
            this.toolTipMod1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTipMod1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipMod1.OwnerDraw = true;
            this.toolTipMod1.Size = new System.Drawing.Size(100, 30);
            // 
            // frmBackupDataBase
            // 
            this.AcceptButton = this.btnEfetuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 298);
            this.Controls.Add(this.pnlopcaoImpressao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBackupDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpcaoImpressao";
            this.Load += new System.EventHandler(this.frmOpcaoImpressao_Load);
            this.pnlopcaoImpressao.ResumeLayout(false);
            this.pnlopcaoImpressao.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlopcaoImpressao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblopcaoImpressao;
        private ToolTipMod.ToolTipMod toolTipMod1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEfetuar;
    }
}