using System;
using System.Windows.Forms;

namespace DISPLAYPORT
{
    public partial class DISPORTSTART : MaterialSkin.Controls.MaterialForm
    {
        public string DISPLAYPORT1;

        public DISPORTSTART()
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
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\DisplayPortTeste.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            if (DISPLAYPORT1 != "TESTADO")//Somente se não tiver nenhum valor na variável
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
                            DisplayPortTeste();

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

        public void DisplayPortTeste()
        {
            if (DISPLAYPORT1 != "TESTADO")
            {
                DISPLAYPORT1 = "TESTADO";
                DISPLAYPORT formDISPLAYPORT = new DISPLAYPORT();
                this.Hide();
                formDISPLAYPORT.ShowDialog();
            }
        }
    }
}
