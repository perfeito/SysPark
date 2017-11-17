using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmTipoCartao : Form
    {
        private readonly clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        /// <summary>
        /// opcao é qual o tipo de recebimento de cartão
        /// </summary>
        /// <param value="1">TEF</param>
        /// <param value="2">POS</param>
        private int opcao;
        /// <summary>
        /// escolha é o valor a ser retornado
        /// </summary>
        /// <param value="1">DEBITO</param>
        /// <param value="2">CREDITO</param>
        private static int escolha;
       
        public int Escolha
        {
            get { return escolha; }
            set { escolha = value; }
        }

        public frmTipoCartao(int Opcao)
        {
            InitializeComponent();

            this.opcao = Opcao;                      
        }

        private void frmTipoCartao_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            if (opcao == 2)
                Escolha = 2;            

            this.Close();
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            if (opcao == 2)
                Escolha = 1;

            this.Close();
        }
    }
}
