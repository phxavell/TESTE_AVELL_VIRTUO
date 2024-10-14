using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Linq;

namespace WEBCAM
{
    public partial class WEBCAM_RECFACE : MaterialSkin.Controls.MaterialForm
    {
        //Variável pública para validadar detecção
        public string Detectado;

        public WEBCAM_RECFACE()
        {
            InitializeComponent();
            //TimeStart();
            Verificador();
        }

        public void Verificador()
        {
            var quantidadeLog = Directory.GetFiles(@"C:\TESTES_AVELL\logs_webcam", "*.log", SearchOption.TopDirectoryOnly).Count().ToString();
            int valor = int.Parse(quantidadeLog);
            if (valor < 2)
            {
                //Interacao();
                TimeStart();
            }
            else if (valor > 1)
            {
                using (ENVIAREPARO formEnviarReparo = new ENVIAREPARO())
                {
                    this.Hide();
                    formEnviarReparo.ShowDialog();
                }
            }
        }

        FilterInfoCollection filter;
        VideoCaptureDevice device;

        private void WEBCAM_RECFACE_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            Aciona();
        }

        public void Aciona()
        {
            device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        public void Interacao()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\WebCamReconhecimento.mp3";
            wplayer.controls.play();
        }

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                //throw new NotImplementedException();
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
                foreach (Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Orange, 3))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }
                        Detectado = "true";
                    }
                }
                pic.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Apresentou erros no teste" + ex);
            }
            finally
            {
                //if (device.IsRunning)
                //    device.Stop();
            }
        }

        private void WEBCAM_RECFACE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 8;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    try
                    {
                        relogio.Stop();
                        ValidaOK();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        public void ValidaOK()
        {
            if (Detectado == "true")
            {
                VALIDARECFACIAL formValidaRecFace = new VALIDARECFACIAL();
                this.Hide();
                formValidaRecFace.ShowDialog();
            }
            if (Detectado != "true")
            {
                REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                this.Hide();
                formReprovaFalha.ShowDialog();
            }
        }
    }
}
