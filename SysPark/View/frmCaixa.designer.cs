namespace SysPark.View
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.pnlCaixa = new System.Windows.Forms.Panel();
            this.pnlCaixa2 = new System.Windows.Forms.Panel();
            this.pnlMinCortesia = new System.Windows.Forms.Panel();
            this.txtMInCortesia = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHorarioEntrada = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesqisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlDescomto = new System.Windows.Forms.Panel();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.pnlDesconto2 = new System.Windows.Forms.Panel();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.pnltotalItem = new System.Windows.Forms.Panel();
            this.txtHorarioAtual = new System.Windows.Forms.TextBox();
            this.pnltotalItem2 = new System.Windows.Forms.Panel();
            this.lbltotalItem = new System.Windows.Forms.Label();
            this.pnlsubTotal = new System.Windows.Forms.Panel();
            this.txtsubTotal = new System.Windows.Forms.TextBox();
            this.pnlsubTotal2 = new System.Windows.Forms.Panel();
            this.lblsubTotal = new System.Windows.Forms.Label();
            this.pnlDescricao = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnlDescricao2 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pnlvalorUnitario = new System.Windows.Forms.Panel();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.pnlvalorUnitario2 = new System.Windows.Forms.Panel();
            this.lblvalorUnitario = new System.Windows.Forms.Label();
            this.pnlQuantidade = new System.Windows.Forms.Panel();
            this.pnlQuantiade2 = new System.Windows.Forms.Panel();
            this.cmbTipoVeiculo = new ComboBoxMod.ComboBoxMod();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.pnlCodigo2 = new System.Windows.Forms.Panel();
            this.lblcodBarras = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pnlTotal2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCaixa.SuspendLayout();
            this.pnlCaixa2.SuspendLayout();
            this.pnlMinCortesia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDescomto.SuspendLayout();
            this.pnltotalItem.SuspendLayout();
            this.pnlsubTotal.SuspendLayout();
            this.pnlDescricao.SuspendLayout();
            this.pnlvalorUnitario.SuspendLayout();
            this.pnlQuantidade.SuspendLayout();
            this.pnlQuantiade2.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaixa
            // 
            this.pnlCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCaixa.BackColor = System.Drawing.Color.Black;
            this.pnlCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCaixa.Controls.Add(this.pnlCaixa2);
            this.pnlCaixa.Controls.Add(this.lblCaixa);
            this.pnlCaixa.Controls.Add(this.btnMinimizar);
            this.pnlCaixa.Controls.Add(this.btnFechar);
            this.pnlCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCaixa.Location = new System.Drawing.Point(0, 0);
            this.pnlCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCaixa.Name = "pnlCaixa";
            this.pnlCaixa.Size = new System.Drawing.Size(903, 585);
            this.pnlCaixa.TabIndex = 2;
            // 
            // pnlCaixa2
            // 
            this.pnlCaixa2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCaixa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCaixa2.Controls.Add(this.pnlMinCortesia);
            this.pnlCaixa2.Controls.Add(this.panel1);
            this.pnlCaixa2.Controls.Add(this.btnPesqisar);
            this.pnlCaixa2.Controls.Add(this.btnVoltar);
            this.pnlCaixa2.Controls.Add(this.pnlDescomto);
            this.pnlCaixa2.Controls.Add(this.pnltotalItem);
            this.pnlCaixa2.Controls.Add(this.pnlsubTotal);
            this.pnlCaixa2.Controls.Add(this.pnlDescricao);
            this.pnlCaixa2.Controls.Add(this.pnlvalorUnitario);
            this.pnlCaixa2.Controls.Add(this.pnlQuantidade);
            this.pnlCaixa2.Controls.Add(this.pnlCodigo);
            this.pnlCaixa2.Controls.Add(this.pnlTotal);
            this.pnlCaixa2.Location = new System.Drawing.Point(4, 36);
            this.pnlCaixa2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCaixa2.Name = "pnlCaixa2";
            this.pnlCaixa2.Size = new System.Drawing.Size(895, 545);
            this.pnlCaixa2.TabIndex = 77;
            // 
            // pnlMinCortesia
            // 
            this.pnlMinCortesia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMinCortesia.BackColor = System.Drawing.Color.Black;
            this.pnlMinCortesia.Controls.Add(this.txtMInCortesia);
            this.pnlMinCortesia.Controls.Add(this.panel4);
            this.pnlMinCortesia.Controls.Add(this.label2);
            this.pnlMinCortesia.Location = new System.Drawing.Point(318, 231);
            this.pnlMinCortesia.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMinCortesia.Name = "pnlMinCortesia";
            this.pnlMinCortesia.Size = new System.Drawing.Size(242, 90);
            this.pnlMinCortesia.TabIndex = 139;
            // 
            // txtMInCortesia
            // 
            this.txtMInCortesia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMInCortesia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMInCortesia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMInCortesia.Enabled = false;
            this.txtMInCortesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtMInCortesia.ForeColor = System.Drawing.Color.LightGray;
            this.txtMInCortesia.Location = new System.Drawing.Point(-16, 30);
            this.txtMInCortesia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMInCortesia.MaxLength = 30;
            this.txtMInCortesia.Name = "txtMInCortesia";
            this.txtMInCortesia.ReadOnly = true;
            this.txtMInCortesia.Size = new System.Drawing.Size(257, 54);
            this.txtMInCortesia.TabIndex = 83;
            this.txtMInCortesia.Tag = "V";
            this.txtMInCortesia.Text = "0";
            this.txtMInCortesia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 37);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(39, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 84;
            this.label2.Text = "Min. Cortesia";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtHorarioEntrada);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 90);
            this.panel1.TabIndex = 83;
            // 
            // txtHorarioEntrada
            // 
            this.txtHorarioEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorarioEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtHorarioEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorarioEntrada.Enabled = false;
            this.txtHorarioEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtHorarioEntrada.ForeColor = System.Drawing.Color.LightGray;
            this.txtHorarioEntrada.Location = new System.Drawing.Point(-17, 30);
            this.txtHorarioEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorarioEntrada.MaxLength = 30;
            this.txtHorarioEntrada.Name = "txtHorarioEntrada";
            this.txtHorarioEntrada.ReadOnly = true;
            this.txtHorarioEntrada.Size = new System.Drawing.Size(257, 54);
            this.txtHorarioEntrada.TabIndex = 78;
            this.txtHorarioEntrada.Tag = "V";
            this.txtHorarioEntrada.Text = "00:00";
            this.txtHorarioEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 37);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(43, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Hora Entrada";
            // 
            // btnPesqisar
            // 
            this.btnPesqisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesqisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPesqisar.Enabled = false;
            this.btnPesqisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPesqisar.FlatAppearance.BorderSize = 0;
            this.btnPesqisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPesqisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPesqisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqisar.ForeColor = System.Drawing.Color.LightGray;
            this.btnPesqisar.Location = new System.Drawing.Point(710, 233);
            this.btnPesqisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesqisar.Name = "btnPesqisar";
            this.btnPesqisar.Size = new System.Drawing.Size(160, 92);
            this.btnPesqisar.TabIndex = 134;
            this.btnPesqisar.Text = "Pesquisar";
            this.btnPesqisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesqisar.UseVisualStyleBackColor = false;
            this.btnPesqisar.Click += new System.EventHandler(this.btnPesqisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.LightGray;
            this.btnVoltar.Location = new System.Drawing.Point(710, 339);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(160, 92);
            this.btnVoltar.TabIndex = 128;
            this.btnVoltar.Text = "Voltar\r\n(ESC)";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pnlDescomto
            // 
            this.pnlDescomto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDescomto.BackColor = System.Drawing.Color.Black;
            this.pnlDescomto.Controls.Add(this.txtDesconto);
            this.pnlDescomto.Controls.Add(this.pnlDesconto2);
            this.pnlDescomto.Controls.Add(this.lblDesconto);
            this.pnlDescomto.Location = new System.Drawing.Point(319, 444);
            this.pnlDescomto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDescomto.Name = "pnlDescomto";
            this.pnlDescomto.Size = new System.Drawing.Size(241, 90);
            this.pnlDescomto.TabIndex = 86;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtDesconto.ForeColor = System.Drawing.Color.LightGray;
            this.txtDesconto.Location = new System.Drawing.Point(-18, 30);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.MaxLength = 30;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(257, 54);
            this.txtDesconto.TabIndex = 80;
            this.txtDesconto.Tag = "V";
            this.txtDesconto.Text = "0.00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // pnlDesconto2
            // 
            this.pnlDesconto2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesconto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlDesconto2.Location = new System.Drawing.Point(0, 30);
            this.pnlDesconto2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDesconto2.Name = "pnlDesconto2";
            this.pnlDesconto2.Size = new System.Drawing.Size(241, 37);
            this.pnlDesconto2.TabIndex = 0;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.LightGray;
            this.lblDesconto.Location = new System.Drawing.Point(56, 1);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(123, 29);
            this.lblDesconto.TabIndex = 81;
            this.lblDesconto.Text = "Desconto";
            // 
            // pnltotalItem
            // 
            this.pnltotalItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnltotalItem.BackColor = System.Drawing.Color.Black;
            this.pnltotalItem.Controls.Add(this.txtHorarioAtual);
            this.pnltotalItem.Controls.Add(this.pnltotalItem2);
            this.pnltotalItem.Controls.Add(this.lbltotalItem);
            this.pnltotalItem.Location = new System.Drawing.Point(602, 22);
            this.pnltotalItem.Margin = new System.Windows.Forms.Padding(4);
            this.pnltotalItem.Name = "pnltotalItem";
            this.pnltotalItem.Size = new System.Drawing.Size(263, 90);
            this.pnltotalItem.TabIndex = 84;
            // 
            // txtHorarioAtual
            // 
            this.txtHorarioAtual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHorarioAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtHorarioAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorarioAtual.Enabled = false;
            this.txtHorarioAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtHorarioAtual.ForeColor = System.Drawing.Color.LightGray;
            this.txtHorarioAtual.Location = new System.Drawing.Point(3, 30);
            this.txtHorarioAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorarioAtual.MaxLength = 30;
            this.txtHorarioAtual.Name = "txtHorarioAtual";
            this.txtHorarioAtual.ReadOnly = true;
            this.txtHorarioAtual.Size = new System.Drawing.Size(257, 54);
            this.txtHorarioAtual.TabIndex = 78;
            this.txtHorarioAtual.Tag = "V";
            this.txtHorarioAtual.Text = "00:00 PM";
            this.txtHorarioAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHorarioAtual.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtHorarioAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtHorarioAtual.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // pnltotalItem2
            // 
            this.pnltotalItem2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnltotalItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnltotalItem2.Location = new System.Drawing.Point(0, 30);
            this.pnltotalItem2.Margin = new System.Windows.Forms.Padding(4);
            this.pnltotalItem2.Name = "pnltotalItem2";
            this.pnltotalItem2.Size = new System.Drawing.Size(263, 37);
            this.pnltotalItem2.TabIndex = 0;
            // 
            // lbltotalItem
            // 
            this.lbltotalItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltotalItem.AutoSize = true;
            this.lbltotalItem.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalItem.ForeColor = System.Drawing.Color.LightGray;
            this.lbltotalItem.Location = new System.Drawing.Point(64, 1);
            this.lbltotalItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalItem.Name = "lbltotalItem";
            this.lbltotalItem.Size = new System.Drawing.Size(134, 29);
            this.lbltotalItem.TabIndex = 79;
            this.lbltotalItem.Text = "Hora Atual";
            // 
            // pnlsubTotal
            // 
            this.pnlsubTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlsubTotal.BackColor = System.Drawing.Color.Black;
            this.pnlsubTotal.Controls.Add(this.txtsubTotal);
            this.pnlsubTotal.Controls.Add(this.pnlsubTotal2);
            this.pnlsubTotal.Controls.Add(this.lblsubTotal);
            this.pnlsubTotal.Location = new System.Drawing.Point(40, 444);
            this.pnlsubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlsubTotal.Name = "pnlsubTotal";
            this.pnlsubTotal.Size = new System.Drawing.Size(239, 90);
            this.pnlsubTotal.TabIndex = 85;
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtsubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsubTotal.Enabled = false;
            this.txtsubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtsubTotal.ForeColor = System.Drawing.Color.LightGray;
            this.txtsubTotal.Location = new System.Drawing.Point(-20, 30);
            this.txtsubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubTotal.MaxLength = 30;
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.ReadOnly = true;
            this.txtsubTotal.Size = new System.Drawing.Size(257, 54);
            this.txtsubTotal.TabIndex = 83;
            this.txtsubTotal.Tag = "V";
            this.txtsubTotal.Text = "0.00";
            this.txtsubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubTotal.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtsubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtsubTotal.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // pnlsubTotal2
            // 
            this.pnlsubTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsubTotal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlsubTotal2.Location = new System.Drawing.Point(0, 30);
            this.pnlsubTotal2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlsubTotal2.Name = "pnlsubTotal2";
            this.pnlsubTotal2.Size = new System.Drawing.Size(239, 37);
            this.pnlsubTotal2.TabIndex = 0;
            // 
            // lblsubTotal
            // 
            this.lblsubTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblsubTotal.AutoSize = true;
            this.lblsubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblsubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblsubTotal.Location = new System.Drawing.Point(60, 1);
            this.lblsubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubTotal.Name = "lblsubTotal";
            this.lblsubTotal.Size = new System.Drawing.Size(119, 29);
            this.lblsubTotal.TabIndex = 84;
            this.lblsubTotal.Text = "SubTotal";
            // 
            // pnlDescricao
            // 
            this.pnlDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDescricao.BackColor = System.Drawing.Color.Black;
            this.pnlDescricao.Controls.Add(this.txtDescricao);
            this.pnlDescricao.Controls.Add(this.pnlDescricao2);
            this.pnlDescricao.Controls.Add(this.lblDescricao);
            this.pnlDescricao.Location = new System.Drawing.Point(33, 123);
            this.pnlDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDescricao.Name = "pnlDescricao";
            this.pnlDescricao.Size = new System.Drawing.Size(832, 90);
            this.pnlDescricao.TabIndex = 81;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtDescricao.ForeColor = System.Drawing.Color.LightGray;
            this.txtDescricao.Location = new System.Drawing.Point(3, 30);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(826, 54);
            this.txtDescricao.TabIndex = 76;
            // 
            // pnlDescricao2
            // 
            this.pnlDescricao2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescricao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlDescricao2.Location = new System.Drawing.Point(0, 30);
            this.pnlDescricao2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDescricao2.Name = "pnlDescricao2";
            this.pnlDescricao2.Size = new System.Drawing.Size(832, 37);
            this.pnlDescricao2.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescricao.Location = new System.Drawing.Point(348, 1);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(130, 29);
            this.lblDescricao.TabIndex = 77;
            this.lblDescricao.Text = "Descrição";
            // 
            // pnlvalorUnitario
            // 
            this.pnlvalorUnitario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlvalorUnitario.BackColor = System.Drawing.Color.Black;
            this.pnlvalorUnitario.Controls.Add(this.txtValorHora);
            this.pnlvalorUnitario.Controls.Add(this.pnlvalorUnitario2);
            this.pnlvalorUnitario.Controls.Add(this.lblvalorUnitario);
            this.pnlvalorUnitario.Location = new System.Drawing.Point(33, 231);
            this.pnlvalorUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlvalorUnitario.Name = "pnlvalorUnitario";
            this.pnlvalorUnitario.Size = new System.Drawing.Size(246, 90);
            this.pnlvalorUnitario.TabIndex = 82;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtValorHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorHora.Enabled = false;
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtValorHora.ForeColor = System.Drawing.Color.LightGray;
            this.txtValorHora.Location = new System.Drawing.Point(-12, 30);
            this.txtValorHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorHora.MaxLength = 30;
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.ReadOnly = true;
            this.txtValorHora.Size = new System.Drawing.Size(257, 54);
            this.txtValorHora.TabIndex = 78;
            this.txtValorHora.Tag = "V";
            this.txtValorHora.Text = "0.00";
            this.txtValorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorHora.TextChanged += new System.EventHandler(this.txtCalculo_textChanged);
            this.txtValorHora.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValorHora.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // pnlvalorUnitario2
            // 
            this.pnlvalorUnitario2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlvalorUnitario2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlvalorUnitario2.Location = new System.Drawing.Point(0, 30);
            this.pnlvalorUnitario2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlvalorUnitario2.Name = "pnlvalorUnitario2";
            this.pnlvalorUnitario2.Size = new System.Drawing.Size(246, 37);
            this.pnlvalorUnitario2.TabIndex = 0;
            // 
            // lblvalorUnitario
            // 
            this.lblvalorUnitario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblvalorUnitario.AutoSize = true;
            this.lblvalorUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblvalorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorUnitario.ForeColor = System.Drawing.Color.LightGray;
            this.lblvalorUnitario.Location = new System.Drawing.Point(61, 1);
            this.lblvalorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalorUnitario.Name = "lblvalorUnitario";
            this.lblvalorUnitario.Size = new System.Drawing.Size(137, 29);
            this.lblvalorUnitario.TabIndex = 79;
            this.lblvalorUnitario.Text = "Valor Hora";
            // 
            // pnlQuantidade
            // 
            this.pnlQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlQuantidade.BackColor = System.Drawing.Color.Black;
            this.pnlQuantidade.Controls.Add(this.pnlQuantiade2);
            this.pnlQuantidade.Controls.Add(this.lblQuantidade);
            this.pnlQuantidade.Location = new System.Drawing.Point(331, 23);
            this.pnlQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuantidade.Name = "pnlQuantidade";
            this.pnlQuantidade.Size = new System.Drawing.Size(253, 90);
            this.pnlQuantidade.TabIndex = 83;
            // 
            // pnlQuantiade2
            // 
            this.pnlQuantiade2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuantiade2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlQuantiade2.Controls.Add(this.cmbTipoVeiculo);
            this.pnlQuantiade2.Location = new System.Drawing.Point(0, 30);
            this.pnlQuantiade2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuantiade2.Name = "pnlQuantiade2";
            this.pnlQuantiade2.Size = new System.Drawing.Size(253, 56);
            this.pnlQuantiade2.TabIndex = 0;
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.ArrowColor = System.Drawing.Color.LightGray;
            this.cmbTipoVeiculo.ArrowColorDown = System.Drawing.Color.Red;
            this.cmbTipoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbTipoVeiculo.BorderColor = System.Drawing.Color.Black;
            this.cmbTipoVeiculo.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbTipoVeiculo.ButtonColor = System.Drawing.Color.Black;
            this.cmbTipoVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeiculo.EnabledBorderColor = System.Drawing.Color.Black;
            this.cmbTipoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F);
            this.cmbTipoVeiculo.ForeColor = System.Drawing.Color.LightGray;
            this.cmbTipoVeiculo.ForecolorSelect = System.Drawing.Color.Black;
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(4, 3);
            this.cmbTipoVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.SelectColor = System.Drawing.Color.LightGray;
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(245, 51);
            this.cmbTipoVeiculo.TabIndex = 100;
            this.cmbTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVeiculo_SelectedIndexChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.LightGray;
            this.lblQuantidade.Location = new System.Drawing.Point(31, 1);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(198, 29);
            this.lblQuantidade.TabIndex = 75;
            this.lblQuantidade.Text = "Tipo de Veículo";
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCodigo.BackColor = System.Drawing.Color.Black;
            this.pnlCodigo.Controls.Add(this.txtPlaca);
            this.pnlCodigo.Controls.Add(this.pnlCodigo2);
            this.pnlCodigo.Controls.Add(this.lblcodBarras);
            this.pnlCodigo.Location = new System.Drawing.Point(33, 22);
            this.pnlCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(290, 90);
            this.pnlCodigo.TabIndex = 79;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtPlaca.ForeColor = System.Drawing.Color.LightGray;
            this.txtPlaca.Location = new System.Drawing.Point(3, 30);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.MaxLength = 13;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(285, 54);
            this.txtPlaca.TabIndex = 74;
            this.txtPlaca.Tag = "C";
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidaNumero_KeyPress);
            this.txtPlaca.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // pnlCodigo2
            // 
            this.pnlCodigo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCodigo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCodigo2.Location = new System.Drawing.Point(0, 30);
            this.pnlCodigo2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCodigo2.Name = "pnlCodigo2";
            this.pnlCodigo2.Size = new System.Drawing.Size(290, 37);
            this.pnlCodigo2.TabIndex = 0;
            // 
            // lblcodBarras
            // 
            this.lblcodBarras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcodBarras.AutoSize = true;
            this.lblcodBarras.BackColor = System.Drawing.Color.Transparent;
            this.lblcodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodBarras.ForeColor = System.Drawing.Color.LightGray;
            this.lblcodBarras.Location = new System.Drawing.Point(101, 2);
            this.lblcodBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodBarras.Name = "lblcodBarras";
            this.lblcodBarras.Size = new System.Drawing.Size(78, 29);
            this.lblcodBarras.TabIndex = 75;
            this.lblcodBarras.Text = "Placa";
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTotal.BackColor = System.Drawing.Color.IndianRed;
            this.pnlTotal.Controls.Add(this.txtTotal);
            this.pnlTotal.Controls.Add(this.pnlTotal2);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Location = new System.Drawing.Point(607, 444);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(263, 90);
            this.pnlTotal.TabIndex = 87;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.5F);
            this.txtTotal.ForeColor = System.Drawing.Color.LightGray;
            this.txtTotal.Location = new System.Drawing.Point(3, 30);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.MaxLength = 30;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(257, 54);
            this.txtTotal.TabIndex = 85;
            this.txtTotal.Tag = "V";
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtTotal.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // pnlTotal2
            // 
            this.pnlTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlTotal2.Location = new System.Drawing.Point(0, 30);
            this.pnlTotal2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotal2.Name = "pnlTotal2";
            this.pnlTotal2.Size = new System.Drawing.Size(263, 37);
            this.pnlTotal2.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotal.Location = new System.Drawing.Point(95, 1);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 29);
            this.lblTotal.TabIndex = 86;
            this.lblTotal.Text = "Total";
            // 
            // lblCaixa
            // 
            this.lblCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.ForeColor = System.Drawing.Color.White;
            this.lblCaixa.Location = new System.Drawing.Point(341, 1);
            this.lblCaixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(223, 31);
            this.lblCaixa.TabIndex = 3;
            this.lblCaixa.Text = "SysPark - Caixa\r\n";
            this.lblCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaixa.Visible = false;
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
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(821, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 37);
            this.btnMinimizar.TabIndex = 70;
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
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(862, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 37);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 585);
            this.Controls.Add(this.pnlCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaixa_KeyDown);
            this.pnlCaixa.ResumeLayout(false);
            this.pnlCaixa.PerformLayout();
            this.pnlCaixa2.ResumeLayout(false);
            this.pnlMinCortesia.ResumeLayout(false);
            this.pnlMinCortesia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDescomto.ResumeLayout(false);
            this.pnlDescomto.PerformLayout();
            this.pnltotalItem.ResumeLayout(false);
            this.pnltotalItem.PerformLayout();
            this.pnlsubTotal.ResumeLayout(false);
            this.pnlsubTotal.PerformLayout();
            this.pnlDescricao.ResumeLayout(false);
            this.pnlDescricao.PerformLayout();
            this.pnlvalorUnitario.ResumeLayout(false);
            this.pnlvalorUnitario.PerformLayout();
            this.pnlQuantidade.ResumeLayout(false);
            this.pnlQuantidade.PerformLayout();
            this.pnlQuantiade2.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlCaixa;
        private System.Windows.Forms.Panel pnlCaixa2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblcodBarras;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtsubTotal;
        private System.Windows.Forms.Label lblsubTotal;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Panel pnlCodigo2;
        private System.Windows.Forms.Panel pnlDescricao;
        private System.Windows.Forms.Panel pnlDescricao2;
        private System.Windows.Forms.Panel pnltotalItem;
        private System.Windows.Forms.Panel pnltotalItem2;
        private System.Windows.Forms.Label lbltotalItem;
        private System.Windows.Forms.Panel pnlQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel pnlDescomto;
        private System.Windows.Forms.Panel pnlDesconto2;
        private System.Windows.Forms.Panel pnlsubTotal;
        private System.Windows.Forms.Panel pnlsubTotal2;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlTotal2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.TextBox txtHorarioAtual;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesqisar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtHorarioEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlvalorUnitario;
        public System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Panel pnlvalorUnitario2;
        private System.Windows.Forms.Label lblvalorUnitario;
        private System.Windows.Forms.Panel pnlQuantiade2;
        public ComboBoxMod.ComboBoxMod cmbTipoVeiculo;
        private System.Windows.Forms.Panel pnlMinCortesia;
        private System.Windows.Forms.TextBox txtMInCortesia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}

