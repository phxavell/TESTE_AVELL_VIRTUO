using System;
using System.IO;
using System.Management;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;

namespace TOUCHPAD
{
    public partial class VALIDAOK : MaterialSkin.Controls.MaterialForm
    {
        public VALIDAOK()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
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
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TouchPadOk.mp3";
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

                    //CriarLogOK_MySQL(); //Remover, obsoleto
                    GerarLogIndividual();
                    //RelatorioAprovado();
                    CriarLog_MySQLOK();

                    USB.USB formUSB = new USB.USB();
                    this.Hide();
                    formUSB.ShowDialog();
                }
            };
            relogio.Start();
        }

        public void CriarLogOK_MySQL()
        {
            try
            {
                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Touchpad = @"C:\TESTES_AVELL\MySqlData\TouchPad.txt";
                var Arquivo = File.AppendText(Touchpad);
                Arquivo.WriteLine("TOUCHPAD OK: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pasta não Encotrada" + ex);
            }
        }

        public void GerarLogIndividual()
        {
            try
            {
                //Gera Log de Instalado para os Drivers
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Drivers = @"C:\TESTES_AVELL\logs_touch\TouchPad.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("TESTE TOUCHOPAD REALIZADO: " + dataHoraMinutoOK);
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
                string Furmark = "C:\\TESTES_AVELL_VIRTUO\\MySqlData\\" + NomeArquivo + "\\TouchPad_OK.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("TOUCHPAD OK: " + dataHoraMinutoOK);
                Arquivo.Close();
                break;
            }

            try
            {
                //FireBase - Atualizado
                var dataHoraMinuto = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
                ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS1.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoTouchpad = "Touchpad OK: " + dataHoraMinuto;
                    var teste = new Touchpad1
                    {
                        Serial = SerialAvell,
                        TTouchpad = InfoTouchpad
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoTouchpad = string.Empty;
                    break;
                }
                //FireBase - Atualizado
            }
            catch
            {
                lblFirebase.Text = "Firebase Off-Line";
                lblFirebase.ForeColor = Color.Red;
            }
        }
    }
}
