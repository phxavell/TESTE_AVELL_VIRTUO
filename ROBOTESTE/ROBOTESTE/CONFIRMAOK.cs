using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace ROBOTESTE
{
    public partial class CONFIRMAOK : MaterialSkin.Controls.MaterialForm
    {
        public string BurninOK;

        public CONFIRMAOK()
        {
            InitializeComponent();
            PararTestes();
            Interacao();
            //StartFireBaseServices();
            TimeStart();
        }

        public void PararTestes()
        {
            //Finaliza o processo após a confirmação
            try
            {
                string Burnin = "bit";
                var processes = Process.GetProcessesByName(Burnin);
                foreach (var BurninTeste in processes)
                BurninTeste.Kill();
                //Esse precisa ficar aqui porque ele abre a contagem para liberar para o proximo teste.
                LimparTemp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel finalizar o processo");
            }
        }

        public void LimparTemp()
        {
            //Metodo apaga pasta Temp1
            string caminhoPasta1 = @"C:\BurnInTest test files";
            if (Directory.Exists(caminhoPasta1))
            {
                try
                {
                    //MessageBox.Show("Limpez Temp:" + caminhoPasta1, "Limpeza Temp.");
                    string apagarPasta1 = @"C:\BurnInTest test files";
                    Directory.Delete(apagarPasta1, true);
                }
                catch { MessageBox.Show("Não foi possível apagar a pasta:" + caminhoPasta1); }
            }

            ////Metodo apaga pasta Temp2
            //string caminhoPasta2 = @"C:\scratchdir";
            //if (Directory.Exists(caminhoPasta2))
            //{
            //    try
            //    {
            //        string apagarPasta2 = @"C:\scratchdir";
            //        Directory.Delete(apagarPasta2, true);
            //    }
            //    catch { MessageBox.Show("Não foi possível apagar a pasta:" + caminhoPasta2); }
            //}

            ////Metodo apaga pasta Temp3
            //string caminhoPasta3 = @"C:\ESD";
            //if (Directory.Exists(caminhoPasta3))
            //{
            //    try
            //    {
            //        string apagarPasta3 = @"C:\ESD";
            //        Directory.Delete(apagarPasta3, true);
            //    }
            //    catch { MessageBox.Show("Não foi possível apagar a pasta:" + caminhoPasta3); }
            //}
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\BurninOK.mp3";
            wplayer.controls.play();
        }

        //Firebase
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            //Utilizando RealTimeDatabase do TestesAvell - OK Atualizado
            AuthSecret = "v3zyDmyUJC4sGsdGHHonCePdpxvaKLGu0IN8AAHb",
            BasePath = "https://database-5c3ab-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private object res;

        public void StartFireBaseServices()
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir os dados");
            }
        }
        //Firebase

        public void TimeStart()
        {
            if (BurninOK != "Active")
            //Adicionado variável para evitar loop
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 3;

                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();
                        BurninOK = "Active";
                        GerarLogIndividual();
                        CriarLog_MySQLOK();
                        ChamarProximoTeste();
                    }
                };
                relogio.Start();
            }
        }

        public void GerarLogIndividual()
        {
            try
            {
                //Gera Log de Instalado para os Drivers
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Drivers = @"C:\TESTES_AVELL_VIRTUO\logs_burnin\Burnin.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("TESTE BURNIN REALIZADO: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
            catch (Exception ex) { }
        }

        public void CriarLog_MySQLOK()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Furmark = "C:\\TESTES_AVELL_VIRTUO\\MySqlData\\" + NomeArquivo + "\\Burnin_OK.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("BURNIN OK: " + dataHoraMinutoOK);
                Arquivo.Close();
                break;
            }

            try
            {
                //Firebase - Atualizado
                var dataHoraMinuto = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
                ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS1.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoBurnin = "Burnin OK: " + dataHoraMinuto;
                    var teste = new Burnin
                    {
                        Serial = SerialAvell,
                        TBurnin = InfoBurnin
                    };
               //     FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoBurnin = string.Empty;
                    break;
                }
                //Firebase - Atualizado
            }
            catch
            {
                lblFirebase.Text = "Firebase Off-Line";
                lblFirebase.ForeColor = Color.Red;
            }
        }

        public void ChamarProximoTeste()
        {
            TECLADO.TESTETECLADO formAuditorStart = new TECLADO.TESTETECLADO();
            this.Hide();
            formAuditorStart.ShowDialog();
        }

        private void pictureBoxOK_Click(object sender, EventArgs e)
        {

        }

        private void panelOK_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
