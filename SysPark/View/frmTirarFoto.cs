using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysPark.View
{
    public partial class frmTirarFoto : Form
    {
        readonly clsFuncoesGenericas objBLFuncoesGenerica = new clsFuncoesGenericas();
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;
        private PictureBox webPictureBox;
        private byte[] fotoCamBytes;
        private Image fotoCamImage;


        public frmTirarFoto(PictureBox WebPictureBox)
        {
            InitializeComponent();

            this.webPictureBox = WebPictureBox;

            pnlTirarFoto.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            pnlTirarFoto.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            pnlTirarFoto.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            lblTiraFoto.MouseDown += objBLFuncoesGenerica.Form_MouseDown;
            lblTiraFoto.MouseMove += objBLFuncoesGenerica.Form_MouseMove;
            lblTiraFoto.MouseUp += objBLFuncoesGenerica.Form_MouseUp;

            AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);

            if (videosources != null)
            {
                videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosources[0].MonikerString);
                videoSource.NewFrame += (s, e) => pcbImagem.Image = (Bitmap)e.Frame.Clone();
                videoSource.Start();
            }
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

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            fotoCamBytes = ConverterFotoParaByteArray();

            fotoCamImage = objBLFuncoesGenerica.ConverteByte_Imagem(fotoCamBytes);

            webPictureBox.Image = new Bitmap(fotoCamImage, webPictureBox.Size);

            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pcbImagem.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void frmTirarFoto_Load(object sender, EventArgs e)
        {
            objBLFuncoesGenerica.Drop_Shadow(this);
        }
    }
}
