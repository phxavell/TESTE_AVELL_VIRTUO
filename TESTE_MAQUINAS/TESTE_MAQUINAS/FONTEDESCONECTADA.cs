using System;
using System.IO;
using System.Windows.Forms;

namespace TESTE_MAQUINAS
{
    public partial class FONTEDESCONECTADA : MaterialSkin.Controls.MaterialForm
    {
        public FONTEDESCONECTADA()
        {
            InitializeComponent();
            TimeStart1();
            CriarLogFalha();
        }

        public void Interacao()
        {
            //https://www.naturalreaders.com/online/ - Cria vozes
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\FonteDesconectada.mp3";
            wplayer.controls.play();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;

                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chamar o próximo projeto
                    Interacao();
                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;

                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chamar o próximo projeto
                    Interacao();
                    TimeStart3();
                }
            };
            relogio.Start();
        }

        public void TimeStart3()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;

                if (tempo == 0)
                {
                    relogio.Stop();
                    //Chamar o próximo projeto
                    Interacao();
                    this.Close();
                }
            };
            relogio.Start();
        }

        public void CriarLogFalha()
        {
            try
            {
                var dataHoraMinuto = DateTime.Now.ToString("dd-MM-yyyy-HH-mms-s");
                //Criar log de voz
                System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL_VIRTUO\logs_font\Falha" + dataHoraMinuto + ".log");
                //System.IO.StreamWriter sw2 = new StreamWriter(@"C:\TESTES_AVELL\logs_usb\falha.log");
                sw2.WriteLine("Falha em Testes Dia:" + dataHoraMinuto);
                sw2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void pictureBoxFonte_Click(object sender, EventArgs e)
        {

        }
    }
}
