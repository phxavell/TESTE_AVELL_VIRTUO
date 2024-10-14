using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;

namespace WIFI
{
    public partial class REPROVAFALHA : MaterialSkin.Controls.MaterialForm
    {
        public REPROVAFALHA()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            Verificador();
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

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL\logs_wifi", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor == 1)
            {
                //Chamar form, método mais eficiente.
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
            else
            {
                Interacao();
                CriarLogFalha();
            }
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\RepetirTeste.mp3";
            wplayer.controls.play();
        }

        public void CriarLogFalha()
        {
            try
            {
                var dataHoraMinuto = DateTime.Now.ToString("dd-MM-yyyy-HH-mms-s");
                System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL\logs_wifi\Falha" + dataHoraMinuto + ".log");
                sw2.WriteLine("Falha em Testes Dia:" + dataHoraMinuto);
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnReteste_Click_1(object sender, EventArgs e)
        {
            CriarLog_MySQLFalha();

            WIFI formWifi = new WIFI();
            this.Hide();
            formWifi.ShowDialog();
        }

        public void CriarLog_MySQLFalha()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Furmark = "C:\\TESTES_AVELL\\MySqlData\\" + NomeArquivo + "\\Wifi_RETESTES.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("WIFI FALHA RETESTE!: " + dataHoraMinutoOK);
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
                    String InfoWifi = "Wifi Falha: " + dataHoraMinuto;
                    var teste = new Wifi1
                    {
                        Serial = SerialAvell,
                        TWifi = InfoWifi
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoWifi = string.Empty;
                    break;
                }
                //Firebase - Atualizado

                //Firebase - Atualizado
                ManagementObjectSearcher MOS2 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS2.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoWifi = "Wifi Falha: " + dataHoraMinuto;
                    var teste = new Wifi1
                    {
                        Serial = SerialAvell,
                        TWifi = InfoWifi
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUOFALHA/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoWifi = string.Empty;
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
    }
}