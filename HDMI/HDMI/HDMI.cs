using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HDMI
{
    public partial class HDMI : MaterialSkin.Controls.MaterialForm
    {
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170;

        public string HDMIOK;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        public HDMI()
        {
            InitializeComponent();
            Interacao1();
            //Inicio do processo de teste do HDMI
            TimeStart1();
        }

        public void Interacao1()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMIConexao.mp3";
            wplayer.controls.play();
        }

        public void Interacao2()
        {
            //Desativar e ativa tela
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMIOffOn.mp3";
            wplayer.controls.play();
        }

        public void Interacao3()
        {
            //Toque no touch pad para retornar a imagem
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMIRetorna.mp3";
            wplayer.controls.play();
        }

        public void VerificaStatusHdmi()
        {
            try
            {
                if (Screen.AllScreens[0].Bounds.Contains(this.Bounds))
                {
                    var StatusMonitor = (Screen.AllScreens[1].Bounds.Contains(this.Bounds));
                    if (StatusMonitor == false)
                    {
                        lblStatusHdmi.Text = "CONECTADO!";
                        lblStatusHdmi.ForeColor = Color.DarkGreen;
                    }
                }
            }
            catch
            {
                if (HDMIOK != "OK")
                {
                    HDMIDESCONECTADO formHDMIDesconectado = new HDMIDESCONECTADO();
                    this.Hide();
                    formHDMIDesconectado.ShowDialog();
                }
            }
        }

        public void ResolucaoTelaNote()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                lblResolucao.Text = ("RESOLUÇÃO TELA NOTEBOOK:" + screen.Bounds.Width + "x" + screen.Bounds.Height);
                lblResolucao.ForeColor = Color.DarkGreen;
            }
        }

        public void OcilacaoTelas()
        {
            Interacao2();//Teste
            SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }


        public void TimeStart1()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 2;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chama Form Loopback
                    lblTime.ForeColor = Color.White;
                    //Interacao2();
                    VerificaStatusHdmi();
                    ResolucaoTelaNote();
                    //TimeStart2();--Saltar direto para o que chama os testes
                    TimeStart4();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            //Depois de parar o testes de ocilação, isso só server como jumper
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo =2;

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Para o Timer e inicia ação
                    //OcilacaoTelas();
                    TimeStart3();
                }
            };
            relogio.Start();
        }

        public void TimeStart3()
        {
            //Só para dar um delay de 3 segundos.
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Para o Timer e inicia ação
                    //Interacao3();
                    TimeStart4();
                }
            };
            relogio.Start();
        }

        public void TimeStart4()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();

                    if (HDMIOK != "OK")
                    {
                        HDMIOK = "OK";
                        //Tirei o form que testa a ocilação do vídeo.
                        HDMIAUDIO formHDMIAudio = new HDMIAUDIO();
                        this.Hide();
                        formHDMIAudio.ShowDialog();
                    }
                }
            };
            relogio.Start();
        }
    }
}
