using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ROBOTESTE
{
    public partial class AVISOBURNIN : MaterialSkin.Controls.MaterialForm
    {
        public AVISOBURNIN()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            PararTestes();
        }

        public void PararTestes()
        {
            try
            {
                string Burnin = "bit";
                var processes2 = Process.GetProcessesByName(Burnin);
                foreach (var BurninTeste in processes2)
                BurninTeste.Kill();

                //Parar tudo que estiver aberto e enviar para Imagem novamente
                string ProgramaTeste = "ROBOTESTE";
                var processes1 = Process.GetProcessesByName(ProgramaTeste);
                foreach (var Testes in processes1)
                Testes.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel finalizar o processo");
            }
        }
    }
}
