using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace WIFI
{
    public partial class WIFI : MaterialSkin.Controls.MaterialForm
    {
        public WIFI()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //Interacao - Precisa ficar dentro do evento do form devido auto start das propriedades de video.
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WIFITeste.mp3";
            wplayer.controls.play();
        }

        public void InteracaoConexaoOK()
        {
            pictureBoxStatus.Image = Image.FromFile(@"C:\TESTES_AVELL\img_wifi\wifiOk.jpg");
            lblStatus.Text = "OK, CONECTADO!";
            lblStatus.ForeColor = Color.DarkOliveGreen;
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WIFITesteOk.mp3";
            wplayer.controls.play();

            TimeStartValidaOk();
        }

        public void TimeStartValidaOk()
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
                        //Método à executar:
                        VALIDAOK formValidaOk = new VALIDAOK();
                        this.Hide();
                        formValidaOk.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        public void InteracaoConexaoFalha()
        {
            pictureBoxStatus.Image = Image.FromFile(@"C:\TESTES_AVELL\img_wifi\wifiFalha.jpg");
            lblStatus.Text = "NÃO CONECTADO!";
            lblStatus.BackColor = Color.DarkRed;
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WIFITesteFalha.mp3";
            wplayer.controls.play();

            TimeStarReprovaFalha();
        }

        public void TimeStarReprovaFalha()
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
                        //Método à executar:
                        REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                        this.Hide();
                        formReprovaFalha.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
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
                        //Método à executar:
                        StatusTeste();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public void StatusTeste()
        {
            //Método simplificado verificação de um parâmetro booleano (sim ou não)
            if (CheckForInternetConnection())
                InteracaoConexaoOK();
            else
                InteracaoConexaoFalha();
        }
    }
}
