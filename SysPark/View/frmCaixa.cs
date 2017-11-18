using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Threading;
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
        ModSeguranca Seg;
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
            idSacola;
        private int
            idterminal,
            coditem,
            codigoItem;
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
        private int
            IRetorno,
            IRetornoSweda,
            IRetornoEpson;


        public frmCaixa()
        {
            InitializeComponent();

            pnlCaixa.MouseDown += objFuncao.Form_MouseDown;
            pnlCaixa.MouseMove += objFuncao.Form_MouseMove;
            pnlCaixa.MouseUp += objFuncao.Form_MouseUp;

            lblCaixa.MouseDown += objFuncao.Form_MouseDown;
            lblCaixa.MouseMove += objFuncao.Form_MouseMove;
            lblCaixa.MouseUp += objFuncao.Form_MouseUp;
        }

        /*private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }*/

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            //objFuncao.txtMoeda_Leave(sender, e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.txtMoeda_KeyDown(sender, e);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                objFuncao.Button_Maximizar(sender, this);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                objFuncao.Button_Maximizar(sender, this);
            }
        }

        // LOAD DA TELA DE CAIXA
        public void frmCaixa_Load(object sender, EventArgs e)
        {
            idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
            var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);
            
            idcaixa = dadosCaixa.IdCaixa;
            idoperador = dadosCaixa.IdcpfcnpjPessoa;
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {
            //objFuncao.txtMedidas_Enter(sender, e);
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            //objFuncao.txtMedidas_Leave(sender, e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.txtMedidas_KeyPress(sender, e);
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            objFuncao.txtCodigo_Enter(sender, e);
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
                case Keys.F3:
                    {
                        Quantidade(e);
                    }
                    break;
                case Keys.F4:
                    {
                        btnConsulta_Click(sender, e);
                    }
                    break;
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
                case Keys.Enter:
                    {
                        objFuncao.txtCodigo_Leave(txtPlaca, e);
                        //InsereItem();
                    }
                    break;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //InsereItem();
        }        

        //altera a quantidade dos itens
        private void Quantidade(EventArgs e)
        {
            
        }

        //chama a tela de recebimento
        private void Receber()
        {
                var formReceber = new frmReceber(this);
                formReceber.ShowDialog();
        }

        //
        /*private void MenuCaixa()
        {
            if (idvenda == 0)
            {
                frmConfigImpressora menu = new frmConfigImpressora(this);
                menu.ShowDialog();
            }
            else
            {
                var Mensagem = new frmShowMessage("Não é possivel executar essa função com uma venda aberta.", "SysPark - ATENÇÃO", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                return;
            }
        }*/

        //verifica se a impressora esta ligada
        /*private void VerificaImpressoraLigada()
        {
            switch (marcaImp)
            {
                case "BEMATECH":
                    {
                        // BEMATECH
                        IRetorno = BemaFI32.Bematech_FI_VerificaImpressoraLigada();
                        if (IRetorno != 1)
                        {
                            SplashScreen.UdpateStatusTextWithStatus("Impressora não encontrada.", TypeOfMessage.Error);
                            Thread.Sleep(1000);
                            SplashScreen.CloseSplashScreen();
                            BemaFI32.Analisa_iRetorno(IRetorno);
                            return;
                        }
                    }
                    break;
                case "SWEDA":
                    {
                        // SWEDA
                        IRetornoSweda = ECFSWEDA.ECF_VerificaImpressoraLigada();
                        if (IRetornoSweda != 1)
                        {
                            SplashScreen.UdpateStatusTextWithStatus("Impressora não encontrada.", TypeOfMessage.Error);
                            Thread.Sleep(1000);
                            SplashScreen.CloseSplashScreen();
                            ECFSWEDA.Analisa_Retorno_Dll(IRetornoSweda);
                            return;
                        }
                    }
                    break;
                case "EPSON":
                    {
                        InterfaceEpson.EPSON_Serial_Abrir_Porta(115200, 1);

                    }
                    break;
            }
        }*/

        //
        /*private void AbreFechaCaixa(object sender, EventArgs e)
        {
            idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
            var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);

            if (dadosCaixa.IdCaixa == -1)
            {
                var movCaixa = objBlGeral.VerificaMovimentoDiaCaixaAntigoAberto(idterminal);

                if (movCaixa.IdMovDiaCaixa == -1)
                {
                    var movDia = objBlGeral.VerificaMovimentoDiaCaixaAberto(idterminal);

                    if (movCaixa.IdMovDiaCaixa != -1)
                    {
                        VerificaImpressoraLigada();

                        Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
                        splashthread.IsBackground = true;
                        splashthread.Start();

                        frmAberturaCaixa abreCaixa = new frmAberturaCaixa();
                        abreCaixa.ShowDialog();
                        frmCaixa_Load(sender, e);
                    }
                    else
                    {
                        var Mensagem = new frmShowMessage("Deseja iniciar o dia do Caixa?", "SysPark - ATENÇÃO", frmShowMessage.enumMessageButton.YesNo, frmShowMessage.enumMessageIcon.Question);
                        if (Mensagem.ShowDialog() == DialogResult.No)
                            return;

                        LeituraX();

                        objBlGeral.AbreMovimentoDiaCaixa(idterminal);

                        Mensagem = new frmShowMessage("Inicio do dia do Caixa realizado com sucesso.", "SysPark - ATENÇÃO", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Information);
                        Mensagem.ShowDialog();
                        return;
                    }
                }
                else
                {
                    var Mensagem = new frmShowMessage("O TERMINAL NÃO TEVE O DIA DE ONTEM ENCERRADO.\nÉ NECESSÁRIO FAZER A REDUÇÃO Z.", "SysPark - ATENÇÃO", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                    return;
                }
            }
            else
            {
                frmConcedePermissao permissao = new frmConcedePermissao();
                permissao.ShowDialog();

                if (objModSeg.IdFuncionario != -1)
                {
                    Seg = objBlSeg.VerificaPermissaoSeguranca(objModSeg.IdFuncionario);

                    if (Seg.FechaCaixa == true)
                    {
                        Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
                        splashthread.IsBackground = true;
                        splashthread.Start();

                        frmFechaCaixa fechaCaixa = new frmFechaCaixa();
                        fechaCaixa.ShowDialog();
                        frmCaixa_Load(sender, e);
                    }
                    else
                    {
                        var Mensagem = new frmShowMessage("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                        Mensagem.ShowDialog();
                        return;
                    }
                }
            }
        }*/

        //faz a leitura x
        /*private void LeituraX()
        {
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            VerificaImpressoraLigada();

            switch (marcaImp)
            {
                case "BEMATECH":
                    {
                        //*********   BEMATECH   ********* 
                        SplashScreen.UdpateStatusTextWithStatus("Realizando o início do dia.\nAguarde.", TypeOfMessage.Process);
                        IRetorno = BemaFI32.Bematech_FI_LeituraX();
                        if (IRetorno != 1)
                        {
                            SplashScreen.UdpateStatusTextWithStatus("Falha no início do dia.", TypeOfMessage.Error);
                            Thread.Sleep(1000);
                            SplashScreen.CloseSplashScreen();
                            BemaFI32.Analisa_iRetorno(IRetorno);
                            return;
                        }

                        SplashScreen.UdpateStatusTextWithStatus("Início de dia realizado co sucesso.", TypeOfMessage.Success);
                        Thread.Sleep(2000);
                        SplashScreen.CloseSplashScreen();
                    }
                    break;
                case "SWEDA":
                    {
                        //****   SWEDA  *******
                        SplashScreen.UdpateStatusTextWithStatus("Realizando o início do dia.\nAguarde.", TypeOfMessage.Process);
                        IRetornoSweda = ModuloCaixa.ECFSWEDA.ECF_LeituraX();
                        if (IRetornoSweda != 1)
                        {
                            SplashScreen.UdpateStatusTextWithStatus("Falha no início do dia.", TypeOfMessage.Error);
                            Thread.Sleep(1000);
                            SplashScreen.CloseSplashScreen();
                            ModuloCaixa.ECFSWEDA.Analisa_Retorno_Dll(IRetornoSweda);
                            return;
                        }

                        SplashScreen.UdpateStatusTextWithStatus("Início de dia realizado co sucesso.", TypeOfMessage.Success);
                        Thread.Sleep(2000);
                        SplashScreen.CloseSplashScreen();
                    }
                    break;
                case "EPSON":
                    {
                        //**********   EPSON   *********  
                        SplashScreen.UdpateStatusTextWithStatus("Realizando o início do dia.\nAguarde.", TypeOfMessage.Process);
                        IRetornoEpson = InterfaceEpson.EPSON_RelatorioFiscal_LeituraX();
                        if (IRetornoEpson != 1)
                        {
                            SplashScreen.UdpateStatusTextWithStatus("Falha no início do dia.", TypeOfMessage.Error);
                            Thread.Sleep(1000);
                            SplashScreen.CloseSplashScreen();
                            InterfaceEpson.atualizaRetorno(IRetornoEpson, "EPSON_RelatorioFiscal_LeituraX");
                            return;
                        }

                        SplashScreen.UdpateStatusTextWithStatus("Leitura X realizado com sucesso.", TypeOfMessage.Success);
                        Thread.Sleep(2000);
                    }
                    break;
            }
        }*/

        //prepara a abertura da venda
        /*public void PreparaParaAbrirVenda(frmCaixa cx)
        {
            VerificaImpressoraLigada();

            var Mensagem = new frmShowMessage("O CLIENTE tem cadastro na loja?", "SysPark - ATENÇÃO", frmShowMessage.enumMessageButton.YesNo, frmShowMessage.enumMessageIcon.Question);
            if (Mensagem.ShowDialog() == DialogResult.Yes)
            {
                frmBuscaCliente buscaCliente = new frmBuscaCliente(cx);
                buscaCliente.ShowDialog();
            }

            var CpfCnpj = new frmCpfCupom("Deseja o CPF/CNPJ na nota?", cx);
            if (CpfCnpj.ShowDialog() == DialogResult.Yes)
                cpjcnpjCupom = CpfCnpj.txtCpfCnpj.Text;            

            txtCodigo.Select();
            txtQuantidade.Text = "1,000";
        }*/

        //abre a venda

        //prepara os dados para inseri na venda
        private void CarregaDadosItemVenda()
        {
            objModItem.CodigoItem = codigoItem;
            objModItem.IdVenda = idvenda;
            objModItem.IdProdutoServico = idProdutoServico;
            objModItem.PrecoVenda = Convert.ToDecimal(txtValorHora.Text);
            objModItem.TotalItem = Convert.ToDecimal(txtHorarioAtual.Text);
            objModItem.DescontoItem = 0.00m;
            objModItem.DescontoFidelidade = descCliente;
            objModItem.IdOperadorDesc = 0;
            objModItem.IdOperadorCancel = 0;
        }

        //Monta os dados na tela
        public void MontaDadosItemVenda()
        {
            idProdutoServico = objModItem.IdProdutoServico;
            txtPlaca.Text = objModItem.CodigoBarras.ToString();
            txtDescricao.Text = objModItem.NomeProdutoServico;
            txtValorHora.Text = objModItem.PrecoVenda.ToString("N2");
            aliquota = objModItem.Aliquota;
            percIbpt = objModItem.Ibpt;
        }
        
        //Calcula desconto de fidelidade do cliente
        public void CalculaDescontoFidelidade(decimal desc)
        {
            descCliente = ((objModItem.PrecoVenda * desc) / 100) * quantidade;
            txtDesconto.Text = descCliente.ToString("N2");
            totaldescCliente += descCliente;
        }

        //Calcula o valor aprox. dos tributos
        private void CalcularTributos()
        {
            valorIbpt += (totalItem * percIbpt) / 100;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHorarioAtual.Text = DateTime.Now.ToShortTimeString();
        }

        //calcula o total do item
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

        //calcula o total da venta
        private void CalculaTotalVenda()
        {
            subtotal = 0.00m;
            desconto = 0.00m;

            var dtlistaitens = objBlCaixa.ListaItensVenda(idvenda);

            foreach (DataRow row in dtlistaitens.Rows)
            {
                if (Convert.ToBoolean(row["Cancelado"].ToString()) == false)
                {
                    subtotal += (decimal)row["Valor Item"] * (decimal)row["Qtd"];
                    desconto += ((decimal)row["Desconto"] + (decimal)row["DescFidel"]);
                }
            }
            txtsubTotal.Text = subtotal.ToString("N2");

            txtDesconto.Text = desconto.ToString("N2");

            txtTotal.Text = (subtotal - desconto).ToString("N2");
        }

        //
        private void txtCalculo_textChanged(object sender, EventArgs e)
        {

        }

        //limpa todos os dados da tela
        public void LimparTudo()
        {
            objFuncao.LimpaCampos(this);
            codigoItem = 0;
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
            if (idvenda == 0)
            {
                LimparTudo();
                this.Close();
            }
            else
            {
                var Mensagem = new frmMessage_Box("Não é possivel voltar.\rJá exite um item lançado na venda.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                return;
            }
        }

        private void btnPesqisar_Click(object sender, EventArgs e)
        {
            //BuscarProduto();
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {
            Quantidade(e);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmEntradaSaidaVeiculos consultaPreco = new frmEntradaSaidaVeiculos();
            consultaPreco.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //CancelarItem();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            Receber();
        }

        #endregion
    }
}
