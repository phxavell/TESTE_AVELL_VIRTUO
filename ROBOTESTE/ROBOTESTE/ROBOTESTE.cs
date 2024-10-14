using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ROBOTESTE.Click;
//https://www.youtube.com/watch?v=mydcHC6379A&t=2s

namespace ROBOTESTE
{
    public partial class ROBOTESTE : Form
    {
        public string BurninTeste;
        public string Coordenada1;
        public string Coordenada2;
        public string Coordenada3;
       



        //Muito mais eficiente, utiliza ("user32.dll") - Do Windows
        Click c = new Click();

        public ROBOTESTE()
        {
            InitializeComponent();
            //Primeiro vai verificar se apresentou falhas!
            Verificador();
        }

    


        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\InicioBurnin.mp3";
            wplayer.controls.play();
        }

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL_VIRTUO\logs_burnin", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor < 2)
            {
                AbrirPrograma();
                Interacao();
            }
            else if (valor > 1)
            {
                //Utilizar este método melhorado para chamar todos os outros forms do teste.
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
        }

        public void AbrirPrograma()
        {
            if (BurninTeste != "Active1")
            //Para não entrar em loop
            {
                try
                {
                    //Sincronizar data e hora antes de startar o burnin-teste
                    setTime();
                    var startInfo = new ProcessStartInfo(@"C:\TESTES_AVELL_VIRTUO\burnin\bit.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    Process.Start(startInfo);
                    TimeStart();

                }
                catch (Exception e)
                {
                    BurninTeste = "Active1";
                    SemBurnin();
                }
            }
        }

        public void TimeStart()
        //Preciso adicionar este time para tirar o bug de abrir o form antes de finalizar o processo.
        {
            if (BurninTeste != "Active1")
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
                        VerificarModelo();
                    }
                };
                relogio.Start();
            }
        }

        public void SemBurnin()
        {
            AVISOBURNIN formSemBurnin = new AVISOBURNIN();
            this.Hide();
            formSemBurnin.ShowDialog();
        }

        public void setTime()
        {
            try
            {
                Process sincronizarhora = System.Diagnostics.Process.Start(@"C:\TESTES_AVELL_VIRTUO\.executaveisAux\SincronizarHoraServer.exe");
                sincronizarhora.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Não foi possível encontrar o Sincronizador de Data e Hora!");
            }
        }

        public void VerificarModelo()
        {
            BurninTeste = "Active1";

            SelectQuery tecladoAvell = new SelectQuery("Win32_BIOS");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(tecladoAvell);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            foreach (ManagementObject filtroPorBios in osDetailsCollection)
            {
                string selecaoVersao = (filtroPorBios["SMBIOSBIOSVersion"].ToString());

                if (selecaoVersao == "1.07.11TBN1")
                {
                    lblModelo.Text = "A52-MOB";
                    ROBO_A55HYB_TELA15();
                }
                if (selecaoVersao == "N.1.05AVE04")
                {
                    lblModelo.Text = "A52-MOB";
                    ROBO_A52MOB_TELA15();
                }
                if (selecaoVersao == "N.1.22AVE00")
                {
                    lblModelo.Text = "BIOS: N.1.22AVE00";
                    ROBO_STORMX_TELA17();
                }
                if (selecaoVersao == "N.1.13AVE01")
                {
                    lblModelo.Text = "BIOS: N.1.13AVE01";
                    ROBO_A52ION_TELA15();
                }
                if (selecaoVersao == "N.1.08AVE00")
                {
                    lblModelo.Text = "A72-ION";
                    ROBO_A72ION_TELA15();
                }
                if (selecaoVersao == "N.1.08AVE04")
                {
                    lblModelo.Text = "A52-HYB NEW / STORM BS";
                    ROBO_A52HYBNEW_TELA15();
                }
                if (selecaoVersao == "N.1.10AVE03")
                {
                    lblModelo.Text = "A70HYB / STORM 2";
                    ROBO_A70HYB_STORM2_TELA_17_2();
                }
                if (selecaoVersao == "N.1.10AVE04")
                {
                    lblModelo.Text = "A70HYB / STORM 2";
                    ROBO_A70HYB_STORM2_TELA15_17();
                }
                if (selecaoVersao == "N.1.13AVE05")
                {//Adicionado outrava versãoStorm2*********
                    lblModelo.Text = "A70HYB / STORM 2";
                    ROBO_A70HYB_STORM2_TELA_17_2();
                }//Adicionado outrava versãoStorm2*********
                if (selecaoVersao == "N.1.07AVE02")
                {
                    lblModelo.Text = "A70HYB";
                    ROBO_A70HYB_3050_TELA15();
                }
                if (selecaoVersao == "N.1.04AVE00")
                {//Adicionando - versão de bios #
                    lblModelo.Text = "A70MOB 3050";
                    ROBO_A70MOB_3050_TELA15();
                }
                if (selecaoVersao == "N.1.07AVE00")
                {
                    lblModelo.Text = "A70MOB / A72LIV";
                    ROBO_A70MOB_TELA15();
                }
                if (selecaoVersao == "1.07.06TBN")
                {
                    lblModelo.Text = "B.ON LITE";
                    ROBO_BONLITE_TELA15();
                }
                if (selecaoVersao == "N.1.09AVE00")
                {
                    lblModelo.Text = "STORM GO";
                    ROBO_STORMGO_TELA16();
                }
                if (selecaoVersao == "N.1.01")
                {
                    lblModelo.Text = "C65 LIV";
                    ROBO_STORMGO_TELA16();
                }
                if (selecaoVersao == "N.1.01AVE00")
                {
                    lblModelo.Text = "B11 MOB";
                    ROBO_B11MOB_TELA11();
                }
                if (selecaoVersao == "N.1.09AVE01")
                {
                    lblModelo.Text = "A65ION";
                    ROBO_A65_TELA16();
                }
                //Adicionado modelo Antigo A62LIV
                if (selecaoVersao == "N.1.03")
                {
                    lblModelo.Text = "A62 LIV";
                    ROBO_A62_TELA15();
                }
                //Adicionado modelo Antigo A62LIV
                if (selecaoVersao == "N.1.02")
                {
                    lblModelo.Text = "A62 LIV";
                    ROBO_A62_TELA15();
                } 
                //validacao
                if (selecaoVersao == "N.1.10AVE01")
                {
                    lblModelo.Text = "A70 ION";
                    ROBO_A70ION();
                }
                if (selecaoVersao == "N.1.04Ave01")
                {
                    lblModelo.Text = "A52i ION - D58i";
                    ROBO_A70HYB_STORM2_TELA_17_2();
                }
                if (selecaoVersao == "N.1.09AVE02")
                {
                    lblModelo.Text = "A65 ION";
                    ROBO_STORMGO_TELA16();
                }
                if (selecaoVersao != "N.1.04Ave01" && selecaoVersao != "N.1.10AVE01" && selecaoVersao != "1.07.11TBN1" && selecaoVersao != "N.1.10AVE03" && selecaoVersao != "N.1.05AVE04" &&
                    selecaoVersao != "N.1.22AVE00" && selecaoVersao != "N.1.13AVE01" && selecaoVersao != "N.1.08AVE00" &&
                    selecaoVersao != "N.1.08AVE04" && selecaoVersao != "N.1.10AVE04" && selecaoVersao != "N.1.13AVE05" &&
                    selecaoVersao != "N.1.07AVE02" && selecaoVersao != "N.1.04AVE00" && selecaoVersao != "N.1.07AVE00" &&
                    selecaoVersao != "1.07.06TBN" && selecaoVersao != "N.1.09AVE00" && selecaoVersao != "N.1.01" &&
                    selecaoVersao != "N.1.01AVE00" && selecaoVersao != "N.1.09AVE01"&& selecaoVersao != "N.1.03" &&
                    selecaoVersao != "N.1.02")
                {
                    NAOCADASTRADA formNaoCadastrada = new NAOCADASTRADA();
                    this.Hide();
                    formNaoCadastrada.Show();
                }
                break;
            }
        }

        //Métodos de Click
        public void ROBO_A55HYB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 345;
                    p.Y = 55;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo < 0)
                        {
                            //Windows 11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 830;
                            p.Y = 510;
                            c.leftClick(p);
                        }

                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }

        }

        public void ROBO_A52MOB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 830;
                            p.Y = 510;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();

            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_STORMX_TELA17()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";

                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 920;
                            p.Y = 625;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A52ION_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";

                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 510;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 570;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A72ION_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";

                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";

                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 625;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A52HYBNEW_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 345;
                    p.Y = 58;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 514;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 570;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70HYB_STORM2_TELA_17_2()
        {//Versão adicionada, como se houvesse versão N.1.10AVE03
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 514;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 570;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70ION()
        {//Versão adicionada, como se houvesse versão N.1.10AVE03
            Coordenada1 = "OK";
            try
                {
                if (Coordenada1 == "OK")
                    {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 337;
                    p.Y = 14;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 337;
                            p.Y = 14;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                /*if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 570;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                */
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70HYB_STORM2_TELA15_17()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 514;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 925;
                            p.Y = 570;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70HYB_3050_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 515;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70MOB_3050_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 515;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        
        //=================================AJUSTAR PARA ESTE MÉTODO=========================================
        public void ROBO_A70MOB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    //ROBO_A70MOB_TELA15CLK1()
                  //  Helpers.BringWindowToFront("bit");
                    Coordenada2 = "OK";
                    
                      Point p = new Point();
                    //tempo
                      p.X = 354;
                      p.Y = 60;
                      c.rightClick(p);
                      p.X = 354;
                      p.Y = 60;
                      System.Threading.Thread.Sleep(500);
                      c.leftClick(p);
                    

                }
               /* if (Coordenada2 == "OK")
                {
                    ROBO_A70MOB_TELA15CLK2();
                }
               */
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A70MOB_TELA15CLK2()
        {
            Coordenada3 = "OK";
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 10;
            relogio.Tick += delegate
            {
                tempo -= 1;
                if (tempo == 0)
                {
                    //Windows11
                    relogio.Stop();
                    Point p = new Point();
                    p.X = 835;
                    p.Y = 514;
                    c.leftClick(p);
                    ROBO_A70MOB_TELA15CLK3();
                }
            };
            relogio.Start();
        }

        public void ROBO_A70MOB_TELA15CLK3()
        {
            Point p = new Point();
            p.X = 1023;
            p.Y = 627;
            c.leftClick(p);
            ROBO_A70MOB_TELA15CLK4();
        }

        public void ROBO_A70MOB_TELA15CLK4()
        {
            Point p = new Point();
            p.X = 920;
            p.Y = 570;
            c.leftClick(p);
        }
        //=================================AJUSTAR PARA ESTE MÉTODO=========================================

        public void ROBO_BONLITE_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 345;
                    p.Y = 60;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 510;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                if (Coordenada3 == "OK")
                {
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows10
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 1023;
                            p.Y = 627;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_STORMGO_TELA16()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                     Coordenada2 = "OK";
                     Point p = new Point();
                     p.X = 340;
                     p.Y = 55;
                     c.leftClick(p);
                    
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 920;
                            p.Y = 620;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_B11MOB_TELA11()
        {
            Coordenada1 = "OK";
            try
            {//AJUSTANDO...
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 335;
                    p.Y = 55;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 788;
                            p.Y = 530;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void Temporizador()
        {
            TEMPORIZADOR formTemporizador = new TEMPORIZADOR();
            this.Hide();
            formTemporizador.ShowDialog();
        }

        private void llabelSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public void ROBO_A65_TELA16()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 55;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 920;
                            p.Y = 620;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ROBO_A62_TELA15()
        {
            //Adicionado modelo antigo LIV
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 340;
                    p.Y = 55;
                    c.leftClick(p);
                }
                if (Coordenada2 == "OK")
                {
                    //Coordenada3 = "OK";
                    Timer relogio = new Timer();
                    relogio.Interval = 1000;
                    int tempo = 10;
                    relogio.Tick += delegate
                    {
                        tempo -= 1;
                        if (tempo == 0)
                        {
                            //Windows11
                            relogio.Stop();
                            Point p = new Point();
                            p.X = 835;
                            p.Y = 510;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                Temporizador();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        private void pBoxAvell_Click(object sender, EventArgs e)
        {

        }

        private void ROBOTESTE_Load(object sender, EventArgs e)
        {

        }
    }
}