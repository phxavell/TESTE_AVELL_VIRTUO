using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace USB
{
    public partial class QUANTIDADEARQUIVOS : MaterialSkin.Controls.MaterialForm
    {
        public QUANTIDADEARQUIVOS()
        {
            InitializeComponent();
            Interacao();
            TimeStart();
        }

        public void Interacao()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\USBTotalOk.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate
            {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    //Para e chama o método
                    relogio.Stop();

                    //Chama o Form OK para avançar
                    VALIDAOK formValidaOk = new VALIDAOK();
                    this.Hide();
                    formValidaOk.Show();
                }
            };
            relogio.Start();
        }

        public void ApagarArquivosTemp()
        {
            try
            {
                //Exclui pasta da mídia removível
                var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
                if (drives.FirstOrDefault() != null)
                {
                    string unidade = drives.FirstOrDefault().Name.ToString();
                    string destino = unidade + "\\TESTES_AVELL_VIRTUO";
                    var Exluir = new DirectoryInfo(destino);
                    Exluir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir os arquivos" + ex);
            }
        }

        public void formPrincipal()
        {
            USB formUSB = new USB();
            this.Hide();
            formUSB.Show();
        }

        private void panelOK_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
