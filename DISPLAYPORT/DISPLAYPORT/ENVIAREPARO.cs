using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using System.IO;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace DISPLAYPORT
{
    public partial class ENVIAREPARO : MaterialSkin.Controls.MaterialForm
    {
        public ENVIAREPARO()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            TimeStart1();
            Interacao();
            CriarLog_MySQLReparo();
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

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\EnvieParaReparo.mp3";
            wplayer.controls.play();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 1;//1 minuto e 20

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    panelFalha.BackColor = Color.DarkRed;
                    panelFalha.Refresh();
                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 1;//1 minuto e 20

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    panelFalha.BackColor = Color.DarkOrange;
                    panelFalha.Refresh();
                    TimeStart1();

                }
            };
            relogio.Start();
        }

        public void CriarLog_MySQLReparo()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string DisplayPort = "C:\\TESTES_AVELL\\MySqlData\\" + NomeArquivo + "\\DISPLAYPORT_FALHA.txt";
                var Arquivo = File.AppendText(DisplayPort);
                Arquivo.WriteLine("DISPLAYPORT FALHA - ENVIO REPARO!: " + dataHoraMinutoOK);
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
                    String InfoDisplayPort = "DisplayPort Falha: " + dataHoraMinuto;
                    var teste = new Dpport1
                    {
                        Serial = SerialAvell,
                        TDisplayPort = InfoDisplayPort
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoDisplayPort = string.Empty;
                    break;
                }
                //Firebase - Atualizado

                //Firebase - Atualizado
                ManagementObjectSearcher MOS2 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS2.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoDisplayPort = "DisplayPort Falha: " + dataHoraMinuto;
                    var teste = new Dpport1
                    {
                        Serial = SerialAvell,
                        TDisplayPort = InfoDisplayPort
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUOFALHA/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoDisplayPort = string.Empty;
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
