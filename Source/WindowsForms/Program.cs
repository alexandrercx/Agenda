
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.ThreadException += (o, e) => MessageBox.Show(string.Format("Erro: {0}", e.Exception.Message), "ThreadException!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var culture = CultureInfo.GetCultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmConsulta = new FrmConsulta();
            Application.Run(frmConsulta);


        }
    }
}
