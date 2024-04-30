using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED
{
    public partial class FrmGuardarCitas : Form
    {
        public FrmGuardarCitas()
        {
            InitializeComponent();
            try
            {
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
                miconexion.VerDatosDCombo(cmbDoctor);
            }
            catch { }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuardarCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }
    }
}
