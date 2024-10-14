using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Management;
using FireSharp.Response;
using System.Drawing;

namespace AVELLCUSTOM1
{
    public partial class CUSTOM1 : MaterialSkin.Controls.MaterialForm
    {
        public string CUSTOMOK;
        public string CONFIRMACUSTOMOK;
        public string BON_LITE;
        public string TIMECUSTOM;
        public string TASKKILLCUSTOM;

        public CUSTOM1()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            ProcModelosNosLogs();
            VerificaArquivoSistema();
            Interacao();
            //Precisa ter um Delay nesta etapa
            TimeStart();
        }

        //Firebase
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            //Utilizando RealTimeDatabase do TestesAvell - OK Atualizado
            AuthSecret = "ni99x0Zyr1HfIsjyF92bKJuoazt3cc7HtsNDrcMF",
            BasePath = "https://testesavell-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private object res;

        public void StartFireBaseServices()
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir os dados");
            }
        }
        //Firebase

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\AvellCustm.mp3";
            wplayer.controls.play();
        }

        public void VerificaArquivoSistema()
        {
            string sistemaTxt = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
            bool caminho = File.Exists(sistemaTxt);
            if (caminho == false)
            {
                try
                {
                    //GerarLogsTeste
                    ProcessStartInfo GerarLogSistema = new ProcessStartInfo("cmd.exe", @"/C " + "systeminfo > C:\\TESTES_AVELL_VIRTUO\\systemInfo\\sistema.txt");
                    GerarLogSistema.UseShellExecute = false;
                    GerarLogSistema.CreateNoWindow = true;
                    Process.Start(GerarLogSistema);
                }
                catch (Exception ex) { }
            }
        }

        public void ProcModelosNosLogs()
        {
            try
            {
                //PRECISA POSTERIORMENTE NA VERSÃO 2 DEIXAR DE FORMA DINÂMICA - PERSISTIR DADOS
                //Ajustar para o usuários que estiver localdo
                string modeloA52 = "A52";
                string filePathA52 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA52 = new StreamReader(filePathA52);

                while (!readerA52.EndOfStream)
                {
                    string lineA52 = readerA52.ReadLine();
                    if (lineA52.Contains(modeloA52))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA52.Close();

                string modeloD58i = "D58i";
                string filePathD58i = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerD58i = new StreamReader(filePathD58i);

                while (!readerD58i.EndOfStream)
                {
                    string lineD58i = readerD58i.ReadLine();
                    if (lineD58i.Contains(modeloD58i))
                    {
                        // System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        //pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        //pProcess.Start();
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = "AvellCustomControl"; // Nome do executável sem o caminho
                        pProcess.StartInfo.UseShellExecute = true; // Importante para permitir que o sistema encontre o executável
                        pProcess.Start();
                        break;
                        break;
                    }
                }
                readerD58i.Close();

                //-----------------------------------------------------------------
                string modeloA55 = "A55";
                string filePathA55 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA55 = new StreamReader(filePathA55);

                while (!readerA55.EndOfStream)
                {
                    string lineA55 = readerA55.ReadLine();
                    if (lineA55.Contains(modeloA55))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA55.Close();

                //-----------------------------------------------------------------
                string modeloA57 = "A57";
                string filePathA57 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA57 = new StreamReader(filePathA57);

                while (!readerA57.EndOfStream)
                {
                    string lineA57 = readerA57.ReadLine();
                    if (lineA57.Contains(modeloA57))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA57.Close();

                //-----------------------------------------------------------------
                string modeloA70 = "A70";
                string filePathA70 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA70 = new StreamReader(filePathA70);

                while (!readerA70.EndOfStream)
                {
                    string lineA70 = readerA70.ReadLine();
                    if (lineA70.Contains(modeloA70))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA70.Close();

                //-----------------------------------------------------------------
                string modeloA72 = "A72";
                string filePathA72 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA72 = new StreamReader(filePathA72);

                while (!readerA72.EndOfStream)
                {
                    string lineA72 = readerA72.ReadLine();
                    if (lineA72.Contains(modeloA72))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA72.Close();

                //-----------------------------------------------------------------

                string modeloC65 = "C65";
                string filePathC65 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerC65 = new StreamReader(filePathC65);

                while (!readerC65.EndOfStream)
                {
                    string lineC65 = readerC65.ReadLine();
                    if (lineC65.Contains(modeloC65))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom Control.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerC65.Close();

                //-----------------------------------------------------------------
                string modeloBON = "B.ON";
                string filePathBON = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerBON = new StreamReader(filePathBON);

                while (!readerBON.EndOfStream)
                {
                    string lineBON = readerBON.ReadLine();
                    if (lineBON.Contains(modeloBON))
                    {
                        ChamarB_ON();
                        break;
                    }
                }
                readerBON.Close();

                //-----------------------------------------------------------------
                string modeloB11 = "B11";
                string filePathB11 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerB11 = new StreamReader(filePathB11);

                while (!readerB11.EndOfStream)
                {
                    string lineB11 = readerB11.ReadLine();
                    if (lineB11.Contains(modeloB11))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerB11.Close();
                //-----------------------------------------------------------------
                //Para o Custom, não foi preciso adicionar em separado "Storm BS", só com a palavra chave
                //"Storm" foi possível detectar a configuração do CUSTOM.
                string modeloStorm = "STORM";
                string filePathStorm = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerStorm = new StreamReader(filePathStorm);

                while (!readerStorm.EndOfStream)
                {
                    string lineStorm = readerStorm.ReadLine();
                    if (lineStorm.Contains(modeloStorm))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerStorm.Close();
                //-----------------------------------------------------------------

                string modeloA65 = "A65";
                string filePathA65 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA65 = new StreamReader(filePathA65);

                while (!readerA65.EndOfStream)
                {
                    string lineA65 = readerA65.ReadLine();
                    if (lineA65.Contains(modeloA65))
                    {
                        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
                        pProcess.StartInfo.FileName = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                        pProcess.Start();
                        break;
                    }
                }
                readerA65.Close();
                //-----------------------------------------------------------------
            }
            catch
            {
                MessageBox.Show("Arquivo sistema.txt não encontrado em: C:\\TESTES_AVELL_VIRTUO\\systemInfo", "ARQUIVO NÃO ENCONTRADO!");
            }
        }

        public void ChamarB_ON()
        {
            //Ajustado aqui para não mais abrir
            if (CUSTOMOK != "B_ON")
            {
                CUSTOMOK = "B_ON";
                B_ON formB_ON = new B_ON();
                this.Hide();
                formB_ON.ShowDialog();
            }
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            //Só vai iniciar a contagem se a máquina não for B.ON
            if (TIMECUSTOM != "OK")
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 21;
                relogio.Tick += delegate
                {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();
                        TIMECUSTOM = "OK";
                        VerificaPastaCustom();
                        //De qualquer forma o Custom não está sendo fechado aqui
                        //TaskKillCustom();
                    }
                };
                relogio.Start();
            }
        }

        public void VerificaPastaCustom()
        {
            if (CONFIRMACUSTOMOK != "OK")
            {
                //Não vou usar a tratativa do try catch, vou usar esta outra
                string CaminhoCustom = @"C:\Program Files\OEM";
                DateTime fileCreatedDate = File.GetCreationTime(CaminhoCustom);

                DateTime dt1 = DateTime.Parse("01/01/2023 00:00:00");
                DateTime dt2 = fileCreatedDate;

                if (dt2.Date > dt1.Date)
                {
                    MessageBox.Show("DATA OEM CUSTOM OK!" + fileCreatedDate, "DATA OEM CUSTOM OK!");

                    CONFIRMACUSTOMOK = "OK";
                    CONFIRMACUSTOM formConfirmaCustom = new CONFIRMACUSTOM();
                    this.Hide();
                    formConfirmaCustom.ShowDialog();
                }
                else
                {
                    try
                    {
                        //Firebase - Atualizado
                        var dataHoraMinuto = DateTime.Now.ToString("dd/MM/yyyy - HH:mm");
                        ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * From Win32_BIOS");
                        foreach (ManagementObject getserial in MOS1.Get())
                        {
                            string SerialAvell = getserial["SerialNumber"].ToString();
                            String InfoCustom = "Problemas de Licença Custom" + dataHoraMinuto;
                            var teste = new Custom
                            {
                                Serial = SerialAvell,
                                TCustom = InfoCustom
                            };
                            FirebaseResponse response = client.Update("TESTE_FUNVIRTUO/" + SerialAvell, teste);
                            SerialAvell = string.Empty;
                            InfoCustom = string.Empty;
                            break;
                        }
                        //Firebase - Atualizado
                    }
                    catch
                    {
                        lblFirebase.Text = "Firebase Off-Line";
                        lblFirebase.ForeColor = Color.Red;
                    }
                }
            }
        }

        public void TaskKillCustom()
        {
            if (TASKKILLCUSTOM != "OK")
            {
                try
                {
                    TASKKILLCUSTOM = "OK";
                    Process.Start("taskkill", "/F /IM ControlCenterU.exe");
                    Process.Start("taskkill", "/F /IM Avell Custom Control.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
