using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using PrototipoPED.Forms_de_mensaje;
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
    //Form que agrega/genera el perfil del médico a la base

    public partial class FrmAgregarDoctor : Form
    {
        public FrmAgregarDoctor()
        {
            InitializeComponent();
            llenarcmb();
            //Hace que se muestre en el centro de la pantalla este formulario
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void llenarcmb()
        {
            //Estructura de datos
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
            mtxtTelefono.Clear();
            //Limpia el combobox
            cmbEspecialidad.SelectedIndex = -1;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Limpiar();
        }

        private void txNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
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
            string numero = mtxtTelefono.Text.Trim();
            //Validaciones
            if (txNombre.Text == "" || txtApellido.Text == "" || mtxtTelefono.Text=="")
            {
                MessageBox.Show("Complete todos los campos antes de guardar");
                return;
            }
            if (mtxtTelefono.Text == "")
            {
                MessageBox.Show("Es obligatorio ingresar un número de teléfono");
                mtxtTelefono.Focus();
                return;
            }
            if (!ValidarTel(numero))
            {
                MessageBox.Show("El número telefónico debe tener el formato: 1122-3344", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtTelefono.Focus();
                mtxtTelefono.Clear();
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
            miMedico.Telefono = mtxtTelefono.Text;

            // Agregar médico a la base
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
            cmbEspecialidad.Enabled = false;
            txtApellido.Enabled = false;
            mtxtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
        }

        
        private void txNombre_TextChanged(object sender, EventArgs e)
        { 

            if (!string.IsNullOrEmpty(txNombre.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txNombre.Text = char.ToUpper(txNombre.Text[0]) + txNombre.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txNombre.SelectionStart = txNombre.Text.Length;
            }
            txtApellido.Enabled = true;
         

        }
 

        private void txtApellido_TextChanged(object sender, EventArgs e)
        { 

            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtApellido.Text = char.ToUpper(txtApellido.Text[0]) + txtApellido.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
            mtxtTelefono.Enabled = true;

        }

        

        private void FrmAgregarDoctor_Load(object sender, EventArgs e)
        {
            txNombre.Focus();
           
            //No se puede escribir sobre el combobox y obliga a seleccionar unicamente las opciones
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbEspecialidad.Enabled = false;
            txtApellido.Enabled = false;
            mtxtTelefono.Enabled = false;
          

            //Tab index orden
            txNombre.TabIndex = 0;
            txtApellido.TabIndex = 1;
            mtxtTelefono.TabIndex = 2;
            cmbEspecialidad.TabIndex = 3;
            btnGuardar.TabIndex = 4;

           
        }

        //Hace que cuando se de enter, se guarde automáticamente
        private void cmbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Cancela el sonido de la tecla Enter
                e.Handled = true;

                // Llama al evento Click del botón
                btnGuardar.PerformClick();
            }
        }

        private void mtxtTelefono_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && mtxtTelefono.MaskCompleted)
            {
                cmbEspecialidad.Enabled = true;
            }
            else
            {
                cmbEspecialidad.Enabled = false;
            }
            cmbEspecialidad.Enabled = true;

            
        }

        private void mtxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!mtxtTelefono.MaskCompleted)
            {
                MessageBox.Show("Por favor, completa todos los espacios requeridos del número de teléfono.");
                e.Cancel = true;
            }
        }


    }
}
