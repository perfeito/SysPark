using SysPark.Properties;

namespace SysPark
{
    partial class frmcadLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadLogin));
            this.pnlcadLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.pcbUsuario = new PictureBoxMod.PictureBoxMod();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btngeraSenha = new System.Windows.Forms.Button();
            this.txtconfSenha = new TextBoxMod.TextBoxMod();
            this.txtnomeUsuario = new TextBoxMod.TextBoxMod();
            this.txtSenha = new TextBoxMod.TextBoxMod();
            this.lblnovoUsuario = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblnomeFuncionario = new System.Windows.Forms.Label();
            this.lblconfSenha = new System.Windows.Forms.Label();
            this.lblcpfFuncionario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblcadLogin = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.pnlcadLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlcadLogin
            // 
            this.pnlcadLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcadLogin.BackColor = System.Drawing.Color.Black;
            this.pnlcadLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcadLogin.Controls.Add(this.panel2);
            this.pnlcadLogin.Controls.Add(this.btnFechar);
            this.pnlcadLogin.Controls.Add(this.lblcadLogin);
            this.pnlcadLogin.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlcadLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlcadLogin.Name = "pnlcadLogin";
            this.pnlcadLogin.Size = new System.Drawing.Size(546, 269);
            this.pnlcadLogin.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.pnlMenu);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(1, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 236);
            this.panel2.TabIndex = 76;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(45, 236);
            this.pnlMenu.TabIndex = 138;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.lblnomeUsuario);
            this.pnlUsuario.Controls.Add(this.pcbUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(3, 41);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(140, 40);
            this.pnlUsuario.TabIndex = 143;
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
            this.lblnomeUsuario.Size = new System.Drawing.Size(100, 40);
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
            this.pcbUsuario.Tag = "L";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel5.Location = new System.Drawing.Point(10, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 1);
            this.panel5.TabIndex = 129;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(10, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 129;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(5, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 139;
            this.btnMenu.Tag = "";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnPesquisar);
            this.flowLayoutPanel1.Controls.Add(this.btnEditar);
            this.flowLayoutPanel1.Controls.Add(this.btnSalvar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 150);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(140, 40);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Tag = "";
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(3, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Tag = "";
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(3, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Tag = "";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(3, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(63, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(463, 210);
            this.panel8.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(181, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel9.Controls.Add(this.btngeraSenha);
            this.panel9.Controls.Add(this.txtconfSenha);
            this.panel9.Controls.Add(this.txtnomeUsuario);
            this.panel9.Controls.Add(this.txtSenha);
            this.panel9.Controls.Add(this.lblnovoUsuario);
            this.panel9.Controls.Add(this.lblFuncionario);
            this.panel9.Controls.Add(this.lblnomeFuncionario);
            this.panel9.Controls.Add(this.lblconfSenha);
            this.panel9.Controls.Add(this.lblcpfFuncionario);
            this.panel9.Controls.Add(this.lblSenha);
            this.panel9.Controls.Add(this.lblCpf);
            this.panel9.Location = new System.Drawing.Point(1, 24);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(461, 185);
            this.panel9.TabIndex = 0;
            // 
            // btngeraSenha
            // 
            this.btngeraSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btngeraSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngeraSenha.FlatAppearance.BorderSize = 0;
            this.btngeraSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btngeraSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btngeraSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeraSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeraSenha.ForeColor = System.Drawing.Color.LightGray;
            this.btngeraSenha.Location = new System.Drawing.Point(346, 102);
            this.btngeraSenha.Name = "btngeraSenha";
            this.btngeraSenha.Size = new System.Drawing.Size(90, 60);
            this.btngeraSenha.TabIndex = 91;
            this.btngeraSenha.Tag = "";
            this.btngeraSenha.Text = "Gerar Senha";
            this.btngeraSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngeraSenha.UseVisualStyleBackColor = false;
            this.btngeraSenha.Click += new System.EventHandler(this.btngeraSenha_Click);
            // 
            // txtconfSenha
            // 
            this.txtconfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtconfSenha.BorderColor = System.Drawing.Color.Black;
            this.txtconfSenha.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtconfSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfSenha.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtconfSenha.ColorirTexto = System.Drawing.Color.Black;
            this.txtconfSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtconfSenha.Location = new System.Drawing.Point(161, 135);
            this.txtconfSenha.MaxLength = 16;
            this.txtconfSenha.MudaBorda = true;
            this.txtconfSenha.MudarCor = false;
            this.txtconfSenha.MudarTitulo = false;
            this.txtconfSenha.Name = "txtconfSenha";
            this.txtconfSenha.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtconfSenha.Size = new System.Drawing.Size(165, 27);
            this.txtconfSenha.TabIndex = 86;
            this.txtconfSenha.UseSystemPasswordChar = true;
            // 
            // txtnomeUsuario
            // 
            this.txtnomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnomeUsuario.BorderColor = System.Drawing.Color.Black;
            this.txtnomeUsuario.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeUsuario.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtnomeUsuario.ColorirTexto = System.Drawing.Color.Black;
            this.txtnomeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.txtnomeUsuario.Location = new System.Drawing.Point(161, 69);
            this.txtnomeUsuario.MaxLength = 30;
            this.txtnomeUsuario.MudaBorda = true;
            this.txtnomeUsuario.MudarCor = false;
            this.txtnomeUsuario.MudarTitulo = false;
            this.txtnomeUsuario.Name = "txtnomeUsuario";
            this.txtnomeUsuario.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtnomeUsuario.Size = new System.Drawing.Size(275, 27);
            this.txtnomeUsuario.TabIndex = 85;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSenha.BorderColor = System.Drawing.Color.Black;
            this.txtSenha.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtSenha.ColorirTexto = System.Drawing.Color.Black;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenha.Location = new System.Drawing.Point(161, 102);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.MudaBorda = true;
            this.txtSenha.MudarCor = false;
            this.txtSenha.MudarTitulo = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtSenha.Size = new System.Drawing.Size(165, 27);
            this.txtSenha.TabIndex = 85;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // lblnovoUsuario
            // 
            this.lblnovoUsuario.AutoSize = true;
            this.lblnovoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnovoUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblnovoUsuario.Location = new System.Drawing.Point(9, 71);
            this.lblnovoUsuario.Name = "lblnovoUsuario";
            this.lblnovoUsuario.Size = new System.Drawing.Size(146, 21);
            this.lblnovoUsuario.TabIndex = 73;
            this.lblnovoUsuario.Text = "Nome de Usuário:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.LightGray;
            this.lblFuncionario.Location = new System.Drawing.Point(51, 21);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(104, 21);
            this.lblFuncionario.TabIndex = 64;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // lblnomeFuncionario
            // 
            this.lblnomeFuncionario.AutoSize = true;
            this.lblnomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeFuncionario.ForeColor = System.Drawing.Color.LightGray;
            this.lblnomeFuncionario.Location = new System.Drawing.Point(161, 21);
            this.lblnomeFuncionario.Name = "lblnomeFuncionario";
            this.lblnomeFuncionario.Size = new System.Drawing.Size(46, 21);
            this.lblnomeFuncionario.TabIndex = 65;
            this.lblnomeFuncionario.Text = "###";
            // 
            // lblconfSenha
            // 
            this.lblconfSenha.AutoSize = true;
            this.lblconfSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfSenha.ForeColor = System.Drawing.Color.LightGray;
            this.lblconfSenha.Location = new System.Drawing.Point(2, 137);
            this.lblconfSenha.Name = "lblconfSenha";
            this.lblconfSenha.Size = new System.Drawing.Size(153, 21);
            this.lblconfSenha.TabIndex = 71;
            this.lblconfSenha.Text = "Confirme a Senha:";
            // 
            // lblcpfFuncionario
            // 
            this.lblcpfFuncionario.AutoSize = true;
            this.lblcpfFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpfFuncionario.ForeColor = System.Drawing.Color.LightGray;
            this.lblcpfFuncionario.Location = new System.Drawing.Point(161, 43);
            this.lblcpfFuncionario.Name = "lblcpfFuncionario";
            this.lblcpfFuncionario.Size = new System.Drawing.Size(46, 21);
            this.lblcpfFuncionario.TabIndex = 67;
            this.lblcpfFuncionario.Text = "###";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.LightGray;
            this.lblSenha.Location = new System.Drawing.Point(92, 104);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 21);
            this.lblSenha.TabIndex = 70;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.LightGray;
            this.lblCpf.Location = new System.Drawing.Point(111, 42);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 21);
            this.lblCpf.TabIndex = 66;
            this.lblCpf.Text = "CPF:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(515, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lblcadLogin
            // 
            this.lblcadLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcadLogin.AutoSize = true;
            this.lblcadLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblcadLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadLogin.ForeColor = System.Drawing.Color.LightGray;
            this.lblcadLogin.Location = new System.Drawing.Point(100, 4);
            this.lblcadLogin.Name = "lblcadLogin";
            this.lblcadLogin.Size = new System.Drawing.Size(347, 25);
            this.lblcadLogin.TabIndex = 1;
            this.lblcadLogin.Text = "SysPark - Cadastro de Login";
            this.lblcadLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipMod1
            // 
            this.toolTipMod1.AutoSize = false;
            this.toolTipMod1.BackColor = System.Drawing.Color.Black;
            this.toolTipMod1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolTipMod1.ForeColor = System.Drawing.Color.LightGray;
            this.toolTipMod1.OwnerDraw = true;
            this.toolTipMod1.Size = new System.Drawing.Size(100, 30);
            // 
            // frmcadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 269);
            this.Controls.Add(this.pnlcadLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmcadLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcadLogin";
            this.Load += new System.EventHandler(this.frmcadLogin_Load);
            this.pnlcadLogin.ResumeLayout(false);
            this.pnlcadLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlcadLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblcadLogin;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblconfSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblnovoUsuario;
        public System.Windows.Forms.Label lblnomeFuncionario;
        public System.Windows.Forms.Label lblcpfFuncionario;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        public TextBoxMod.TextBoxMod txtnomeUsuario;
        public TextBoxMod.TextBoxMod txtconfSenha;
        public TextBoxMod.TextBoxMod txtSenha;
        private System.Windows.Forms.Button btngeraSenha;
        private ToolTipMod.ToolTipMod toolTipMod1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlUsuario;
        public System.Windows.Forms.Label lblnomeUsuario;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
    }
}