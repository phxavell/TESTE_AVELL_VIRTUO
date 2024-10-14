using System;
using System.Drawing;
using System.Windows.Forms;

namespace BLUETOOTH
{
    public partial class ENVIAREPARO : MaterialSkin.Controls.MaterialForm
    {
        public ENVIAREPARO()
        {
            InitializeComponent();
            TimeStart1();
        }

        public void TimeStart1()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 1;//1 minuto e 20

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    panelFalha.BackColor = Color.DarkRed;
                    panelFalha.Refresh();
                    TimeStart2();
                }
            };
            relogio.Start();
        }

        public void TimeStart2()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 1;//1 minuto e 20

            relogio.Tick += delegate {
                tempo -= 1;
                //lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    relogio.Stop();
                    //O que vai parar
                    panelFalha.BackColor = Color.DarkOrange;
                    panelFalha.Refresh();
                    TimeStart1();

                }
            };
            relogio.Start();
        }
    }
}
