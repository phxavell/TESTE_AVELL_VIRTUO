using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace CONTROL_COOLER
{
    public partial class COOLERS2 : MaterialSkin.Controls.MaterialForm
    {
        public string ControlCooler;
        public string Coordenada1;
        public string Coordenada2;
        public string Coordenada3;

        Click c = new Click();

        public COOLERS2()
        {
            InitializeComponent();
            Color1();
            StartCustomControl();
            InteracaoGPU_CPU();
        }

        public void InteracaoGPU_CPU()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\ControlCoolers.mp3";
            wplayer.controls.play();
        }

        public void Color1()
        {
            try
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 2;

                relogio.Tick += delegate {
                    tempo -= 1;
                    //lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        lblInfomacao.ForeColor = Color.Red;

                        Color2();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        public void Color2()
        {
            try
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 2;

                relogio.Tick += delegate {
                    tempo -= 1;
                    //lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        lblInfomacao.ForeColor = Color.Orange;
                        Color1();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        //Esse timer inicializa todo o processo!
        public void StartCustomControl()
        {
            try
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 15;

                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();

                        VerificarOpenCustom();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        public void VerificarOpenCustom()
        {
            if (Process.GetProcessesByName("GamingCenter3_Cross").Length > 0)
            //if (Process.GetProcessesByID("Avell").Length > 0)
            {
                MinimizarForm();
                TimeCustomControl();
            }
            else
            {
                AbrirCustomControl();
                //Volta para checar novamente
                StartCustomControl();
            }
        }

        public void AbrirCustomControl()
        {
            //Verificar se o atalho do Custom Control está instalado
            String CaminhoAtalhoCustom = @"C:\Users\Public\Desktop\Avell Custom.lnk";

            if (File.Exists(CaminhoAtalhoCustom))
            {
                try
                {
                    //Primeiro tenta encontrar pelo atalho
                    Process CustomControl = new Process();
                    string CaminhoCustomControl = @"C:\Users\Public\Desktop\Avell Custom.lnk";
                    CustomControl.StartInfo.FileName = CaminhoCustomControl;
                    CustomControl.Start();
                    //CustomControl.WaitForExit();--Não esperar para sair
                    //TimeCustomControl();
                }
                catch (Exception ex) { }
            }
            else
            {
                //Se não conseguir abrir no atalho, vai tentar abrir diretamente pelo executável
                try
                {
                    Process CustomControl = new Process();
                    string CaminhoCustomControl = @"C:\Program Files\OEM\Avell Custom\GamingCenter\ControlCenterU.exe";
                    CustomControl.StartInfo.FileName = CaminhoCustomControl;
                    CustomControl.Start();
                    //CustomControl.WaitForExit();--Não esperar para sair
                    //TimeCustomControl();
                }
                catch (Exception ex) { }
            }
        }

        //Tempo para dar tempo de abrir o Custom Control
        public void TimeCustomControl()
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

                        ClickCustomControl();
                    }
                };
                relogio.Start();
            }
            catch (Exception ex) { }
        }

        public void ClickCustomControl()
        {
            ControlCooler = "Active1";

            SelectQuery tecladoAvell = new SelectQuery("Win32_BIOS");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(tecladoAvell);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            foreach (ManagementObject filtroPorBios in osDetailsCollection)
            {
                string selecaoVersao = (filtroPorBios["SMBIOSBIOSVersion"].ToString());

                if (selecaoVersao == "1.07.11TBN1")
                {
                    lblModelo.Text = "BIOS: 1.07.11TBN1";
                    CUSTOM_A55HYB_TELA15();
                }
                if (selecaoVersao == "N.1.05AVE04")
                {
                    lblModelo.Text = "BIOS: N.1.05AVE04";
                    CUSTOM_A52MOB_TELA15();
                }
                if (selecaoVersao == "N.1.22AVE00")
                {//AJUSTADO STORM-X
                    lblModelo.Text = "BIOS: N.1.22AVE00";
                    CUSTOM_STORMX_TELA17();
                }
                if (selecaoVersao == "N.1.13AVE01")
                {//AJUSTADO STORMB-BS
                    lblModelo.Text = "BIOS: N.1.13AVE01";
                    CUSTOM_A52ION_STORMBS_TELA15();
                }
                if (selecaoVersao == "N.1.08AVE00")
                {
                    lblModelo.Text = "A72-ION";
                    CUSTOM_A72ION_TELA15();
                }
                if (selecaoVersao == "N.1.08AVE04")
                {
                    lblModelo.Text = "A52-HYB NEW / STORM BS";
                    CUSTOM_A52HYBNEW_TELA15();
                }
                if (
                    selecaoVersao == "N.1.10AVE03")
                {
                    lblModelo.Text = "A70HYB / STORM 2";
                    CUSTOM_A70HYB_STORM2_TELA_17_2();
                }
                
                if (selecaoVersao == "N.1.10AVE04")
                {//AJUSTADO A70HYB - ALGUNS STORM2
                    lblModelo.Text = "A70HYB 15''/ STORM 2 17''";
                    CUSTOM_A70HYB_STORM2_TELA15_17();
                }
                if (selecaoVersao == "N.1.13AVE05")
                {
                    lblModelo.Text = "A70HYB / STORM 2";
                    CUSTOM_A70HYB_STORM2_TELA_17_2();
                }
                if (selecaoVersao == "N.1.07AVE02")
                {
                    lblModelo.Text = "A70HYB";
                    CUSTOM_A70HYB_3050_TELA15();
                }
                if (selecaoVersao == "N.1.04AVE00")
                {
                    lblModelo.Text = "A70MOB 3050";
                    CUSTOM_A70MOB_3050_TELA15();
                }
                if (selecaoVersao == "N.1.07AVE00")
                {
                    lblModelo.Text = "A70MOB / LIV";
                    CUSTOM_A70MOB_TELA15();
                }
                if (selecaoVersao == "1.07.06TBN")
                {
                    lblModelo.Text = "B.ON LITE";
                    CUSTOM_BONLITE_TELA15();
                }
                if (selecaoVersao == "N.1.09AVE00")
                {
                    lblModelo.Text = "STORM GO";
                    CUSTOM_STORMGO_TELA16();
                }
                if (selecaoVersao == "N.1.01")
                {
                    lblModelo.Text = "C65 LIV";
                    CUSTOM_STORMGO_TELA16();
                }
                if (selecaoVersao == "N.1.01AVE00")
                {
                    lblModelo.Text = "B11 MOB";
                    CUSTOM_B11MOB_TELA11();
                }
                if (selecaoVersao == "N.1.09AVE01")
                {
                    lblModelo.Text = "A65ION";
                    CUSTOM_A65_TELA16();
                }
                //Adicionado modelo Antigo A62LIV
                if (selecaoVersao == "N.1.03")
                {
                    lblModelo.Text = "A62 LIV";
                    CUSTOM_A62_TELA15();
                }
                //Adicionado modelo Antigo A62LIV
                if (selecaoVersao == "N.1.02")
                {
                    lblModelo.Text = "A62 LIV";
                    CUSTOM_A62_TELA15();
                }
                if (selecaoVersao != "1.07.11TBN1" && selecaoVersao != "N.1.10AVE03" && selecaoVersao != "N.1.05AVE04" &&
                    selecaoVersao != "N.1.22AVE00" && selecaoVersao != "N.1.13AVE01" && selecaoVersao != "N.1.08AVE00" &&
                    selecaoVersao != "N.1.08AVE04" && selecaoVersao != "N.1.10AVE04" && selecaoVersao != "N.1.13AVE05" &&
                    selecaoVersao != "N.1.07AVE02" && selecaoVersao != "N.1.04AVE00" && selecaoVersao != "N.1.07AVE00" &&
                    selecaoVersao != "1.07.06TBN" && selecaoVersao != "N.1.09AVE00" && selecaoVersao != "N.1.01" &&
                    selecaoVersao != "N.1.01AVE00" && selecaoVersao != "N.1.09AVE01" && selecaoVersao != "N.1.03" &&
                    selecaoVersao != "N.1.02")
                {
                    //NAOCADASTRADA formNaoCadastrada = new NAOCADASTRADA();
                    //this.Hide();
                    //formNaoCadastrada.Show();
                }
                break;
            }
        }

        //Métodos de Click
        public void CUSTOM_A55HYB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }

        }

        public void CUSTOM_A52MOB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();

            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_STORMX_TELA17()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1000;
                    p.Y = 670;
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
                            p.X = 160;
                            p.Y = 251;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A52ION_STORMBS_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 900;
                    p.Y = 570;
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
                            p.X = 150;
                            p.Y = 220;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A72ION_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A52HYBNEW_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A70HYB_STORM2_TELA_17_2()
        {//Versão adicionada, como se houvesse versão N.1.10AVE03
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A70HYB_STORM2_TELA15_17()
        {//AJUSTADO
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1000;
                    p.Y = 600;
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
                            p.X = 160;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                //Para o próximo teste
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A70HYB_3050_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A70MOB_3050_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        //=================================AJUSTAR PARA ESTE MÉTODO=========================================
        public void CUSTOM_A70MOB_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A70MOB_TELA15CLK2()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_BONLITE_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_STORMGO_TELA16()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_B11MOB_TELA11()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A65_TELA16()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void CUSTOM_A62_TELA15()
        {
            Coordenada1 = "OK";
            try
            {
                if (Coordenada1 == "OK")
                {
                    Coordenada2 = "OK";
                    Point p = new Point();
                    p.X = 1100;
                    p.Y = 650;
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
                            p.X = 170;
                            p.Y = 250;
                            c.leftClick(p);
                        }
                    };
                    relogio.Start();
                }
                ValidaOK();
            }
            catch (Exception ex) { MessageBox.Show("Não Consegui executar a inicialização do Burnin" + ex); }
        }

        public void ValidaOK()
        {
            VALIDACONFIRMA formConfirma = new VALIDACONFIRMA();
            this.Hide();
            formConfirma.ShowDialog();
        }

        public void MinimizarForm()
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
