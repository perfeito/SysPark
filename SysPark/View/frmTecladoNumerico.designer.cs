namespace SysPark.View
{
    partial class frmTecladoNumerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTecladoNumerico));
            this.pnlTeclado = new System.Windows.Forms.Panel();
            this.pnlShowMessage = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTreis = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.txtDado = new TextBoxMod.TextBoxMod();
            this.pnlTeclado.SuspendLayout();
            this.pnlShowMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeclado.BackColor = System.Drawing.Color.Black;
            this.pnlTeclado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTeclado.Controls.Add(this.pnlShowMessage);
            this.pnlTeclado.Controls.Add(this.lblTeclado);
            this.pnlTeclado.Location = new System.Drawing.Point(0, 0);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(406, 579);
            this.pnlTeclado.TabIndex = 5;
            // 
            // pnlShowMessage
            // 
            this.pnlShowMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShowMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlShowMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlShowMessage.Controls.Add(this.txtDado);
            this.pnlShowMessage.Controls.Add(this.btnVoltar);
            this.pnlShowMessage.Controls.Add(this.btnLimpar);
            this.pnlShowMessage.Controls.Add(this.btnZero);
            this.pnlShowMessage.Controls.Add(this.btnSete);
            this.pnlShowMessage.Controls.Add(this.btnOito);
            this.pnlShowMessage.Controls.Add(this.btnNove);
            this.pnlShowMessage.Controls.Add(this.btnQuatro);
            this.pnlShowMessage.Controls.Add(this.btnCinco);
            this.pnlShowMessage.Controls.Add(this.btnSeis);
            this.pnlShowMessage.Controls.Add(this.btnUm);
            this.pnlShowMessage.Controls.Add(this.btnDois);
            this.pnlShowMessage.Controls.Add(this.btnTreis);
            this.pnlShowMessage.Controls.Add(this.btnBackSpace);
            this.pnlShowMessage.Controls.Add(this.btnConfirmar);
            this.pnlShowMessage.ForeColor = System.Drawing.Color.Transparent;
            this.pnlShowMessage.Location = new System.Drawing.Point(1, 54);
            this.pnlShowMessage.Name = "pnlShowMessage";
            this.pnlShowMessage.Size = new System.Drawing.Size(404, 523);
            this.pnlShowMessage.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.LightGray;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(162, 431);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 80);
            this.btnVoltar.TabIndex = 161;
            this.btnVoltar.Tag = "";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(76, 431);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 80);
            this.btnLimpar.TabIndex = 160;
            this.btnLimpar.Tag = "";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.LightGray;
            this.btnZero.Image = ((System.Drawing.Image)(resources.GetObject("btnZero.Image")));
            this.btnZero.Location = new System.Drawing.Point(162, 345);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(80, 80);
            this.btnZero.TabIndex = 159;
            this.btnZero.Tag = "0";
            this.btnZero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnSete
            // 
            this.btnSete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.LightGray;
            this.btnSete.Image = ((System.Drawing.Image)(resources.GetObject("btnSete.Image")));
            this.btnSete.Location = new System.Drawing.Point(76, 87);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(80, 80);
            this.btnSete.TabIndex = 158;
            this.btnSete.Tag = "7";
            this.btnSete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnOito
            // 
            this.btnOito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnOito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnOito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.LightGray;
            this.btnOito.Image = ((System.Drawing.Image)(resources.GetObject("btnOito.Image")));
            this.btnOito.Location = new System.Drawing.Point(162, 87);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(80, 80);
            this.btnOito.TabIndex = 157;
            this.btnOito.Tag = "8";
            this.btnOito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnNove
            // 
            this.btnNove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnNove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.LightGray;
            this.btnNove.Image = ((System.Drawing.Image)(resources.GetObject("btnNove.Image")));
            this.btnNove.Location = new System.Drawing.Point(248, 87);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(80, 80);
            this.btnNove.TabIndex = 156;
            this.btnNove.Tag = "9";
            this.btnNove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnQuatro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnQuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.LightGray;
            this.btnQuatro.Image = ((System.Drawing.Image)(resources.GetObject("btnQuatro.Image")));
            this.btnQuatro.Location = new System.Drawing.Point(76, 173);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(80, 80);
            this.btnQuatro.TabIndex = 155;
            this.btnQuatro.Tag = "4";
            this.btnQuatro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCinco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.LightGray;
            this.btnCinco.Image = ((System.Drawing.Image)(resources.GetObject("btnCinco.Image")));
            this.btnCinco.Location = new System.Drawing.Point(162, 173);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(80, 80);
            this.btnCinco.TabIndex = 154;
            this.btnCinco.Tag = "5";
            this.btnCinco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSeis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.LightGray;
            this.btnSeis.Image = ((System.Drawing.Image)(resources.GetObject("btnSeis.Image")));
            this.btnSeis.Location = new System.Drawing.Point(248, 173);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(80, 80);
            this.btnSeis.TabIndex = 153;
            this.btnSeis.Tag = "6";
            this.btnSeis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnUm
            // 
            this.btnUm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnUm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.LightGray;
            this.btnUm.Image = ((System.Drawing.Image)(resources.GetObject("btnUm.Image")));
            this.btnUm.Location = new System.Drawing.Point(76, 259);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(80, 80);
            this.btnUm.TabIndex = 152;
            this.btnUm.Tag = "1";
            this.btnUm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnDois
            // 
            this.btnDois.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDois.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.LightGray;
            this.btnDois.Image = ((System.Drawing.Image)(resources.GetObject("btnDois.Image")));
            this.btnDois.Location = new System.Drawing.Point(162, 259);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(80, 80);
            this.btnDois.TabIndex = 151;
            this.btnDois.Tag = "2";
            this.btnDois.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnTreis
            // 
            this.btnTreis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnTreis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTreis.FlatAppearance.BorderSize = 0;
            this.btnTreis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTreis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTreis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreis.ForeColor = System.Drawing.Color.LightGray;
            this.btnTreis.Image = ((System.Drawing.Image)(resources.GetObject("btnTreis.Image")));
            this.btnTreis.Location = new System.Drawing.Point(248, 259);
            this.btnTreis.Name = "btnTreis";
            this.btnTreis.Size = new System.Drawing.Size(80, 80);
            this.btnTreis.TabIndex = 150;
            this.btnTreis.Tag = "3";
            this.btnTreis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTreis.UseVisualStyleBackColor = false;
            this.btnTreis.Click += new System.EventHandler(this.btnAddNumero);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.Color.LightGray;
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(76, 345);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(80, 80);
            this.btnBackSpace.TabIndex = 149;
            this.btnBackSpace.Tag = "";
            this.btnBackSpace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(248, 345);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 166);
            this.btnConfirmar.TabIndex = 147;
            this.btnConfirmar.Tag = "";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTeclado
            // 
            this.lblTeclado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.BackColor = System.Drawing.Color.Transparent;
            this.lblTeclado.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeclado.ForeColor = System.Drawing.Color.LightGray;
            this.lblTeclado.Location = new System.Drawing.Point(133, 9);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(140, 38);
            this.lblTeclado.TabIndex = 0;
            this.lblTeclado.Text = "Teclado";
            this.lblTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDado
            // 
            this.txtDado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDado.BorderColor = System.Drawing.Color.Black;
            this.txtDado.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDado.ColorirFundo = System.Drawing.Color.Empty;
            this.txtDado.ColorirTexto = System.Drawing.Color.Empty;
            this.txtDado.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDado.ForeColor = System.Drawing.Color.LightGray;
            this.txtDado.Location = new System.Drawing.Point(8, 9);
            this.txtDado.MudaBorda = true;
            this.txtDado.MudarCor = false;
            this.txtDado.MudarTitulo = false;
            this.txtDado.Name = "txtDado";
            this.txtDado.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtDado.Size = new System.Drawing.Size(388, 66);
            this.txtDado.TabIndex = 162;
            // 
            // frmTecladoNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 579);
            this.Controls.Add(this.pnlTeclado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTecladoNumerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTecladoNumerico";
            this.Load += new System.EventHandler(this.frmTecladoNumerico_Load);
            this.pnlTeclado.ResumeLayout(false);
            this.pnlTeclado.PerformLayout();
            this.pnlShowMessage.ResumeLayout(false);
            this.pnlShowMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeclado;
        private System.Windows.Forms.Panel pnlShowMessage;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTreis;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        public TextBoxMod.TextBoxMod txtDado;
    }
}