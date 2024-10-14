using System;
using System.Windows.Forms;

namespace AUDITOR
{
    public partial class AUDITORSTART : MaterialSkin.Controls.MaterialForm
    {
        public string AUDITOR = "";

        public AUDITORSTART()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\AuditoriaInicioConfig.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            if (AUDITOR != "STARTED")
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 5;
                relogio.Tick += delegate
                {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        AUDITOR = "STARTED";
                        //Chama o form de Auditoria de máquina
                        AUDITOR formAuditor = new AUDITOR();
                        //this.Hide();
                        this.Close();
                        formAuditor.Show();
                    }
                };
                relogio.Start();
            }
        }
    }
}
