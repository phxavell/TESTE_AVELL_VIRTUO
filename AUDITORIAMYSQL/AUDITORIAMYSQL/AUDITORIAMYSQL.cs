using System;
using System.Management;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

//utilização do MySQL
using MySql.Data.MySqlClient;

namespace AUDITORIAMYSQL
{
    public partial class AUDITORIAMYSQL : MaterialSkin.Controls.MaterialForm
    {
        //Conexão MySQL
        MySqlConnection Conexao;

        //Variáveis públicas para serem usadas em todo o form;
        public string Serial;
        public string Processador;
        public string Memoria;
        public string Bios;
        public string DataBios;
        public string SerialHistorico;
        //public string HistoricoProcessador;

        //Imports para funcionamento do programa:
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


        public AUDITORIAMYSQL()
        {
            InitializeComponent();
            DadosMaquina();
            //InsertDatabase();

            //Método para copiar pasta
            CopyallStart();

            TimeStart();
        }

        public void DadosMaquina()
        {
            try//Processador
            {
                SelectQuery Sq = new SelectQuery("Win32_Processor");
                ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
                ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
                StringBuilder sb = new StringBuilder();
                foreach (ManagementObject mo in osDetailsCollection)
                {
                    sb.AppendLine(string.Format((string)mo["Name"]));
                }
                //Enviar para variáveis públicas
                Processador = sb.ToString();
            }
            catch (Exception ex) { }


            try//Memória
            {
                long memKb;
                GetPhysicallyInstalledSystemMemory(out memKb);
                Memoria = ((memKb / 1024 / 1024) + " GB de RAM");
            }
            catch (Exception ex) { }

            string relDt = "";//Variáveis Públicas
            try
            {
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
                ManagementObjectCollection collection = mSearcher.Get();
                foreach (ManagementObject obj in collection)
                {
                    //Enviar para Variáveis públicas:
                    relDt = (string)obj["ReleaseDate"];
                    DateTime dt = ManagementDateTimeConverter.ToDateTime(relDt);
                    Serial = (string)obj["SerialNumber"];
                    SerialHistorico = (string)obj["SerialNumber"];
                    Bios = (string)obj["SMBIOSBIOSVersion"];
                    DataBios = dt.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex) { }
        }

        public void InsertDatabase()
        {
            string data_source = "datasource=192.168.247.253;username=avell;password=k4hvdq9tj9;database=avellaudit";
            try
            {
                //Cria conexão com o MySql
                Conexao = new MySqlConnection(data_source);
                string sql = "INSERT INTO avellaudit1 (serial, processador, memoria, bios, revisao)" +
                " VALUES ('" + Serial + "','" + Processador + "', '" + Memoria + "', '" + Bios + "', '" + DataBios + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                //MessageBox.Show("Deu tudo certo e inserido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
                this.Close();
            }
        }

        public void TimeStart()
        {
            {
                Timer relogio = new Timer();
                relogio.Interval = 1000;
                int tempo = 2;
                relogio.Tick += delegate {
                    tempo -= 1;
                    lblTime.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        try
                        {
                            relogio.Stop();
                            InsertDatabase();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel capturar Imagem" + ex);
                        }
                    }
                };
                relogio.Start();
            }
        }

        public void CopyallStart()
        {
            string sourceDirectory = @"C:\TESTES_AVELL\MySqlData\";
            string targetDirectory = @"Y:\avell-hist-2023\";
            DirectoryInfo sourceDircetory = new DirectoryInfo(sourceDirectory);
            DirectoryInfo targetDircetory = new DirectoryInfo(targetDirectory);
            CopyAll(sourceDircetory, targetDircetory);

            //Remove o mapeamento que para não ir para o cliente
            DesconectarUnidades();
        }

        //FALTA ATIVAR***************************************************************************************
        public void DesconectarUnidades()
        {
            try
            {
                ProcessStartInfo DesconectarZ = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Z: /delete");
                DesconectarZ.UseShellExecute = false;
                DesconectarZ.CreateNoWindow = true;
                Process.Start(DesconectarZ);

                ProcessStartInfo DesconectarY = new ProcessStartInfo("cmd.exe", @"/C " + "@net use Y: /delete");
                DesconectarY.UseShellExecute = false;
                DesconectarY.CreateNoWindow = true;
                Process.Start(DesconectarY);
            }
            catch (Exception ex) { }
        }
        //FALTA ATIVAR***************************************************************************************

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                //Verificar o porque inserir no método variáveis de origem e destino 
                Directory.CreateDirectory(target.FullName);
                foreach (FileInfo fi in source.GetFiles())
                {
                    Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (Exception ex) { }
        }
    }
}
