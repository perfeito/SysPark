using System;
using System.Threading;
using System.Windows.Forms;

namespace SysPark
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var LoginEntrada = new frmDescansoTela())
            {
                try
                {
                    Application.Run(LoginEntrada);
                }
                catch (Exception)
                {
                }                
            }

            //using (var frmDescanso = new frmDescansoTela())
            //{
            //    Application.Run(frmDescanso);
            //}
            return;
        }
    }
}
