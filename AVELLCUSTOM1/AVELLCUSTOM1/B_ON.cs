using System;
using System.Windows.Forms;


namespace AVELLCUSTOM1
{
    public partial class B_ON : MaterialSkin.Controls.MaterialForm
    {
        public string BON_LITE;

        public B_ON()
        {
            InitializeComponent();
            TimeStart();
            //SimplificaMetodo();
        }

        public void InteracaoB_ON()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\AvellCustmBOn.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 5;
            relogio.Tick += delegate
            {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    InteracaoB_ON();
                    ConfirmarCustom();
                }
            };
            relogio.Start();
        }

        public void ConfirmarCustom()
        {
            if (BON_LITE != "OK")
            {
                BON_LITE = "OK";
                AVELLCUSTOMOK formConfirmaCustom = new AVELLCUSTOMOK();
                this.Hide();
                formConfirmaCustom.ShowDialog();
            }
        }

        public void SimplificaMetodo()
        {
            if (BON_LITE != "OK")
            {
                InteracaoB_ON();
                ConfirmarCustom();

                BON_LITE = "OK";
                AVELLCUSTOMOK formConfirmaCustom = new AVELLCUSTOMOK();
                this.Hide();
                formConfirmaCustom.ShowDialog();
            }
        }

        private void B_ON_Load(object sender, EventArgs e)
        {

        }
    }
}
