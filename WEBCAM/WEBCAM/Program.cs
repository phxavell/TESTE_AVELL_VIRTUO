using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEBCAM
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ENVIAREPARO());
            Application.Run(new WEBCAM());

            //Para o Programa não abrir duas vezes
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("Programa já está sendo executado, não é necessário abrir novamente!",
                    "Testes Avell - Iformação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
