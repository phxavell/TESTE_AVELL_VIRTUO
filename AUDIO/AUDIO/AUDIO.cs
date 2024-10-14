using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
//Barra de Áudio
//https://www.youtube.com/watch?v=TNpDD4ljIgY  -- Rerferência de código.

namespace AUDIO
{
    public partial class AUDIO : MaterialSkin.Controls.MaterialForm
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public AUDIO()
        {
            InitializeComponent();
            //Player automático da Música
            MusicStart();
            timerCronometro.Start();
            TimeStart();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 40;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    timerCronometro.Stop();
                    MusicStop();
                    ConfirmaTeste();

                }
            };
            relogio.Start();
        }

        public void MusicStart()
        {
            //inicializar a música
            player.URL = @"C:\\TESTES_AVELL\\audiofiles\\audioLoopAvell.mp3";
            player.controls.play();

        }

        public void MusicStop()
        {
            //Para a música
            player.controls.stop();
        }

        //Necessário para acionamento da barra de progresso do audio
        private void cronometro_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator de = new MMDeviceEnumerator();
            MMDevice device = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            float volume = (float)device.AudioMeterInformation.MasterPeakValue * 100;
            progressBarAudio.Value = (int)volume;
        }

        public void ConfirmaTeste()
        {
            //Chamar o Form confirmar áudio
            CONFIRMARAUD formConfirmaAud = new CONFIRMARAUD();
            this.Hide();
            formConfirmaAud.ShowDialog();
        }
    }
}
