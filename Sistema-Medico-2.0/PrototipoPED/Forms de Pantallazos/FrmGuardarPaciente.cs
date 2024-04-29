using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED
{
    public partial class FrmGuardarPaciente : Form
    {
        private void LlenarCmbZona()
        {
            string zona, departamento;

            string[] zonas = { "Occidente", "Central", "Oriente" };

            cmbZona.Items.AddRange(zonas);
        }

        private void LlenarCmbDepartamento(string zona)
        {
            string[] depasOccidente = { "Ahuachapan", "Santa Ana", "Sonsonate" };
            string[] depasCentral = { "Chalatenango", "Cuscatlan", "Cabañas", "La libertad", "La paz", "San Vicente", "San Salvador" };
            string[] depasOriental = { "Morazan", "La Unión", "San Miguel", "Usulután" };

            switch (zona)
            {
                case "Occidente":
                    cmbDepartamento.Enabled = true;
                    cmbDepartamento.Items.AddRange(depasOccidente);
                    break;

                case "Central":
                    cmbDepartamento.Enabled = true;
                    cmbDepartamento.Items.AddRange(depasCentral);
                    break;

                case "Oriente":
                    cmbDepartamento.Enabled = true;
                    cmbDepartamento.Items.AddRange(depasOriental);
                    break;
            }

        }

        private void LlenarCmbDistritos(string departamento)
        {
            string[] distriUno = { "Norte", "Centro", "Sur" }; //Ahuachapam y chalate
            string[] distriDos = { "Norte", "Centro", "Sur", "Oeste", "Este" };
            string[] distriTres = { "Norte", "Centro", "Sur", "Oeste", "Este", "Costa" };
            string[] distriCuatro = { "Este", "Oeste", "Centro" };

            switch (departamento)
            {
                case "Ahuachapan":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;
                    break;
                case "Santa Ana":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriDos);
                    txtDireccion.Enabled = true;

                    break;
                case "Sonsonate":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriDos);
                    txtDireccion.Enabled = true;

                    break;
                case "Chalatenango":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;

                    break;
                case "Cuscatlan":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;

                    break;
                case "Cabañas":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriCuatro);
                    txtDireccion.Enabled = true;

                    break;
                case "La Libertad":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriTres);
                    txtDireccion.Enabled = true;

                    break;
                case "La Paz":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriCuatro);
                    txtDireccion.Enabled = true;

                    break;
                case "San Vicente":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;

                    break;
                case "San Salvador":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriDos);
                    txtDireccion.Enabled = true;

                    break;
                case "Morazan":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;

                    break;
                case "La Unión":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriUno);
                    txtDireccion.Enabled = true;

                    break;
                case "San Miguel":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriDos);
                    txtDireccion.Enabled = true;

                    break;
                case "Usulután":
                    cmbMunicipio.Enabled = true;
                    cmbMunicipio.Items.AddRange(distriDos);
                    txtDireccion.Enabled = true;

                    break;
            }
        }

        public FrmGuardarPaciente()
        {
            InitializeComponent();
            LlenarCmbZona();
        }

        public void Limpiar()
        {
            txtNombre1.Clear();
            txtNombre2.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDui.Clear();
            txtNit.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int edad;
                //Las validaciones
                if (txtNombre1.Text == "" || txtApellido1.Text == "")
                {
                    MessageBox.Show("Debe ingresar al menos un nombre y un apellido");
                }
                if (txtDui.Text == "")
                {
                    MessageBox.Show("Es obligatorio ingresar un dui");
                    txtDui.Focus();
                }

                Paciente miPaciente = new Paciente();

                miPaciente.Primer_Nombre = txtNombre1.Text;
                miPaciente.Segundo_Nombre = txtNombre2.Text;
                miPaciente.Primer_Apellido = txtApellido1.Text;
                miPaciente.Segundo_Apellido = txtNombre2.Text;
                miPaciente.Direccion = cmbZona.Text + ", " + cmbDepartamento.Text + ", " + cmbMunicipio.Text + ", " + txtDireccion.Text;
                miPaciente.Telefono = txtTelefono.Text;

                string sexo;

                if (rbtnMasculino.Checked)
                {
                    sexo = "M";
                    miPaciente.Sexo = sexo;
                }
                else if (rbtnFemenino.Checked)
                {
                    sexo = "F";
                    miPaciente.Sexo = sexo;
                }
                else
                {
                    MessageBox.Show("Debe elegir un sexo");
                }

                miPaciente.DUI = txtDui.Text;
                miPaciente.NIT = txtNit.Text;
                miPaciente.Fecha_Nacimiento = dtpFechaNacimiento.Value.ToString();

                Conexion miConexion = new Conexion();
                try
                {
                    miConexion.AgregarPaciente(miPaciente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Limpiar();
            }
            catch { }
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartamento.Items.Clear();
            LlenarCmbDepartamento(cmbZona.Text);
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.Items.Clear();
            LlenarCmbDistritos(cmbDepartamento.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar(); 
        }
    }
}
