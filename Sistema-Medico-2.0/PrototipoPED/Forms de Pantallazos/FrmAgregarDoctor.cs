using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmAgregarDoctor : Form
    {
        public FrmAgregarDoctor()
        {
            InitializeComponent();
            llenarcmb();
        }
        private void llenarcmb()
        {
            string[] especialidades = {
                "Medicina interna",
                "Pediatría",
                "Cirugía general",
                "Obstetricia y ginecología",
                "Cardiología",
                "Ortopedia",
                "Neurología",
                "Psiquiatría",
                "Psicología",
                "Dermatología",
                "Oftalmología",
                "Odontología",
                "Otorrinolaringología",
                "Radiología",
                "Geriatría",
                "Medicina física y rehabilitación",
                "Emergencia",
            };

            Array.Sort(especialidades);
            cmbEspecialidad.Items.AddRange(especialidades);
        }
        public void Limpiar()
        {
            txNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            cmbEspecialidad.SelectedIndex = 0;
        }
        private void FrmAgregarDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private bool ValidarTel(string telefono)
        {
            Regex regex = new Regex(@"^\d{4}-\d{4}$");
            return regex.IsMatch(telefono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string numero = txtTelefono.Text.Trim();
            //Validaciones
            if (txNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el primer nombre y el primer apellido");
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Es obligatorio ingresar un número de telefono");
                txtTelefono.Focus();
                return;
            }
            if (!ValidarTel(numero))
            {
                MessageBox.Show("El número telefónico debe tener el formato: 7345-7865", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }
            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medico miMedico = new Medico();

            miMedico.Primer_Nombre = txNombre.Text;
            miMedico.Primer_Apellido = txtApellido.Text;
            miMedico.Especialidad = cmbEspecialidad.Text;
            miMedico.Telefono = txtTelefono.Text;

            // Agregar medico a la base
            Conexion miConexion = new Conexion();
            try
            {
                miConexion.AgregarMedico(miMedico);

                // Obtener el código y la clave del médico
                string codigoMedico = miConexion.ObtenerCodigoM(miMedico.Primer_Nombre, miMedico.Primer_Apellido);
                string claveMedico = miConexion.ObtenerClaveM(codigoMedico);

                MessageBox.Show($"Médico ingresado exitosamente.\nCódigo: {codigoMedico}\nClave: {claveMedico}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Limpiar();
        }
    }
}
