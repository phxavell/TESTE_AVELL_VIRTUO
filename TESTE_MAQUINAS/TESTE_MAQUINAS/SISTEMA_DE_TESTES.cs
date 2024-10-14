using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TESTE_MAQUINAS
{
    //public partial class Sistema_Teste : MaterialSkin.Controls.MaterialForm
    public partial class Sistema_Teste : Form
    {
        public string Fonte;
        public string WinAuditOK;
        public string InstaladorDriver;
        public Sistema_Teste()
        {
            InitializeComponent();
            TaskKillSysprep();
            tirarHiberna();
            InteracaoVirtuo();
            //Quem está chamado o StartTestes?
            StartTestes();
        }

        public void setTime()//Ajustado nova versão
        {
            try
            {
                Process sincronizarhora = System.Diagnostics.Process.Start(@"C:\TESTES_AVELL_VIRTUO\.executaveisAux\SincronizarHoraServer.exe");
                sincronizarhora.WaitForExit();
            }
            catch (Exception ex){ }
        }

        public void tirarHiberna()
        {
            try
            {
                //Tirar o Hibernar da máquina
                Process.Start(@"C:\TESTES_AVELL_VIRTUO\.executaveisAux\hibernarOff.vbs");
            }
            catch (Exception ex) { MessageBox.Show("Caminho não encontrado: C:\\TESTES_AVELL_VIRTUO\\.executaveisAux\\hibernarOff.vbs"); }
        }

        public void InteracaoVirtuo()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\TesteVirtuoEQualidade.mp3";
            wplayer.controls.play();
        }

        public void StartTestes()
        {
            try
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 5;

                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        WiFiConectLicenca();
                        setTime();
                        Iniciar();
                        timerBateria.Start();
                        CriarPastaLogs();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        public void WiFiConectLicenca()
        {
            ProcessStartInfo ConectarWifi1 = new ProcessStartInfo("cmd.exe", @"/C " + "netsh wlan add profile filename=C:\\TESTES_AVELL_VIRTUO\\.executaveisAux\\avell-infra-ultra.xml");
            ConectarWifi1.UseShellExecute = false;
            ConectarWifi1.CreateNoWindow = true;
            Process.Start(ConectarWifi1);

            //Conexão com Avell Infra-ultar
            ProcessStartInfo ConectarWifi2 = new ProcessStartInfo("cmd.exe", @"/C " + "netsh wlan connect ssid=avell-infra-ultra name=avell-infra-ultra");
            ConectarWifi2.UseShellExecute = false;
            ConectarWifi2.CreateNoWindow = true;
            Process.Start(ConectarWifi2);
        }

        public void TaskKillSysprep()
        {
            try
            {
                Process.Start("taskkill", "/F /IM sysprep.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void Iniciar()
        {
            CriarLogs();
            TimeStart1();
            //Depois de iniciar os testes
            //Vou copiar a pasta de lipeza
            CopiarLimparTestes();
        }

        public void CopiarLimparTestes()
        {
            try
            {
                //Copia toda pasta para Desktop, não importa qual é o usuário!
                string Usuario = System.Environment.UserName;
                string localOrigem = "C:\\TESTES_AVELL_VIRTUO\\.limparTestes\\";
                string localDestino = "C:\\Users\\" + Usuario + "\\Desktop\\LIMPAR_TESTES\\";

                if (!Directory.Exists(localDestino))
                {
                    Directory.CreateDirectory(localDestino);
                }
                foreach (var srcPath in Directory.GetFiles(localOrigem))
                {
                    File.Copy(srcPath, srcPath.Replace(localOrigem, localDestino), true);
                    //Aqui também copia o atalho
                    System.Threading.Thread.Sleep(2000);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 8;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    FrequenciaMonitor();
                    ModeloEquipamento();
                    lblTime.Text = "OK";
                    LeituraSerial();
                    TimeBateria1();
                    RoboTesteBurnin();
                }
            };
            relogio.Start();
        }

        public void LeituraSerial()
        {
            const string caminhoArquivoMySql = (@"C:\TESTES_AVELL_VIRTUO\MySqlData\SerialNumber.txt");
            if (File.Exists(caminhoArquivoMySql))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\TESTES_AVELL_VIRTUO\MySqlData\SerialNumber.txt");
                foreach (string line in lines)
                {
                    lblSerial.Text = (line);
                }
            }
        }
        public void CriarLogs()
        //Melhorar a nomenclatura deste método
        {
            try
            {
                //A Licença está sendo feita em outra etapa, conecta wi - fi, depois ativa a licença!
                //1-Conectar Wi-fi antes de tudo
                ProcessStartInfo ConectarWifi1 = new ProcessStartInfo("cmd.exe", @"/C " + "netsh wlan add profile filename=C:\\TESTES_AVELL_VIRTUO\\.executaveisAux\\avell-infra-ultra.xml");
                ConectarWifi1.UseShellExecute = false;
                ConectarWifi1.CreateNoWindow = true;
                Process.Start(ConectarWifi1);

                //2Conexão com Avell Infra-ultra
                ProcessStartInfo ConectarWifi2 = new ProcessStartInfo("cmd.exe", @"/C " + "netsh wlan connect ssid=avell-infra-ultra name=avell-infra-ultra");
                ConectarWifi2.UseShellExecute = false;
                ConectarWifi2.CreateNoWindow = true;
                Process.Start(ConectarWifi2);

                //3-Vai Chamar o Script de Inserção da licença avell lic 23
                //3.1-Primeiro vou desconectar unidade se estiver mapeada**********************************************
                ProcessStartInfo DesconectarZ = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Z: /delete");
                DesconectarZ.UseShellExecute = false;
                DesconectarZ.CreateNoWindow = true;
                Process.Start(DesconectarZ);

                //3.2-Segundo vou mapear a pasta onde está o bat para inserir a licença (Avell Lic23)
                ProcessStartInfo MapearCMDLic = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Z: \\\\tucuma\\windowssetup$ /user:localhost\\netadmin 8fc6716fa3");
                MapearCMDLic.UseShellExecute = false;
                MapearCMDLic.CreateNoWindow = true;
                Process.Start(MapearCMDLic);

                //4-Geração de logs de Testes
                //4.1-Gerar Losgs de Testes - Informações de sistemas de onde vai escolher a inicialização de Teclados e itens respectivos das máquinas
                ProcessStartInfo GerarLogSistema = new ProcessStartInfo("cmd.exe", @"/C " + "systeminfo > C:\\TESTES_AVELL_VIRTUO\\systemInfo\\sistema.txt");
                GerarLogSistema.UseShellExecute = false;
                GerarLogSistema.CreateNoWindow = true;
                Process.Start(GerarLogSistema);
                //4.2-Gerar Logs Referente frequencia de monitor
                ProcessStartInfo GerarFrequenciaMonitor = new ProcessStartInfo("cmd.exe", @"/C " + "wmic PATH Win32_videocontroller get currentrefreshrate > C:\\TESTES_AVELL_VIRTUO\\systemInfo\\FrequenciaMonitor.txt");
                GerarFrequenciaMonitor.UseShellExecute = false;
                GerarFrequenciaMonitor.CreateNoWindow = true;
                Process.Start(GerarFrequenciaMonitor);
                //4.3-Gerar logs Referentes ao Número de Série da máquina
                ProcessStartInfo GerarNumeroSerie = new ProcessStartInfo("cmd.exe", @"/C " + "wmic bios get serialnumber > C:\\TESTES_AVELL_VIRTUO\\MySqlData\\SerialNumber.txt");
                GerarNumeroSerie.UseShellExecute = false;
                GerarNumeroSerie.CreateNoWindow = true;
                Process.Start(GerarNumeroSerie);
                //4.4-Gerar Logs Referente ao Modelo da Máquina
                ProcessStartInfo GerarModelo = new ProcessStartInfo("cmd.exe", @"/C " + "wmic computersystem get model > C:\\TESTES_AVELL_VIRTUO\\systemInfo\\ModeloMaquina.txt");
                GerarModelo.UseShellExecute = false;
                GerarModelo.CreateNoWindow = true;
                Process.Start(GerarModelo);

                //4.5-Mapear unidade de rede Tucuma para logs
                //Enviar os logs para Y: Trocar em toda a estrutura
                ProcessStartInfo CompartilhamentoTucuma = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Y: \\\\tucuma\\windowssetup$\\avell-test-2023 /user:localhost\\netadmin 8fc6716fa3");
                CompartilhamentoTucuma.UseShellExecute = false;
                CompartilhamentoTucuma.CreateNoWindow = true;
                Process.Start(CompartilhamentoTucuma);

                TimeStart2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao criar log");
            }
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 10;
            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    WinAudit();
                }
            };
            relogio.Start();
        }

        public void WinAudit()
        {
            try
            {
                string strFile1 = File.ReadAllText(@"C:\TESTES_AVELL_VIRTUO\MySqlData\SerialNumber.txt");
                strFile1 = Regex.Replace(strFile1, @"SerialNumber", "");
                File.WriteAllText(@"C:\TESTES_AVELL_VIRTUO\winAudit\files1\SerialNumber.txt", strFile1);

                List<string> novasLinhas = new List<string>();
                string[] todasAsLinhas = File.ReadAllLines(@"C:\TESTES_AVELL_VIRTUO\winAudit\files1\SerialNumber.txt");
                foreach (string linha in todasAsLinhas)
                {
                    if (WinAuditOK != "OK!")
                    {
                        if (linha.Contains("AVNB"))
                        {
                            novasLinhas.Add(linha);
                            ProcessStartInfo GerarWinAudit = new ProcessStartInfo("cmd.exe", @"/C " + "@C:\\TESTES_AVELL_VIRTUO\\winAudit\\files1\\WinAudit.exe /r=gsoPxuTUeERNtnzDaIbMpmidcSArCOHG /f=" + linha + ".html /T=datetime");
                            GerarWinAudit.UseShellExecute = false;
                            GerarWinAudit.CreateNoWindow = true;
                            Process.Start(GerarWinAudit);
                            WinAuditOK = "OK!";
                        }
                    }
                }
                TimeStart3();
            }
            catch (Exception ex) { }
        }

        public void TimeStart3()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 70;
            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    CopiaArquivos();
                }
            };
            relogio.Start();
        }

        public void CopiaArquivos()
        {
            DirectoryInfo CopiaReplace = new DirectoryInfo(@"C:\TESTES_AVELL_VIRTUO\winAudit\files1");
            string outputDir = (@"C:\TESTES_AVELL_VIRTUO\winAudit");
            foreach (var file in CopiaReplace.GetFiles())
            {
                try
                {
                    File.Copy(file.FullName, Path.Combine(outputDir, Path.GetFileName(file.FullName).Replace(" ", ""))); 
                }
                catch (Exception ex) { }
            }
            TimeStart4();
        }

        public void TimeStart4()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;
            relogio.Tick += delegate {
                tempo -= 1;
                if (tempo == 0)
                {
                    relogio.Stop();
                    EnviarArquivosServer();
                }
            };
            relogio.Start();
        }

        public void EnviarArquivosServer()
        {
            string sourceDir = @"C:\TESTES_AVELL_VIRTUO\winAudit";
            string backupDir = @"Y:\";
            try
            {
                string[] txtList = Directory.GetFiles(sourceDir, "*.html");

                foreach (string f in txtList)
                {
                    try
                    {
                        string fName = f.Substring(sourceDir.Length + 1);
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }
                    catch (Exception ex) { }
                }
            }
            catch (DirectoryNotFoundException ex) { }
        }

        public void FrequenciaMonitor()
        {
            try
            {
                lblDisplay.Text = File.ReadAllText(@"C:\TESTES_AVELL_VIRTUO\systemInfo\FrequenciaMonitor.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não consegui detectar frequencia do Monitor");
            }
        }

        public void ModeloEquipamento()
        {
            try
            {
                lblModelo.Text = File.ReadAllText(@"C:\TESTES_AVELL_VIRTUO\systemInfo\ModeloMaquina.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não consegui detectar o modelo da máquina");
            }
        }


        public void RoboTesteBurnin()
        {
            //************************BURNIN**********************************
            ROBOTESTE.ROBOTESTE projetoBurnin = new ROBOTESTE.ROBOTESTE();
            projetoBurnin.Show();
            MinimizarForm();
            //****************************************************************
        }

        private void timerBateria_Tick(object sender, EventArgs e)
        {
            PowerStatus energia = SystemInformation.PowerStatus;

            pbBateria.Value = (int)(energia.BatteryLifePercent * 100);
            if (energia.BatteryLifeRemaining < 0)
                lblTempoDescarga.Text = "Carregando Bateria: Fonte ligada.";
            else
                lblTempoDescarga.Text = "Tempo Restante: " + new TimeSpan(0, 0, energia.BatteryLifeRemaining);
            lblPercentual.Text = energia.BatteryLifePercent.ToString("P");
        }

        public void CheckBateria2()
        {
            PowerStatus energia = SystemInformation.PowerStatus;

            pbBateria.Value = (int)(energia.BatteryLifePercent * 100);
            if (energia.BatteryLifeRemaining < 0)
                Fonte = "Conectada";
            else
                InformmaFonte();
        }

        public void InformmaFonte()
        {
            FONTEDESCONECTADA formFonteDesconectada = new FONTEDESCONECTADA();
            formFonteDesconectada.Show();
        }
        
        public void TimeBateria1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 2;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    timerBateria.Start();

                    CheckBateria2();
                }
            };
            relogio.Start();
        }

        public void CriarPastaLogs()
        {
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string NomeArquivo = (string)obj["SerialNumber"];
                string pastaLogs = @"C:\TESTES_AVELL_VIRTUO\MySqlData\" + NomeArquivo;
                try
                {
                    if (Directory.Exists(pastaLogs))
                    {
                        MessageBox.Show("Esta máquina já possui logos de testes!");
                    }
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(pastaLogs);
                    }
                }
                catch (Exception ex) { }
            }
        }

        public void MinimizarForm()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}