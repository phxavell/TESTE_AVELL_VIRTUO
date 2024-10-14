using System;
using System.Windows.Forms;

namespace RGB
{
    public partial class CONFIRMATELAPIX : MaterialSkin.Controls.MaterialForm
    {
        string Lcd;

        public CONFIRMATELAPIX()
        {
            InitializeComponent();
            Cursor.Show();
            Interacao();
            //TimeStart();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\LCDAprovaouNao.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 20;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    try
                    {
                        relogio.Stop();
                        //Chamar form de reprovação

                        if (Lcd != "aprovado")
                        {
                            REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                            this.Hide();
                            formReprovaFalha.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Variável pública para não entrar em loop
            Lcd = "aprovado";

            VALIDAOK formConfirmaValidaOK = new VALIDAOK();
            this.Hide();
            formConfirmaValidaOK.Show();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            REPROVAFALHA formReprovaFalha= new REPROVAFALHA();
            this.Hide();
            formReprovaFalha.Show();
        }
    }
}
