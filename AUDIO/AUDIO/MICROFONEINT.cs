using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AUDIO
{
    public partial class MICROFONEINT : MaterialSkin.Controls.MaterialForm
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int myfunc(string a, string b, int c, int d);
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public MICROFONEINT()
        {
            InitializeComponent();
            Interacao();
            TimeStart1();
            GravarAudio();
            timerCronometro.Start();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\AudioMicrofoneInterno.mp3";
            wplayer.controls.play();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 5;
            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Inicializar música
                    MusicStart();
                    TimeStart2();
                }
            };
            relogio.Start();
        }


        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 30;//30segundos

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
                    ChamarOuvirMicrofone();
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
            myfunc("save recsound C:\\TESTES_AVELL\\recordfiles\\Jigulina.wav", "", 0, 0);
            myfunc("close recsound", "", 0, 0);
        }

        public void MusicStart()
        {
            player.URL = @"C:\\TESTES_AVELL\\audiofiles\\audioEdMayaJigulina.mp3";
            player.controls.play();
        }

        public void MusicStop()
        {
            player.controls.stop();
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator de = new MMDeviceEnumerator();
            MMDevice device = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            float volume = (float)device.AudioMeterInformation.MasterPeakValue * 100;
            progressBarAudio.Value = (int)volume;
        }

        public void ChamarOuvirMicrofone()
        {
            OUVIRMICROFONE formMicrofoneInterno = new OUVIRMICROFONE();
            this.Hide();
            formMicrofoneInterno.ShowDialog();
        }
    }
}
