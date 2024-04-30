using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmCrearGrafica : Form
    {
        public FrmCrearGrafica()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FrmVerReporte form = new FrmVerReporte();
            form.ShowDialog();
        }
    }
}
