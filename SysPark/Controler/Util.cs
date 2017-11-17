using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPark.Controler
{
    public static class Util
    {
        private static int check = 0;

        /*public enum Effect
        {
            Roll,
            Slide,
            Center,
            Blend
        }

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];

            if (ctl.Visible)
            {
                flags |= 0x10000;
                angle += 180;
            }
            else
            {
                if (ctl.TopLevelControl == ctl)
                    flags |= 0x20000;
                else if (effect == Effect.Blend)
                    throw new ArgumentException();

                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animação Falhou");
                ctl.Visible = !ctl.Visible;
            }
        }

        private static int[] dirmap = { 1, 2, 3, 4, 5, 7, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);*/

        public static void SlideMenu(Control menu, int height, int width_Fechado, int width_Aberto, int speed)
        {
            if (check == 0)
            {
                for (int i = width_Fechado; i <= width_Aberto; i += 5)
                {
                    menu.Size = new Size(i, height);

                    Thread.Sleep(speed);
                }
                check = 1;
            }
            else if (check == 1)
            {
                for (int i = width_Aberto; i >= width_Fechado; i -= 5)
                {
                    menu.Size = new Size(i, height);

                    Thread.Sleep(speed);
                }
                check = 0;
            }
        }

        public static void OpenForm(Type frmType)
        {
            try
            {
                bool bolCtl = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType().Equals(frmType))
                    {
                        form.Show();
                        bolCtl = true;
                        break;
                    }
                }

                if (!bolCtl)
                {
                    Form frm = (Form)Activator.CreateInstance(frmType);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                var Mensagem = new frmMessage_Box(ex.Message, "*****ALERTA*****", frmMessage_Box.enumMessageButton.OK, frmMessage_Box.enumMessageIcon.Error);
                Mensagem.ShowDialog();
            }
        }
    }
}
