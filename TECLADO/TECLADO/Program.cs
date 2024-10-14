using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECLADO
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
            //Mudar esta linha para escolher qual projeto vai iniciar prioritariamente.
            Application.Run(new TESTETECLADO());
            //Application.Run(new TECLADO7());
            
            //Para o Programa não abrir duas vezes  ---- Temporariamente desabilitado
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
