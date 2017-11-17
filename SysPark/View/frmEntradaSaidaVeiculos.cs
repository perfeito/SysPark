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
using SysPark.Controler;
using SysPark.Model;

namespace SysPark.View
{
    public partial class frmEntradaSaidaVeiculos : Form
    {
        clsFuncoesGenericas objFuncao = new clsFuncoesGenericas();
        BLCaixa objBlCaixa = new BLCaixa();
        ModProduto objModItem = new ModProduto();

        public frmEntradaSaidaVeiculos()
        {
            InitializeComponent();

            //Rectangle bounds = new Microsoft.VisualBasic.Devices.Computer().Screen.Bounds;
            //this.Size = new Size(bounds.Width, 521);

            pnlConsultaPreco.MouseDown += objFuncao.Form_MouseDown;
            pnlConsultaPreco.MouseMove += objFuncao.Form_MouseMove;
            pnlConsultaPreco.MouseUp += objFuncao.Form_MouseUp;

            lblCancelar.MouseDown += objFuncao.Form_MouseDown;
            lblCancelar.MouseMove += objFuncao.Form_MouseMove;
            lblCancelar.MouseUp += objFuncao.Form_MouseUp;
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

        private void frmConsultaPreco_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    {
                        objFuncao.txtCodigo_Leave(txtCodigo, e);
                        ConsultaItem();
                    }
                    break;
                case Keys.F2:
                    {
                        btnLimpar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    {
                        btnVoltar_Click(sender, e);
                    }
                    break;

            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            objFuncao.txtCodigo_Enter(sender, e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.ValidaCamposNumerico(e);
        }

        private void frmConsultaPreco_Load(object sender, EventArgs e)
        {
            objFuncao.Drop_Shadow(this);

            txtCodigo.Select();
        }

        private void ConsultaItem()
        {
            if (txtCodigo.Text.Length == 13)
            {
                try
                {
                    txtDescricao.Clear();                   
                    
                        objModItem = objBlCaixa.SelecionaItemCaixaCodigo(Convert.ToInt64(txtCodigo.Text));
                        objModItem.ItemCancelado = false;
                    MontaDadosItemConsulta();                   

                    txtCodigo.Clear();  
                }
                catch (Exception erro)
                {
                    var Mensagem = new frmMessage_Box(erro.Message, "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                }
            }
        }

        public void MontaDadosItemConsulta()
        {            
            txtCodigo.Text = objModItem.CodBarras.ToString();
            txtDescricao.Text = objModItem.NomeProduto;
            txtPreco.Text = objModItem.PrecoVenda.ToString();
            pcbImagem.Image = objFuncao.ConverteByte_Imagem(objModItem.ImagemProduto);
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Enter(sender, e);
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            //objFuncao.txtMoeda_Leave(sender, e);
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            objFuncao.txtMoeda_KeyDown(sender, e);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ConsultaItem();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtPreco.Text = "0,00";
            txtCodigo.Focus();
            pcbImagem.Image = null;
        }
    }
}
