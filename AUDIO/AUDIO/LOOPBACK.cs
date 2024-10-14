using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
//Referencia para gravador de áudio
//https://www.youtube.com/watch?v=ew4k6VAgqZk

namespace AUDIO
{
    public partial class LOOPBACK : MaterialSkin.Controls.MaterialForm
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int myfunc(string a, string b, int c, int d);
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public LOOPBACK()
        {
            InitializeComponent();
            TimeStart();
            MusicStart();
            GravarAudio();
            timerCronometro.Start();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\AudioGravado.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 20;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    timerCronometro.Stop();
                    MusicStop();
                    SalvarAudio();
                    //Interacao();
                    ChamarOuvirLoopBack();
                }
            };
            relogio.Start();
        }


        public void GravarAudio()
        {
            myfunc("open new Type waveaudio Alias recsound", "", 0, 0);
            myfunc("record recsound", "", 0, 0);
        }

        public void SalvarAudio()
        {
            myfunc("save recsound C:\\TESTES_AVELL\\recordfiles\\audio_gravado.wav", "", 0, 0);
            myfunc("close recsound", "", 0, 0);
        }

        public void MusicStart()
        {
            player.URL = @"C:\\TESTES_AVELL\\audiofiles\\audioLoopAvell.mp3";
            player.controls.play();
        }

        public void MusicStop()
        {
            player.controls.stop();
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator de = new MMDeviceEnumerator();
            MMDevice device = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            float volume = (float)device.AudioMeterInformation.MasterPeakValue * 100;
            progressBarAudio.Value = (int)volume;
        }

        public void ChamarOuvirLoopBack()
        {
            OUVIRLOOPBACK formLoopBack = new OUVIRLOOPBACK();
            this.Hide();
            formLoopBack.ShowDialog();
        }
    }
}
