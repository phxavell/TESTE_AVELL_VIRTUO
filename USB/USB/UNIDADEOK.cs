using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace USB
{
    public partial class UNIDADEOK : MaterialSkin.Controls.MaterialForm
    {
        public string ARQUIVOSOK;

        public UNIDADEOK()
        {
            InitializeComponent();
            //Verificador();
            Interacao();
            CriarLogPendrive();
            CriarLogInteracao();
            CopiaMediaRemovivel();
            ListarArquivos2();
        }

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_usb", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor == 1)
            {
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
            else if (valor != 1)
            {
                Interacao();
                CriarLogPendrive();
                CriarLogInteracao();
                CopiaMediaRemovivel();
                ListarArquivos2();
            }
        }

        public void Interacao()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\USBListadeArquivos.mp3";
            wplayer.controls.play();
        }

        public void CriarLogPendrive()
        {
            try
            {
                //OK = "true";
                var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
                if (drives.FirstOrDefault() != null)
                {
                    //Aqui pega informações do pendrive testado
                    string nomeUnidade = drives.FirstOrDefault().Name.ToString();
                    string formatoDriver = drives.FirstOrDefault().DriveFormat.ToString();
                    string tipoDriver = drives.FirstOrDefault().DriveType.ToString();
                    string status = drives.FirstOrDefault().IsReady.ToString();
                    string espacoLivre = drives.FirstOrDefault().TotalFreeSpace.ToString();
                    string espacoTotal = drives.FirstOrDefault().TotalSize.ToString();

                    //Aqui grava o arquivo de log com as informações do pendrive
                    string DataHoraTipo3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    string DataHoraTipo4 = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                    StreamWriter sw = new StreamWriter(@"C:\TESTES_AVELL_VIRTUO\logs_usb\" + DataHoraTipo4 + ".txt");

                    sw.WriteLine(DataHoraTipo3);
                    sw.WriteLine("Unidade:" + nomeUnidade);
                    sw.WriteLine("Formato:" + formatoDriver);
                    sw.WriteLine("Tipo:" + tipoDriver);
                    sw.WriteLine("Status:" + status);
                    sw.WriteLine("Espaço Livre:" + espacoLivre);
                    sw.WriteLine("Espaço Total:" + espacoTotal);
                    sw.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar log" + ex);
            }
        }

        public void CriarLogInteracao()
        {
            try
            {
                //Criar log de voz
                StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL_VIRTUO\logs_usb\Interacao1.txt");
                sw2.WriteLine("OK!");
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void CopiaMediaRemovivel()
        {
            //Copia para a mídia removível
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                string unidade = drives.FirstOrDefault().Name.ToString();
                string origem = @"C:\TESTES_AVELL_VIRTUO\usb_origem";
                string destino = unidade + "\\TESTES_AVELL_VIRTUO\\usb_destino";
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }
                foreach (var srcPath in Directory.GetFiles(origem))
                {
                    File.Copy(srcPath, srcPath.Replace(origem, destino), true);
                }
            }
        }

        //Ajustar para ser dinâmico conform letra da unidade do pen-drive
        public void ListarArquivos2()
        {
            //Ajuste listar aquivos****************************************************************************
            if (ARQUIVOSOK != "ARQUIVOSLISTA")
            {
                try
                {
                    var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
                    if (drives.FirstOrDefault() != null)
                    {
                        string unidade = drives.FirstOrDefault().Name.ToString();
                        string destino = unidade + "\\TESTES_AVELL_VIRTUO\\";
                        //var Exluir = new DirectoryInfo(destino);

                        DirectoryInfo Dir2 = new DirectoryInfo(destino);
                        FileInfo[] Files2 = Dir2.GetFiles("*", SearchOption.AllDirectories);
                        foreach (FileInfo File2 in Files2)
                        {
                            listbArquivos2.Items.Add(File2.FullName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Localizar pastas de arquivos" + ex);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ARQUIVOSOK != "OK")
            {
                TaskkillCustom();//Adicionado para dar um Kill nesse processo

                ARQUIVOSOK = "ARQUIVOSLISTA";
                ARQVIVOSTEMP formArquivosTemp = new ARQVIVOSTEMP();
                this.Hide();
                formArquivosTemp.Show();
            }
        }

        public void TaskkillCustom()
        {
            Process.Start("taskkill", "/F /IM AVELL CUSTOM.exe");
            //Process.Start("taskkill", "/F /IM Avell Custom Control.exe");
        }

        private void panelOK_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
