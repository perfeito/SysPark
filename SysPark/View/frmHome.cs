using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using SysPark.Controler;
using SysPark.View;

namespace SysPark
{
    public partial class frmHome : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLSeguranca objBlSeg = new BLSeguranca();
        BLTerminal objBlTerminal = new BLTerminal();
        BLLogin objBlLogin = new BLLogin();
        frmDescansoTela descansoTela = new frmDescansoTela();
        private int IdTerminalLogado, idterminal;
        ModSeguranca Seg;


        public frmHome()
        {
            InitializeComponent();

            pnlHome.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlHome.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlHome.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblHome.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblHome.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblHome.MouseUp += objBLFuncoesGenerica.Form_MouseUp;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                var Mensagem = new frmMessage_Box("Deseja mesmo sair do programa fazer LOGOFF?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                if (Mensagem.ShowDialog() == DialogResult.Yes)
                {
                    idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                    objBlLogin.LogoutUsuario(Convert.ToInt64(lblidUsuario.Text), idterminal);

                    var Mensagem2 = new frmMessage_Box("LOGOFF REALIZADO COM SUCESSO!", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                    Mensagem2.ShowDialog();

                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                objBLFuncoesGenerica.Button_Maximizar(sender, this);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                objBLFuncoesGenerica.Button_Maximizar(sender, this);
            }
            objBLFuncoesGenerica.Refresh_Drop_Shadow();
        }



        private void frmHome_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);

            bool falha = false;
            objBLFuncoesGenerica.CarregaNomeUsuario_Load(lblnomeUsuario, ref falha);
            if (falha == true)
            {
                Close();
                Application.Exit();
                return;
            }

            objBLFuncoesGenerica.CarregaCpfUsuario_Load(lblidUsuario, ref falha);
            if (falha == true)
                Application.Exit();
            objBLFuncoesGenerica.CarregaImagemUsuario_Load(pcbUsuario, ref falha);
            if (falha == true)
                Application.Exit();

            objBLFuncoesGenerica.CarregaLogo_Home(picLogo);
            objBLFuncoesGenerica.CarregaNome_Fantasia(lblnomeFantasia);
            objBLFuncoesGenerica.Button_Maximizar(sender, this);

            ListaFormCadastros();
            ListaFormPesquisas();
            ListaFormVendas();
            ListaFormConfig();
            ListaFormProced();

            this.BringToFront();

            Seg = objBlSeg.VerificaPermissaoSeguranca(Convert.ToInt64(lblidUsuario.Text));
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProcedimentos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVendas_EnabledChanged(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Color_Button_Enabled(sender);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            
        }

        #region CRIA SUB MENUS

        private List<KeyValuePair<string, string>> cadastros = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> pesquisas = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> procedimentos = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> vendas = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> config = new List<KeyValuePair<string, string>>();

        private List<KeyValuePair<string, string>> listaBotoes = new List<KeyValuePair<string, string>>();

        static int OrdemAlfabetica(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
        {
            return a.Value.CompareTo(b.Value);
        }

        private void rbCadastro_CheckedChanged(object sender, EventArgs e)
        {
            flpSubMenu.Controls.Clear();

            if (rbCadastro.Checked)
            {
                listaBotoes = cadastros;
                CriaBotoes();
            }
            else if (rbConfig.Checked)
            {
                listaBotoes = config;
                CriaBotoes();
            }
            else if (rbPesquisas.Checked)
            {
                listaBotoes = pesquisas;
                CriaBotoes();
            }
            else if (rbProcedimento.Checked)
            {
                listaBotoes = procedimentos;
                CriaBotoes();
            }
            else if (rbVendas.Checked)
            {
                listaBotoes = vendas;
                CriaBotoes();
            }
        }
        private void ListaFormCadastros()
        {
            cadastros.Add(new KeyValuePair<string, string>("btnCliente", "Mensalistas"));
            cadastros.Add(new KeyValuePair<string, string>("btnFuncionario", "Funcionários"));
            cadastros.Add(new KeyValuePair<string, string>("btnTipoVeiculo", "Tipo de Veículo"));
            cadastros.Add(new KeyValuePair<string, string>("btnCargo", "Cargos"));
            cadastros.Add(new KeyValuePair<string, string>("btnLogin", "Login"));

            cadastros.Sort(OrdemAlfabetica);
        }

        private void ListaFormPesquisas()
        {
            pesquisas.Add(new KeyValuePair<string, string>("btnCliente", "Mensalistas"));
            pesquisas.Add(new KeyValuePair<string, string>("btnFuncionario", "Funcionários"));
            pesquisas.Add(new KeyValuePair<string, string>("btnTipoVeiculo", "Tipo de Veículo"));
            pesquisas.Add(new KeyValuePair<string, string>("btnCargo", "Cargos"));

            pesquisas.Sort(OrdemAlfabetica);
        }

        private void ListaFormVendas()
        {
            vendas.Add(new KeyValuePair<string, string>("btnAbreCaixa", "Abrir Caixa"));
            vendas.Add(new KeyValuePair<string, string>("btnCaixa", "Caixa"));
            //vendas.Add(new KeyValuePair<string, string>("btnConsultaPreco", "Consulta Veiculo"));

            vendas.Sort(OrdemAlfabetica);
        }

        private void ListaFormConfig()
        {
            config.Add(new KeyValuePair<string, string>("btnTerminal", "Terminal"));
            config.Add(new KeyValuePair<string, string>("btnInfo", "Informações da Empresa"));
            config.Add(new KeyValuePair<string, string>("btnSeguranca", "Segurança"));
            config.Add(new KeyValuePair<string, string>("btnBackup", "Backup de segurança"));

            config.Sort(OrdemAlfabetica);
        }

        private void ListaFormProced()
        {
            procedimentos.Add(new KeyValuePair<string, string>("btnMovDia", "Movimento Dia"));
            procedimentos.Add(new KeyValuePair<string, string>("btnRelCaixa", "Contagem Caixa"));

            procedimentos.Sort(OrdemAlfabetica);
        }

        private void ClickCadastro(object sender)
        {
            Button btn = (sender as Button);

            switch (btn.Name)
            {
                case "btnCliente":
                    {
                        if (Seg.CadClientes == true)
                        {
                            frmcadClientes cadClientes = new frmcadClientes(0);
                            cadClientes.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnFuncionario":
                    {
                        if (Seg.CadFuncionarios == true)
                        {
                            frmcadFuncionarios cadFuncionarios = new frmcadFuncionarios(0);
                            cadFuncionarios.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnTipoVeiculo":
                    {
                        frmCadTipoVeiculo objfrmCadTipoVeiculo = new frmCadTipoVeiculo(0);
                        objfrmCadTipoVeiculo.ShowDialog();
                    }
                    break;
                case "btnCargo":
                    {
                        if (Seg.CadCargo == true)
                        {
                            frmcadCargo objCargo = new frmcadCargo(0);
                            objCargo.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnLogin":
                    {
                        if (Seg.CadLogin == true)
                        {
                            frmcadLogin objLogin = new frmcadLogin(null, 0, null, null);
                            objLogin.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
               
            }
        }

        private void ClickPesquisa(object sender)
        {
            Button btn = (sender as Button);

            switch (btn.Name)
            {
                case "btnCliente":
                    {
                        if (Seg.PesClientes == true)
                        {
                            frmBuscaCliente buscaCliente = new frmBuscaCliente(null, 0);
                            buscaCliente.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnFuncionario":
                    {
                        if (Seg.PesFuncionarios == true)
                        {
                            frmBuscaFuncionario buscaFuncionario = new frmBuscaFuncionario(null, null, null);
                            buscaFuncionario.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnTipoVeiculo":
                    {
                        frmBuscaTipoVeiculo objfrmBuscaTipoVeiculo = new frmBuscaTipoVeiculo();
                        objfrmBuscaTipoVeiculo.ShowDialog();
                    }
                    break;
                case "btnCargo":
                    {
                        if (Seg.PesCargo == true)
                        {
                            frmBuscaCargo buscaCargo = new frmBuscaCargo(null);
                            buscaCargo.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
            }
        }

        private void ClickVenda(object sender)
        {
            Button btn = (sender as Button);

            switch (btn.Name)
            {
                //case "btnConsultaPreco":
                //    {
                //        frmEntradaSaidaVeiculos consultaPreco = new frmEntradaSaidaVeiculos();
                //        consultaPreco.ShowDialog();
                //    }
                //    break;
                case "btnCaixa":
                    {
                        BLGeral objBlGeral = new BLGeral();
                        BLCaixa objBlCaixa = new BLCaixa();
                        idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
                        var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);

                        if (dadosCaixa.IdCaixa != -1)
                        {
                            frmCaixa caixa = new frmCaixa(dadosCaixa.IdCaixa);
                            caixa.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("O caixa não esta aberto.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                            Mensagem.ShowDialog();
                        }
                    }
                    break;
                case "btnAbreCaixa":
                    {
                        BLGeral objBlGeral = new BLGeral();
                        BLCaixa objBlCaixa = new BLCaixa();
                        idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);
                        var dadosCaixa = objBlCaixa.PegaOperadorCaixaAberto(idterminal);

                        if (dadosCaixa.IdCaixa == -1)
                        {
                            var dtAntigo = objBlGeral.VerificaMovimentoDiaAntigoAberto();

                            if (dtAntigo.Rows.Count > 0)
                            {
                                var Mensagem = new frmMessage_Box("Exite um MOVIMENTO DIA anterior a data de hoje aberto. Ele PRECISA ser FECHADO primeiro, para que o de hoje possa ser aberto.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                                Mensagem.ShowDialog();
                                return;
                            }
                            else
                            {
                                var dtAtual = objBlGeral.VerificaMovimentoDiaAberto();

                                if (dtAtual.Rows.Count > 0)
                                {
                                    var movCaixa = objBlGeral.VerificaMovimentoDiaCaixaAntigoAberto(idterminal);
                                    
                                            var movDia = objBlGeral.VerificaMovimentoDiaCaixaAberto(idterminal);

                                            if (movCaixa.IdMovimentoDia != -1)
                                            {
                                                frmAberturaCaixa abreCaixa = new frmAberturaCaixa();
                                                abreCaixa.ShowDialog();
                                            }
                                            else
                                            {
                                                var Mensagem = new frmMessage_Box("Deseja iniciar o dia do Caixa?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                                                if (Mensagem.ShowDialog() == DialogResult.No)
                                                    return;
                                                objBlGeral.AbreMovimentoDiaCaixa(idterminal);

                                                Mensagem = new frmMessage_Box("Inicio do dia do Caixa realizado com sucesso.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Information);
                                                Mensagem.ShowDialog();
                                                return;
                                            }
                                }
                                else
                                {
                                    var Mensagem = new frmMessage_Box("Não é possivel abrir o caixa.\rÉ preciso abrir o MOVIMENTO DIA primeiro.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                                    Mensagem.ShowDialog();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            frmFechaCaixa fechaCaixa = new frmFechaCaixa();
                            fechaCaixa.ShowDialog();
                        }
                    }
                    break;
            }
        }

        private void ClickConfig(object sender)
        {
            Button btn = (sender as Button);

            switch (btn.Name)
            {
                case "btnTerminal":
                    {
                        if (Seg.Terminal == true)
                        {
                            frmTerminal formTerminal = new frmTerminal();
                            formTerminal.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnInfo":
                    {
                        if (Seg.Informacoes == true)
                        {
                            frmInformacoesEmpresa formEmpresa = new frmInformacoesEmpresa();
                            formEmpresa.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnSeguranca":
                    {
                        if (Seg.Seguranca == true)
                        {
                            frmSeguranca formSeguranca = new frmSeguranca();
                            formSeguranca.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnBackup":
                    {
                        if (Seg.Backup == true)
                        {
                            frmBackupDataBase formBackup = new frmBackupDataBase();
                            formBackup.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
            }
        }

        private void ClickProced(object sender)
        {
            Button btn = (sender as Button);

            switch (btn.Name)
            {
                case "btnMovDia":
                    {
                        if (Seg.MovimentoDia == true)
                        {
                            frmMovimentoDia formMovimento = new frmMovimentoDia();
                            formMovimento.ShowDialog();
                        }
                        else
                        {
                            var Mensagem = new frmMessage_Box("VOÇÊ NÃO TEM PERMISSÃO PARA ISSO.", "ACESSO NEGADO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                            Mensagem.ShowDialog();
                            return;
                        }
                    }
                    break;
                case "btnRelCaixa":
                    {
                        frmContagemCaixa caixa = new frmContagemCaixa();
                        caixa.ShowDialog();
                    }
                    break;
            }
        }

        private void CriaBotoes()
        {
            foreach (var item in listaBotoes)
            {
                Button btnButton = new Button();

                btnButton.Name = item.Key;
                btnButton.Text = item.Value;
                toolTipMod1.SetToolTip(btnButton, item.Value);
                btnButton.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnButton.TextAlign = ContentAlignment.MiddleLeft;
                btnButton.ForeColor = Color.LightGray;
                btnButton.BackColor = Color.Transparent;
                btnButton.FlatStyle = FlatStyle.Flat;
                btnButton.FlatAppearance.BorderSize = 0;
                btnButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
                btnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
                btnButton.Width = 260;
                btnButton.Height = 100;
                btnButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnButton.ImageAlign = ContentAlignment.MiddleLeft;

                btnButton.Image = imageList.Images[item.Key + ".png"];

                btnButton.Click += btnButton_Click;

                flpSubMenu.Controls.Add(btnButton);
            }
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            if (listaBotoes == cadastros)
                ClickCadastro(sender);
            if (listaBotoes == pesquisas)
                ClickPesquisa(sender);
            if (listaBotoes == vendas)
                ClickVenda(sender);
            if (listaBotoes == config)
                ClickConfig(sender);
            if (listaBotoes == procedimentos)
                ClickProced(sender);
        }

        #endregion
    }
}
