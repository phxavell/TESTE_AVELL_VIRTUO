using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB
{
    public partial class RGBTESTE : Form
    {
        public RGBTESTE()
        {
            InitializeComponent();
            //Tela Inteira
            fullScreen();
            timerRGB.Start();
            Interacao1();
            Cursor.Hide();
        }

        public void Interacao1()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\LCDDeadPix.mp3";
            wplayer.controls.play();
        }

        public void fullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        public void normalScreen()
        {
            //Volta para o tamanho normal
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        public static class check
        {
            public static int R = 0;
            public static int G = 0;
            public static int B = 0;
        }

        private void timerRGB_Tick(object sender, EventArgs e)
        {
            //Inciat tempo de contagem de teste
            timerSTOP.Start();

            Random color = new Random();
            check.R = color.Next(0, 255);
            check.G = color.Next(0, 255);
            check.B = color.Next(0, 255);
            this.BackColor = Color.FromArgb(check.R, check.G, check.B);
        }


        private void timerSTOP_Tick(object sender, EventArgs e)
        {
            //Depois de 1 minuto de Testes finalizará. - Vou modificar isso!
            this.BackColor = Color.Black;
            timerRGB.Stop();
            //Aqui vai chamar o teste de 
            ConfirmarTesteLcd();
        }

        public void ConfirmarTesteLcd()
        {
            ////Precisar chamar outro form
            //timerSTOP.Stop();
            //CONFIRMATELAPIX formConfirmaTelaPix = new CONFIRMATELAPIX();
            //this.Hide();
            ////frm.Closed += (s, args) => this.Close();
            //formConfirmaTelaPix.Show();

            timerSTOP.Stop();
            FUGALUZ formFulgaDeLuz = new FUGALUZ();
            this.Hide();
            formFulgaDeLuz.Show();

        }
    }
}
