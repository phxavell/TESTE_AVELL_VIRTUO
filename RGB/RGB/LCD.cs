using System;
using System.Windows.Forms;

namespace RGB
{
    public partial class LCD : MaterialSkin.Controls.MaterialForm
    {
        public LCD()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\LCDTeste.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate
            {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    //Para e chama o método
                    relogio.Stop();

                    //Chama o Form OK para avançar
                    RGBTESTE formRgbTeste = new RGBTESTE();
                    this.Hide();
                    formRgbTeste.Show();
                }
            };
            relogio.Start();
        }
    }
}
