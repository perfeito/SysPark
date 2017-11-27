using System;
using System.Data;
using System.Windows.Forms;
using SysPark.Controler;
using SysPark.Model;

namespace SysPark.View
{
    public partial class frmCaixa : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        BLGeral objBlGeral = new BLGeral();
        BLCaixa objBlCaixa = new BLCaixa();
        BLTerminal objBlTerminal = new BLTerminal();
        BLCliente objBlCliente = new BLCliente();
        ModSeguranca objModSeg = new ModSeguranca();
        ModCliente objModCliente = new ModCliente();
        ModCaixa objModCaixa = new ModCaixa();
        ModProdutoServico objModItem = new ModProdutoServico();
        ModTipoVeiculo objmodTipoVeiculo = new ModTipoVeiculo();
        BLTipoVeiculo objbLTipoVeiculo = new BLTipoVeiculo();
        frmTecladoNumerico teclado = new frmTecladoNumerico();
        public string
            aliquota,
            marcaImp,
            cpjcnpjCupom,
            nomeCliente;
        public long
            idProdutoServico,
            idcaixa,
            idoperador,
            idvenda,
            idOperador,
            idcliente,
            idMensalista,
            idSacola;
        private int
            idterminal
        ;
        public decimal
            valorUnitario,
            quantidade,
            totalItem,
            desconto,
            subtotal,
            totalgeral,
            totaldaLista,
            valorCancelado,
            percIbpt,
            valorIbpt,
            percTotalIbpt,
            descCliente,
            totaldescCliente,
            percFidel;


        public frmCaixa(long idCaixa)
        {
            InitializeComponent();
            this.idcaixa = idCaixa;
            pnlCaixa.MouseDown += objFuncao.Form_MouseDown;
            pnlCaixa.MouseMove += objFuncao.Form_MouseMove;
            pnlCaixa.MouseUp += objFuncao.Form_MouseUp;

            lblCaixa.MouseDown += objFuncao.Form_MouseDown;
            lblCaixa.MouseMove += objFuncao.Form_MouseMove;
            lblCaixa.MouseUp += objFuncao.Form_MouseUp;
        }
        
        public void frmCaixa_Load(object sender, EventArgs e)
        {
            idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
            var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);

            idcaixa = dadosCaixa.IdCaixa;
            idoperador = dadosCaixa.IdcpfcnpjPessoa;

            txtPlaca.Select();
            txtPlaca.Focus();
            listaTipoVeiculo();
        }

        public void listaTipoVeiculo()
        {
            try
            {
                cmbTipoVeiculo.Items.Clear();

                var tipoVeiculo = objbLTipoVeiculo.BuscaTipoVeiculoAtivos();

                for (int i = 0; i < tipoVeiculo.Count; i++)
                {
                    cmbTipoVeiculo.Items.Add(new ComboBoxMod.ComboBoxItem(tipoVeiculo[i].Key, tipoVeiculo[i].Value));
                }

                if (cmbTipoVeiculo.Items.Count > 0)
                {
                    cmbTipoVeiculo.SelectedIndex = 0;
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {            
            if ((sender as TextBox).Text.Length >= 8)
            {
              if (e.KeyData != Keys.Back && e.KeyData != Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaDadosTipoVeiculo();
        }

        private void listaDadosTipoVeiculo()
        {
            try
            {
                objmodTipoVeiculo = objbLTipoVeiculo.BuscaTipoVeiculoPorID(Convert.ToInt32( cmbTipoVeiculo.SelectedValue));

                txtValorHora.Text = string.Format("{0:N}", objmodTipoVeiculo.ValorHora);
                txtMInCortesia.Text = objmodTipoVeiculo.CortesiaAte.ToString();
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void habilitaReceber()
        {
            txtDesconto.Enabled = true;
            btnPesqisar.Text = "Receber";
            pnlDescricao.Enabled = false;
        }

        private void desabilitaReceber()
        {
            txtDesconto.Enabled = false;
            btnPesqisar.Text = "Lançar";
            txtDescricao.Enabled = true;
            txtHorarioEntrada.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Enter(sender, e);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text == string.Empty)
            {
                txtDesconto.Text = "0.00";
            }
            try
            {
                Convert.ToDecimal(txtDesconto.Text);
            }
            catch (Exception)
            {
                txtDesconto.Text = "0.00";
            }
            CalculaTotal();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // objFuncao.txtMoeda_KeyDown(sender, e);
        }
        
        private void txtCodigo_Leave(object sender, EventArgs e)
        {

        }

        private void txtValidaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
               
        }

        public void frmCaixa_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F11:
                    {
                        Receber();
                    }
                    break;
                case Keys.Escape:
                    {
                        btnVoltar_Click(sender, e);
                    }
                    break;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnPesqisar.Enabled = (sender as TextBox).Text.Length == 8;
            btnPesqisar.Text = "Pesquisar";
            txtDescricao.Text = string.Empty;
            tbMinutos.Text = "0";
            txtHorarioEntrada.Text = "00:00";
            txtsubTotal.Text = "0.00";
            txtDesconto.Text = "0.00";
            txtTotal.Text = "0.00";
        }
        
        private void Receber()
        {
             var formReceber = new frmReceber(this);
             formReceber.ShowDialog();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHorarioAtual.Text = DateTime.Now.ToShortTimeString();
        }
        
        public void CalculaTotalItem()
        {
            try
            {
                valorUnitario = !string.IsNullOrEmpty(txtValorHora.Text)
                                ? Convert.ToDecimal(txtValorHora.Text)
                                : 0.00m;
                desconto = !string.IsNullOrEmpty(txtDesconto.Text)
                             ? Convert.ToDecimal(txtDesconto.Text)
                             : 0.00m;

                txtHorarioAtual.Text = ((valorUnitario * quantidade) - desconto).ToString("N2");

                totalItem = !string.IsNullOrEmpty(txtHorarioAtual.Text)
                            ? Convert.ToDecimal(txtHorarioAtual.Text)
                            : 0.00m;
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        
        private void CalculaTotalVenda(ModVenda modVenda)
        {
            var dt1 = DateTime.Now;
            var dt2 = modVenda.HoraEntrada;

            TimeSpan ts = dt1 - dt2;

            tbMinutos.Text = Convert.ToInt32(ts.TotalMinutes).ToString();

            if (Convert.ToInt32(tbMinutos.Text) > Convert.ToInt32(txtMInCortesia.Text))
            {
                txtsubTotal.Text = (ts.TotalHours * Convert.ToDouble(txtValorHora.Text)).ToString("N2");

                txtTotal.Text = (Convert.ToDecimal(txtsubTotal.Text) - Convert.ToDecimal(txtDesconto.Text)).ToString("N2");
            }
            if (modVenda.IdVeiculoMensalista != -1)
            {
                txtsubTotal.Text = "0.00";
                txtTotal.Text = "0.00";
            }
        }

        private void CalculaTotal()
        {
            txtTotal.Text = (Convert.ToDecimal(txtsubTotal.Text) - Convert.ToDecimal(txtDesconto.Text)).ToString("N2");
        }

        private void txtCalculo_textChanged(object sender, EventArgs e)
        {

        }
        
        public void LimparTudo()
        {
            objFuncao.LimpaCampos(this);
            idvenda = 0;
            valorIbpt = 0;
            percTotalIbpt = 0;
            desconto = 0;
            descCliente = 0;
            totaldescCliente = 0;
            idcliente = 0;
            idSacola = -1;
            cpjcnpjCupom = string.Empty;
        }

        #region BOTOES

        private void btnVoltar_Click(object sender, EventArgs e)
        {
                LimparTudo();
                this.Close();
        }

        private void btnPesqisar_Click(object sender, EventArgs e)
        {
            if (btnPesqisar.Text == "Pesquisar")
            {
                BuscarPlaca();
                
            }
            else if (btnPesqisar.Text == "Lançar")
            {
                ModVenda modVenda = new ModVenda
                {
                    Placa = txtPlaca.Text,
                    IDTipoVeiculo = Convert.ToInt32(cmbTipoVeiculo.SelectedValue),
                    HoraEntrada = DateTime.Now,
                    Descricao = txtDescricao.Text,
                    HoraValor = Convert.ToDecimal(txtValorHora.Text),
                    MinCortesia = Convert.ToInt32(txtMInCortesia.Text),
                    IdCaixaAbertura = idcaixa,
                    IdVeiculoMensalista = new BLVenda().VerificaVeiculoMensalista(txtPlaca.Text)
            };
                new BLVenda().InsereVenda(modVenda);
                txtPlaca.Text = string.Empty;
                txtHorarioEntrada.Text = "00:00";
                txtDescricao.Text = string.Empty;
                txtDescricao.Enabled = false;
                txtPlaca.Focus();
                txtPlaca.Select();
            }
            else if (btnPesqisar.Text == "Receber")
            {
                Receber();
            }
        }

        public void BuscarPlaca()
        {
            ModVenda modVenda = new BLVenda().BuscaVendaPorPlaca(txtPlaca.Text);
            if (modVenda.ID == -1)
            {
                desabilitaReceber();
                
            }
            else
            {
                habilitaReceber();
                idvenda = modVenda.ID;
                txtDescricao.Text = modVenda.Descricao;
                txtPlaca.Text = modVenda.Placa;
                cmbTipoVeiculo.SelectedIndex = modVenda.IDTipoVeiculo -1;
                txtHorarioEntrada.Text = modVenda.HoraEntrada.ToShortTimeString();
                txtMInCortesia.Text = modVenda.MinCortesia.ToString();
                idMensalista = modVenda.IdVeiculoMensalista;

                CalculaTotalVenda(modVenda);
            }
        }
        
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmEntradaSaidaVeiculos consultaPreco = new frmEntradaSaidaVeiculos();
            consultaPreco.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
    }
}
