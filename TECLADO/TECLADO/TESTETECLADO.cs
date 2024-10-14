using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Management;

namespace TECLADO
{
    public partial class TESTETECLADO : MaterialSkin.Controls.MaterialForm
    {
        public TESTETECLADO()
        {
            InitializeComponent();
            //Se arquivo de referencia não existir, cria.
            VerificaArquivoSistema();
            Interacao();
            TimeStart();
        }

        public void VerificaArquivoSistema()
        {
            //Verificar se o arquivo existe, se não existir, vou criar:
            //Vou usuar uma variável booleana para verificar 'true' ou false 'false'
            //Adicionar em todos os testes que fazem consulta no arquivo sistema.txt
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

        public void Interacao()
        {
            //Asterisk/Beep/Exclamation/Hand/Question - Não utilizados Aqui
            //SystemSounds.Hand.Play();
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\Teclado.mp3";
            wplayer.controls.play();
        }

        public void TimeStart()
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
                    ProcModelosNosLogs();
                }
            };
            relogio.Start();
        }

        public void ProcModelosNosLogs()
        {
            try
            {
                //PRECISA POSTERIORMENTE NA VERSÃO 3 DEIXAR DE FORMA DINÂMICA - PERSISTIR DADOS
                string modeloC65 = "C65";
                string filePathC65 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerC65 = new StreamReader(filePathC65);

                while (!readerC65.EndOfStream)
                {
                    string lineC65 = readerC65.ReadLine();
                    if (lineC65.Contains(modeloC65))
                    {
                        TECLADO1 formTeclado1 = new TECLADO1();
                        this.Hide();
                        formTeclado1.ShowDialog();
                        break;
                    }
                }
                readerC65.Close();

                string modeloD58i = "D58i";
                string filePathD58i = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerD58 = new StreamReader(filePathD58i);

                while (!readerD58.EndOfStream)
                {
                    string lineD58i = readerD58.ReadLine();
                    if (lineD58i.Contains(modeloD58i))
                    {
                        TECLADO2 formTeclado2 = new TECLADO2();
                        this.Hide();
                        formTeclado2.ShowDialog();
                        break;
                    }
                }
                readerD58.Close();

                //-----------------------------------------------------------------
                string modeloA55 = "A55";
                string filePathA55 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA55 = new StreamReader(filePathA55);

                while (!readerA55.EndOfStream)
                {
                    string lineA55 = readerA55.ReadLine();
                    if (lineA55.Contains(modeloA55))
                    {
                        TECLADO3 formTeclado3 = new TECLADO3();
                        this.Hide();
                        formTeclado3.ShowDialog();
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
                        TECLADO3 formTeclado3 = new TECLADO3();
                        this.Hide();
                        formTeclado3.ShowDialog();
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
                        //Nova estrutura para seleção do teclado pela BIOS, matar o while
                        SelectQuery tecladoAvell = new SelectQuery("Win32_BIOS");
                        ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(tecladoAvell);
                        ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                        foreach (ManagementObject filtroPorBios in osDetailsCollection)
                        {
                            string selecaoVersao = (filtroPorBios["SMBIOSBIOSVersion"].ToString());

                            if (selecaoVersao == "N.1.10AVE01")
                            {
                                //Se for esta versão de BIOS chamará o novo Techado
                                TECLADO7 formTeclado70ION = new TECLADO7();
                                this.Hide();
                                formTeclado70ION.ShowDialog();
                            }

                            if (selecaoVersao == "N.1.08AVE00")
                            {
                                //Se for esta versão de BIOS chamará o novo Techado
                                TECLADO7 formTeclado7 = new TECLADO7();
                                this.Hide();
                                formTeclado7.ShowDialog();
                            }
                       /*     else
                            {
                                //Se for a versão anterior vai chamar o layout antigo
                                TECLADO2 formTecladoA70 = new TECLADO2();
                                this.Hide();
                                formTecladoA70.ShowDialog();
                            }
                       */
                        }
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
                        //Nova estrutura para seleção do teclado pela BIOS, matar o while
                        SelectQuery tecladoAvell = new SelectQuery("Win32_BIOS");
                        ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(tecladoAvell);
                        ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                        foreach (ManagementObject filtroPorBios in osDetailsCollection)
                        {
                            string selecaoVersao = (filtroPorBios["SMBIOSBIOSVersion"].ToString());

                            if (selecaoVersao == "N.1.08AVE00")
                            {
                                //Se for esta versão de BIOS chamará o novo Techado
                                TECLADO7 formTeclado7 = new TECLADO7();
                                this.Hide();
                                formTeclado7.ShowDialog();
                            }
                            else
                            {
                                //Se for a versão anterior vai chamar o layout antigo
                                TECLADO2 formTecladoA70 = new TECLADO2();
                                this.Hide();
                                formTecladoA70.ShowDialog();
                            }
                        }
                        break;
                    }
                }
                readerA72.Close();

                //-----------------------------------------------------------------
                string modeloBON = "B.ON";
                string filePathBON = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerBON = new StreamReader(filePathBON);

                while (!readerBON.EndOfStream)
                {
                    string lineBON = readerBON.ReadLine();
                    if (lineBON.Contains(modeloBON))
                    {
                        TECLADO3 formTeclado3 = new TECLADO3();
                        this.Hide();
                        formTeclado3.ShowDialog();
                        break;
                    }
                }
                readerBON.Close();

                //-----------------------------------------------------------------
                string modeloA52 = "A52";
                string filePathA52 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA52 = new StreamReader(filePathA52);

                while (!readerA52.EndOfStream)
                {
                    string lineA52 = readerA52.ReadLine();
                    if (lineA52.Contains(modeloA52))
                    {
                        TECLADO2 formTeclado2 = new TECLADO2();
                        this.Hide();
                        formTeclado2.ShowDialog();
                        break;
                    }
                }
                readerA52.Close();

                //-----------------------------------------------------------------
                string modeloB11 = "B11";
                string filePathB11 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerB11 = new StreamReader(filePathB11);

                while (!readerB11.EndOfStream)
                {
                    string lineB11 = readerB11.ReadLine();
                    if (lineB11.Contains(modeloB11))
                    {
                        //Verificar se realmente o B11 é esse layout
                        TECLADO2 formTeclado2 = new TECLADO2();
                        this.Hide();
                        formTeclado2.ShowDialog();
                        break;
                    }
                }
                readerB11.Close();

                //-----------------------------------------------------------------
                string modeloStorm = "STORM";
                string filePathStorm = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerStorm = new StreamReader(filePathStorm);

                while (!readerStorm.EndOfStream)
                {
                    string lineStorm = readerStorm.ReadLine();
                    if (lineStorm.Contains(modeloStorm))
                    {
                        //Nova estrutura para seleção do teclado pela BIOS, matar o while
                        SelectQuery tecladoAvell = new SelectQuery("Win32_BIOS");
                        ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(tecladoAvell);
                        ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                        foreach (ManagementObject filtroPorBios in osDetailsCollection)
                        {
                            string selecaoVersao = (filtroPorBios["SMBIOSBIOSVersion"].ToString());

                            if (selecaoVersao == "N.1.10AVE04")
                            {
                                TECLADO2 formTeclado2 = new TECLADO2();
                                this.Hide();
                                formTeclado2.ShowDialog();
                            }
                            else if (selecaoVersao == "N.1.09AVE00")
                            {
                                TECLADO6 formTeclado2 = new TECLADO6();
                                this.Hide();
                                formTeclado2.ShowDialog();
                            }
                            else if (selecaoVersao == "N.1.22AVE00")
                            {
                                TECLADO2 formTeclado2 = new TECLADO2();
                                this.Hide();
                                formTeclado2.ShowDialog();
                            }
                            else if (selecaoVersao == "N.1.13AVE05")
                            {
                                TECLADO2 formTeclado2 = new TECLADO2();
                                this.Hide();
                                formTeclado2.ShowDialog();
                            }
                        }
                        break;
                    }
                }
                readerStorm.Close();

                //-----------------------------------------------------------------
                //Adicionado Layout de modelo antigo
                string modeloA65 = "A65";
                string filePathA65 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA65 = new StreamReader(filePathA65);

                while (!readerA65.EndOfStream)
                {
                    string lineA65 = readerA65.ReadLine();
                    if (lineA65.Contains(modeloA65))
                    {
                        TECLADO2 formTeclado4 = new TECLADO2();
                        this.Hide();
                        formTeclado4.ShowDialog();
                        break;
                    }
                }
                readerA65.Close();

                //-----------------------------------------------------------------
                string modeloC62 = "C62";
                string filePathC62 = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerC62 = new StreamReader(filePathC62);

                while (!readerC62.EndOfStream)
                {
                    string lineC62 = readerC62.ReadLine();
                    if (lineC62.Contains(modeloC62))
                    {
                        TECLADO5 formTeclado5 = new TECLADO5();
                        this.Hide();
                        formTeclado5.ShowDialog();
                        break;
                    }
                }
                readerC62.Close();

                //-----------------------------------------------------------------
                string modeloStormBS = "STORM BS";
                string filePathStormBS = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerStormBS = new StreamReader(filePathStormBS);

                while (!readerStormBS.EndOfStream)
                {
                    string lineStormBS = readerStormBS.ReadLine();
                    if (lineStormBS.Contains(modeloStormBS))
                    {
                        TECLADO2 formTeclado2 = new TECLADO2();
                        this.Hide();
                        formTeclado2.ShowDialog();
                        break;
                    }
                }
                readerStormBS.Close();
                //-----------------------------------------------------------------

                string modeloA62Liv = "A62 LIV";
                string filePathA62Liv = @"C:\TESTES_AVELL_VIRTUO\systemInfo\sistema.txt";
                StreamReader readerA62Liv = new StreamReader(filePathStormBS);

                while (!readerA62Liv.EndOfStream)
                {
                    string lineA62Liv = readerA62Liv.ReadLine();
                    if (lineA62Liv.Contains(modeloA62Liv))
                    {
                        TECLADO2 formTeclado2 = new TECLADO2();
                        this.Hide();
                        formTeclado2.ShowDialog();
                        break;
                    }
                }
                readerStormBS.Close();
                //-----------------------------------------------------------------
            }
            catch
            {
                MessageBox.Show("Arquivo sistema.txt não encontrado em: C:\\TESTES_AVELL_VIRTUO\\systemInfo", "ARQUIVO NÃO ENCONTRADO!");
            }
        }

        private void pictureBoxTeclado_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirme_Click(object sender, EventArgs e)
        {

        }
    }
}