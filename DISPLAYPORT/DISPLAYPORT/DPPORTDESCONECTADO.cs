using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DISPLAYPORT
{
    public partial class DPPORTDESCONECTADO : MaterialSkin.Controls.MaterialForm
    {
        public string DISPLAYPORTFALHA;

        public DPPORTDESCONECTADO()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            CriarLog_MySQLReteste();
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
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL\logs_displayport", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
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
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\DisplayPortFalha.mp3";
            wplayer.controls.play();
        }

        public void CriarLogFalha()
        {
            try
            {
                var dataHoraMinuto = DateTime.Now.ToString("dd-MM-yyyy-HH-mms-s");
                //Criar log de voz
                System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL\logs_displayport\Falha" + dataHoraMinuto + ".log");
                sw2.WriteLine("Falha em Testes Dia:" + dataHoraMinuto);
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnReteste_Click(object sender, EventArgs e)
        {
            if (DISPLAYPORTFALHA != "FALHA")
            {
                DISPLAYPORTFALHA = "FALHA";
                //
                VERIF_DPORT formHDMIStart = new VERIF_DPORT();
                this.Hide();
                formHDMIStart.ShowDialog();
            }
        }

        public void CriarLog_MySQLReteste()
        {
            try
            {
                //Firebase - Atualizado
                var dataHoraMinuto = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
                ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                foreach (ManagementObject getserial in MOS1.Get())
                {
                    string SerialAvell = getserial["SerialNumber"].ToString();
                    String InfoDisplayPort = "DisplayPort Desconectado: " + dataHoraMinuto;
                    var teste = new Dpport1
                    {
                        Serial = SerialAvell,
                        TDisplayPort = InfoDisplayPort
                    };
                    //Mundar para FUNC_FALHA
                    FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
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
