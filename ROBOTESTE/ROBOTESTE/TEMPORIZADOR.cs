using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ROBOTESTE
{
    public partial class TEMPORIZADOR : MaterialSkin.Controls.MaterialForm
    {
        public string BurninTeste;

        public TEMPORIZADOR()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\InicioBurnin.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            //Só começa a contagem se não tiver gerador o valor na variável global.
            if (BurninTeste != "Active2")
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 2700;
                //int tempo = 60;
                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();
                        ConfirmarBurnin();
                    }
                };
                relogio.Start();
            }
        }

        private void linkAvancar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConfirmarSkip();
        }

        public void ConfirmarBurnin()
        {
            BurninTeste = "Active2";//Evitar loops

            CONFIRMABURNIN formConfirmaBurnin = new CONFIRMABURNIN();
            this.Hide();
            formConfirmaBurnin.ShowDialog();
        }

        public void ConfirmarSkip()
        {
            BurninTeste = "Active2";//Evitar loops
            PararTestes();

            CONFIRMASKIP formConfirmaSkip = new CONFIRMASKIP();
            this.Hide();
            formConfirmaSkip.ShowDialog();
        }

        public void PararTestes()
        {
            //Finaliza o processo após a confirmação
            try
            {
                string Burnin = "bit";
                var processes = Process.GetProcessesByName(Burnin);
                foreach (var BurninTeste in processes)
                    BurninTeste.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel finalizar o processo");
            }
        }

        public void MedidorRecursosWindows()
        {
            try
            {
                var startInfo = new ProcessStartInfo(@"C:\Windows\system32\perfmon.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(startInfo);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível abir o medidor de recursos do Windows!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeInfo_Click(object sender, EventArgs e)
        {

        }
    }
}