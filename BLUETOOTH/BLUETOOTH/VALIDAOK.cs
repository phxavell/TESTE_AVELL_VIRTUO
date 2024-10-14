using System;
using System.IO;
using System.Windows.Forms;
using System.Management;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;

namespace BLUETOOTH
{
    public partial class VALIDAOK : MaterialSkin.Controls.MaterialForm
    {
        public VALIDAOK()
        {
            InitializeComponent();
            StartFireBaseServices();
            //Apresenta falha devido estrutura de repetição que tem no formBluetooth
            Interacao();
            TimeStart();
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
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\BluetoothOK.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
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
                    CriarLog_MySQLOK();

                    ChamaTesteHDMI();
                }
            };
            relogio.Start();
        }

        public void ChamaTesteHDMI()
        {
            //Utilizar este padrão para chamar próximas etapas de testes
            GerarLogIndividual();
            CriarLog_MySQLOK();

            HDMI.HDMISTART formHdmiStart = new HDMI.HDMISTART();
            this.Hide();
            formHdmiStart.ShowDialog();
        }

        public void GerarLogIndividual()
        {
            try
            {
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Drivers = @"C:\TESTES_AVELL\logs_bluetooth\Bluetooth.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("TESTE BLUETOOTH REALIZADO: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CriarLog_MySQLOK()
        {
            //FALTA INSERIR NA TABELA MYSQL
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Bluetooth = "C:\\TESTES_AVELL\\MySqlData\\" + NomeArquivo + "\\Bluetooth_OK.txt";
                var Arquivo = File.AppendText(Bluetooth);
                Arquivo.WriteLine("BLUETOOH OK: " + dataHoraMinutoOK);
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
                    String InfoBluetooth = "Bluetooth OK: " + dataHoraMinuto;
                    var teste = new Bluetooth1
                    {
                        Serial = SerialAvell,
                        TBluetooth = InfoBluetooth
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoBluetooth = string.Empty;
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