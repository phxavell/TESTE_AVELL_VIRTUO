using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HDMI
{
    public partial class HDMIAUDIO : MaterialSkin.Controls.MaterialForm
    {
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170;

        public string HDMIOK;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public HDMIAUDIO()
        {
            InitializeComponent();
            //TesteHDMITestarSom
            Interacao1();
            MusicStart();
        }

        public void Interacao1()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMITestarSom.mp3";
            wplayer.controls.play();

            TimeStart1();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 35;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Para o Timer e inicia ação
                    MusicStop();
                    MusicStart2();
                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 25;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Para o Timer e inicia ação
                    MusicStop();

                    if (HDMIOK != "OK")
                    {
                        HDMIOK = "OK";
                        CONFIRMASOMHDMI formConfirmaSomHdmi = new CONFIRMASOMHDMI();
                        this.Hide();
                        formConfirmaSomHdmi.ShowDialog();
                    }
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

        public void MusicStart2()
        {
            //inicializar a música
            player.URL = @"C:\\TESTES_AVELL\\audiofiles\\GuruJoshProjecInfinity.mp3";
            player.controls.play();
        }

        public void MusicStop()
        {
            //Para a música
            player.controls.stop();
        }
    }
}
