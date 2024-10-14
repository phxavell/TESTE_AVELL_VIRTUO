using System;
using System.Windows.Forms;

namespace HDMI
{
    public partial class HDMISTART : MaterialSkin.Controls.MaterialForm
    {
        public string HDMIOK1;

        public HDMISTART()
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
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMI.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            if (HDMIOK1 == null)//Somente se não tiver nenhum valor na variável
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 15;

                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        try
                        {
                            relogio.Stop();
                            //Limpa se já houver algum arquivo
                            HdmiTeste();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                        }
                    }
                };
                relogio.Start();
            }
        }

        public void HdmiTeste()
        {
            if (HDMIOK1 != "TESTADO")
            {
                HDMIOK1 = "TESTADO";
                HDMI formHDMI = new HDMI();
                this.Hide();
                formHDMI.ShowDialog();
            }
        }
    }
}
