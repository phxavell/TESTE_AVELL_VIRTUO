using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ROBOTESTE
{
    public partial class CONFIRMABURNIN : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMABURNIN()
        {
            InitializeComponent();
            //Após execução do burnin-fará a instalação do CustomControl
            //InstalarCustom();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            CONFIRMAOK formConfirmaOK = new CONFIRMAOK();
            this.Hide();
            formConfirmaOK.ShowDialog();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            REPROVAFALHA formReprovaFalhas = new REPROVAFALHA();
            this.Hide();
            formReprovaFalhas.ShowDialog();
        }

        public void InstalarCustom()
        {
            try
            {
                //NÃO É NECESSARIO INSTALAR O CUSTOM CONTROL NO VIRTUO
                Process instalarCustom = System.Diagnostics.Process.Start(@"C:\TESTES_AVELL_VIRTUO\.executaveisAux\InstalarCustomControl.exe");
                instalarCustom.WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show("Não foi possivel instalaro o Custom Control, ou não foi possível encontrar o caminho"); }
        }
    }
}
