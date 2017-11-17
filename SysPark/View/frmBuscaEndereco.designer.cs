using SysPark.Properties;

namespace SysPark
{
    partial class frmBuscaEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaEndereco));
            this.pnlbuscaCep = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.msknumCep = new MaskedTextBoxMod.MaskedTextBoxMod();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblcepCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnomeEstado = new TextBoxMod.TextBoxMod();
            this.txtnomeCidade = new TextBoxMod.TextBoxMod();
            this.txtnomeBairro = new TextBoxMod.TextBoxMod();
            this.txtnomeRua = new TextBoxMod.TextBoxMod();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblbuscaCep = new System.Windows.Forms.Label();
            this.pnlbuscaCep.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbuscaCep
            // 
            this.pnlbuscaCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlbuscaCep.BackColor = System.Drawing.Color.Black;
            this.pnlbuscaCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlbuscaCep.Controls.Add(this.panel2);
            this.pnlbuscaCep.Controls.Add(this.btnMinimizar);
            this.pnlbuscaCep.Controls.Add(this.btnFechar);
            this.pnlbuscaCep.Controls.Add(this.lblbuscaCep);
            this.pnlbuscaCep.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbuscaCep.Location = new System.Drawing.Point(0, 0);
            this.pnlbuscaCep.Name = "pnlbuscaCep";
            this.pnlbuscaCep.Size = new System.Drawing.Size(724, 347);
            this.pnlbuscaCep.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Location = new System.Drawing.Point(1, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 314);
            this.panel2.TabIndex = 74;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(12, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 181);
            this.panel5.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(60, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel7.Controls.Add(this.msknumCep);
            this.panel7.Controls.Add(this.btnBusca);
            this.panel7.Controls.Add(this.lblcepCliente);
            this.panel7.Location = new System.Drawing.Point(1, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(182, 156);
            this.panel7.TabIndex = 0;
            // 
            // msknumCep
            // 
            this.msknumCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.msknumCep.BorderColor = System.Drawing.Color.Black;
            this.msknumCep.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msknumCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msknumCep.ColorirFundo = System.Drawing.Color.LightGray;
            this.msknumCep.ColorirTexto = System.Drawing.Color.Black;
            this.msknumCep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msknumCep.ForeColor = System.Drawing.Color.LightGray;
            this.msknumCep.Location = new System.Drawing.Point(74, 14);
            this.msknumCep.Mask = "00000-000";
            this.msknumCep.MudaBorda = true;
            this.msknumCep.MudarCor = false;
            this.msknumCep.MudarTitulo = false;
            this.msknumCep.Name = "msknumCep";
            this.msknumCep.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.msknumCep.Size = new System.Drawing.Size(86, 27);
            this.msknumCep.TabIndex = 85;
            this.msknumCep.Click += new System.EventHandler(this.StartLeft_Click);
            this.msknumCep.Enter += new System.EventHandler(this.mskCep_Enter);
            this.msknumCep.Leave += new System.EventHandler(this.mskCep_Leave);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.LightGray;
            this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
            this.btnBusca.Location = new System.Drawing.Point(36, 55);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(111, 86);
            this.btnBusca.TabIndex = 77;
            this.btnBusca.Tag = "";
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblcepCliente
            // 
            this.lblcepCliente.AutoSize = true;
            this.lblcepCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcepCliente.ForeColor = System.Drawing.Color.LightGray;
            this.lblcepCliente.Location = new System.Drawing.Point(23, 16);
            this.lblcepCliente.Name = "lblcepCliente";
            this.lblcepCliente.Size = new System.Drawing.Size(45, 21);
            this.lblcepCliente.TabIndex = 14;
            this.lblcepCliente.Text = "CEP:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(202, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 181);
            this.panel1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(220, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.txtnomeEstado);
            this.panel3.Controls.Add(this.txtnomeCidade);
            this.panel3.Controls.Add(this.txtnomeBairro);
            this.panel3.Controls.Add(this.txtnomeRua);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.lblCidade);
            this.panel3.Controls.Add(this.lblBairro);
            this.panel3.Controls.Add(this.lblRua);
            this.panel3.Location = new System.Drawing.Point(1, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 156);
            this.panel3.TabIndex = 0;
            // 
            // txtnomeEstado
            // 
            this.txtnomeEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnomeEstado.BorderColor = System.Drawing.Color.Black;
            this.txtnomeEstado.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnomeEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeEstado.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtnomeEstado.ColorirTexto = System.Drawing.Color.Black;
            this.txtnomeEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeEstado.ForeColor = System.Drawing.Color.LightGray;
            this.txtnomeEstado.Location = new System.Drawing.Point(86, 114);
            this.txtnomeEstado.MaxLength = 30;
            this.txtnomeEstado.MudaBorda = true;
            this.txtnomeEstado.MudarCor = false;
            this.txtnomeEstado.MudarTitulo = false;
            this.txtnomeEstado.Name = "txtnomeEstado";
            this.txtnomeEstado.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtnomeEstado.Size = new System.Drawing.Size(407, 27);
            this.txtnomeEstado.TabIndex = 87;
            // 
            // txtnomeCidade
            // 
            this.txtnomeCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnomeCidade.BorderColor = System.Drawing.Color.Black;
            this.txtnomeCidade.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnomeCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeCidade.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtnomeCidade.ColorirTexto = System.Drawing.Color.Black;
            this.txtnomeCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeCidade.ForeColor = System.Drawing.Color.LightGray;
            this.txtnomeCidade.Location = new System.Drawing.Point(86, 81);
            this.txtnomeCidade.MaxLength = 30;
            this.txtnomeCidade.MudaBorda = true;
            this.txtnomeCidade.MudarCor = false;
            this.txtnomeCidade.MudarTitulo = false;
            this.txtnomeCidade.Name = "txtnomeCidade";
            this.txtnomeCidade.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtnomeCidade.Size = new System.Drawing.Size(407, 27);
            this.txtnomeCidade.TabIndex = 86;
            // 
            // txtnomeBairro
            // 
            this.txtnomeBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnomeBairro.BorderColor = System.Drawing.Color.Black;
            this.txtnomeBairro.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnomeBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeBairro.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtnomeBairro.ColorirTexto = System.Drawing.Color.Black;
            this.txtnomeBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeBairro.ForeColor = System.Drawing.Color.LightGray;
            this.txtnomeBairro.Location = new System.Drawing.Point(86, 48);
            this.txtnomeBairro.MaxLength = 30;
            this.txtnomeBairro.MudaBorda = true;
            this.txtnomeBairro.MudarCor = false;
            this.txtnomeBairro.MudarTitulo = false;
            this.txtnomeBairro.Name = "txtnomeBairro";
            this.txtnomeBairro.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtnomeBairro.Size = new System.Drawing.Size(407, 27);
            this.txtnomeBairro.TabIndex = 85;
            // 
            // txtnomeRua
            // 
            this.txtnomeRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtnomeRua.BorderColor = System.Drawing.Color.Black;
            this.txtnomeRua.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtnomeRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeRua.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtnomeRua.ColorirTexto = System.Drawing.Color.Black;
            this.txtnomeRua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeRua.ForeColor = System.Drawing.Color.LightGray;
            this.txtnomeRua.Location = new System.Drawing.Point(86, 15);
            this.txtnomeRua.MaxLength = 50;
            this.txtnomeRua.MudaBorda = true;
            this.txtnomeRua.MudarCor = false;
            this.txtnomeRua.MudarTitulo = false;
            this.txtnomeRua.Name = "txtnomeRua";
            this.txtnomeRua.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtnomeRua.Size = new System.Drawing.Size(407, 27);
            this.txtnomeRua.TabIndex = 83;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstado.Location = new System.Drawing.Point(12, 116);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 21);
            this.lblEstado.TabIndex = 50;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.LightGray;
            this.lblCidade.Location = new System.Drawing.Point(7, 83);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(73, 21);
            this.lblCidade.TabIndex = 48;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.LightGray;
            this.lblBairro.Location = new System.Drawing.Point(23, 50);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(57, 21);
            this.lblBairro.TabIndex = 46;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.LightGray;
            this.lblRua.Location = new System.Drawing.Point(35, 17);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(45, 21);
            this.lblRua.TabIndex = 44;
            this.lblRua.Text = "Rua:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(306, 217);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 82);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Tag = "";
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = Resources.Minus;
            this.btnMinimizar.Location = new System.Drawing.Point(657, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
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
            this.btnFechar.Image = Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(693, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblbuscaCep
            // 
            this.lblbuscaCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbuscaCep.AutoSize = true;
            this.lblbuscaCep.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscaCep.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscaCep.ForeColor = System.Drawing.Color.LightGray;
            this.lblbuscaCep.Location = new System.Drawing.Point(215, 3);
            this.lblbuscaCep.Name = "lblbuscaCep";
            this.lblbuscaCep.Size = new System.Drawing.Size(295, 25);
            this.lblbuscaCep.TabIndex = 1;
            this.lblbuscaCep.Text = "SysPark - Pesquisa CEP\r\n";
            this.lblbuscaCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscaEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 347);
            this.Controls.Add(this.pnlbuscaCep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmBuscaEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaEndereco";
            this.Load += new System.EventHandler(this.frmBuscaEndereco_Load);
            this.pnlbuscaCep.ResumeLayout(false);
            this.pnlbuscaCep.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbuscaCep;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblbuscaCep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblcepCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button btnBusca;
        public TextBoxMod.TextBoxMod txtnomeRua;
        public TextBoxMod.TextBoxMod txtnomeBairro;
        public TextBoxMod.TextBoxMod txtnomeCidade;
        public TextBoxMod.TextBoxMod txtnomeEstado;
        public MaskedTextBoxMod.MaskedTextBoxMod msknumCep;
    }
}