using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//Adicionado para teste display port:
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DISPLAYPORT
{
    public partial class DISPLAYPORT : MaterialSkin.Controls.MaterialForm
    {
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170;

        public string DISPLAYPORTOK;

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        public DISPLAYPORT()
        {
            InitializeComponent();
            Interacao1();
            VerificaStatusDisplay();
        }

        public void Interacao1()
        {//Ajustado...
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteDISPLAYPORTConexao.mp3";
            wplayer.controls.play();
        }

        public void VerificaStatusDisplay()
        {
            try
            {
                if (Screen.AllScreens[0].Bounds.Contains(this.Bounds))
                {
                    var StatusMonitor = (Screen.AllScreens[1].Bounds.Contains(this.Bounds));
                    if (StatusMonitor == false)
                    {
                        lblStatusDisplayPort.Text = "CONECTADO!";
                        lblStatusDisplayPort.ForeColor = Color.DarkGreen;

                        //DISPLAYPORTOK = "OK";
                        TimeStart1();
                    }
                }
            }
            catch
            {
                //String pública criada para não ficar em loop.
                DISPLAYPORTOK = "FALHA";
                TimeFalha();
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
            //Desativado ocilação de tela
            SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        public void TimeStart1()
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
                    lblTime.ForeColor = Color.White;
                    //VerificaStatusHdmi();
                    ResolucaoTelaNote();
                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
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

                    if (DISPLAYPORTOK != "OK")
                    {
                        DISPLAYPORTOK = "OK";

                        DISPLAYPORTAUDIO formDISPORTAudio = new DISPLAYPORTAUDIO();
                        this.Hide();
                        formDISPORTAudio.ShowDialog();
                    }
                }
            };
            relogio.Start();
        }

        //Timer adicionado para Evitar falhas
        public void TimeFalha()
        {
            if (DISPLAYPORTOK != "FALHA")
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

                        DPPORTDESCONECTADO formDPPORTDesconectado = new DPPORTDESCONECTADO();
                        this.Hide();
                        formDPPORTDesconectado.ShowDialog();
                    }
                };
                relogio.Start();
            }
        }
    }
}
