namespace SysPark.View
{
    partial class frmTipoCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoCartao));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 268);
            this.panel2.TabIndex = 12;
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.Black;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTipo.Location = new System.Drawing.Point(1, 42);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(568, 40);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo Cartão";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDebito.FlatAppearance.BorderSize = 0;
            this.btnDebito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDebito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.ForeColor = System.Drawing.Color.LightGray;
            this.btnDebito.Image = ((System.Drawing.Image)(resources.GetObject("btnDebito.Image")));
            this.btnDebito.Location = new System.Drawing.Point(310, 143);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(170, 75);
            this.btnDebito.TabIndex = 10;
            this.btnDebito.Text = "Débito\r\n(Digite 2)";
            this.btnDebito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDebito.UseVisualStyleBackColor = false;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.LightGray;
            this.btnCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnCredito.Image")));
            this.btnCredito.Location = new System.Drawing.Point(88, 143);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(170, 75);
            this.btnCredito.TabIndex = 9;
            this.btnCredito.Text = "Crédito\n(Digite 1)";
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnDebito);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.btnCredito);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 266);
            this.panel1.TabIndex = 12;
            // 
            // frmTipoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 268);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoCartao";
            this.Load += new System.EventHandler(this.frmTipoCartao_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Panel panel1;
    }
}