using SysPark.Properties;

namespace SysPark
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picLogo = new PictureBoxMod.PictureBoxMod();
            this.lblnomeFantasia = new System.Windows.Forms.Label();
            this.pcbUsuario = new PictureBoxMod.PictureBoxMod();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.pnlOpcao4 = new System.Windows.Forms.Panel();
            this.flpSubMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOpcao2 = new System.Windows.Forms.Panel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.rbCadastro = new System.Windows.Forms.RadioButton();
            this.rbPesquisas = new System.Windows.Forms.RadioButton();
            this.rbConfig = new System.Windows.Forms.RadioButton();
            this.rbVendas = new System.Windows.Forms.RadioButton();
            this.rbProcedimento = new System.Windows.Forms.RadioButton();
            this.btnVendas = new ButtonMod.ButtonMod();
            this.btnPesquisa = new ButtonMod.ButtonMod();
            this.btnConfiguracao = new ButtonMod.ButtonMod();
            this.btnRelatorios = new ButtonMod.ButtonMod();
            this.btnProcedimentos = new ButtonMod.ButtonMod();
            this.btnCadastro = new ButtonMod.ButtonMod();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlHome.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.pnlOpcao4.SuspendLayout();
            this.pnlOpcao2.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHome.BackColor = System.Drawing.Color.Black;
            this.pnlHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHome.Controls.Add(this.pnlCabecalho);
            this.pnlHome.Controls.Add(this.btnMaximizar);
            this.pnlHome.Controls.Add(this.btnMinimizar);
            this.pnlHome.Controls.Add(this.btnFechar);
            this.pnlHome.Controls.Add(this.lblHome);
            this.pnlHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1120, 901);
            this.pnlHome.TabIndex = 0;
            this.pnlHome.Tag = "B";
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCabecalho.Controls.Add(this.pnlMenu);
            this.pnlCabecalho.Controls.Add(this.pnlOpcao4);
            this.pnlCabecalho.Controls.Add(this.pnlOpcao2);
            this.pnlCabecalho.Controls.Add(this.btnVendas);
            this.pnlCabecalho.Controls.Add(this.btnPesquisa);
            this.pnlCabecalho.Controls.Add(this.btnConfiguracao);
            this.pnlCabecalho.Controls.Add(this.btnRelatorios);
            this.pnlCabecalho.Controls.Add(this.btnProcedimentos);
            this.pnlCabecalho.Controls.Add(this.btnCadastro);
            this.pnlCabecalho.Location = new System.Drawing.Point(1, 39);
            this.pnlCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1117, 860);
            this.pnlCabecalho.TabIndex = 67;
            this.pnlCabecalho.Tag = "DG";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblnomeFantasia);
            this.pnlMenu.Controls.Add(this.pcbUsuario);
            this.pnlMenu.Controls.Add(this.lblnomeUsuario);
            this.pnlMenu.Controls.Add(this.lblidUsuario);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(348, 860);
            this.pnlMenu.TabIndex = 143;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.Location = new System.Drawing.Point(93, 7);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 140;
            this.picLogo.TabStop = false;
            // 
            // lblnomeFantasia
            // 
            this.lblnomeFantasia.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeFantasia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeFantasia.ForeColor = System.Drawing.Color.LightGray;
            this.lblnomeFantasia.Location = new System.Drawing.Point(4, 159);
            this.lblnomeFantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomeFantasia.Name = "lblnomeFantasia";
            this.lblnomeFantasia.Size = new System.Drawing.Size(340, 98);
            this.lblnomeFantasia.TabIndex = 67;
            this.lblnomeFantasia.Text = "Empresa";
            this.lblnomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnomeFantasia.UseMnemonic = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.Black;
            this.pcbUsuario.Location = new System.Drawing.Point(93, 261);
            this.pcbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(160, 148);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbUsuario.TabIndex = 139;
            this.pcbUsuario.TabStop = false;
            // 
            // lblnomeUsuario
            // 
            this.lblnomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblnomeUsuario.Location = new System.Drawing.Point(13, 412);
            this.lblnomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomeUsuario.Name = "lblnomeUsuario";
            this.lblnomeUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnomeUsuario.Size = new System.Drawing.Size(320, 57);
            this.lblnomeUsuario.TabIndex = 63;
            this.lblnomeUsuario.Text = "Usuário\r\n";
            this.lblnomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblidUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblidUsuario.Location = new System.Drawing.Point(93, 496);
            this.lblidUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(150, 25);
            this.lblidUsuario.TabIndex = 65;
            this.lblidUsuario.Text = "000.000.000-00";
            this.lblidUsuario.Visible = false;
            // 
            // pnlOpcao4
            // 
            this.pnlOpcao4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpcao4.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpcao4.Controls.Add(this.flpSubMenu);
            this.pnlOpcao4.Location = new System.Drawing.Point(731, 289);
            this.pnlOpcao4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOpcao4.Name = "pnlOpcao4";
            this.pnlOpcao4.Size = new System.Drawing.Size(372, 527);
            this.pnlOpcao4.TabIndex = 0;
            // 
            // flpSubMenu
            // 
            this.flpSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSubMenu.AutoScroll = true;
            this.flpSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSubMenu.ForeColor = System.Drawing.Color.LightGray;
            this.flpSubMenu.Location = new System.Drawing.Point(0, 0);
            this.flpSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flpSubMenu.Name = "flpSubMenu";
            this.flpSubMenu.Size = new System.Drawing.Size(400, 527);
            this.flpSubMenu.TabIndex = 0;
            // 
            // pnlOpcao2
            // 
            this.pnlOpcao2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOpcao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlOpcao2.Controls.Add(this.flpMenu);
            this.pnlOpcao2.Location = new System.Drawing.Point(348, 0);
            this.pnlOpcao2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOpcao2.Name = "pnlOpcao2";
            this.pnlOpcao2.Size = new System.Drawing.Size(375, 860);
            this.pnlOpcao2.TabIndex = 0;
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.Transparent;
            this.flpMenu.Controls.Add(this.rbCadastro);
            this.flpMenu.Controls.Add(this.rbPesquisas);
            this.flpMenu.Controls.Add(this.rbConfig);
            this.flpMenu.Controls.Add(this.rbVendas);
            this.flpMenu.Controls.Add(this.rbProcedimento);
            this.flpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpMenu.ForeColor = System.Drawing.Color.LightGray;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(403, 860);
            this.flpMenu.TabIndex = 0;
            // 
            // rbCadastro
            // 
            this.rbCadastro.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.rbCadastro.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCadastro.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rbCadastro.FlatAppearance.BorderSize = 0;
            this.rbCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rbCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCadastro.ForeColor = System.Drawing.Color.LightGray;
            this.rbCadastro.Image = ((System.Drawing.Image)(resources.GetObject("rbCadastro.Image")));
            this.rbCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbCadastro.Location = new System.Drawing.Point(4, 4);
            this.rbCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.rbCadastro.Name = "rbCadastro";
            this.rbCadastro.Size = new System.Drawing.Size(367, 129);
            this.rbCadastro.TabIndex = 143;
            this.rbCadastro.TabStop = true;
            this.rbCadastro.Text = "Cadastros";
            this.rbCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbCadastro.UseVisualStyleBackColor = false;
            this.rbCadastro.CheckedChanged += new System.EventHandler(this.rbCadastro_CheckedChanged);
            // 
            // rbPesquisas
            // 
            this.rbPesquisas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPesquisas.BackColor = System.Drawing.Color.Transparent;
            this.rbPesquisas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPesquisas.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rbPesquisas.FlatAppearance.BorderSize = 0;
            this.rbPesquisas.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rbPesquisas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbPesquisas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbPesquisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPesquisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisas.ForeColor = System.Drawing.Color.LightGray;
            this.rbPesquisas.Image = ((System.Drawing.Image)(resources.GetObject("rbPesquisas.Image")));
            this.rbPesquisas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbPesquisas.Location = new System.Drawing.Point(4, 141);
            this.rbPesquisas.Margin = new System.Windows.Forms.Padding(4);
            this.rbPesquisas.Name = "rbPesquisas";
            this.rbPesquisas.Size = new System.Drawing.Size(367, 129);
            this.rbPesquisas.TabIndex = 144;
            this.rbPesquisas.TabStop = true;
            this.rbPesquisas.Text = "Pesquisas";
            this.rbPesquisas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbPesquisas.UseVisualStyleBackColor = false;
            this.rbPesquisas.CheckedChanged += new System.EventHandler(this.rbCadastro_CheckedChanged);
            // 
            // rbConfig
            // 
            this.rbConfig.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbConfig.BackColor = System.Drawing.Color.Transparent;
            this.rbConfig.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbConfig.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rbConfig.FlatAppearance.BorderSize = 0;
            this.rbConfig.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rbConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConfig.ForeColor = System.Drawing.Color.LightGray;
            this.rbConfig.Image = ((System.Drawing.Image)(resources.GetObject("rbConfig.Image")));
            this.rbConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbConfig.Location = new System.Drawing.Point(4, 278);
            this.rbConfig.Margin = new System.Windows.Forms.Padding(4);
            this.rbConfig.Name = "rbConfig";
            this.rbConfig.Size = new System.Drawing.Size(367, 129);
            this.rbConfig.TabIndex = 148;
            this.rbConfig.TabStop = true;
            this.rbConfig.Text = "Configurações";
            this.rbConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbConfig.UseVisualStyleBackColor = false;
            this.rbConfig.CheckedChanged += new System.EventHandler(this.rbCadastro_CheckedChanged);
            // 
            // rbVendas
            // 
            this.rbVendas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbVendas.BackColor = System.Drawing.Color.Transparent;
            this.rbVendas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbVendas.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rbVendas.FlatAppearance.BorderSize = 0;
            this.rbVendas.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rbVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendas.ForeColor = System.Drawing.Color.LightGray;
            this.rbVendas.Image = ((System.Drawing.Image)(resources.GetObject("rbVendas.Image")));
            this.rbVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbVendas.Location = new System.Drawing.Point(4, 415);
            this.rbVendas.Margin = new System.Windows.Forms.Padding(4);
            this.rbVendas.Name = "rbVendas";
            this.rbVendas.Size = new System.Drawing.Size(367, 129);
            this.rbVendas.TabIndex = 147;
            this.rbVendas.TabStop = true;
            this.rbVendas.Text = "Vendas";
            this.rbVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbVendas.UseVisualStyleBackColor = false;
            this.rbVendas.CheckedChanged += new System.EventHandler(this.rbCadastro_CheckedChanged);
            // 
            // rbProcedimento
            // 
            this.rbProcedimento.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbProcedimento.BackColor = System.Drawing.Color.Transparent;
            this.rbProcedimento.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbProcedimento.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rbProcedimento.FlatAppearance.BorderSize = 0;
            this.rbProcedimento.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rbProcedimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbProcedimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProcedimento.ForeColor = System.Drawing.Color.LightGray;
            this.rbProcedimento.Image = ((System.Drawing.Image)(resources.GetObject("rbProcedimento.Image")));
            this.rbProcedimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbProcedimento.Location = new System.Drawing.Point(4, 552);
            this.rbProcedimento.Margin = new System.Windows.Forms.Padding(4);
            this.rbProcedimento.Name = "rbProcedimento";
            this.rbProcedimento.Size = new System.Drawing.Size(367, 129);
            this.rbProcedimento.TabIndex = 146;
            this.rbProcedimento.TabStop = true;
            this.rbProcedimento.Text = "Procedimentos";
            this.rbProcedimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbProcedimento.UseVisualStyleBackColor = false;
            this.rbProcedimento.CheckedChanged += new System.EventHandler(this.rbCadastro_CheckedChanged);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.Location = new System.Drawing.Point(847, 10);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(107, 98);
            this.btnVendas.TabIndex = 80;
            this.toolTipMod1.SetToolTip(this.btnVendas, "Vendas");
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Visible = false;
            this.btnVendas.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(847, 116);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(107, 98);
            this.btnPesquisa.TabIndex = 79;
            this.toolTipMod1.SetToolTip(this.btnPesquisa, "Pesquisas");
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Visible = false;
            this.btnPesquisa.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConfiguracao.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConfiguracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnConfiguracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.Image")));
            this.btnConfiguracao.Location = new System.Drawing.Point(961, 116);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(107, 98);
            this.btnConfiguracao.TabIndex = 78;
            this.toolTipMod1.SetToolTip(this.btnConfiguracao, "Configurações");
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Visible = false;
            this.btnConfiguracao.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.Location = new System.Drawing.Point(732, 10);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(107, 98);
            this.btnRelatorios.TabIndex = 77;
            this.toolTipMod1.SetToolTip(this.btnRelatorios, "Relatórios");
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Visible = false;
            this.btnRelatorios.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnProcedimentos
            // 
            this.btnProcedimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnProcedimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnProcedimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProcedimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcedimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnProcedimentos.Image")));
            this.btnProcedimentos.Location = new System.Drawing.Point(961, 10);
            this.btnProcedimentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcedimentos.Name = "btnProcedimentos";
            this.btnProcedimentos.Size = new System.Drawing.Size(107, 98);
            this.btnProcedimentos.TabIndex = 76;
            this.toolTipMod1.SetToolTip(this.btnProcedimentos, "Procedimentos Diários");
            this.btnProcedimentos.UseVisualStyleBackColor = false;
            this.btnProcedimentos.Visible = false;
            this.btnProcedimentos.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnProcedimentos.Click += new System.EventHandler(this.btnProcedimentos_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.Location = new System.Drawing.Point(732, 116);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(107, 98);
            this.btnCadastro.TabIndex = 75;
            this.toolTipMod1.SetToolTip(this.btnCadastro, "Cadastros");
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Visible = false;
            this.btnCadastro.EnabledChanged += new System.EventHandler(this.btnVendas_EnabledChanged);
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = global::SysPark.Properties.Resources.Collapse_25;
            this.btnMaximizar.Location = new System.Drawing.Point(1031, 1);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 37);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = global::SysPark.Properties.Resources.Minus;
            this.btnMinimizar.Location = new System.Drawing.Point(983, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::SysPark.Properties.Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(1079, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 37);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblHome
            // 
            this.lblHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.LightGray;
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(413, 5);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(225, 31);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "SysPark - Home\r\n";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMod1
            // 
            this.toolTipMod1.AutoSize = false;
            this.toolTipMod1.BackColor = System.Drawing.Color.Black;
            this.toolTipMod1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolTipMod1.ForeColor = System.Drawing.Color.LightGray;
            this.toolTipMod1.OwnerDraw = true;
            this.toolTipMod1.Size = new System.Drawing.Size(200, 30);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Black;
            this.imageList.Images.SetKeyName(0, "btnCliente.png");
            this.imageList.Images.SetKeyName(1, "btnFuncionario.png");
            this.imageList.Images.SetKeyName(2, "btnFornecedor.png");
            this.imageList.Images.SetKeyName(3, "btnTipoVeiculo.png");
            this.imageList.Images.SetKeyName(4, "btnCargo.png");
            this.imageList.Images.SetKeyName(5, "btnProduto.png");
            this.imageList.Images.SetKeyName(6, "btnPromocao.png");
            this.imageList.Images.SetKeyName(7, "btnPerda.png");
            this.imageList.Images.SetKeyName(8, "btnServico.png");
            this.imageList.Images.SetKeyName(9, "btnSubGrupo.png");
            this.imageList.Images.SetKeyName(10, "btnBackup.png");
            this.imageList.Images.SetKeyName(11, "btnCaixa.png");
            this.imageList.Images.SetKeyName(12, "btnAbreCaixa.png");
            this.imageList.Images.SetKeyName(13, "btnLogin.png");
            this.imageList.Images.SetKeyName(14, "btnRelCaixa.png");
            this.imageList.Images.SetKeyName(15, "btnRelEstoque.png");
            this.imageList.Images.SetKeyName(16, "btnRelCancel.png");
            this.imageList.Images.SetKeyName(17, "btnRelVendas.png");
            this.imageList.Images.SetKeyName(18, "btnRelItens.png");
            this.imageList.Images.SetKeyName(19, "btnOrcamento.png");
            this.imageList.Images.SetKeyName(20, "btnCarrinho.png");
            this.imageList.Images.SetKeyName(21, "btnOrdemServico.png");
            this.imageList.Images.SetKeyName(22, "btnListaCar.png");
            this.imageList.Images.SetKeyName(23, "btnDevolucao.png");
            this.imageList.Images.SetKeyName(24, "btnTerminal.png");
            this.imageList.Images.SetKeyName(25, "btnSeguranca.png");
            this.imageList.Images.SetKeyName(26, "btnInfo.png");
            this.imageList.Images.SetKeyName(27, "btnImpressora.png");
            this.imageList.Images.SetKeyName(28, "btnMovDia.png");
            this.imageList.Images.SetKeyName(29, "btnControleEstoque.png");
            this.imageList.Images.SetKeyName(30, "btnConsultaPreco.png");
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1120, 901);
            this.Controls.Add(this.pnlHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysPark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.pnlOpcao4.ResumeLayout(false);
            this.pnlOpcao2.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblnomeUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblnomeFantasia;
        private ToolTipMod.ToolTipMod toolTipMod1;
        private ButtonMod.ButtonMod btnPesquisa;
        private ButtonMod.ButtonMod btnConfiguracao;
        private ButtonMod.ButtonMod btnRelatorios;
        private ButtonMod.ButtonMod btnProcedimentos;
        private ButtonMod.ButtonMod btnCadastro;
        private ButtonMod.ButtonMod btnVendas;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
        private PictureBoxMod.PictureBoxMod picLogo;
        private System.Windows.Forms.Panel pnlOpcao2;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Panel pnlOpcao4;
        private System.Windows.Forms.FlowLayoutPanel flpSubMenu;
        private System.Windows.Forms.RadioButton rbConfig;
        private System.Windows.Forms.RadioButton rbVendas;
        private System.Windows.Forms.RadioButton rbProcedimento;
        private System.Windows.Forms.RadioButton rbPesquisas;
        private System.Windows.Forms.RadioButton rbCadastro;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ImageList imageList;
    }
}

