using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Threading;
using System.Text.RegularExpressions;

using SysPark.Properties;
using SysPark.Controler;

namespace SysPark
{
    public class clsFuncoesGenericas
    {
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Dropshadow shadow;
        private BLGeral objBlGeral = new BLGeral();

        public void BackSpace(object sender)
        {
            try
            {
                var txtDados = (sender as TextBox);

                if (txtDados != null)
                {
                    var qtd_digitos = txtDados.TextLength;

                    if (txtDados.TextLength > 0)
                        txtDados.Text = txtDados.Text.Substring(0, qtd_digitos - 1);

                    txtDados.SelectionStart = 0;
                    txtDados.SelectionLength = txtDados.Text.Length;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void Form_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (sender is Panel)
                {
                    var objPanel = sender as Panel;
                    var objForm = objPanel.Parent as Form;
                    dragging = true;
                    dragCursorPoint = Cursor.Position;
                    dragFormPoint = objForm.Location;
                }
                else if (sender is Label)
                {
                    var objLabel = sender as Label;

                    if (objLabel.Parent is Panel)
                    {
                        var objPanel = objLabel.Parent as Panel;
                        var objForm = objPanel.Parent as Form;
                        dragging = true;
                        dragCursorPoint = Cursor.Position;
                        dragFormPoint = objForm.Location;
                    }
                    else if (objLabel.Parent is Form)
                    {
                        var objForm = objLabel.Parent as Form;
                        dragging = true;
                        dragCursorPoint = Cursor.Position;
                        dragFormPoint = objForm.Location;
                    }
                }
                else if (sender is Form)
                {
                    var objForm = sender as Form;
                    dragging = true;
                    dragCursorPoint = Cursor.Position;
                    dragFormPoint = objForm.Location;
                }
                else if (sender is PictureBox)
                {
                    var objPictureBox = sender as PictureBox;
                    var objForm = objPictureBox.Parent as Form;
                    dragging = true;
                    dragCursorPoint = Cursor.Position;
                    dragFormPoint = objForm.Location;
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void Form_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (!this.dragging)
                    return;
                if (sender is Panel)
                {
                    var objPanel = sender as Panel;
                    var objForm = objPanel.Parent as Form;
                    var dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                    objForm.Location = Point.Add(this.dragFormPoint, new Size(dif));
                }
                else if (sender is Label)
                {
                    var objLabel = sender as Label;

                    if (objLabel.Parent is Panel)
                    {
                        var objPanel = objLabel.Parent as Panel;
                        var objForm = objPanel.Parent as Form;
                        var dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                        objForm.Location = Point.Add(this.dragFormPoint, new Size(dif));
                    }
                    else if (objLabel.Parent is Form)
                    {
                        var objForm = objLabel.Parent as Form;
                        var dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                        objForm.Location = Point.Add(this.dragFormPoint, new Size(dif));
                    }
                }
                else if (sender is Form)
                {
                    var objForm = sender as Form;
                    var dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                    objForm.Location = Point.Add(this.dragFormPoint, new Size(dif));
                }
                else if (sender is PictureBox)
                {
                    var objPictureBox = sender as PictureBox;
                    var objForm = objPictureBox.Parent as Form;
                    var dif = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                    objForm.Location = Point.Add(this.dragFormPoint, new Size(dif));
                }
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void Form_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                dragging = false;
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        public void txtMoeda_KeyDown(object sender, KeyPressEventArgs e)
        {
            try
            {
                var tbValor = (sender as TextBox);

                if (tbValor == null)
                    return;

                var str = tbValor.Text.Replace(".", "").Replace(",", "").TrimStart('0');
                //tbValor.ReadOnly = true;

                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != Convert.ToChar(Keys.Delete) && e.KeyChar != Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = true;

                if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)) && (str.Length > 0))
                {
                    str = str.Substring(0, str.Length - 1);
                }
                else if (!((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back))))
                {
                    str = str + e.KeyChar;
                }

                if (str.Length == 0)
                {
                    tbValor.Text = "0,00";
                }

                switch (str.Length)
                {
                    case 1:
                        tbValor.Text = "0,0" + str;
                        break;
                    case 2:
                        tbValor.Text = "0," + str;
                        break;
                    default:
                        if (str.Length > 2 && str.Length <= 5)
                        {
                            tbValor.Text = str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2);
                        }
                        else if (str.Length > 5 && str.Length <= 8)
                        {
                            tbValor.Text = str.Substring(0, str.Length - 5) + "." + str.Substring(str.Length - 5, 3) + "," + str.Substring(str.Length - 2);
                        }
                        else if (str.Length > 8 && str.Length <= 11)
                        {
                            tbValor.Text = str.Substring(0, str.Length - 8) + "." + str.Substring(str.Length - 8, 3) + "." + str.Substring(str.Length - 5, 3) + "," + str.Substring(str.Length - 2);
                        }
                        else if (str.Length > 11 && str.Length <= 14)
                        {
                            tbValor.Text = str.Substring(0, str.Length - 11) + "." + str.Substring(str.Length - 11, 3) + "." + str.Substring(str.Length - 8, 3) + "." + str.Substring(str.Length - 5, 3) + "," + str.Substring(str.Length - 2);
                        }
                        break;
                }
                tbValor.Select(tbValor.Text.Length, 0);
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        
        public void txtMedidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                var txtMedidas = (sender as TextBox);

                if (txtMedidas == null)
                    return;

                var str = txtMedidas.Text.Replace(".", "").Replace(",", "").TrimStart('0');
                //txtMedidas.ReadOnly = true;
                
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != Convert.ToChar(Keys.Delete) && e.KeyChar != Convert.ToChar(Keys.Back)))
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = true;

                if ((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back)) && (str.Length > 0))
                {
                    str = str.Substring(0, str.Length - 1);
                }
                else if (!((e.KeyChar == Convert.ToChar(Keys.Delete)) || (e.KeyChar == Convert.ToChar(Keys.Back))))
                {
                    str = str + e.KeyChar;
                }

                if (str.Length == 0)
                {
                    txtMedidas.Text = "0,000";
                }

                switch (str.Length)
                {
                    case 1:
                        txtMedidas.Text = "0,00" + str;
                        break;
                    case 2:
                        txtMedidas.Text = "0,0" + str;
                        break;
                    case 3:
                        txtMedidas.Text = "0," + str;
                        break;
                    default:
                        if (str.Length > 3 && str.Length <= 6)
                        {
                            txtMedidas.Text = str.Substring(0, str.Length - 3) + "," + str.Substring(str.Length - 3);
                        }
                        else if (str.Length > 6 && str.Length <= 9)
                        {
                            txtMedidas.Text = str.Substring(0, str.Length - 6) + "." + str.Substring(str.Length - 6, 3) + "," + str.Substring(str.Length - 3);
                        }
                        else if (str.Length > 9 && str.Length <= 12)
                        {
                            txtMedidas.Text = str.Substring(0, str.Length - 9) + "." + str.Substring(str.Length - 9, 3) + "." + str.Substring(str.Length - 6, 3) + "," + str.Substring(str.Length - 3);
                        }
                        else if (str.Length > 12 && str.Length <= 15)
                        {
                            txtMedidas.Text = str.Substring(0, str.Length - 12) + "." + str.Substring(str.Length - 12, 3) + "." + str.Substring(str.Length - 9, 3) + "." + str.Substring(str.Length - 6, 3) + "," + str.Substring(str.Length - 3);
                        }
                        break;
                }
                txtMedidas.SelectionStart = txtMedidas.TextLength;
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
        public void txtNumero_Leave(object sender, EventArgs e)
        {
            try
            {
                var tbMoeda = (sender as TextBox);

                if (tbMoeda != null)
                {
                    tbMoeda.Text = tbMoeda.Text == string.Empty
                                       ? "0"
                                       : tbMoeda.Text;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void txtNumero_Enter(object sender, EventArgs e)
        {
            try
            {
                var tbMoeda = sender as TextBox;

                if (tbMoeda != null && tbMoeda.Text == "0")
                {
                    tbMoeda.Text = string.Empty;
                }
                else
                {
                    if (tbMoeda == null)
                        return;
                    tbMoeda.SelectionStart = 0;
                    tbMoeda.SelectionLength = tbMoeda.Text.Length;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void ValidaCamposNumerico(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void txtPlaca_Leave(object sender, EventArgs e)
        {
            try
            {
                //var txtPlaca = (sender as TextBox);

                //if (txtPlaca != null)
                //{
                //    var valida = txtPlaca.Text.Length == 8;
                //    tb.Text = txtPlaca.Text.Length == valida
                //                       ? "   -    "
                //                       : string.Format("{0:0000000000000}", double.Parse(txtPlaca.Text));
                //}
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void txtCodigo_Enter(object sender, EventArgs e)
        {
            try
            {
                var txtCodigo = sender as TextBox;

                if (txtCodigo != null && txtCodigo.Text == "0000000000000")
                {
                    txtCodigo.Text = string.Empty;
                }
                else
                {
                    if (txtCodigo == null)
                        return;
                    txtCodigo.SelectionStart = 0;
                    txtCodigo.SelectionLength = txtCodigo.Text.Length;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                var txtCep = (sender as MaskedTextBox);

                if (txtCep != null)
                {
                    txtCep.Text = txtCep.Text == string.Empty
                                              ? string.Empty
                                              : txtCep.Text;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void txtCep_Enter(object sender, EventArgs e)
        {
            try
            {
                var txtCep = (sender as MaskedTextBox);

                if (txtCep != null || txtCep.Text == "00000-000")
                {
                    txtCep.Text = string.Empty;
                }
                else
                {
                    if (txtCep == null)
                        return;
                    txtCep.SelectionStart = 0;
                    txtCep.SelectionLength = txtCep.Text.Length;
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void LimpaCampos(Control conponente)
        {
            foreach (Control controle in conponente.Controls)
            {
                if (controle is GroupBox)
                {
                    foreach (var control in controle.Controls)
                    {
                        if (control is TextBox)
                            if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "V")
                                ((TextBox)control).Text = "0,00";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "N")
                                ((TextBox)control).Text = "0";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "Q")
                                ((TextBox)control).Text = "0,000";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "E")
                                ((TextBox)control).Text = "0000000000000";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "C")
                                continue;
                            else
                                ((TextBox)control).Clear();

                        if (control is Label)
                            if (((Label)control).Tag != null && ((Label)control).Tag.ToString() == "A")
                                ((Label)control).Text = "";
                            else
                                continue;

                        else if (control is MaskedTextBox) ((MaskedTextBox)control).Clear();

                        else if (control is ComboBox)
                        {
                            if ((control as ComboBox).Items.Count > 0)
                            {
                                ((ComboBox)control).SelectedIndex = 0;
                            }
                        }
                        else if (control is CheckBox) ((CheckBox)control).Checked = false;

                        else if (control is RadioButton) ((RadioButton)control).Checked = false;

                        else if (control is DataGridView) ((DataGridView)control).DataSource = null;

                        else if (control is PictureBox)
                            if (((PictureBox)control).Tag != null && ((PictureBox)control).Tag.ToString() == "L")
                                continue;
                            else
                                ((PictureBox)control).Image = Resources.Imagem_50;
                        else if (control is PictureBox)
                            ((PictureBox)control).SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    this.LimpaCampos(controle);
                }

                if (controle is Panel)
                {
                    foreach (var control in controle.Controls)
                    {
                        if (control is TextBox)
                            if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "V")
                                ((TextBox)control).Text = "0,00";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "N")
                                ((TextBox)control).Text = "0";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "Q")
                                ((TextBox)control).Text = "0,000";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "E")
                                ((TextBox)control).Text = "0000000000000";
                            else if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "C")
                                continue;
                            else
                                ((TextBox)control).Clear();

                        if (control is Label)
                            if (((Label)control).Tag != null && ((Label)control).Tag.ToString() == "A")
                                ((Label)control).Text = "";
                            else
                                continue;

                        else if (control is MaskedTextBox) ((MaskedTextBox)control).Clear();

                        else if (control is ComboBox)
                        {
                            if ((control as ComboBox).Items.Count > 0)
                            {
                                ((ComboBox)control).SelectedIndex = 0;
                            }
                        }
                        else if (control is CheckBox) ((CheckBox)control).Checked = false;

                        else if (control is RadioButton) ((RadioButton)control).Checked = false;

                        else if (control is DataGridView) ((DataGridView)control).DataSource = null;

                        else if (control is PictureBox)
                            if (((PictureBox)control).Tag != null && ((PictureBox)control).Tag.ToString() == "L")
                                continue;
                            else
                                ((PictureBox)control).Image = Resources.Imagem_50;
                        else if (control is PictureBox)
                            ((PictureBox)control).SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    this.LimpaCampos(controle);
                }
            }
        }

        //================================= BOTÕES ===============================

        public void Button_Maximizar(object sender, Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                var btnGeral = sender as Button;
                if (btnGeral == null)
                    return;
                btnGeral.Image = Resources.Collapse_25;
            }
            else
            {
                var btnGeral = sender as Button;
                if (btnGeral == null)
                    return;
                btnGeral.Image = Resources.Expand_25;
            }
        }

        public void MaximizarBranco(object sender)
        {
            //var btnGeral = sender as Button;
            //if (btnGeral == null)
            //    return;
            //btnGeral.Image = Resources.appbar_app;
        }

        public void Color_Button_Enabled(object sender)
        {
            try
            {
                var btn = (sender as Button);

                btn.BackColor = btn.Enabled == true
                                ? Color.FromArgb(15, 15, 15)
                                : Color.FromArgb(5, 5, 5);
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void Color_Menu_Enabled(object sender)
        {
            try
            {
                var btn = (sender as Button);

                btn.BackColor = btn.Enabled == true
                                ? Color.FromArgb(50, 50, 50)
                                : Color.FromArgb(25, 25, 25);
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void Drop_Shadow(Form form)
        {
            shadow = new Dropshadow(form)
            {
                ShadowBlur = 8,
                ShadowSpread = 0,
                ShadowH = 0,
                ShadowV = 0,
                ShadowColor = Color.FromArgb(20, 20, 20) /*Color.FromKnownColor(KnownColor.Highlight)*/,
            };
            shadow.RefreshShadow();
        }

        public void Refresh_Drop_Shadow()
        {
            shadow.RefreshShadow();
        }

        //======================== CARREGA INFORMAÇÕES ===========================

        public void CarregaNomeUsuario_Load(Label lblUsuario, ref bool falha)
        {
            try
            {
                BLTerminal objBlTerminal = new BLTerminal();
                BLLogin objBlLogin = new BLLogin();
                int idterminal;
                DataTable usuario;

                idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                if (idterminal != -1)
                {
                    usuario = objBlLogin.PegaUsuarioLogado(idterminal);
                    var row = usuario.Rows[0];

                    lblUsuario.Text = row["NomePessoa"].ToString().Length >= 15
                                    ? row["NomePessoa"].ToString().Substring(0, 15)
                                    : row["NomePessoa"].ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        public void CarregaCpfUsuario_Load(Label idUsuario, ref bool falha)
        {
            try
            {
                BLTerminal objBlTerminal = new BLTerminal();
                BLLogin objBlLogin = new BLLogin();
                int idterminal;
                DataTable usuario;

                idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                usuario = objBlLogin.PegaUsuarioLogado(idterminal);
                if (usuario.Rows.Count == 0)
                {
                    var Mensagem = new frmMessage_Box("ERRO AO BUSCAR DADOS", "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                    Mensagem.ShowDialog();
                    falha = true;
                    return;
                }
                var row = usuario.Rows[0];

                idUsuario.Text = row["IdcpfcnpjPessoa"].ToString();
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void CarregaIdOperador_Load(long idUsuario)
        {
            try
            {
                BLTerminal objBlTerminal = new BLTerminal();
                BLLogin objBlLogin = new BLLogin();
                int idterminal;
                DataTable usuario;

                idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                usuario = objBlLogin.PegaUsuarioLogado(idterminal);
                if (usuario.Rows.Count != 0)
                {
                    var row = usuario.Rows[0];

                    idUsuario = Convert.ToInt64(row["IdcpfcnpjPessoa"].ToString());
                }
                idUsuario = -1;
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public long CarregaIdUsuario_Load()
        {
            BLTerminal objBlTerminal = new BLTerminal();
            BLLogin objBlLogin = new BLLogin();
            long idUsuario = -1;
            int idterminal;
            DataTable dt;

            idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

            dt = objBlLogin.PegaUsuarioLogado(idterminal);

            if (dt.Rows.Count != 0)
            {
                var row = dt.Rows[0];

                idUsuario = (long)row["IdcpfcnpjPessoa"];
            }

            return idUsuario;
        }

        public void CarregaNome_Fantasia(Label Fantasia)
        {
            BLGeral objGeral = new BLGeral();
            Fantasia.Text = objGeral.BuscaNomeFantasia();
        }

        public void CarregaImagemUsuario_Load(PictureBox Usuario, ref bool falha)
        {
            try
            {
                BLTerminal objBlTerminal = new BLTerminal();
                BLLogin objBlLogin = new BLLogin();
                int idterminal;
                DataTable usuario;

                try
                {
                    idterminal = objBlTerminal.BuscaTerminalPorMac(BLNetworkAdapter.Mac);

                    if (idterminal != -1)
                    {
                        usuario = objBlLogin.PegaUsuarioLogado(idterminal);
                        var row = usuario.Rows[0];

                        Usuario.Image = ConverteByte_Imagem((byte[])row["ImagemPessoa"]);
                        Usuario.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                }
                catch (Exception)
                {
                }
                
            }
            catch (Exception erro)
            {
                var Mensagem = new frmMessage_Box(erro.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }

        public void CarregaLogo_Home(PictureBox picBox)
        {
            BLGeral objGeral = new BLGeral();
            picBox.Image = ConverteByte_Imagem(objGeral.BuscaLogo_Home()) != null
                                                                          ? ConverteByte_Imagem(objGeral.BuscaLogo_Home())
                                                                          : Resources.Imagem_100;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void CarregaLogo_Descanso(Panel picBox)
        {
            BLGeral objGeral = new BLGeral();
            picBox.BackgroundImage = ConverteByte_Imagem(objGeral.BuscaLogo_Descanso()) != null
                                                                                        ? ConverteByte_Imagem(objGeral.BuscaLogo_Descanso())
                                                                                        : Resources.Imagem_100;
        }

        //============================== BUSCAR IMAGEM ===========================   

        //procura imagem na maquina e redimenciona para exibir no pictureBox
        public void BuscaImagem_Redimencionada(PictureBox picBox)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Abrir Foto";
            dlg.Filter = "JPG (*.jpg)|*.jpg"
                + "|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(dlg.OpenFile());
                    picBox.Image = new Bitmap(bmp, picBox.Size);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dlg.Dispose();

        }

        //procura imagem na maquina tamanho original para exibir no pictureBox
        public void BuscaImagem_Original(PictureBox picBox)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Abrir Foto";
            dlg.Filter = "JPG (*.jpg)|*.jpg"
                + "|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picBox.Image = new Bitmap(dlg.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dlg.Dispose();
        }

        //================================= CONVERTE IMAGENS =====================

        //converte de imagem para byte
        public byte[] ConverteImagem_Byte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        //converte de byte para de imagem
        public Image ConverteByte_Imagem(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public void CPF_CNPJ(object sender, ref bool resultado, ref ModPessoas dados)
        {
            var msk = (sender as MaskedTextBox);

            string documento = Regex.Replace(msk.Text, "[^0-9]", string.Empty);

            if (documento.Length < 11 && !string.IsNullOrEmpty(documento) && msk.Tag.ToString() == "CPF")
            {
                var Mensagem = new frmMessage_Box("O CPF não está completo. Verifique se digitou todos os números.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                msk.Clear();
                msk.Focus();
            }
            else if (documento.Length < 14 && !string.IsNullOrEmpty(documento) && msk.Tag.ToString() == "CNPJ")
            {
                var Mensagem = new frmMessage_Box("O CNPJ não está completo. Verifique se digitou todos os números.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                Mensagem.ShowDialog();
                msk.Clear();
                msk.Focus();
            }
            else
            {
                if (clsValidacao.isCPFCNPJ(documento, true))
                {
                    if (!objBlGeral.Verifica_Pessoa_Existe(Convert.ToInt64(documento == string.Empty ? "0" : documento)))
                    {
                        return;
                    }
                    else
                    {
                        if (msk.Tag.ToString() == "CPF")
                        {
                            var Mensagem = new frmMessage_Box("Esse CPF já possui dados no sistema. Deseja utilizar esses dados.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                            if (Mensagem.ShowDialog() == DialogResult.No)
                                return;

                            dados = objBlGeral.Busca_Dados_Pessoa_CPF(Convert.ToInt64(documento));
                            resultado = true;
                        }
                        else if (msk.Tag.ToString() == "CNPJ")
                        {
                            var Mensagem = new frmMessage_Box("Esse CNPJ já possui dados no sistema. Deseja utilizar esses dados.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.YesNo, frmMessage_Box.enumMessageIcon.Question);
                            if (Mensagem.ShowDialog() == DialogResult.No)
                                return;

                            dados = objBlGeral.Busca_Dados_Pessoa_CPF(Convert.ToInt64(documento));
                            resultado = true;
                        }
                    }
                }
                else
                {
                    if (msk.Tag.ToString() == "CPF")
                    {
                        var Mensagem = new frmMessage_Box("Insira um CPF válido.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        msk.Clear();
                        msk.Focus();
                    }
                    else if (msk.Tag.ToString() == "CNPJ")
                    {
                        var Mensagem = new frmMessage_Box("Insira um CNPJ válido.", "SysPark - ATENÇÃO", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Warning);
                        Mensagem.ShowDialog();
                        msk.Clear();
                        msk.Focus();
                    }

                }
            }
        }
    }
}
