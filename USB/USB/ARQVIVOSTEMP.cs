using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace USB
{
    public partial class ARQVIVOSTEMP : MaterialSkin.Controls.MaterialForm
    {
        public ARQVIVOSTEMP()
        {
            InitializeComponent();
            TimeStart();
        }

        public void Interacao()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\USBRemoverDispositivo.mp3";
            wplayer.controls.play();
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
                    try
                    {
                        //Para e chama o método
                        relogio.Stop();
                        //Vamos verificar se o teste continua.
                        var quantidadeTestes = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_usb", "*.*", SearchOption.TopDirectoryOnly).Count().ToString();
                        int valor = int.Parse(quantidadeTestes);
                        if (valor == 6)
                        {
                            QUANTIDADEARQUIVOS formQuantidade = new QUANTIDADEARQUIVOS();
                            this.Hide();
                            formQuantidade.Show();
                        }
                        if (valor > 6)
                        {
                            QUANTIDADEARQUIVOS formQuantidade = new QUANTIDADEARQUIVOS();
                            this.Hide();
                            formQuantidade.Show();
                        }
                        if (valor < 6)
                        {
                            //Limpar o Pendrive
                            ApagarArquivosTemp();
                            Interacao();
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

        public void formPrincipal()
        {
            USB formUSB = new USB();
            this.Hide();
            formUSB.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formPrincipal();
        }

        public void QuantidadeDeTestes()
        {
            try
            {
                var quantidadeTestes = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_usb", "*.*", SearchOption.TopDirectoryOnly).Count().ToString();
                int valor = int.Parse(quantidadeTestes);
                if (valor == 6)
                {
                    QUANTIDADEARQUIVOS formQuantidade = new QUANTIDADEARQUIVOS();
                    this.Hide();
                    formQuantidade.Show();
                }

                if (valor > 6)
                {
                    QUANTIDADEARQUIVOS formQuantidade = new QUANTIDADEARQUIVOS();
                    this.Hide();
                    formQuantidade.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível encontrar pasta com arquivos!" + ex);
            }
        }
    }
}
