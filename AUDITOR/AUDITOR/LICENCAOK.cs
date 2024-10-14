using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace AUDITOR
{
    public partial class LICENCAOK : MaterialSkin.Controls.MaterialForm
    {
        public LICENCAOK()
        {
            InitializeComponent();
            TimeStart1();
            ChaveWindows();
        }

        public void TimeStart1()
        //Gera Auditoria.html
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 10;// 3segundos

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    this.Close();
                }
            };
            relogio.Start();
        }

        public void ChaveWindows()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string NomeArquivo = (string)obj["SerialNumber"];
                string pastaLogs = @"C:\TESTES_AVELL\MySqlData\" + NomeArquivo;
                {
                    string ChaveWindows = File.ReadAllText("C:\\TESTES_AVELL\\MySqlData\\" + NomeArquivo + "\\LincencaWindows.txt");
                    lblChave.Text = ChaveWindows;
                }
            }
        }
    }
}
