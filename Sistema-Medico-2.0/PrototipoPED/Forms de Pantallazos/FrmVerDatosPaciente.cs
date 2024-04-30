using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmVerDatosPaciente : Form
    {
        public FrmVerDatosPaciente()
        {
            InitializeComponent();
            try
            {
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
            }
            catch { }

        }

        private void FrmVerDatosPaciente_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtDui.Clear();
            txtEdad.Clear ();
            txtNit.Clear ();
            txtSexo.Clear();
            txtTelefono.Clear();
            txtfecha.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Paciente miPaciente = new Paciente();
            Conexion miConexion = new Conexion();

            try
            {
                miPaciente=miConexion.DatosPaciente(cmbPaciente.Text);
                txtDireccion.Text = miPaciente.Direccion;
                txtEdad.Text = miPaciente.Edad;
                txtfecha.Text = miPaciente.Fecha_Nacimiento;
                txtNit.Text= miPaciente.NIT;
                txtSexo.Text = miPaciente.Sexo;
                txtTelefono.Text= miPaciente.Telefono;
                txtDui.Text = miPaciente.DUI;

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
