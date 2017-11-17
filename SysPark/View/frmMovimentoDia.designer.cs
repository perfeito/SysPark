using SysPark.Properties;

namespace SysPark.View
{
    partial class frmMovimentoDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentoDia));
            this.pnlmovimentoDia = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.pcbUsuario = new PictureBoxMod.PictureBoxMod();
            this.lblData = new System.Windows.Forms.Label();
            this.lblexibeData = new System.Windows.Forms.Label();
            this.lblidOperador = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtTerminal = new TextBoxMod.TextBoxMod();
            this.txtusuarioAbertura = new TextBoxMod.TextBoxMod();
            this.txtMovimento = new TextBoxMod.TextBoxMod();
            this.txtdataAbertura = new TextBoxMod.TextBoxMod();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblusuarioAbertura = new System.Windows.Forms.Label();
            this.lblMovimento = new System.Windows.Forms.Label();
            this.lbldataAbertura = new System.Windows.Forms.Label();
            this.btnfecharMovimento = new System.Windows.Forms.Button();
            this.btniabreMovimento = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblmovimentoDia = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.pnlmovimentoDia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmovimentoDia
            // 
            this.pnlmovimentoDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmovimentoDia.BackColor = System.Drawing.Color.Black;
            this.pnlmovimentoDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlmovimentoDia.Controls.Add(this.panel1);
            this.pnlmovimentoDia.Controls.Add(this.btnFechar);
            this.pnlmovimentoDia.Controls.Add(this.lblmovimentoDia);
            this.pnlmovimentoDia.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmovimentoDia.Location = new System.Drawing.Point(0, 0);
            this.pnlmovimentoDia.Name = "pnlmovimentoDia";
            this.pnlmovimentoDia.Size = new System.Drawing.Size(568, 369);
            this.pnlmovimentoDia.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblexibeData);
            this.panel1.Controls.Add(this.lblidOperador);
            this.panel1.Controls.Add(this.pnlCampos);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 336);
            this.panel1.TabIndex = 77;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblnomeUsuario);
            this.panel4.Controls.Add(this.pcbUsuario);
            this.panel4.Location = new System.Drawing.Point(20, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 40);
            this.panel4.TabIndex = 138;
            // 
            // lblnomeUsuario
            // 
            this.lblnomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnomeUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblnomeUsuario.Location = new System.Drawing.Point(41, 0);
            this.lblnomeUsuario.Name = "lblnomeUsuario";
            this.lblnomeUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnomeUsuario.Size = new System.Drawing.Size(130, 40);
            this.lblnomeUsuario.TabIndex = 63;
            this.lblnomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.Black;
            this.pcbUsuario.Location = new System.Drawing.Point(0, 0);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(40, 40);
            this.pcbUsuario.TabIndex = 137;
            this.pcbUsuario.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.LightGray;
            this.lblData.Location = new System.Drawing.Point(16, 46);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 21);
            this.lblData.TabIndex = 62;
            this.lblData.Text = "Data:";
            // 
            // lblexibeData
            // 
            this.lblexibeData.AutoSize = true;
            this.lblexibeData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexibeData.ForeColor = System.Drawing.Color.LightGray;
            this.lblexibeData.Location = new System.Drawing.Point(68, 46);
            this.lblexibeData.Name = "lblexibeData";
            this.lblexibeData.Size = new System.Drawing.Size(96, 21);
            this.lblexibeData.TabIndex = 63;
            this.lblexibeData.Text = "00/00/0000";
            // 
            // lblidOperador
            // 
            this.lblidOperador.AutoSize = true;
            this.lblidOperador.Location = new System.Drawing.Point(506, 15);
            this.lblidOperador.Name = "lblidOperador";
            this.lblidOperador.Size = new System.Drawing.Size(49, 21);
            this.lblidOperador.TabIndex = 83;
            this.lblidOperador.Text = "label1";
            this.lblidOperador.Visible = false;
            // 
            // pnlCampos
            // 
            this.pnlCampos.BackColor = System.Drawing.Color.Transparent;
            this.pnlCampos.Controls.Add(this.txtTerminal);
            this.pnlCampos.Controls.Add(this.txtusuarioAbertura);
            this.pnlCampos.Controls.Add(this.txtMovimento);
            this.pnlCampos.Controls.Add(this.txtdataAbertura);
            this.pnlCampos.Controls.Add(this.lblTerminal);
            this.pnlCampos.Controls.Add(this.lblusuarioAbertura);
            this.pnlCampos.Controls.Add(this.lblMovimento);
            this.pnlCampos.Controls.Add(this.lbldataAbertura);
            this.pnlCampos.Controls.Add(this.btnfecharMovimento);
            this.pnlCampos.Controls.Add(this.btniabreMovimento);
            this.pnlCampos.Location = new System.Drawing.Point(0, 78);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(566, 257);
            this.pnlCampos.TabIndex = 82;
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTerminal.BorderColor = System.Drawing.Color.Black;
            this.txtTerminal.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTerminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerminal.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtTerminal.ColorirTexto = System.Drawing.Color.Black;
            this.txtTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.txtTerminal.Location = new System.Drawing.Point(20, 213);
            this.txtTerminal.MaxLength = 50;
            this.txtTerminal.MudaBorda = true;
            this.txtTerminal.MudarCor = false;
            this.txtTerminal.MudarTitulo = false;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtTerminal.Size = new System.Drawing.Size(324, 27);
            this.txtTerminal.TabIndex = 93;
            // 
            // txtusuarioAbertura
            // 
            this.txtusuarioAbertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtusuarioAbertura.BorderColor = System.Drawing.Color.Black;
            this.txtusuarioAbertura.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtusuarioAbertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuarioAbertura.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtusuarioAbertura.ColorirTexto = System.Drawing.Color.Black;
            this.txtusuarioAbertura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuarioAbertura.ForeColor = System.Drawing.Color.LightGray;
            this.txtusuarioAbertura.Location = new System.Drawing.Point(20, 153);
            this.txtusuarioAbertura.MaxLength = 50;
            this.txtusuarioAbertura.MudaBorda = true;
            this.txtusuarioAbertura.MudarCor = false;
            this.txtusuarioAbertura.MudarTitulo = false;
            this.txtusuarioAbertura.Name = "txtusuarioAbertura";
            this.txtusuarioAbertura.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtusuarioAbertura.Size = new System.Drawing.Size(324, 27);
            this.txtusuarioAbertura.TabIndex = 139;
            // 
            // txtMovimento
            // 
            this.txtMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMovimento.BorderColor = System.Drawing.Color.Black;
            this.txtMovimento.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMovimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovimento.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtMovimento.ColorirTexto = System.Drawing.Color.Black;
            this.txtMovimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovimento.ForeColor = System.Drawing.Color.LightGray;
            this.txtMovimento.Location = new System.Drawing.Point(20, 92);
            this.txtMovimento.MaxLength = 50;
            this.txtMovimento.MudaBorda = true;
            this.txtMovimento.MudarCor = false;
            this.txtMovimento.MudarTitulo = false;
            this.txtMovimento.Name = "txtMovimento";
            this.txtMovimento.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtMovimento.Size = new System.Drawing.Size(324, 27);
            this.txtMovimento.TabIndex = 140;
            // 
            // txtdataAbertura
            // 
            this.txtdataAbertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtdataAbertura.BorderColor = System.Drawing.Color.Black;
            this.txtdataAbertura.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtdataAbertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdataAbertura.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtdataAbertura.ColorirTexto = System.Drawing.Color.Black;
            this.txtdataAbertura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdataAbertura.ForeColor = System.Drawing.Color.LightGray;
            this.txtdataAbertura.Location = new System.Drawing.Point(20, 33);
            this.txtdataAbertura.MaxLength = 50;
            this.txtdataAbertura.MudaBorda = true;
            this.txtdataAbertura.MudarCor = false;
            this.txtdataAbertura.MudarTitulo = false;
            this.txtdataAbertura.Name = "txtdataAbertura";
            this.txtdataAbertura.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtdataAbertura.Size = new System.Drawing.Size(260, 27);
            this.txtdataAbertura.TabIndex = 92;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTerminal.Location = new System.Drawing.Point(16, 189);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(180, 21);
            this.lblTerminal.TabIndex = 86;
            this.lblTerminal.Text = "Terminal de Abertura:";
            // 
            // lblusuarioAbertura
            // 
            this.lblusuarioAbertura.AutoSize = true;
            this.lblusuarioAbertura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioAbertura.ForeColor = System.Drawing.Color.LightGray;
            this.lblusuarioAbertura.Location = new System.Drawing.Point(16, 129);
            this.lblusuarioAbertura.Name = "lblusuarioAbertura";
            this.lblusuarioAbertura.Size = new System.Drawing.Size(171, 21);
            this.lblusuarioAbertura.TabIndex = 84;
            this.lblusuarioAbertura.Text = "Usuário de Abertura:";
            // 
            // lblMovimento
            // 
            this.lblMovimento.AutoSize = true;
            this.lblMovimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimento.ForeColor = System.Drawing.Color.LightGray;
            this.lblMovimento.Location = new System.Drawing.Point(16, 68);
            this.lblMovimento.Name = "lblMovimento";
            this.lblMovimento.Size = new System.Drawing.Size(156, 21);
            this.lblMovimento.TabIndex = 80;
            this.lblMovimento.Text = "Movimento Dia Nº:";
            // 
            // lbldataAbertura
            // 
            this.lbldataAbertura.AutoSize = true;
            this.lbldataAbertura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataAbertura.ForeColor = System.Drawing.Color.LightGray;
            this.lbldataAbertura.Location = new System.Drawing.Point(16, 9);
            this.lbldataAbertura.Name = "lbldataAbertura";
            this.lbldataAbertura.Size = new System.Drawing.Size(156, 21);
            this.lbldataAbertura.TabIndex = 82;
            this.lbldataAbertura.Text = "Data de Abertura:";
            // 
            // btnfecharMovimento
            // 
            this.btnfecharMovimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnfecharMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnfecharMovimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnfecharMovimento.FlatAppearance.BorderSize = 0;
            this.btnfecharMovimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnfecharMovimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnfecharMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfecharMovimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharMovimento.ForeColor = System.Drawing.Color.White;
            this.btnfecharMovimento.Image = ((System.Drawing.Image)(resources.GetObject("btnfecharMovimento.Image")));
            this.btnfecharMovimento.Location = new System.Drawing.Point(445, 152);
            this.btnfecharMovimento.Name = "btnfecharMovimento";
            this.btnfecharMovimento.Size = new System.Drawing.Size(80, 80);
            this.btnfecharMovimento.TabIndex = 79;
            this.btnfecharMovimento.Tag = "";
            this.btnfecharMovimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMod1.SetToolTip(this.btnfecharMovimento, "Fecha\r\nMovimento Dia");
            this.btnfecharMovimento.UseVisualStyleBackColor = false;
            this.btnfecharMovimento.Click += new System.EventHandler(this.btnfecharMovimento_Click);
            // 
            // btniabreMovimento
            // 
            this.btniabreMovimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btniabreMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btniabreMovimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btniabreMovimento.FlatAppearance.BorderSize = 0;
            this.btniabreMovimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btniabreMovimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btniabreMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniabreMovimento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniabreMovimento.ForeColor = System.Drawing.Color.White;
            this.btniabreMovimento.Image = ((System.Drawing.Image)(resources.GetObject("btniabreMovimento.Image")));
            this.btniabreMovimento.Location = new System.Drawing.Point(445, 24);
            this.btniabreMovimento.Name = "btniabreMovimento";
            this.btniabreMovimento.Size = new System.Drawing.Size(80, 80);
            this.btniabreMovimento.TabIndex = 76;
            this.btniabreMovimento.Tag = "";
            this.btniabreMovimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMod1.SetToolTip(this.btniabreMovimento, "Abre \r\nMovimento Dia");
            this.btniabreMovimento.UseVisualStyleBackColor = false;
            this.btniabreMovimento.Click += new System.EventHandler(this.btniabreMovimento_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(537, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblmovimentoDia
            // 
            this.lblmovimentoDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmovimentoDia.AutoSize = true;
            this.lblmovimentoDia.BackColor = System.Drawing.Color.Transparent;
            this.lblmovimentoDia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmovimentoDia.ForeColor = System.Drawing.Color.LightGray;
            this.lblmovimentoDia.Location = new System.Drawing.Point(127, 4);
            this.lblmovimentoDia.Name = "lblmovimentoDia";
            this.lblmovimentoDia.Size = new System.Drawing.Size(315, 25);
            this.lblmovimentoDia.TabIndex = 1;
            this.lblmovimentoDia.Text = "SysPark - Movimento Dia\r\n";
            this.lblmovimentoDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMod1
            // 
            this.toolTipMod1.AutoSize = false;
            this.toolTipMod1.BackColor = System.Drawing.Color.Black;
            this.toolTipMod1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolTipMod1.ForeColor = System.Drawing.Color.LightGray;
            this.toolTipMod1.OwnerDraw = true;
            this.toolTipMod1.Size = new System.Drawing.Size(200, 60);
            // 
            // frmMovimentoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 369);
            this.Controls.Add(this.pnlmovimentoDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimentoDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMovimentoDia";
            this.Load += new System.EventHandler(this.frmMovimentoDia_Load);
            this.pnlmovimentoDia.ResumeLayout(false);
            this.pnlmovimentoDia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmovimentoDia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btniabreMovimento;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblmovimentoDia;
        private System.Windows.Forms.Button btnfecharMovimento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblexibeData;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblMovimento;
        private System.Windows.Forms.Label lblusuarioAbertura;
        private System.Windows.Forms.Label lbldataAbertura;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblidOperador;
        private ToolTipMod.ToolTipMod toolTipMod1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblnomeUsuario;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
        public TextBoxMod.TextBoxMod txtdataAbertura;
        public TextBoxMod.TextBoxMod txtMovimento;
        public TextBoxMod.TextBoxMod txtusuarioAbertura;
        public TextBoxMod.TextBoxMod txtTerminal;
    }
}