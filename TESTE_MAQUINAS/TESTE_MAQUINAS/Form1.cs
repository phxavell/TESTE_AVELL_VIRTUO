using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;


namespace TESTE_MAQUINAS
{
    //public partial class Sistema_Teste : MaterialSkin.Controls.MaterialForm
    public partial class Sistema_Teste : Form
    {
        public Sistema_Teste()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
