using System;
using System.Windows.Forms;

namespace AUDIO
{
    public partial class CONFIRMALOOP : MaterialSkin.Controls.MaterialForm
    {
        public CONFIRMALOOP()
        {
            InitializeComponent();
        }

        private void CONFIRMALOOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chamar o Form loopback
            LOOPBACK formLoopback = new LOOPBACK();
            this.Hide();
            formLoopback.Show();
        }
    }
}
