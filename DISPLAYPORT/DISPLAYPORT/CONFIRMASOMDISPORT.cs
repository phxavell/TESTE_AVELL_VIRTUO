using System;
using System.Windows.Forms;

namespace DISPLAYPORT
{
    public partial class CONFIRMASOMDISPORT : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMASOMDISPORT()
        {
            InitializeComponent();
            Interacao();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\TesteDISPLAYPORTAudio.mp3";
            wplayer.controls.play();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            VALIDAOK formValidaOk = new VALIDAOK();
            this.Hide();
            formValidaOk.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            //Ajustar segunda dia 30/10/2023 - para verificar quantos logs de erro já tem
            REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
            this.Hide();
            formReprovaFalha.ShowDialog();
        }
    }
}
