using SysPark.Properties;

namespace SysPark
{
    partial class frmBuscaCargo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlpesquisaCargo = new System.Windows.Forms.Panel();
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
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblpesquisaCargo = new System.Windows.Forms.Label();
            this.pnlpesquisaCargo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlpesquisaCargo
            // 
            this.pnlpesquisaCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlpesquisaCargo.BackColor = System.Drawing.Color.Black;
            this.pnlpesquisaCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlpesquisaCargo.Controls.Add(this.panel2);
            this.pnlpesquisaCargo.Controls.Add(this.btnMinimizar);
            this.pnlpesquisaCargo.Controls.Add(this.btnFechar);
            this.pnlpesquisaCargo.Controls.Add(this.lblpesquisaCargo);
            this.pnlpesquisaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlpesquisaCargo.Location = new System.Drawing.Point(0, 0);
            this.pnlpesquisaCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlpesquisaCargo.Name = "pnlpesquisaCargo";
            this.pnlpesquisaCargo.Size = new System.Drawing.Size(1146, 511);
            this.pnlpesquisaCargo.TabIndex = 5;
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
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 471);
            this.panel2.TabIndex = 73;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsuario.Controls.Add(this.lblnomeUsuario);
            this.pnlUsuario.Controls.Add(this.pcbUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(19, 17);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(187, 49);
            this.pnlUsuario.TabIndex = 142;
            // 
            // lblnomeUsuario
            // 
            this.lblnomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblnomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblnomeUsuario.Location = new System.Drawing.Point(55, 0);
            this.lblnomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnomeUsuario.Name = "lblnomeUsuario";
            this.lblnomeUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblnomeUsuario.Size = new System.Drawing.Size(133, 49);
            this.lblnomeUsuario.TabIndex = 63;
            this.lblnomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BackColor = System.Drawing.Color.Black;
            this.pcbUsuario.Location = new System.Drawing.Point(0, 0);
            this.pcbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(53, 49);
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
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.LightGray;
            this.txtPesquisa.Location = new System.Drawing.Point(396, 33);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.MudaBorda = true;
            this.txtPesquisa.MudarCor = false;
            this.txtPesquisa.MudarTitulo = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.NovaBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtPesquisa.Size = new System.Drawing.Size(625, 30);
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
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.LightGray;
            this.btnTodos.Location = new System.Drawing.Point(1029, 26);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(101, 44);
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
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(17, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 384);
            this.panel3.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(484, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
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
            this.panel5.Location = new System.Drawing.Point(1, 30);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1111, 353);
            this.panel5.TabIndex = 0;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToResizeColumns = false;
            this.dgvPesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPesquisa.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPesquisa.EnableHeadersVisualStyles = false;
            this.dgvPesquisa.GridColor = System.Drawing.Color.Black;
            this.dgvPesquisa.Location = new System.Drawing.Point(0, 0);
            this.dgvPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(1111, 353);
            this.dgvPesquisa.TabIndex = 0;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.Color.LightGray;
            this.lblPesquisa.Location = new System.Drawing.Point(281, 36);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(99, 25);
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
            this.btnMinimizar.Image = global::SysPark.Properties.Resources.Minus;
            this.btnMinimizar.Location = new System.Drawing.Point(1055, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 69;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
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
            this.btnFechar.Image = global::SysPark.Properties.Resources.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(1103, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 37);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lblpesquisaCargo
            // 
            this.lblpesquisaCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpesquisaCargo.AutoSize = true;
            this.lblpesquisaCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblpesquisaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisaCargo.ForeColor = System.Drawing.Color.LightGray;
            this.lblpesquisaCargo.Location = new System.Drawing.Point(359, 5);
            this.lblpesquisaCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpesquisaCargo.Name = "lblpesquisaCargo";
            this.lblpesquisaCargo.Size = new System.Drawing.Size(356, 31);
            this.lblpesquisaCargo.TabIndex = 1;
            this.lblpesquisaCargo.Text = "SysPark - Pesquisa Cargo";
            this.lblpesquisaCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1143, 509);
            this.Controls.Add(this.pnlpesquisaCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBuscaCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaCargo";
            this.Load += new System.EventHandler(this.frmBuscaCargo_Load);
            this.pnlpesquisaCargo.ResumeLayout(false);
            this.pnlpesquisaCargo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpesquisaCargo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblpesquisaCargo;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private TextBoxMod.TextBoxMod txtPesquisa;
        private System.Windows.Forms.Panel pnlUsuario;
        public System.Windows.Forms.Label lblnomeUsuario;
        private PictureBoxMod.PictureBoxMod pcbUsuario;
    }
}