using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TOUCHPAD
{
    public partial class TOUCHPAD : MaterialSkin.Controls.MaterialForm
    {
        public string TouchPad;

        string ValorTouchpad;
        string ValorbtnDir;
        string ValorbtnEsq;
        string ValorbtnDir2;
        string ValorbtnEsq2;
        string ValorbtnTouch;

        public TOUCHPAD()
        {
            InitializeComponent();
            Verificador();
            Interacao();
            TimeStart();
        }

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_touch", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor != 0 && valor != 1)
            {
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
            else
            {
                DesabilitarTab();
                //Interacao();
                //TimeStart();
            }
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\TouchPad.mp3";
            wplayer.controls.play();
        }

        private void TOUCHPAD_Load(object sender, EventArgs e)
        {
            timerCursor.Start();
            timerCursor.Interval = 1;
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 20;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                relogio.Stop();
                if (TouchPad != "OK")
                {
                    if (tempo == 0)
                    {
                        //Caso não seja testado no tempo, irá para falha!
                        TouchFimDoTempo();
                    }
                }
            };
            relogio.Start();
        }


        private void timerCursor_Tick(object sender, EventArgs e)
        {
            lblCoordenadas.Text = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString();

            //Aproveitar esse Timer para fazer a finalização dos testes
            ValorTouchpad = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString();
            TouchOK();
        }

        public void TouchOK()
        {
            if (ValorTouchpad == "0:0")
            {
                if (ValorbtnDir == "true" && ValorbtnEsq == "true" && ValorbtnDir2 == "true" && ValorbtnEsq2 == "true" && ValorbtnTouch == "true")
                {
                    //Para o Timer e finaliza
                    timerCursor.Stop();

                    TouchPad = "OK";

                    //Parar também o timer regressivo
                    VALIDAOK formValidaOK = new VALIDAOK();
                    this.Hide();
                    formValidaOK.ShowDialog();
                }
            }
        }

        public void TouchFimDoTempo()
        {
            if (ValorTouchpad != "0:0")
            {
                //Caso não seja testado no tempo, irá para falha, verifica também se já tem um log de falha registrado
                var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_touch", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
                int valor = int.Parse(quantidadeLog);
                if (valor == 2)
                {
                    ENVIAREPARO formEnviaReparo = new ENVIAREPARO();
                    this.Hide();
                    formEnviaReparo.ShowDialog();
                }
                else
                {
                    REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                    this.Hide();
                    formReprovaFalha.ShowDialog();
                }
            }
            if (ValorbtnDir != "true" && ValorbtnEsq != "true" && ValorbtnDir2 != "true" && ValorbtnEsq2 != "true" && ValorbtnTouch != "true")
            {
                //Caso não seja testado no tempo, irá para falha, verifica também se já tem um log de falha registrado
                var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_touch", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
                int valor = int.Parse(quantidadeLog);
                if (valor == 2)
                {
                    ENVIAREPARO formEnviaReparo = new ENVIAREPARO();
                    this.Hide();
                    formEnviaReparo.ShowDialog();
                }
                else
                {
                    REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                    this.Hide();
                    formReprovaFalha.ShowDialog();
                }
            }
        }

        public void DesabilitarTab()
        {
            btnEsq.TabStop = false;
            btnDir.TabStop = false;
        }

        private void btnEsq_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelBotaoEsq.BackColor = Color.DarkGreen;
                ValorbtnEsq = "true";
            }
        }

        private void btnDir_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panelBotaoDir.BackColor = Color.DarkGreen;
                ValorbtnDir = "true";
                //Aviso
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\TouchPadValor0.mp3";
                wplayer.controls.play();
            }
        }

        private void btnDir2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panelBotaoDir2.BackColor = Color.DarkGreen;
                ValorbtnDir2 = "true";
            }
        }

        private void btnEsq2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelBotaoEsq2.BackColor = Color.DarkGreen;
                ValorbtnEsq2 = "true";
            }
        }

        private void btnTouch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelTouchPad.BackColor = Color.DarkGreen;
                ValorbtnTouch = "true";
            }
        }

        private void panelTouchPad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
