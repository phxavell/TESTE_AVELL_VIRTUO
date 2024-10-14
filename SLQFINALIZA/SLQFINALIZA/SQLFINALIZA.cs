using System;
using System.IO;
using System.Windows.Forms;

namespace SLQFINALIZA
{
    public partial class SQLFINALIZA : MaterialSkin.Controls.MaterialForm
    {
        public SQLFINALIZA()
        {
            InitializeComponent();
            ListarArquivos();
            Interacao();
            TimeStart1();
        }

        public void ListarArquivos()
        {
            try
            {
                DirectoryInfo Dir = new DirectoryInfo(@"C:\TESTES_AVELL");
                FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
                foreach (FileInfo File in Files)
                {
                    //listbArquivos1.Items.Add(File.FullName); - Mostra caminho completo
                    listBoxTeste.Items.Add(File);
                }
            }
            catch (Exception ex) { }
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\FinalizandoTestes.mp3";
            wplayer.controls.play();
        }

        public void TimeStart1()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 10;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Inserir aqui próximo método
                    Limpeza1Pastas();
                    TimeStart2();
                    listBoxTeste.Items.Clear();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    //Inserir aqui próximo método
                    ListarArquivos();
                    GerarLogIndividual();
                    ConfirmarFinalizacao();
                }
            };
            relogio.Start();
        }

        public void Limpeza1Pastas()
        {
            try
            {
                //Executar ação somente se existir diretório ou pasta
                string caminho = (@"C:\TESTES_AVELL");
                if (Directory.Exists(caminho))
                {
                    lblStatus.Text = "Arquivos Temporários apagados.";
                    System.IO.Directory.Delete(@"C:\TESTES_AVELL", true);
                    //Finaliza depois de tudo
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 5;
                    relogio.Tick += delegate {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            relogio.Stop();
                        }
                    };
                    relogio.Start();
                }
            }
            catch(Exception ex) { }
        }

        public void GerarLogIndividual()
        {
            try
            {
                //Gera Log de Instalado para os Drivers
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Drivers = @"C:\TESTES_AVELL\logs_auditor\Auditor.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("TESTE AUDITOR REALIZADO: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
            catch (Exception ex) { }
        }

        public void ConfirmarFinalizacao()
        {
            CONFIRMARFINALIZA formConfirmaFinaliza = new CONFIRMARFINALIZA();
            this.Hide();
            formConfirmaFinaliza.ShowDialog();
        }
    }
}
