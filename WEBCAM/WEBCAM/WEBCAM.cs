using System;
using System.Windows.Forms;

namespace WEBCAM
{
    public partial class WEBCAM : MaterialSkin.Controls.MaterialForm
    {
        public WEBCAM()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //Interacao - Precisa ficar dentro do evento do form devido auto start das propriedades de video.
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WebCamReconhecimento.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    try
                    {
                        relogio.Stop();
                        //Limpa se já houver algum arquivo
                        RecFace();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        public void RecFace()
        {
            WEBCAM_RECFACE formWebCamRecface = new WEBCAM_RECFACE();
            this.Hide();
            formWebCamRecface.ShowDialog();
        }
    }
}
