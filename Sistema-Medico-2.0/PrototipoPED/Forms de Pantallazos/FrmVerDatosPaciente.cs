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
//Form con las validaciones listas

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmVerDatosPaciente : Form
    {
        public FrmVerDatosPaciente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            cmbPaciente.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Si el ComboBox está vacío, deshabilita el botón y muestra un mensaje
            if (cmbPaciente.SelectedIndex == -1)
            {
                btnBuscar.Enabled = false;
                MessageBox.Show("Por favor, seleccione un paciente.");
                cmbPaciente.Focus();
                btnBuscar.Enabled = true;
            }
            else
            {
                // Si el ComboBox no está vacío, habilita el botón

                btnBuscar.Enabled = true;

                Paciente miPaciente = new Paciente();
                Conexion miConexion = new Conexion();
                try
                {
                    miPaciente = miConexion.DatosPaciente(cmbPaciente.Text);
                    txtDireccion.Text = miPaciente.Direccion;
                    txtEdad.Text = miPaciente.Edad;
                    txtfecha.Text = miPaciente.Fecha_Nacimiento.ToString();
                    txtNit.Text = miPaciente.NIT;
                    txtSexo.Text = miPaciente.Sexo;
                    txtTelefono.Text = miPaciente.Telefono;
                    txtDui.Text = miPaciente.DUI;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //Inicializa

        private void FrmVerDatosPaciente_Load(object sender, EventArgs e)
        {
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtSexo.Enabled = false;
            txtfecha.Enabled = false;
            txtDui.Enabled = false;
            txtNit.Enabled = false; 
            txtEdad.Enabled = false;
        }


    }
}
