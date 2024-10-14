using System;
using System.Windows.Forms;

namespace AUDIO
{
    public partial class OUVIRLOOPBACK : MaterialSkin.Controls.MaterialForm
    {
        public OUVIRLOOPBACK()
        {
            InitializeComponent();
            Interacao1();
            TimeStart1();
        }

        public void Interacao1()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\AudioGravacao.mp3";
            wplayer.controls.play();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 2;

            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Ouvir o áudio gravado no LoopBack
                    //https://www.naturalreaders.com/online/ - Cria vozes
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = @"C:\TESTES_AVELL\recordfiles\audio_gravado.wav";
                    wplayer.controls.play();

                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo =20;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chamar o form de confirmação

                    VALIDACONFIRMA1 formValidaOK01 = new VALIDACONFIRMA1();
                    this.Hide();
                    formValidaOK01.ShowDialog();
                }
            };
            relogio.Start();
        }
    }
}
