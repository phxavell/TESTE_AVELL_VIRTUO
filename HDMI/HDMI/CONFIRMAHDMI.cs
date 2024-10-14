using System;
using System.Windows.Forms;

namespace HDMI
{
    public partial class CONFIRMAHDMI : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMAHDMI()
        {
            InitializeComponent();
            Interacao();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteHDMIConfirma.mp3";
            wplayer.controls.play();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            HDMIAUDIO formHDMIAudio = new HDMIAUDIO();
            this.Hide();
            formHDMIAudio.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
            this.Hide();
            formReprovaFalha.ShowDialog();
        }
    }
}
