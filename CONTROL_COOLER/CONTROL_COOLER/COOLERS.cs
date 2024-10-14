using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CONTROL_COOLER
{
    public partial class COOLERS : MaterialSkin.Controls.MaterialForm
    {
        public COOLERS()
        {
            InitializeComponent();
            StartTestes();
            InteracaoCooler();
        }

        public void InteracaoCooler()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\ControlCoolers.mp3";
            wplayer.controls.play();
        }

        public void StartTestes()
        {
            try
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 40;

                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        VerificarInstalacao();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        public void VerificarInstalacao()
        {
            String CaminhoPastaCustom = @"C:\Program Files\OEM";

            if (Directory.Exists(CaminhoPastaCustom))
            {
                Cooler2();
            }
            else
            {
                InstalarCustom();
            }
        }

        public void InstalarCustom()
        {
            try
            {
                Process instalarCustom = System.Diagnostics.Process.Start(@"C:\TESTES_AVELL\.executaveisAux\InstalarCustomControl.exe");
                instalarCustom.WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show("Não foi possivel instalaro o Custom Control, ou não foi possível encontrar o caminho"); }

            Cooler2();
        }

        public void Cooler2()
        {
            COOLERS2 FormTipoFalha = new COOLERS2();
            this.Hide();
            FormTipoFalha.ShowDialog();
        }
    }
}
