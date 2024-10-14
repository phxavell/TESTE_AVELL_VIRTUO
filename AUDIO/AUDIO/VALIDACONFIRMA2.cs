using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AUDIO
{
    public partial class VALIDACONFIRMA2 : MaterialSkin.Controls.MaterialForm
    {
        public string TimeStop;

        public VALIDACONFIRMA2()
        {
            InitializeComponent();
            Interacao();
            //TimeStart();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\MicrofoneOK.mp3";
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
                    try
                    {
                        if (TimeStop != "stop")
                        {
                            //Chamar form de falha se não houver interação
                            REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                            this.Hide();
                            formReprovaFalha.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            TimeStop = "stop";
            VALIDAOK formValidaOK = new VALIDAOK();
            this.Hide();
            formValidaOK.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            try
            {
                var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL\logs_audio", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
                int valor = int.Parse(quantidadeLog);
                if (valor == 1)
                {
                    TimeStop = "stop";
                    //Chamar form, método mais eficiente.
                    using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                    {
                        this.Hide();
                        formEnviarReparo.ShowDialog();
                    }
                }
                else
                {
                    TimeStop = "stop";
                    //Chamar form de falha se não houver interação
                    REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                    this.Hide();
                    formReprovaFalha.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel capturar Imagem" + ex);
            }
        }
    }
}
