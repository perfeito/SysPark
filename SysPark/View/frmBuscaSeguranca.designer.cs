using SysPark.Properties;

namespace SysPark
{
    partial class frmBuscaSeguranca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaSeguranca));
            this.pnlpesquisaSeg = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblnomeUsuario = new System.Windows.Forms.Label();
            this.pcbUsuario = new PictureBoxMod.PictureBoxMod();
            this.txtPesquisa = new TextBoxMod.TextBoxMod();
            this.btnTodos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.pnlSubMensagem = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblpesquisaSeg = new System.Windows.Forms.Label();
            this.pnlpesquisaSeg.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.pnlMensagem.SuspendLayout();
            this.pnlSubMensagem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlpesquisaSeg
            // 
            this.pnlpesquisaSeg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlpesquisaSeg.BackColor = System.Drawing.Color.Black;
            this.pnlpesquisaSeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlpesquisaSeg.Controls.Add(this.panel2);
            this.pnlpesquisaSeg.Controls.Add(this.btnMinimizar);
            this.pnlpesquisaSeg.Controls.Add(this.btnFechar);
            this.pnlpesquisaSeg.Controls.Add(this.lblpesquisaSeg);
            this.pnlpesquisaSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlpesquisaSeg.Location = new System.Drawing.Point(0, 0);
            this.pnlpesquisaSeg.Name = "pnlpesquisaSeg";
            this.pnlpesquisaSeg.Size = new System.Drawing.Size(863, 428);
            this.pnlpesquisaSeg.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.pnlUsuario);
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.btnTodos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblPesquisa);
            this.panel2.Location = new System.Drawing.Point(1, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 395);
            this.panel2.TabIndex = 73;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.lblnomeUsuario);
            this.pnlUsuario.Controls.Add(this.pcbUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(11, 19);
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
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPesquisa.BorderColor = System.Drawing.Color.Black;
            this.txtPesquisa.BorderColorEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.ColorirFundo = System.Drawing.Color.LightGray;
            this.txtPesquisa.ColorirTexto = System.Drawing.Color.Black;
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.LightGray;
            this.txtPesquisa.Location = new System.Drawing.Point(295, 32);
            this.txtPesquisa.MudaBorda = true;
            this.txtPesquisa.MudarCor = false;
            this.txtPesquisa.MudarTitulo = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtPesquisa.Size = new System.Drawing.Size(469, 27);
            this.txtPesquisa.TabIndex = 82;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.LightGray;
            this.btnTodos.Location = new System.Drawing.Point(770, 23);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(76, 36);
            this.btnTodos.TabIndex = 72;
            this.btnTodos.Tag = "";
            this.btnTodos.Text = "Todos";
            this.btnTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(11, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 312);
            this.panel3.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(363, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.dgvPesquisa);
            this.panel5.Controls.Add(this.pnlMensagem);
            this.panel5.Location = new System.Drawing.Point(1, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(833, 287);
            this.panel5.TabIndex = 0;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeColumns = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesquisa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPesquisa.EnableHeadersVisualStyles = false;
            this.dgvPesquisa.GridColor = System.Drawing.Color.Black;
            this.dgvPesquisa.Location = new System.Drawing.Point(0, 0);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(833, 287);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMensagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMensagem.BackgroundImage")));
            this.pnlMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMensagem.Controls.Add(this.pnlSubMensagem);
            this.pnlMensagem.Location = new System.Drawing.Point(246, 53);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(315, 169);
            this.pnlMensagem.TabIndex = 98;
            this.pnlMensagem.Visible = false;
            // 
            // pnlSubMensagem
            // 
            this.pnlSubMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSubMensagem.BackColor = System.Drawing.Color.Black;
            this.pnlSubMensagem.Controls.Add(this.panel1);
            this.pnlSubMensagem.Controls.Add(this.lbltop);
            this.pnlSubMensagem.Controls.Add(this.pictureBox2);
            this.pnlSubMensagem.Location = new System.Drawing.Point(9, 27);
            this.pnlSubMensagem.Name = "pnlSubMensagem";
            this.pnlSubMensagem.Size = new System.Drawing.Size(295, 131);
            this.pnlSubMensagem.TabIndex = 96;
            this.pnlSubMensagem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados não encontrados. Faça a pesquisa novamente.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.BackColor = System.Drawing.Color.Black;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.IndianRed;
            this.lbltop.Location = new System.Drawing.Point(36, 4);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(228, 24);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "SysPark - Atenção";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.Color.LightGray;
            this.lblPesquisa.Location = new System.Drawing.Point(209, 34);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(80, 21);
            this.lblPesquisa.TabIndex = 71;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = Resources.Minus;
            this.btnMinimizar.Location = new System.Drawing.Point(795, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 69;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(831, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblpesquisaSeg
            // 
            this.lblpesquisaSeg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpesquisaSeg.AutoSize = true;
            this.lblpesquisaSeg.BackColor = System.Drawing.Color.Transparent;
            this.lblpesquisaSeg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisaSeg.ForeColor = System.Drawing.Color.LightGray;
            this.lblpesquisaSeg.Location = new System.Drawing.Point(185, 4);
            this.lblpesquisaSeg.Name = "lblpesquisaSeg";
            this.lblpesquisaSeg.Size = new System.Drawing.Size(493, 25);
            this.lblpesquisaSeg.TabIndex = 1;
            this.lblpesquisaSeg.Text = "SysPark - Pesquisa Funcionário Segurança";
            this.lblpesquisaSeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscaSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 428);
            this.Controls.Add(this.pnlpesquisaSeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscaSeguranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaSeguranca";
            this.Load += new System.EventHandler(this.frmBuscaSeguranca_Load);
            this.pnlpesquisaSeg.ResumeLayout(false);
            this.pnlpesquisaSeg.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.pnlMensagem.ResumeLayout(false);
            this.pnlSubMensagem.ResumeLayout(false);
            this.pnlSubMensagem.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpesquisaSeg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Panel pnlMensagem;
        private System.Windows.Forms.Panel pnlSubMensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblpesquisaSeg;
        public TextBoxMod.TextBoxMod txtPesquisa;
        private System.Windows.Forms.Panel pnlUsuario;
        public System.Windows.Forms.Label lblnomeUsuario;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
    }
}