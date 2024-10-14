using System;
using System.Drawing;
using System.Windows.Forms;
//Referencia do projeto: https://www.youtube.com/watch?v=u6cSth9S4HQ

namespace RGB
{
    public partial class FUGALUZ : Form
    {
        public FUGALUZ()
        {
            InitializeComponent();
            Interacao1();
            FullScreen();
            TimeStartBlack();
            Cursor.Hide();
            //Cursor.Show();
        }

        public void Interacao1()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\LCDFulgaLuz.mp3";
            wplayer.controls.play();
        }

        public void FullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //Deve ficar true
            TopMost = true;
            panelBg.BackColor = Color.White;
        }

        public void TimeStartBlack()
        {
            Timer relogio = new Timer();
            relogio.Interval = 3000;
            int tempo = 1;

            relogio.Tick += delegate {
                tempo -= 1;
                relogio.Stop();

                {
                    panelBg.BackColor = Color.Black;
                    TimeStartWhite();
                    TimeAviso();
                }
            };
            relogio.Start();
        }

        public void TimeStartWhite()
        {
            Timer relogio = new Timer();
            relogio.Interval = 3000;
            int tempo = 1;

            relogio.Tick += delegate {
                tempo -= 1;
                relogio.Stop();

                {
                    panelBg.BackColor = Color.White;
                    TimeStartBlack();
                }
            };
            relogio.Start();
        }


        public void TimeAviso()
        {
            Timer relogio = new Timer();
            relogio.Interval = 60000;
            int tempo = 1;

            relogio.Tick += delegate {
                tempo -= 1;
                relogio.Stop();

                {
                    lblAviso.Text = "PRESSIONE ENTER PARA AVANÇAR!";
                }
            };
            relogio.Start();
        }

        private void FUGALUZ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //FormBorderStyle = FormBorderStyle.Sizable;
                //WindowState = FormWindowState.Normal;
                //TopMost = true;

                Cursor.Show();
                //Precisar chamar outro form
                CONFIRMATELAPIX formConfirmaTelaPix = new CONFIRMATELAPIX();
                this.Hide();
                //frm.Closed += (s, args) => this.Close();
                formConfirmaTelaPix.Show();
            }
        }
    }
}
