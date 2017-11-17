using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using SysPark.Controler;
using SysPark.View;

namespace SysPark
{
    public partial class frmDescansoTela : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        BLGeral objBlGeral = new BLGeral();
        private string 
            nome_dia_semana, 
            nome_mes,
            dia_mes, ano;
        

        public frmDescansoTela()
        {
            InitializeComponent();
        }

        private void timerDescanso_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void frmDescansoTela_Load(object sender, EventArgs e)
        {
            if (!objBlGeral.Verifica_Existe_Empresa())
            {
                var Mensagem = new frmMessage_Box("É a primeira utilização do programa. É necessário cadastrar as informações da empresa./rDeseja continuar?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                if (Mensagem.ShowDialog() == DialogResult.Yes)
                {
                    frmInformacoesEmpresa formInfo = new frmInformacoesEmpresa();
                    formInfo.ShowDialog();

                    frmDescansoTela_Load(sender, e);
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (!objBlGeral.Verifica_Primeiro_Usuario())
            {
                var Mensagem = new frmMessage_Box("Não existe nenhum funcionário cadastrado. É necessário cadastrar um funcionário primeiro./rDeseja continuar?", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                if (Mensagem.ShowDialog() == DialogResult.Yes)
                {
                    frmcadFuncionarios cadFun = new frmcadFuncionarios(0);
                    cadFun.ShowDialog();

                    frmDescansoTela_Load(sender, e);
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                objBLFuncoesGenerica.CarregaLogo_Descanso(pnlDescanso);
                lbldiaSemana.BackColor = Color.Transparent;
                lblHora.BackColor = Color.Transparent;

                DateTime data = DateTime.Now; // buscar a Data Atual
                diaSemana(data); // chama a subrotina (método)
                diaMes(data);
                nomeMes(data);
                Ano(data);
                lbldiaSemana.Text = nome_dia_semana + ", " + dia_mes + " de " + nome_mes + " de " + ano;
            }    
        }        

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void ChamaLogin()
        {
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            frmLoginEntrada entrada = new frmLoginEntrada();
            entrada.Show();
        }
       
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            pcbLogo_Click(sender, e);
        }
        public string diaSemana(DateTime data)
        { 
            int numdia = Convert.ToInt32(data.DayOfWeek); //Buscar o dia da semana direto do S.O.
            string[] nome_dia = new string[7];

            nome_dia[0] = "Domingo";
            nome_dia[1] = "Segunda-feira";
            nome_dia[2] = "Terça-feira";
            nome_dia[3] = "Quarta-feira";
            nome_dia[4] = "Quinta-feira";
            nome_dia[5] = "Sexta-feira";
            nome_dia[6] = "Sábado";

            nome_dia_semana = nome_dia[numdia].ToString();            

            return nome_dia_semana;
        }

        public string nomeMes(DateTime data)
        { 
            int numdia = Convert.ToInt32(data.Month); //Buscar o dia da semana direto do S.O.
            string[] nome_dia = new string[13];

            nome_dia[0] = "ERRO";
            nome_dia[1] = "Janeiro";
            nome_dia[2] = "Fevereiro";
            nome_dia[3] = "Março";
            nome_dia[4] = "Abril";
            nome_dia[5] = "Maio";
            nome_dia[6] = "Junho";
            nome_dia[7] = "Julho";
            nome_dia[8] = "Agosto";
            nome_dia[9] = "Setembro";
            nome_dia[10] = "Outubro";
            nome_dia[11] = "Novembro";
            nome_dia[12] = "Dezembro";

            nome_mes = nome_dia[numdia].ToString();

            return nome_mes;
        }

        public string diaMes(DateTime data)
        {           
            dia_mes = data.Day.ToString();

            return dia_mes;
        }

        public string Ano(DateTime data)
        {
            ano = data.Year.ToString();

            return ano;
        }

        private void pnlDescanso_Click(object sender, EventArgs e)
        {
            ChamaLogin();
        }

        private void frmDescansoTela_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Application.Exit();
                    }
                    break;
                case Keys.Enter:
                    {      
                        ChamaLogin();
                    }
                    break;
            }
        }           
    }
}
