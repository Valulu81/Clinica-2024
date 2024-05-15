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
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Julio", "Junio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        string[] dias = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };


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
            this.StartPosition = FormStartPosition.CenterScreen;
            LlenarCmbZona();
            cmbMes.Items.AddRange(meses);
            cmbDia.Items.AddRange(dias);
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
            //Las validaciones
            if (txtNombre1.Text == "" || txtApellido1.Text == "")
            {   
                btnGuardar.Enabled = false;
                MessageBox.Show("Debe ingresar al menos un nombre y un apellido");
                txtNombre1.Focus();
                btnGuardar.Enabled = true;

                if (txtDui.Text == "")
                {
                    MessageBox.Show("Es obligatorio ingresar un dui");
                    txtDui.Focus();
                }
                if(rbtnFemenino.Checked==false || rbtnMasculino.Checked==false)
                {
                    btnGuardar.Enabled = false;
                    MessageBox.Show("Seleccione el sexo del paciente");
                    rbtnFemenino.Focus();
                    rbtnMasculino.Focus();
                    btnGuardar.Enabled = true;
                }

            }
            else
            { 
                try
                {
                
                int edad;
               

                Paciente miPaciente = new Paciente();

                     miPaciente.Primer_Nombre = txtNombre1.Text;
                     miPaciente.Segundo_Nombre = txtNombre2.Text;
                     miPaciente.Primer_Apellido = txtApellido1.Text;
                     miPaciente.Segundo_Apellido = txtApellido2.Text;
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
                    miPaciente.DUI = txtDui.Text;
                    miPaciente.NIT = txtNit.Text;
                    miPaciente.Fecha_Nacimiento = txtAño.Text + "-" + (cmbMes.SelectedIndex + 1).ToString() + "-" + cmbDia.Text;

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
                catch 
                {
                }
            }
        }//fin btnGuardar

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
            //Para que al borrar, se limpien
            cmbZona.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            cmbMunicipio.SelectedIndex = -1;

            Limpiar(); 
        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre1.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtNombre1.Text = char.ToUpper(txtNombre1.Text[0]) + txtNombre1.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtNombre1.SelectionStart = txtNombre1.Text.Length;
            }
            CheckInputs();
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre2.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtNombre2.Text = char.ToUpper(txtNombre2.Text[0]) + txtNombre2.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtNombre2.SelectionStart = txtNombre2.Text.Length;
            }

        }

        private void txtApellido1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido1.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtApellido1.Text = char.ToUpper(txtApellido1.Text[0]) + txtApellido1.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtApellido1.SelectionStart = txtApellido1.Text.Length;
            }

            CheckInputs();
        }

        

        private void txtApellido2_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido2.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtApellido2.Text = char.ToUpper(txtApellido2.Text[0]) + txtApellido2.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtApellido2.SelectionStart = txtApellido2.Text.Length;
            }
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmGuardarPaciente_Load(object sender, EventArgs e)
        {   //Orden del tab Index
            txtNombre1.TabIndex = 0;
            txtNombre2.TabIndex = 1;
            txtApellido1.TabIndex = 2;
            txtApellido2.TabIndex = 3;
            cmbZona.TabIndex = 4;
            cmbDepartamento.TabIndex = 5;
            cmbMunicipio.TabIndex = 6;
            txtDireccion.TabIndex = 7;
            txtTelefono.TabIndex = 8;
            rbtnMasculino.TabIndex = 9;
            rbtnFemenino.TabIndex   = 10;
            cmbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZona.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTelefono.Enabled = false;
            cmbZona.Enabled = false;

            rbtnFemenino.Enabled = false;
            rbtnMasculino.Enabled = false;
            txtAño.Enabled = false;
            cmbMes.Enabled = false;
            cmbDia.Enabled = false;
           
            

        }

        private void CheckInputs()
        {
            if (!string.IsNullOrEmpty(txtNombre1.Text) &&  !string.IsNullOrEmpty(txtApellido1.Text))
            {
                // Habilita el ComboBox
                cmbZona.Enabled = true;
            }
            else
            {
                // Deshabilita el ComboBox
                cmbZona.Enabled = false;
            }

            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                // Convierte la primera letra a mayúsculas y el resto a minúsculas
                txtDireccion.Text = char.ToUpper(txtDireccion.Text[0]) + txtDireccion.Text.Substring(1).ToLower();

                // Mueve el cursor al final del texto
                txtDireccion.SelectionStart = txtDireccion.Text.Length;
            }
            CheckInputs2();
        }

        private void CheckInputs2()
        {
            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                // Habilita el ComboBox
                txtTelefono.Enabled = true;
            }
            else
            {
                // Deshabilita el ComboBox
                txtTelefono.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            CheckInputs2();
            // Verifica si el TextBox está lleno
            if (!string.IsNullOrEmpty(txtTelefono.Text))
            {
                // Habilita el RadioButton
                rbtnFemenino.Enabled = true;
                rbtnMasculino.Enabled = true;
            }
            else
            {
                // Deshabilita el RadioButton
                rbtnMasculino.Enabled = false;
                rbtnFemenino.Enabled=false;
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMasculino.Checked)
            {
                txtAño.Enabled = true;
            }
            else
            {
                // Si no está seleccionado, deshabilita el textbox
                txtAño.Enabled = false;
            }

        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemenino.Checked)
            {
                txtAño.Enabled = true;
            }
            else
            {
                // Si no está seleccionado, deshabilita el textbox
                txtAño.Enabled = false;
            }
        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAño.Text))
            {
                cmbMes.Enabled = true;
            }
            else
            {
                // Si el TextBox está vacío, deshabilita el ComboBox
                cmbDia.Enabled = false;
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex != -1)
            {
                cmbDia.Enabled = true;
            }
            else
            {
                // Si ComboBox1 no tiene ningún elemento seleccionado, deshabilita el ComboBox2
                cmbDia.Enabled = false;
            }
        }

        private void txtAño_MouseLeave(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtAño.Text, out valor))
            {
                if (valor < 1940 || valor > 2024)
                {
                    // Si el valor está fuera del rango, borra el texto del MaskedTextBox
                    txtAño.Text = "";
                }
            }
            else
            {
                // Si el texto no es un número válido, también borra el texto del MaskedTextBox
                txtAño.Text = "";
            }

            // Regresa el foco al MaskedTextBox
            txtAño.Focus();
        }

        //Para que no acepte espacios en blanco

    }
}
