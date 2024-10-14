using System;
using System.Windows.Forms;
using System.Management;

namespace BLUETOOTH
{
    public partial class BLUETOOTH : MaterialSkin.Controls.MaterialForm
    {
        public string BLUETOOTHOK;
        public string BLUETOOTHFALHA;
        public int QUANTIDADE;
 
        public BLUETOOTH()
        {
            InitializeComponent();
            Interacao();
            ChecarBluetooth();
            TimeStart();
        }

        public void Interacao()
        {
            //Interacao - Precisa ficar dentro do evento do form devido auto start das propriedades de video.
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\TESTES_AVELL\audiofilesAlertas\Bluetooth.mp3";
            wplayer.controls.play();
        }

        public void ChecarBluetooth()
        {
            lbDriversBluetooth.Items.Clear();

            //Busca os drivers instalados na máquina - Utiliza propriedades do Win32.dll
            string query = "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%Bluetooth%'";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject device in collection)
            {
                lbDriversBluetooth.Items.Add(device["Name"]);
                var quantidade = collection.Count;
                //Variável public do form
                QUANTIDADE = quantidade;
                //break;
            }
        }

        public void TimeStart()
        {
            Timer relogio = new Timer();
            relogio.Interval = 1000;
            int tempo = 3;

            relogio.Tick += delegate {
                tempo -= 1;
                lblTime.Text = tempo.ToString();
                if (tempo == 0)
                {
                    try
                    {
                        relogio.Stop();
                        //ChecarBluetooth();
                        DriversInstall();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                    }
                }
            };
            relogio.Start();
        }

        public void DriversInstall()
        {
            if (QUANTIDADE >= 4)
            {
                ChamarValidaOk();
            }
            else
            {
                ChamarReprovaFalha();
            }

        }

        private void ChamarValidaOk()
        {
            //Usar esta estrutura em todos para não ficar em loop, ajustar o código em todos os forms
            if (BLUETOOTHOK != "OK" && BLUETOOTHFALHA != "FALHA")
            {
                BLUETOOTHOK = "OK";
                VALIDAOK formAprovaTeste = new VALIDAOK();
                this.Hide();
                formAprovaTeste.ShowDialog();
            }
        }

        private void ChamarReprovaFalha()
        {
            //Usar esta estrutura em todos para não ficar em loop, ajustar o código em todos os forms
            //Padronizar a verificação de quantidadede falhas no ReprovaFalhas em todos os testes.
            if (BLUETOOTHOK != "OK" && BLUETOOTHFALHA != "FALHA")
            {
                BLUETOOTHOK = "FALHA";
                REPROVAFALHA formReprovaFalha = new REPROVAFALHA();
                this.Hide();
                formReprovaFalha.ShowDialog();
            }
        }
    }
}
