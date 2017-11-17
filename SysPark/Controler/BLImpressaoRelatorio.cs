using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using SysPark.Controler;
using SysPark;

namespace SysPark.Controler
{
    public class BLImpressaoRelatorio
    {
        private PrintDocument ptrDocument = new PrintDocument();
        BLGeral objBlGeral = new BLGeral();
        ModGeral objModGeral = new ModGeral();
        BLGrupo objBlGrupo = new BLGrupo();
        private DataTable dtRelatorio = null;
        private string dataInicio,
                       dataFim,
                       grupo,
                       subgrupo,
                       tipo;
        private int qtdLinhas = 0;
        private int linhasporPagina = 0;
        private int pagina = 0;
        private int linha = 0;
        private int sublinha = 0;

        //formatação do texto da impressão
        private Font fontEmpresa = new Font("Century Gothic", 20, FontStyle.Bold);
        private Font fontTitulo = new Font("Century Gothic", 15, FontStyle.Bold);
        private Font fontLarge = new Font("Century Gothic", 12, FontStyle.Bold);
        private Font fontText = new Font("Century Gothic", 9, FontStyle.Regular);
        private Font fontTextBold = new Font("Century Gothic", 9, FontStyle.Bold);
        private StringFormat sfCenter = new StringFormat { Alignment = StringAlignment.Center };
        private StringFormat sfRight = new StringFormat { Alignment = StringAlignment.Far };
        private StringFormat sfLeft = new StringFormat { Alignment = StringAlignment.Near };

        //imprimi linha dr traço 
        private void CaractereSeparadorTraco(PrintPageEventArgs ev, PointF pt)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            using (var myPen = new Pen(Brushes.Black, 2))
            {
                myPen.DashStyle = DashStyle.Dash;

                ev.Graphics.DrawLine(myPen, pt.X, pt.Y, pt.X + ev.PageSettings.PrintableArea.Width, pt.Y);
            }
        }

        private void CaractereSeparadorTracoMargin(PrintPageEventArgs ev, PointF pt)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            using (var myPen = new Pen(Brushes.Black, 2))
            {
                myPen.DashStyle = DashStyle.Dash;

                ev.Graphics.DrawLine(myPen, leftMargin, pt.Y, pt.X + rightMargin, pt.Y);
            }
        }

        //imprimi linha continua
        private void CaractereSeparadorLinha(PrintPageEventArgs ev, PointF pt)
        {
            using (var myPen = new Pen(Brushes.Black, 2))
            {
                myPen.DashStyle = DashStyle.Solid;

                ev.Graphics.DrawLine(myPen, pt.X, pt.Y, pt.X + ev.PageSettings.PrintableArea.Width, pt.Y);
            }
        }

        private void CaractereSeparadorLinhaMargin(PrintPageEventArgs ev, PointF pt)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            using (var myPen = new Pen(Brushes.Black, 2))
            {
                myPen.DashStyle = DashStyle.Solid;

                ev.Graphics.DrawLine(myPen, leftMargin, pt.Y, pt.X + rightMargin, pt.Y);
            }
        }

        //atualiza a posição do texto
        private PointF AtualizaPonto(PointF pt, float incrementoX, float incrementoY)
        {
            var ptNew = new PointF(pt.X + incrementoX, pt.Y + incrementoY);
            return ptNew;
        }

        //converte de byte para de imagem
        public Image ConverteByte_Imagem(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        #region NOVA IMPRESSAO ALINHADA
        //// for PrintDialog, PrintPreviewDialog and PrintDocument:
        //private System.Windows.Forms.PrintDialog prnDialog;
        //private System.Windows.Forms.PrintPreviewDialog prnPreview;
        //private System.Drawing.Printing.PrintDocument prnDocument;
        //private System.ComponentModel.Container components = null;

        //// for Invoice Head:
        //private string InvTitle;
        //private string InvSubTitle1;
        //private string InvSubTitle2;
        //private string InvSubTitle3;
        //private string InvImage;

        //// for Database:
        ////private OleDbConnection cnn;
        ////private OleDbCommand cmd;
        ////private OleDbDataReader rdrInvoice;
        ////private string strCon;
        ////private string InvSql;

        //// for Report:
        //private int CurrentY;
        //private int CurrentX;
        //private int leftMargin;
        //private int rightMargin;
        //private int topMargin;
        //private int bottomMargin;
        //private int InvoiceWidth;
        //private int InvoiceHeight;
        //private string CustomerName;
        //private string CustomerCity;
        //private string SellerName;
        //private string SaleID;
        //private string SaleDate;
        //private decimal SaleFreight;
        //private decimal SubTotal;
        //private decimal InvoiceTotal;
        //private bool ReadInvoice;
        //private int AmountPosition;

        //// Font and Color:------------------
        //// Title Font
        //private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        //// Title Font height
        //private int InvTitleHeight;
        //// SubTitle Font
        //private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        //// SubTitle Font height
        //private int InvSubTitleHeight;
        //// Invoice Font
        //private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //// Invoice Font height
        //private int InvoiceFontHeight;
        //// Blue Color
        //private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        //// Red Color
        //private SolidBrush RedBrush = new SolidBrush(Color.Red);
        //// Black Color
        //private SolidBrush BlackBrush = new SolidBrush(Color.Black);

        //private void ReadInvoiceHead(PrintPageEventArgs ev)
        //{

        //    //var dtEmpresa = objBlGeral.BuscaInformacoes();
        //    //var row = dtEmpresa.Rows[0];
        //    //InvTitle = row["NomeFantasia"].ToString();
        //    //InvSubTitle1 = "Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"];
        //    //InvSubTitle2 = "Cairo, Egypt";
        //    //InvSubTitle3 = "Phone 2233445566";
        //}

        //private void SetInvoiceHead(Graphics g)
        //{
        //    //ReadInvoiceHead();

        //    CurrentY = topMargin;
        //    CurrentX = leftMargin;
        //    int ImageHeight = 0;

        //    // Draw Invoice image:
        //    //if (System.IO.File.Exists(InvImage))
        //    //{
        //    //    Bitmap oInvImage = new Bitmap(InvImage);
        //    //    // Set Image Left to center Image:
        //    //    int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
        //    //    ImageHeight = oInvImage.Height; // Get Image Height
        //    //    g.DrawImage(oInvImage, xImage, CurrentY);
        //    //}

        //    InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
        //    InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

        //    // Get Titles Length:
        //    int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
        //    int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
        //    int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
        //    int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
        //    // Set Titles Left:
        //    int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
        //    int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
        //    int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
        //    int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;

        //    // Draw Invoice Head:
        //    if (InvTitle != "")
        //    {
        //        CurrentY = CurrentY + ImageHeight;
        //        g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
        //    }
        //    if (InvSubTitle1 != "")
        //    {
        //        CurrentY = CurrentY + InvTitleHeight;
        //        g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
        //    }
        //    if (InvSubTitle2 != "")
        //    {
        //        CurrentY = CurrentY + InvSubTitleHeight;
        //        g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
        //    }
        //    if (InvSubTitle3 != "")
        //    {
        //        CurrentY = CurrentY + InvSubTitleHeight;
        //        g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
        //    }

        //    // Draw line:
        //    CurrentY = CurrentY + InvSubTitleHeight + 8;
        //    g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        //}
        #endregion

        #region    RELATORIO CAIXA
        //============== RELATORIO CAIXA =====================
        public void EmiteRelatorioCaixa(DataTable dt, string dInicio, string dFim)
        {
            dtRelatorio = dt;
            dataInicio = dInicio;
            dataFim = dFim;

            try
            {
                ptrDocument.PrintPage += RelatorioCaixa_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioCaixa_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;
            linhasporPagina = 7;

            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];
               
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 2);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== FIM DO CABEÇALHO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                ev.Graphics.DrawString("Relatório Caixa", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                ev.Graphics.DrawString("Movimento: " + dataInicio + " - " + dataFim, fontTextBold, Brushes.Blue, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                //=================== DADOS =========================

                while (linha < dtRelatorio.Rows.Count)
                {
                    //===== nome das colunas
                    ev.Graphics.DrawString("OPERADOR: " + dtRelatorio.Rows[linha]["Operador"] + " - " + dtRelatorio.Rows[linha]["Terminal"], fontTextBold, Brushes.Black, leftMargin, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                    ev.Graphics.DrawString("Data: " + dtRelatorio.Rows[linha]["Fechamento"], fontTextBold, Brushes.Blue, leftMargin, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                    ev.Graphics.DrawString("Hora: " + dtRelatorio.Rows[linha]["Hora Abertura"] + " - " + dtRelatorio.Rows[linha]["Hora Fechamento"], fontTextBold, Brushes.Blue, leftMargin, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    int xValores = leftMargin;
                    ev.Graphics.DrawString(" ", fontTextBold, Brushes.Black, xValores, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro = xValores + (int)g.MeasureString("DINHEIRO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DINHEIRO", fontTextBold, Brushes.Black, xDinheiro, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("CRÉDITO", fontTextBold, Brushes.Black, xCredito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("DÉBITO", fontTextBold, Brushes.Black, xDebito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("CHEQUE", fontTextBold, Brushes.Black, xCheque, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("TICKET", fontTextBold, Brushes.Black, xTicket, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotal = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("TOTAL", fontTextBold, Brushes.Black, xTotal, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);


                    //=========  linha dos valores registrados
                    ev.Graphics.DrawString("REGISTRADO", fontTextBold, Brushes.Black, xValores, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro2 = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width;
                    xDinheiro2 = xDinheiro2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Dinheiro Registrado"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Dinheiro Registrado"].ToString(), fontText, Brushes.Black, xDinheiro2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito2 = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width;
                    xCredito2 = xCredito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Crédito Registrado"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Crédito Registrado"].ToString(), fontText, Brushes.Black, xCredito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito2 = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width;
                    xDebito2 = xDebito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Débito Registrado"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Débito Registrado"].ToString(), fontText, Brushes.Black, xDebito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque2 = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width;
                    xCheque2 = xCheque2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Cheque Registrado"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cheque Registrado"].ToString(), fontText, Brushes.Black, xCheque2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket2 = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width;
                    xTicket2 = xTicket2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Ticket Registrado"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Ticket Registrado"].ToString(), fontText, Brushes.Black, xTicket2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotal2 = xTotal + (int)g.MeasureString("TOTAL", fontTextBold).Width;
                    xTotal2 = xTotal2 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]).ToString(), fontTextBold).Width;
                    ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]).ToString(), fontText, Brushes.Black, xTotal2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    //linha dos valores conferidos
                    ev.Graphics.DrawString("CONFERIDO", fontTextBold, Brushes.Black, xValores, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro3 = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width;
                    xDinheiro3 = xDinheiro3 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Dinheiro Real"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Dinheiro Real"].ToString(), fontText, Brushes.Black, xDinheiro3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito3 = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width;
                    xCredito3 = xCredito3 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Crédito Real"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Crédito Real"].ToString(), fontText, Brushes.Black, xCredito3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito3 = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width;
                    xDebito3 = xDebito3 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Débito Real"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Débito Real"].ToString(), fontText, Brushes.Black, xDebito3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque3 = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width;
                    xCheque3 = xCheque3 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Cheque Real"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cheque Real"].ToString(), fontText, Brushes.Black, xCheque3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket3 = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width;
                    xTicket3 = xTicket3 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Ticket Real"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Ticket Real"].ToString(), fontText, Brushes.Black, xTicket3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotal3 = xTotal + (int)g.MeasureString("TOTAL", fontTextBold).Width;
                    xTotal3 = xTotal3 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]).ToString(), fontTextBold).Width;
                    ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]).ToString(), fontText, Brushes.Black, xTotal3, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    // lonha dos valores de diferença
                    ev.Graphics.DrawString("DIFERENÇA", fontTextBold, Brushes.Black, xValores, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro4 = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width;
                    xDinheiro4 = xDinheiro4 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] - (decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"]).ToString().ToString(), fontText).Width;
                    if (((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] - (decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"]) < 0)
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] - (decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"]).ToString(), fontText, Brushes.Red, xDinheiro4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] - (decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"]).ToString(), fontText, Brushes.Black, xDinheiro4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito4 = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width;
                    xCredito4 = xCredito4 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Crédito Real"] - (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"]).ToString(), fontText).Width;
                    if (((decimal)dtRelatorio.Rows[linha]["Crédito Real"] - (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"]) < 0)
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Crédito Real"] - (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"]).ToString(), fontText, Brushes.Red, xCredito4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Crédito Real"] - (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"]).ToString(), fontText, Brushes.Black, xCredito4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito4 = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width;
                    xDebito4 = xDebito4 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Débito Real"] - (decimal)dtRelatorio.Rows[linha]["Débito Registrado"]).ToString(), fontText).Width;
                    if (((decimal)dtRelatorio.Rows[linha]["Débito Real"] - (decimal)dtRelatorio.Rows[linha]["Débito Registrado"]) < 0)
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Débito Real"] - (decimal)dtRelatorio.Rows[linha]["Débito Registrado"]).ToString(), fontText, Brushes.Red, xDebito4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Débito Real"] - (decimal)dtRelatorio.Rows[linha]["Débito Registrado"]).ToString(), fontText, Brushes.Black, xDebito4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque4 = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width;
                    xCheque4 = xCheque4 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Cheque Real"] - (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"]).ToString(), fontText).Width;
                    if (((decimal)dtRelatorio.Rows[linha]["Cheque Real"] - (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"]) < 0)
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Cheque Real"] - (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"]).ToString(), fontText, Brushes.Red, xCheque4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Cheque Real"] - (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"]).ToString(), fontText, Brushes.Black, xCheque4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket4 = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width;
                    xTicket4 = xTicket4 - (int)g.MeasureString(((decimal)dtRelatorio.Rows[linha]["Ticket Real"] - (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]).ToString(), fontText).Width;
                    if (((decimal)dtRelatorio.Rows[linha]["Ticket Real"] - (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]) < 0)
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Ticket Real"] - (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]).ToString(), fontText, Brushes.Red, xTicket4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString(((decimal)dtRelatorio.Rows[linha]["Ticket Real"] - (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"]).ToString(), fontText, Brushes.Black, xTicket4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotal4 = xTotal + (int)g.MeasureString("TOTAL", fontTextBold).Width;
                    xTotal4 = xTotal4 - (int)g.MeasureString((((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]) - ((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"])).ToString(), fontTextBold).Width;

                    if ((((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]) - ((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"])) < 0)
                        ev.Graphics.DrawString((((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]) - ((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"])).ToString(), fontText, Brushes.Red, xTotal4, ptPrintableArea.Y);
                    else
                        ev.Graphics.DrawString((((decimal)dtRelatorio.Rows[linha]["Dinheiro Real"] + (decimal)dtRelatorio.Rows[linha]["Crédito Real"] + (decimal)dtRelatorio.Rows[linha]["Débito Real"] + (decimal)dtRelatorio.Rows[linha]["Cheque Real"] + (decimal)dtRelatorio.Rows[linha]["Ticket Real"]) - ((decimal)dtRelatorio.Rows[linha]["Dinheiro Registrado"] + (decimal)dtRelatorio.Rows[linha]["Crédito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Débito Registrado"] + (decimal)dtRelatorio.Rows[linha]["Cheque Registrado"] + (decimal)dtRelatorio.Rows[linha]["Ticket Registrado"])).ToString(), fontText, Brushes.Black, xTotal4, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    CaractereSeparadorTracoMargin(ev, ptPrintableArea);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                    qtdLinhas += 1;
                    linha++;

                    if (qtdLinhas < linhasporPagina)
                    {
                        ev.HasMorePages = false;
                    }
                    else
                    {
                        ev.HasMorePages = true;
                        qtdLinhas = 0;
                        return;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region RELATORIO ESTOQUE

        //============== RELATORIO ESTOQUE =====================
        public void RelatorioEstoque(DataTable dt, string gr, string sub)
        {
            dtRelatorio = dt;
            grupo = gr;
            subgrupo = sub;

            try
            {
                ptrDocument.PrintPage += RelatorioEstoque_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioEstoque_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;            
            int sublinhasporPagina = 3;            
            int qtdsubLinhas = 0;

            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];
               
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 2);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== TIPO DE RELATORIO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                ev.Graphics.DrawString("Relatório de Estoque", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                //=================== COLUNAS =========================   

                string texto = "";
                while (sublinha < dtRelatorio.Rows.Count)
                {
                    if (texto != dtRelatorio.Rows[sublinha]["SubGrupo"].ToString())
                    {
                        ev.Graphics.DrawString("Grupo: " + dtRelatorio.Rows[sublinha]["Grupo"].ToString() + " - SubGrupo: " + dtRelatorio.Rows[sublinha]["SubGrupo"].ToString(), fontTextBold, Brushes.Blue, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                        int xProduto = leftMargin;
                        ev.Graphics.DrawString("PRODUTO", fontTextBold, Brushes.Black, xProduto, ptPrintableArea.Y);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                        int xCodigo = xProduto + (int)g.MeasureString("PRODUTO", fontTextBold).Width + 180;
                        ev.Graphics.DrawString("CÓDIGO", fontTextBold, Brushes.Black, xCodigo, ptPrintableArea.Y);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                        int xQtdSistema = xCodigo + (int)g.MeasureString("CÓDIGO", fontTextBold).Width + 60;
                        ev.Graphics.DrawString("QTD SISTEMA", fontTextBold, Brushes.Black, xQtdSistema, ptPrintableArea.Y);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                        int xGrade = xQtdSistema + (int)g.MeasureString("QTD SISTEMA", fontTextBold).Width + 40;
                        ev.Graphics.DrawString("GRADE", fontTextBold, Brushes.Black, xGrade, ptPrintableArea.Y);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                        int xQtdContada = xGrade + (int)g.MeasureString("GRADE", fontTextBold).Width + 25;
                        ev.Graphics.DrawString("QTD CONTADA", fontTextBold, Brushes.Black, xQtdContada, ptPrintableArea.Y);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                        CaractereSeparadorTracoMargin(ev, ptPrintableArea);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                        linha = 0;
                        qtdLinhas = 0;

                        // ===================== DADOS ===============================
                        while (linha < dtRelatorio.Rows.Count)
                        {
                            if (dtRelatorio.Rows[sublinha]["SubGrupo"].ToString() == dtRelatorio.Rows[linha]["SubGrupo"].ToString())
                            {
                                ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Produto"].ToString(), fontText, Brushes.Black, xProduto, ptPrintableArea.Y);
                                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                                ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Código"].ToString(), fontText, Brushes.Black, xCodigo, ptPrintableArea.Y);
                                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                                int xQtdSistema2 = xQtdSistema + (int)g.MeasureString("QTD SISTEMA", fontTextBold).Width;
                                xQtdSistema2 = xQtdSistema2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Estoque"].ToString(), fontTextBold).Width;
                                ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Estoque"].ToString(), fontText, Brushes.Black, xQtdSistema2, ptPrintableArea.Y);
                                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                                int xGrade2 = xGrade + (int)g.MeasureString("GRADE", fontTextBold).Width;
                                xGrade2 = xGrade2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Grade"].ToString(), fontTextBold).Width;
                                ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Grade"].ToString(), fontText, Brushes.Black, xGrade2, ptPrintableArea.Y);
                                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                                int xQtdContada2 = xQtdContada + (int)g.MeasureString("QTD CONTADA", fontTextBold).Width;
                                xQtdContada2 = xQtdContada2 - (int)g.MeasureString("___________", fontTextBold).Width;
                                ev.Graphics.DrawString("___________", fontText, Brushes.Black, xQtdContada2, ptPrintableArea.Y);
                                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                                linha++;
                                qtdLinhas++;                                
                            }
                            else
                            {
                                linha++;                                
                            }
                        }
                        CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                        texto = dtRelatorio.Rows[sublinha]["SubGrupo"].ToString();

                        sublinha++;
                        qtdsubLinhas++;
                        linhasporPagina += sublinhasporPagina + qtdLinhas;

                        if (linhasporPagina < 60)
                        {
                            ev.HasMorePages = false;
                        }
                        else
                        {
                            ev.HasMorePages = true;                           
                            linhasporPagina = 0;                            
                            return;
                        }
                    }
                    else
                    {
                        sublinha++;
                    }
                }
                linha = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region  RELATORIO MAIS OU MENOS VENDIDOS

        //=================== RELATORIO DE VENDA DE ITENS ==================
        public void RelatorioVendaItens(DataTable dt, string Tipo)
        {
            dtRelatorio = dt;
            tipo = Tipo;

            try
            {
                ptrDocument.PrintPage += RelatorioVendaItens_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioVendaItens_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;
            linhasporPagina = 60;

            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];
                               
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 2);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== TIPO DE RELATORIO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                if (tipo == "Mais")
                    ev.Graphics.DrawString("Relatório Itens Mais Vendidos", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                            sfCenter);
                else
                    ev.Graphics.DrawString("Relatório Itens Menos Vendidos", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                //=================== COLUNAS =========================   

                int xProduto = leftMargin;
                ev.Graphics.DrawString("PRODUTO", fontTextBold, Brushes.Black, xProduto, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                int xQtdSistema = xProduto + (int)g.MeasureString("PRODUTO", fontTextBold).Width + 150;
                ev.Graphics.DrawString("QTD", fontTextBold, Brushes.Black, xQtdSistema, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                int xValor = xQtdSistema + (int)g.MeasureString("QTD", fontTextBold).Width + 40;
                ev.Graphics.DrawString("VALOR", fontTextBold, Brushes.Black, xValor, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                int xCodigo = xValor + (int)g.MeasureString("VALOR", fontTextBold).Width + 20;
                ev.Graphics.DrawString("CÓDIGO", fontTextBold, Brushes.Black, xCodigo, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                int xGrupo = xCodigo + (int)g.MeasureString("CÓDIGO", fontTextBold).Width + 50;
                ev.Graphics.DrawString("GRUPO", fontTextBold, Brushes.Black, xGrupo, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                int xSubGrupo = xGrupo + (int)g.MeasureString("GRUPO", fontTextBold).Width + 50;
                ev.Graphics.DrawString("SUBGRUPO", fontTextBold, Brushes.Black, xSubGrupo, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                // ===================== DADOS ===============================
                while (linha < dtRelatorio.Rows.Count)
                {
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Produto"].ToString().Length >= 25
                                           ? dtRelatorio.Rows[linha]["Produto"].ToString().Substring(0, 25)
                                           : dtRelatorio.Rows[linha]["Produto"].ToString(), fontText, Brushes.Black, xProduto, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xQtdSistema2 = xQtdSistema + (int)g.MeasureString("QTD", fontTextBold).Width;
                    xQtdSistema2 = xQtdSistema2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Qtd"].ToString(), fontTextBold).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Qtd"].ToString(), fontText, Brushes.Black, xQtdSistema2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xValor2 = xValor + (int)g.MeasureString("VALOR", fontTextBold).Width;
                    xValor2 = xValor2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontTextBold).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontText, Brushes.Black, xValor2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Código"].ToString(), fontText, Brushes.Black, xCodigo, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Grupo"].ToString().Length >= 13
                                           ? dtRelatorio.Rows[linha]["Grupo"].ToString().Substring(0, 13)
                                           : dtRelatorio.Rows[linha]["Grupo"].ToString(), fontText, Brushes.Black, xGrupo, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["SubGrupo"].ToString().Length >= 13
                                           ? dtRelatorio.Rows[linha]["SubGrupo"].ToString().Substring(0, 13)
                                           : dtRelatorio.Rows[linha]["SubGrupo"].ToString(), fontText, Brushes.Black, xSubGrupo, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    qtdLinhas++;
                    linha++;

                    if (qtdLinhas < linhasporPagina)
                    {
                        ev.HasMorePages = false;
                    }
                    else
                    {
                        ev.HasMorePages = true;
                        qtdLinhas = 0;
                        CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                        ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);
                        return;
                    }
                }

                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);
                linha = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region RELATORIO VENDAS VALORES

        public void RelatorioVendaValores(DataTable dt, string Tipo, string dInicio, string dFim)
        {
            dtRelatorio = dt;
            tipo = Tipo;
            dataInicio = dInicio;
            dataFim = dFim;

            try
            {
                ptrDocument.PrintPage += RelatorioVendaValores_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioVendaValores_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;
            linhasporPagina = 12;


            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 1);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== TIPO DE RELATORIO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                if (tipo == "Maiores")
                    ev.Graphics.DrawString("Relatório das Maiores Vendas", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                            sfCenter);
                else
                    ev.Graphics.DrawString("Relatório das Menores Vendas", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                ev.Graphics.DrawString("Vendas entre: " + dataInicio + " - " + dataFim, fontTextBold, Brushes.Blue, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                while (linha < dtRelatorio.Rows.Count)
                {
                    //=================== COLUNAS 1 =========================                                          

                    int xVenda = leftMargin;
                    ev.Graphics.DrawString("ID VENDA", fontTextBold, Brushes.Black, xVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xOperador = xVenda + (int)g.MeasureString("ID VENDA", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("OPERADOR", fontTextBold, Brushes.Black, xOperador, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTerminal = xOperador + (int)g.MeasureString("OPERADOR", fontTextBold).Width + 120;
                    ev.Graphics.DrawString("TERMINAL", fontTextBold, Brushes.Black, xTerminal, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xItens = xTerminal + (int)g.MeasureString("TERMINAL", fontTextBold).Width + 70;
                    ev.Graphics.DrawString("ITENS", fontTextBold, Brushes.Black, xItens, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xData = xItens + (int)g.MeasureString("ITENS", fontTextBold).Width + 20;
                    ev.Graphics.DrawString("DATA", fontTextBold, Brushes.Black, xData, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xHora = xData + (int)g.MeasureString("DATA", fontTextBold).Width + 50;
                    ev.Graphics.DrawString("HORA", fontTextBold, Brushes.Black, xHora, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    // ============================= DADOS 1 ===============================

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cód. Venda"].ToString(), fontText, Brushes.Black, xVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Operador"].ToString().Length >= 25
                                           ? dtRelatorio.Rows[linha]["Operador"].ToString().Substring(0, 25)
                                           : dtRelatorio.Rows[linha]["Operador"].ToString(), fontText, Brushes.Black, xOperador, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Terminal"].ToString().Length >= 15
                                           ? dtRelatorio.Rows[linha]["Terminal"].ToString().Substring(0, 15)
                                           : dtRelatorio.Rows[linha]["Terminal"].ToString(), fontText, Brushes.Black, xTerminal, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Itens"].ToString(), fontText, Brushes.Black, xItens, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Data"].ToString(), fontText, Brushes.Black, xData, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Hora"].ToString(), fontText, Brushes.Black, xHora, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    //============================= COLUNAS 2 =============================

                    int xValorVenda = leftMargin;
                    ev.Graphics.DrawString("VL VENDA", fontTextBold, Brushes.Black, xValorVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro = xValorVenda + (int)g.MeasureString("VL VENDA", fontTextBold).Width + 60;
                    ev.Graphics.DrawString("DINHEIRO", fontTextBold, Brushes.Black, xDinheiro, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width + 60;
                    ev.Graphics.DrawString("DÉBITO", fontTextBold, Brushes.Black, xDebito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width + 60;
                    ev.Graphics.DrawString("CRÉDITO", fontTextBold, Brushes.Black, xCredito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width + 65;
                    ev.Graphics.DrawString("CHEQUE", fontTextBold, Brushes.Black, xCheque, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width + 65;
                    ev.Graphics.DrawString("TICKET", fontTextBold, Brushes.Black, xTicket, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    //============================== VALORES ================================

                    int xValorVenda2 = xValorVenda + (int)g.MeasureString("VL VENDA", fontTextBold).Width;
                    xValorVenda2 = xValorVenda2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontText, Brushes.Black, xValorVenda2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro2 = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width;
                    xDinheiro2 = xDinheiro2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Dinheiro"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Dinheiro"].ToString(), fontText, Brushes.Black, xDinheiro2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito2 = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width;
                    xCredito2 = xCredito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Crédito"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Crédito"].ToString(), fontText, Brushes.Black, xCredito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito2 = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width;
                    xDebito2 = xDebito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Débito"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Débito"].ToString(), fontText, Brushes.Black, xDebito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque2 = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width;
                    xCheque2 = xCheque2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Cheque"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cheque"].ToString(), fontText, Brushes.Black, xCheque2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket2 = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width;
                    xTicket2 = xTicket2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Ticket"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Ticket"].ToString(), fontText, Brushes.Black, xTicket2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    CaractereSeparadorTracoMargin(ev, ptPrintableArea);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                    qtdLinhas += 1;
                    linha++;

                    if (qtdLinhas < linhasporPagina)
                    {
                        ev.HasMorePages = false;
                    }
                    else
                    {
                        ev.HasMorePages = true;                        
                        return;
                    }
                }
                linha = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region RELATORIO VENDAS CANCELADAS

        public void RelatorioVendasCanceladas(DataTable dt, string dInicio, string dFim)
        {            
            dtRelatorio = dt;           
            dataInicio = dInicio;
            dataFim = dFim;
            linha = 0;

            try
            {
                ptrDocument.PrintPage += RelatorioVendasCanceladas_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else 
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioVendasCanceladas_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;
            linhasporPagina = 10;


            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 1);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== TIPO DE RELATORIO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
               
                    ev.Graphics.DrawString("Relatório de Vendas Canceladas", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                ev.Graphics.DrawString("Cancelamentos entre: " + dataInicio + " - " + dataFim, fontTextBold, Brushes.Blue, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                while (linha < dtRelatorio.Rows.Count)
                {
                    //=================== DADOS DA VENDA =========================                                          

                    int xVenda = leftMargin;
                    ev.Graphics.DrawString("COD. VENDA:", fontTextBold, Brushes.Black, xVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xVenda2 = xVenda + (int)g.MeasureString("COD. VENDA:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cód. Venda"].ToString(), fontTextBold, Brushes.Blue, xVenda2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xItens = xVenda2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Cód. Venda"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("QTD. ITENS:", fontTextBold, Brushes.Black, xItens, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xItens2 = xItens + (int)g.MeasureString("QTD.ITENS:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Itens"].ToString(), fontTextBold, Brushes.Blue, xItens2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);                    

                    int xOperador = leftMargin;
                    ev.Graphics.DrawString("OPERADOR:", fontTextBold, Brushes.Black, xOperador, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xOperador2 = xOperador + (int)g.MeasureString("OPERADOR:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Operador"].ToString().Length >= 25
                                          ? dtRelatorio.Rows[linha]["Operador"].ToString().Substring(0, 25)
                                          : dtRelatorio.Rows[linha]["Operador"].ToString(), fontTextBold, Brushes.Blue, xOperador2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xOperadorCancel = xOperador2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Operador"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("OP. CANCELAMENTO:", fontTextBold, Brushes.Black, xOperadorCancel, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xOperadorCancel2 = xOperadorCancel + (int)g.MeasureString("OP. CANCELAMENTO:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString().Length >= 25
                                          ? dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString().Substring(0, 25)
                                          : dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString(), fontTextBold, Brushes.Blue, xOperadorCancel2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    int xTerminal = leftMargin; 
                    ev.Graphics.DrawString("TERMINAL:", fontTextBold, Brushes.Black, xTerminal, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xTerminal2 = xTerminal + (int)g.MeasureString("TERMINAL:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Terminal"].ToString().Length >= 15
                                           ? dtRelatorio.Rows[linha]["Terminal"].ToString().Substring(0, 15)
                                           : dtRelatorio.Rows[linha]["Terminal"].ToString(), fontTextBold, Brushes.Blue, xTerminal2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xData = xTerminal2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Terminal"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("DATA:", fontTextBold, Brushes.Black, xData, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xData2 = xData + (int)g.MeasureString("DATA:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Data"].ToString(), fontTextBold, Brushes.Blue, xData2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xHora = xData2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Data"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("HORA:", fontTextBold, Brushes.Black, xHora, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xHora2 = xHora + (int)g.MeasureString("HORA:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Hora"].ToString(), fontTextBold, Brushes.Blue, xHora2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);


                    //============================= VALORES DA VENDA =============================

                    int xValorVenda = leftMargin;
                    ev.Graphics.DrawString("VL VENDA", fontTextBold, Brushes.Black, xValorVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDesconto = xValorVenda + (int)g.MeasureString("VL VENDA", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DESCONTO", fontTextBold, Brushes.Black, xDesconto, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro = xDesconto + (int)g.MeasureString("DESCONTO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DINHEIRO", fontTextBold, Brushes.Black, xDinheiro, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DÉBITO", fontTextBold, Brushes.Black, xDebito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("CRÉDITO", fontTextBold, Brushes.Black, xCredito, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("CHEQUE", fontTextBold, Brushes.Black, xCheque, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("TICKET", fontTextBold, Brushes.Black, xTicket, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    //============================== VALORES ================================

                    int xValorVenda2 = xValorVenda + (int)g.MeasureString("VL VENDA", fontTextBold).Width;
                    xValorVenda2 = xValorVenda2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Valor Venda"].ToString(), fontText, Brushes.Black, xValorVenda2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDesconto2 = xDesconto + (int)g.MeasureString("DESCONTO", fontTextBold).Width;
                    xDesconto2 = xDesconto2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Desconto"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Desconto"].ToString(), fontText, Brushes.Black, xDesconto2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDinheiro2 = xDinheiro + (int)g.MeasureString("DINHEIRO", fontTextBold).Width;
                    xDinheiro2 = xDinheiro2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Dinheiro"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Dinheiro"].ToString(), fontText, Brushes.Black, xDinheiro2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCredito2 = xCredito + (int)g.MeasureString("CRÉDITO", fontTextBold).Width;
                    xCredito2 = xCredito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Crédito"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Crédito"].ToString(), fontText, Brushes.Black, xCredito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDebito2 = xDebito + (int)g.MeasureString("DÉBITO", fontTextBold).Width;
                    xDebito2 = xDebito2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Débito"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Débito"].ToString(), fontText, Brushes.Black, xDebito2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xCheque2 = xCheque + (int)g.MeasureString("CHEQUE", fontTextBold).Width;
                    xCheque2 = xCheque2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Cheque"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cheque"].ToString(), fontText, Brushes.Black, xCheque2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTicket2 = xTicket + (int)g.MeasureString("TICKET", fontTextBold).Width;
                    xTicket2 = xTicket2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Ticket"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Ticket"].ToString(), fontText, Brushes.Black, xTicket2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);

                    CaractereSeparadorTracoMargin(ev, ptPrintableArea);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                    qtdLinhas += 1;
                    linha++;

                    if (qtdLinhas < linhasporPagina)
                    {
                        ev.HasMorePages = false;
                    }
                    else
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }
                linha = 0;              
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region RELATORIO ITENS CANCELADOS

        //=================== RELATORIO DE ITENS CANCELADOS ==================
        public void RelatorioItensCancelados(DataTable dt, string dInicio, string dFim)
        {            
            dtRelatorio = dt;
            dataInicio = dInicio;
            dataFim = dFim;
            linha = 0;

            try
            {
                ptrDocument.PrintPage += RelatorioItensCancelados_PrintPage;

                if (ptrDocument.PrinterSettings.IsValid)
                {
                    ptrDocument.Print();
                }
                else
                {
                    Console.Beep();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var Mensagem = new frmShowMessage(erro.Message, "*****ALERTA*****", frmShowMessage.enumMessageButton.OK, frmShowMessage.enumMessageIcon.Error);
                //Mensagem.ShowDialog();
            }
        }

        private void RelatorioItensCancelados_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int leftMargin = (int)ev.MarginBounds.Left;
            int rightMargin = (int)ev.MarginBounds.Right;
            int topMargin = (int)ev.MarginBounds.Top;
            int bottomMargin = (int)ev.MarginBounds.Bottom;
            int InvoiceWidth = (int)ev.MarginBounds.Width;
            int InvoiceHeight = (int)ev.MarginBounds.Height;
            Graphics g = ev.Graphics;
            qtdLinhas = 0;
            linhasporPagina = 60;

            try
            {
                var ptPrintableArea = new PointF(ev.PageSettings.PrintableArea.X, ev.PageSettings.PrintableArea.Y);

                //============= CABEÇALHO DADOS DA EMPRESA ===================                
                var dtEmpresa = objBlGeral.BuscaInformacoes();
                var row = dtEmpresa.Rows[0];

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 1);

                Size newSize = new Size(100, 100);
                Bitmap ImageLogo = new Bitmap(ConverteByte_Imagem((byte[])row["LogoHome"]), newSize);
                int xImage = leftMargin;
                ev.Graphics.DrawImage(ImageLogo, xImage, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);

                int xEmpresa = xImage + ImageLogo.Width + 5;
                ev.Graphics.DrawString(row["NomeFantasia"].ToString(), fontEmpresa, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 30);
                ev.Graphics.DrawString("Endereço: " + row["Logradouro"] + " nº: " + row["NumeroEnd"] + " - " + row["Cidade"] + " - " + row["UF"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("TEL: " + row["Telefone"] + " - " + "CEL: " + row["Celular"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);
                ev.Graphics.DrawString("Email: " + row["Email"] + " - " + "Site: " + row["Website"], fontText, Brushes.Black, xEmpresa, ptPrintableArea.Y);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);

                //================== TIPO DE RELATORIO =============

                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                ev.Graphics.DrawString("Relatório de Itens Cancelados", fontTitulo, Brushes.Black, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                    sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 25);
                ev.Graphics.DrawString("Cancelamentos entre: " + dataInicio + " - " + dataFim, fontTextBold, Brushes.Blue, new RectangleF(ptPrintableArea, ev.PageSettings.PrintableArea.Size),
                        sfCenter);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);
                CaractereSeparadorLinhaMargin(ev, ptPrintableArea);
                ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                while (linha < dtRelatorio.Rows.Count)
                {
                    //=================== DADOS DO ITEM =========================                                          

                    int xBarras = leftMargin;
                    ev.Graphics.DrawString("COD. PRODUTO:", fontTextBold, Brushes.Black, xBarras, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xBarras2 = xBarras + (int)g.MeasureString("COD. PRODUTO:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Código"].ToString(), fontTextBold, Brushes.Blue, xBarras2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xProduto = xBarras2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Código"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("PRODUTO:", fontTextBold, Brushes.Black, xProduto, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xProduto2 = xProduto + (int)g.MeasureString("PRODUTO:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Produto"].ToString(), fontTextBold, Brushes.Blue, xProduto2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    int xOperador = leftMargin;
                    ev.Graphics.DrawString("OPERADOR:", fontTextBold, Brushes.Black, xOperador, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xOperador2 = xOperador + (int)g.MeasureString("OPERADOR:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Operador"].ToString().Length >= 25
                                          ? dtRelatorio.Rows[linha]["Operador"].ToString().Substring(0, 25)
                                          : dtRelatorio.Rows[linha]["Operador"].ToString(), fontTextBold, Brushes.Blue, xOperador2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xOperadorCancel = xOperador2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Operador"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("OP. CANCELAMENTO:", fontTextBold, Brushes.Black, xOperadorCancel, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xOperadorCancel2 = xOperadorCancel + (int)g.MeasureString("OP. CANCELAMENTO:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString().Length >= 25
                                          ? dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString().Substring(0, 25)
                                          : dtRelatorio.Rows[linha]["Op. Cancelamento"].ToString(), fontTextBold, Brushes.Blue, xOperadorCancel2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);

                    int xTerminal = leftMargin;
                    ev.Graphics.DrawString("TERMINAL:", fontTextBold, Brushes.Black, xTerminal, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xTerminal2 = xTerminal + (int)g.MeasureString("TERMINAL:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Terminal"].ToString().Length >= 15
                                           ? dtRelatorio.Rows[linha]["Terminal"].ToString().Substring(0, 15)
                                           : dtRelatorio.Rows[linha]["Terminal"].ToString(), fontTextBold, Brushes.Blue, xTerminal2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xIdVenda = xTerminal2 + (int)g.MeasureString(dtRelatorio.Rows[linha]["Terminal"].ToString(), fontTextBold).Width + 5;
                    ev.Graphics.DrawString("COD. VENDA:", fontTextBold, Brushes.Black, xIdVenda, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);
                    int xIdVenda2 = xIdVenda + (int)g.MeasureString("COD. VENDA:", fontTextBold).Width + 5;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Cód. Venda"].ToString(), fontTextBold, Brushes.Blue, xIdVenda2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);  

                    //============================= VALORES DO ITEM HEADER =============================

                    int xVlUnitario = leftMargin;
                    ev.Graphics.DrawString("VL UNITÁRIO", fontTextBold, Brushes.Black, xVlUnitario, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xQtd = xVlUnitario + (int)g.MeasureString("VL UNITÁRIO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("QUANTIDADE", fontTextBold, Brushes.Black, xQtd, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotalItem = xQtd + (int)g.MeasureString("QUANTIDADE", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("TOTAL ITEM", fontTextBold, Brushes.Black, xTotalItem, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDesconto = xTotalItem + (int)g.MeasureString("TOTAL ITEM", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DESCONTO", fontTextBold, Brushes.Black, xDesconto, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xData = xDesconto + (int)g.MeasureString("DESCONTO", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("DATA", fontTextBold, Brushes.Black, xData, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xHora = xData + (int)g.MeasureString("DATA", fontTextBold).Width + 40;
                    ev.Graphics.DrawString("HORA", fontTextBold, Brushes.Black, xHora, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 15);                    

                    //============================== VALORES ================================

                    int xVlUnitario2 = xVlUnitario + (int)g.MeasureString("VL UNITÁRIO", fontTextBold).Width;
                    xVlUnitario2 = xVlUnitario2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Vl. Unitário"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Vl. Unitário"].ToString(), fontText, Brushes.Black, xVlUnitario2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xQtd2 = xQtd + (int)g.MeasureString("QUANTIDADE", fontTextBold).Width;
                    xQtd2 = xQtd2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Qtd"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Qtd"].ToString(), fontText, Brushes.Black, xQtd2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xTotalItem2 = xTotalItem + (int)g.MeasureString("TOTAL ITEM", fontTextBold).Width;
                    xTotalItem2 = xTotalItem2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Valor Item"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Valor Item"].ToString(), fontText, Brushes.Black, xTotalItem2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xDesconto2 = xDesconto + (int)g.MeasureString("DESCONTO", fontTextBold).Width;
                    xDesconto2 = xDesconto2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Desconto"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Desconto"].ToString(), fontText, Brushes.Black, xDesconto2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xData2 = xData + (int)g.MeasureString("DATA", fontTextBold).Width;
                    xData2 = xData2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Data"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Data"].ToString(), fontText, Brushes.Black, xData2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 0);

                    int xHora2 = xHora + (int)g.MeasureString("HORA", fontTextBold).Width;
                    xHora2 = xHora2 - (int)g.MeasureString(dtRelatorio.Rows[linha]["Hora"].ToString(), fontText).Width;
                    ev.Graphics.DrawString(dtRelatorio.Rows[linha]["Hora"].ToString(), fontText, Brushes.Black, xHora2, ptPrintableArea.Y);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 20);                    

                    CaractereSeparadorTracoMargin(ev, ptPrintableArea);
                    ptPrintableArea = AtualizaPonto(ptPrintableArea, 0, 5);

                    qtdLinhas += 1;
                    linha++;

                    if (qtdLinhas < linhasporPagina)
                    {
                        ev.HasMorePages = false;
                    }
                    else
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }
                linha = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*****ALERTA*****", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
