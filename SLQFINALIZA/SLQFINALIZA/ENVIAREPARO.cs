using System;
using System.Drawing;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace SLQFINALIZA
{
    public partial class ENVIAREPARO : MaterialSkin.Controls.MaterialForm
    {
        public ENVIAREPARO()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            TimeStart1();
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
    }
}
