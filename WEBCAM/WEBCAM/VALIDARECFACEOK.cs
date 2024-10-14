using System;
using System.Windows.Forms;
using MaterialSkin;

namespace WEBCAM
{
    public partial class VALIDARECFACEOK : MaterialSkin.Controls.MaterialForm
    {
        public VALIDARECFACEOK()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WebCamOk.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chamar o próximo projeto
                    //PróximoTeste();
                }
            };
            relogio.Start();
        }


        public void ChamarProximoTeste()
        {
            //AVELLCUSTOM1.CUSTOM1 formAvellCustom = new AVELLCUSTOM1.CUSTOM1();
            //this.Hide();
            //formAvellCustom.ShowDialog();
        }
    }
}
