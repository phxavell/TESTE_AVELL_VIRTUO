using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;
//AJUSTANDO...

namespace ROBOTESTE
{
    public partial class REPROVAFALHA : MaterialSkin.Controls.MaterialForm
    {
        public REPROVAFALHA()
        {
            InitializeComponent();
            //StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            Interacao();
            //Adicionado para limpar arquivos Temp
            LimparTemp();
            CriarLogFalha();
            CriarLog_MySQLReteste();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\BurninFalha.mp3";
            wplayer.controls.play();
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

        public void CriarLogFalha()
        {
            try
            {
                var dataHoraMinuto = DateTime.Now.ToString("dd-MM-yyyy-HH-mms-s");
                System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL_VIRTUO\logs_burnin\Falha" + dataHoraMinuto + ".log");
                sw2.WriteLine("Falha em Burnin Data/Hora:" + dataHoraMinuto);
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
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

        public void CriarLog_MySQLReteste()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                //Dll: System.Management.dll - Para conseguir informações da BIOS
                string NomeArquivo = (string)obj["SerialNumber"];

                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                string Furmark = "C:\\TESTES_AVELL_VIRTUO\\MySqlData\\" + NomeArquivo + "\\Burnin_FALHA.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("BURNIN FALHA: " + dataHoraMinutoOK);
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
                    String InfoBurnin = "Burnin falhou retestado: " + dataHoraMinuto;
                    var teste = new Burnin
                    {
                        Serial = SerialAvell,
                        TBurnin = InfoBurnin
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoBurnin = string.Empty;
                    break;
                }
                //Firebase - Atualizado

                //Firebase - Atualizado
                ManagementObjectSearcher MOS2 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS2.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoBurnin2 = "Burnin falhou: " + dataHoraMinuto;
                    var teste = new Burnin
                    {
                        Serial = SerialAvell,
                        TBurnin = InfoBurnin2
                    };
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUOFALHA/" + SerialAvell, teste);
                    SerialAvell = string.Empty;
                    InfoBurnin2 = string.Empty;
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

        private void btnReteste_Click(object sender, EventArgs e)
        {
            ROBOTESTE FormRoboTeste = new ROBOTESTE();
            this.Hide();
            FormRoboTeste.Show();
        }

        private void pictureBoxOK_Click(object sender, EventArgs e)
        {

        }
    }
}
