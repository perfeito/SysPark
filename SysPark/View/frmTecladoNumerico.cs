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
    public partial class frmTecladoNumerico : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();

        public frmTecladoNumerico()
        {
            InitializeComponent();

            //pnlTeclado.MouseDown += objFuncao.Form_MouseDown;
            //pnlTeclado.MouseMove += objFuncao.Form_MouseMove;
            //pnlTeclado.MouseUp += objFuncao.Form_MouseUp;

            //lblTeclado.MouseDown += objFuncao.Form_MouseDown;
            //lblTeclado.MouseMove += objFuncao.Form_MouseMove;
            //lblTeclado.MouseUp += objFuncao.Form_MouseUp;
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

        private void frmTecladoNumerico_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);

            txtDado.Clear();
            txtDado.Select();
        }

        private void btnAddNumero(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                txtDado.Text += button.Tag;
            //txtDado.Select();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            objFuncao.BackSpace(txtDado);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDado.Text))
                txtDado.Text = "0";

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            txtDado.Clear();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDado.Clear();
        }
    }
}
