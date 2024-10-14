using System;
using System.Diagnostics;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace SLQFINALIZA
{
    public partial class CONFIRMARFINALIZA : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMARFINALIZA()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            Interacao();
        }

        //Firebase
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            //Utilizando RealTimeDatabase do TestesAvell - OK Atualizado
            AuthSecret = "ni99x0Zyr1HfIsjyF92bKJuoazt3cc7HtsNDrcMF",
            BasePath = "https://testesavell-default-rtdb.firebaseio.com/"
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
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TestesAprovados.mp3";
            wplayer.controls.play();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //LimparTestes();
            CopiarReiniciar();
            FinalizarAplicacao();
        }

        public void CopiarReiniciar()
        {
            try
            {
                //Reiniciar a máquina
                ProcessStartInfo ReiniciarMaquina = new ProcessStartInfo("cmd.exe", @"/C " + "shutdown /r /t 5");
                ReiniciarMaquina.UseShellExecute = false;
                ReiniciarMaquina.CreateNoWindow = true;
                Process.Start(ReiniciarMaquina);
            }
            catch (Exception ex) { }
        }

        public void FinalizarAplicacao()
        {
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            ENVIAREPARO formEnviarReparo = new ENVIAREPARO();
            this.Hide();
            formEnviarReparo.ShowDialog();
        }
    }
}
