using SysPark.Properties;

namespace SysPark
{
    partial class frmTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.pcbUsuario = new PictureBoxMod.PictureBoxMod();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPegaMac = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvarTerminal = new System.Windows.Forms.Button();
            this.btnCancelarTerminal = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvTerminal = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTerminal = new TextBoxMod.TextBoxMod();
            this.txtMAC = new TextBoxMod.TextBoxMod();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblformTerminal = new System.Windows.Forms.Label();
            this.toolTipMod1 = new ToolTipMod.ToolTipMod();
            this.pnlTerminal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminal)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTerminal.BackColor = System.Drawing.Color.Black;
            this.pnlTerminal.Controls.Add(this.panel1);
            this.pnlTerminal.Controls.Add(this.btnFechar);
            this.pnlTerminal.Controls.Add(this.lblformTerminal);
            this.pnlTerminal.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTerminal.Location = new System.Drawing.Point(0, 0);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(516, 495);
            this.pnlTerminal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 462);
            this.panel1.TabIndex = 96;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(45, 462);
            this.pnlMenu.TabIndex = 140;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(10, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 1);
            this.panel2.TabIndex = 129;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(10, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 129;
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnPegaMac);
            this.flowLayoutPanel1.Controls.Add(this.btnEditar);
            this.flowLayoutPanel1.Controls.Add(this.btnSalvarTerminal);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarTerminal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 376);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPegaMac
            // 
            this.btnPegaMac.BackColor = System.Drawing.Color.Transparent;
            this.btnPegaMac.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPegaMac.FlatAppearance.BorderSize = 0;
            this.btnPegaMac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPegaMac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPegaMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegaMac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegaMac.ForeColor = System.Drawing.Color.LightGray;
            this.btnPegaMac.Image = ((System.Drawing.Image)(resources.GetObject("btnPegaMac.Image")));
            this.btnPegaMac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPegaMac.Location = new System.Drawing.Point(3, 3);
            this.btnPegaMac.Name = "btnPegaMac";
            this.btnPegaMac.Size = new System.Drawing.Size(140, 40);
            this.btnPegaMac.TabIndex = 90;
            this.btnPegaMac.Tag = "";
            this.btnPegaMac.Text = "Pega Mac";
            this.btnPegaMac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPegaMac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnPegaMac, "Pega Mac");
            this.btnPegaMac.UseVisualStyleBackColor = false;
            this.btnPegaMac.Click += new System.EventHandler(this.btnPegaMac_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
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
            this.btnEditar.TabIndex = 92;
            this.btnEditar.Tag = "";
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvarTerminal
            // 
            this.btnSalvarTerminal.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarTerminal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarTerminal.FlatAppearance.BorderSize = 0;
            this.btnSalvarTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSalvarTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalvarTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalvarTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarTerminal.Image")));
            this.btnSalvarTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarTerminal.Location = new System.Drawing.Point(3, 95);
            this.btnSalvarTerminal.Name = "btnSalvarTerminal";
            this.btnSalvarTerminal.Size = new System.Drawing.Size(140, 40);
            this.btnSalvarTerminal.TabIndex = 89;
            this.btnSalvarTerminal.Tag = "";
            this.btnSalvarTerminal.Text = "Salvar";
            this.btnSalvarTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarTerminal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnSalvarTerminal, "Salvar");
            this.btnSalvarTerminal.UseVisualStyleBackColor = false;
            this.btnSalvarTerminal.Click += new System.EventHandler(this.btnSalvarTerminal_Click);
            // 
            // btnCancelarTerminal
            // 
            this.btnCancelarTerminal.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarTerminal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarTerminal.FlatAppearance.BorderSize = 0;
            this.btnCancelarTerminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelarTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelarTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelarTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarTerminal.Image")));
            this.btnCancelarTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarTerminal.Location = new System.Drawing.Point(3, 141);
            this.btnCancelarTerminal.Name = "btnCancelarTerminal";
            this.btnCancelarTerminal.Size = new System.Drawing.Size(140, 40);
            this.btnCancelarTerminal.TabIndex = 91;
            this.btnCancelarTerminal.Tag = "";
            this.btnCancelarTerminal.Text = "Cancelar";
            this.btnCancelarTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarTerminal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMod1.SetToolTip(this.btnCancelarTerminal, "Cancelar");
            this.btnCancelarTerminal.UseVisualStyleBackColor = false;
            this.btnCancelarTerminal.Click += new System.EventHandler(this.btnCancelarTerminal_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(61, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(437, 285);
            this.panel7.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(173, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Terminais";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Controls.Add(this.dgvTerminal);
            this.panel8.Location = new System.Drawing.Point(1, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(435, 260);
            this.panel8.TabIndex = 0;
            // 
            // dgvTerminal
            // 
            this.dgvTerminal.AllowUserToAddRows = false;
            this.dgvTerminal.AllowUserToDeleteRows = false;
            this.dgvTerminal.AllowUserToResizeColumns = false;
            this.dgvTerminal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTerminal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTerminal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTerminal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTerminal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerminal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerminal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTerminal.EnableHeadersVisualStyles = false;
            this.dgvTerminal.GridColor = System.Drawing.Color.Black;
            this.dgvTerminal.Location = new System.Drawing.Point(0, 0);
            this.dgvTerminal.Name = "dgvTerminal";
            this.dgvTerminal.ReadOnly = true;
            this.dgvTerminal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerminal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTerminal.RowHeadersVisible = false;
            this.dgvTerminal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerminal.Size = new System.Drawing.Size(435, 260);
            this.dgvTerminal.TabIndex = 0;
            this.dgvTerminal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTerminal_CellDoubleClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(60, 307);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 140);
            this.panel5.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(184, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.txtTerminal);
            this.panel6.Controls.Add(this.txtMAC);
            this.panel6.Controls.Add(this.rbInativo);
            this.panel6.Controls.Add(this.rbAtivo);
            this.panel6.Controls.Add(this.lblTerminal);
            this.panel6.Controls.Add(this.lblSituacao);
            this.panel6.Controls.Add(this.lblMAC);
            this.panel6.Location = new System.Drawing.Point(1, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(436, 115);
            this.panel6.TabIndex = 0;
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
            this.txtTerminal.Location = new System.Drawing.Point(120, 44);
            this.txtTerminal.MaxLength = 30;
            this.txtTerminal.MudaBorda = true;
            this.txtTerminal.MudarCor = false;
            this.txtTerminal.MudarTitulo = false;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtTerminal.Size = new System.Drawing.Size(280, 27);
            this.txtTerminal.TabIndex = 96;
            // 
            // txtMAC
            // 
            this.txtMAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMAC.BorderColor = System.Drawing.Color.Black;
            this.txtMAC.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMAC.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtMAC.ColorirTexto = System.Drawing.Color.Black;
            this.txtMAC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.ForeColor = System.Drawing.Color.LightGray;
            this.txtMAC.Location = new System.Drawing.Point(120, 11);
            this.txtMAC.MaxLength = 1000;
            this.txtMAC.MudaBorda = true;
            this.txtMAC.MudarCor = false;
            this.txtMAC.MudarTitulo = false;
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtMAC.Size = new System.Drawing.Size(280, 27);
            this.txtMAC.TabIndex = 85;
            // 
            // rbInativo
            // 
            this.rbInativo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rbInativo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbInativo.FlatAppearance.BorderSize = 0;
            this.rbInativo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbInativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbInativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInativo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.ForeColor = System.Drawing.Color.LightGray;
            this.rbInativo.Location = new System.Drawing.Point(230, 77);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(75, 30);
            this.rbInativo.TabIndex = 95;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInativo.UseVisualStyleBackColor = false;
            // 
            // rbAtivo
            // 
            this.rbAtivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.rbAtivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAtivo.FlatAppearance.BorderSize = 0;
            this.rbAtivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbAtivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rbAtivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rbAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAtivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.ForeColor = System.Drawing.Color.LightGray;
            this.rbAtivo.Location = new System.Drawing.Point(120, 77);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(75, 30);
            this.rbAtivo.TabIndex = 94;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAtivo.UseVisualStyleBackColor = false;
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTerminal.Location = new System.Drawing.Point(35, 46);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(79, 21);
            this.lblTerminal.TabIndex = 86;
            this.lblTerminal.Text = "Terminal:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.LightGray;
            this.lblSituacao.Location = new System.Drawing.Point(30, 79);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(84, 21);
            this.lblSituacao.TabIndex = 93;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.ForeColor = System.Drawing.Color.LightGray;
            this.lblMAC.Location = new System.Drawing.Point(59, 13);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(55, 21);
            this.lblMAC.TabIndex = 88;
            this.lblMAC.Text = "MAC:";
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
            this.btnFechar.Image = Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(484, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 93;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lblformTerminal
            // 
            this.lblformTerminal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblformTerminal.AutoSize = true;
            this.lblformTerminal.BackColor = System.Drawing.Color.Transparent;
            this.lblformTerminal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformTerminal.ForeColor = System.Drawing.Color.LightGray;
            this.lblformTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblformTerminal.Location = new System.Drawing.Point(135, 4);
            this.lblformTerminal.Name = "lblformTerminal";
            this.lblformTerminal.Size = new System.Drawing.Size(247, 25);
            this.lblformTerminal.TabIndex = 92;
            this.lblformTerminal.Text = "SysPark - Terminal";
            this.lblformTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(516, 495);
            this.Controls.Add(this.pnlTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTerminal";
            this.Load += new System.EventHandler(this.frmTerminal_Load);
            this.pnlTerminal.ResumeLayout(false);
            this.pnlTerminal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminal)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTerminal;
        public System.Windows.Forms.Button btnCancelarTerminal;
        public System.Windows.Forms.Button btnPegaMac;
        private System.Windows.Forms.DataGridView dgvTerminal;
        public System.Windows.Forms.Button btnSalvarTerminal;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblformTerminal;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.RadioButton rbInativo;
        public System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        public TextBoxMod.TextBoxMod txtTerminal;
        public TextBoxMod.TextBoxMod txtMAC;
        private ToolTipMod.ToolTipMod toolTipMod1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUsuario;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
        public System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblnomeUsuario;
    }
}