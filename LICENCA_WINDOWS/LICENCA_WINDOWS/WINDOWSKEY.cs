using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Management;

//using MaterialSkin;
//using FireSharp.Config;
//using FireSharp.Interfaces;
//using FireSharp.Response;


namespace LICENCA_WINDOWS
{
    public partial class WINDOWSKEY : Form
    {
        //Vou guardar a versão do Windows
        public string WINVER;

        public string ATIVADOOK;

        public WINDOWSKEY()
        {
            InitializeComponent();
            //VerificaMSKEY();
            MSKEYInfo();
            FilterWin();
        }

        public void FilterWin()
        {
            if (WINVER == null)
            {
                WindowsVer();
            }
            else if (WINVER == "ONZE")
            {
                VerificaMSKEY();
            }
        }

        public void WindowsVer()
        {
            // Consulta para obter informações sobre o sistema operacional
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection information = searcher.Get();

            foreach (ManagementObject obj in information)
            {
                // Obtém a descrição da edição do Windows
                string edition = obj["Caption"].ToString();

                // Exibe a edição do Windows
                lblWinVer.Text = (edition);

                if (edition == "Microsoft Windows 10 Home Single Language")
                {
                    WINVER = "DEZ";
                    ChamarAutidor();
                }
                else
                {
                    WINVER = "ONZE";
                    //MessageBox.Show(WINVER);
                    VerificaMSKEY();
                }
            }
        }

        //Verificar a versão do Windows
        public void VerificaMSKEY()
        {
            try
            {
                //Verifica se a máquina tem licença, se não tiver vai ficar no loop - Original ChatGPT
                Process process = new Process();
                process.StartInfo.FileName = "wmic";
                process.StartInfo.Arguments = "path softwarelicensingservice get OA3xOriginalProductKey";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Extract the product key from the output
                int index = output.IndexOf("OA3xOriginalProductKey");
                if (index != -1)
                {
                    string keySubstring = output.Substring(index + "OA3xOriginalProductKey".Length).Trim();

                    if (keySubstring != "")
                    {
                        lblTime.Text = keySubstring;
                        lblKey.Text = keySubstring;
                        lblTime.ForeColor = Color.DarkGreen;
                        lblLicencaWindows.Text = "CHAVE MICROSOFT OK!";
                        lblLicencaWindows.ForeColor = Color.DarkGreen;
                        //Chamar o Auditor
                        ChamarAutidor();
                    }
                    else
                    {
                        //Não possui ChaveMicrosoft, vou ativar esta máquina
                        TimeStart1();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não consegui verificar MSKEY", "MSKEY FALHA!");
            }
        }

        public void TimeStart1()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    RemoverUnidades();
                }
            };
            relogio.Start();
        }

        public void RemoverUnidades()
        {
            //Se existir as unidades mapeadas, vai tirar o mapeamento para fazer novamente
            try
            {
                ProcessStartInfo DesconectarY = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Y: /delete");
                DesconectarY.UseShellExecute = false;
                DesconectarY.CreateNoWindow = true;
                Process.Start(DesconectarY);
                //==============================================================================================
                ProcessStartInfo DesconectarZ = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Z: /delete");
                DesconectarZ.UseShellExecute = false;
                DesconectarZ.CreateNoWindow = true;
                Process.Start(DesconectarZ);
                lblTime.Text = "Y:/Z: Desconetar";

                TimeStart2();
            }
            catch (Exception ex) { }
        }

        public void TimeStart2()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    MapearUnidade();
                }
            };
            relogio.Start();
        }

        public void MapearUnidade()
        {
            //Aqui mapea novamente as unidades de rede()
            try
            {
                ProcessStartInfo MapearCMDLic = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Z: \\\\tucuma\\windowssetup$ /user:localhost\\netadmin 8fc6716fa3");
                MapearCMDLic.UseShellExecute = false;
                MapearCMDLic.CreateNoWindow = true;
                Process.Start(MapearCMDLic);

                ProcessStartInfo MapearCMDLog = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Y: \\\\tucuma\\windowssetup$\\avell-test-2023 /user:localhost\\netadmin 8fc6716fa3");
                MapearCMDLog.UseShellExecute = false;
                MapearCMDLog.CreateNoWindow = true;
                Process.Start(MapearCMDLog);

                lblTime.Text = "Y:/Z: Reconectar";

                TimeStart3();
            }
            catch (Exception ex) { }
        }

        public void TimeStart3()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    InserirLicencaMicrosoft();
                }
            };
            relogio.Start();
        }

        public void InserirLicencaMicrosoft()
        {
            //Processo de inserção de licença - Chamar arquivos
            try
            {
                lblTime.Text = "Inserir Licença";

                string caminhoDoPrograma = @"Z:\scripts\startnet.cmd";
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = caminhoDoPrograma,
                };
                Process processo = new Process { StartInfo = startInfo };
                processo.Start();
                processo.WaitForExit();

                GerarLog();
            }
            catch  (Exception ex)
            {
                    //Aqui vai ser direcionado para o loop ou para o próximo teste
                    lblTime.Text = "Não consegui Inserir a Chave, tentar denovo!";
                    VerificaMSKEY();
            }
        }

        public void GerarLog()
        {
            try
            {
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Drivers = @"C:\TESTES_AVELL\log_licenca\licenca.log";
                var Arquivo = File.AppendText(Drivers);
                Arquivo.WriteLine("LICENÇA INSERIDA: " + dataHoraMinutoOK);
                Arquivo.Close();
                lblTime.Text = "Verificando Chave Microsoft.";
                VerificaMSKEY();
            }
            catch (Exception e)
            {
                //Voltar para loop
            }
        }

        public void ChamarAutidor()
        {
            if (ATIVADOOK != "OK")
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

                        ATIVADOOK = "OK";
                        ////CHAMAR AUDITOR (CONFERIR DADOS MÁQUINA)
                        AUDITOR.AUDITOR formAuditorStart = new AUDITOR.AUDITOR();
                        this.Hide();
                        formAuditorStart.ShowDialog();
                    }
                };
                relogio.Start();
            }
        }

        public void MSKEYInfo()// -- Somente para Informar se já possui licenca e a chave
        {
            try
            {
                //Verifica se a máquina tem licença, se não tiver vai ficar no loop - Original ChatGPT
                Process process = new Process();
                process.StartInfo.FileName = "wmic";
                process.StartInfo.Arguments = "path softwarelicensingservice get OA3xOriginalProductKey";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Extract the product key from the output
                int index = output.IndexOf("OA3xOriginalProductKey");
                if (index != -1)
                {
                    string keySubstring = output.Substring(index + "OA3xOriginalProductKey".Length).Trim();

                    if (keySubstring != "")
                    {
                        lblKey.Text = keySubstring;
                        lblKey.ForeColor = Color.DarkGreen;
                        lblLicencaWindows.Text = "CHAVE MICROSOFT OK!";
                        lblLicencaWindows.ForeColor = Color.DarkGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                //Messagebox.Show("Não foi possível verificar", ex);
            }
        }
    }
}
