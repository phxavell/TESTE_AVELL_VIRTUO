using System;
using System.IO;
using System.Management;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;

namespace AVELLCUSTOM1
{
    public partial class AVELLCUSTOMOK : MaterialSkin.Controls.MaterialForm
    {
        public string CUSTOMOK;

        public AVELLCUSTOMOK()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
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

                    ChamarTesteTouch();
                }
            };
            relogio.Start();
        }

        public void ChamarTesteTouch()
        {
            GerarLogIndividual();
            //RelatorioAprovado();

            if (CUSTOMOK != "OK")
            {
                CUSTOMOK = "OK";
                TOUCHPAD.TOUCHPAD formTouchpad = new TOUCHPAD.TOUCHPAD();
                this.Hide();
                formTouchpad.ShowDialog();
            }
        }

        public void CriarLogOK_MySQL()
        {
            try
            {
                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Furmark = @"C:\TESTES_AVELL_VIRTUO\MySqlData\AvellCustom.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("AVELLCUSTOM OK: " + dataHoraMinutoOK);
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
                const string Drivers = @"C:\TESTES_AVELL_VIRTUO\logs_custom\AvellCustom.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("TESTE AVELL CUSTOM REALIZADO: " + dataHoraMinutoOK);
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
                string Furmark = "C:\\TESTES_AVELL_VIRTUO\\MySqlData\\" + NomeArquivo + "\\Custom_OK.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("AVELL CUSTOM OK: " + dataHoraMinutoOK);
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
                    String InfoCustom = "CustomControl OK: " + dataHoraMinuto;
                    var teste = new Custom
                    {
                        Serial = SerialAvell,
                        TCustom = InfoCustom
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoCustom = string.Empty;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxOK_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirme_Click(object sender, EventArgs e)
        {

        }
    }
}
