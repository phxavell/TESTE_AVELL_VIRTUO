using System;
using System.IO;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace AVELLCUSTOM1
{
    public partial class CONFIRMACUSTOM : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMACUSTOM()
        {
            InitializeComponent();
            StartFireBaseServices();//Base de Dados On-Line - Ativar ou Desativar Aqui!
            Interacao();
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
            wplayer.URL = @"C:\TESTES_AVELL_VIRTUO\audiofilesAlertas\AvellCustomInstalado.mp3";
            wplayer.controls.play();
        }

        public void CriarLogOK_MySQL()
        {
            try
            {
                //Gera Log de OK para o MySql
                var dataHoraMinutoOK = DateTime.Now.ToString("dd-MM-yyyy-HH:mm:s:s");
                const string Furmark = @"C:\TESTES_AVELL_VIRTUO\MySqlData\AvellCustom.txt";
                var Arquivo = File.AppendText(Furmark);
                Arquivo.WriteLine("AVELLCUSTOM FALHA: " + dataHoraMinutoOK);
                Arquivo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pasta não Encotrada" + ex);

            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            REPROVAFALHAS formCustomFALHA = new REPROVAFALHAS();
            this.Hide();
            formCustomFALHA.ShowDialog();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Chamar o form de confirmação de OK.
            AVELLCUSTOMOK formCustomOK = new AVELLCUSTOMOK();
            this.Hide();
            formCustomOK.ShowDialog();
        }
        //Adicionar o Report para o Firebase++++++
    }
}
