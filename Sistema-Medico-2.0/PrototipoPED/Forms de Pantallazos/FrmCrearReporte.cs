using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations.Storage;
using System.Windows.Forms;

namespace PrototipoPED
{
    public partial class FrmCrearReporte : Form
    {
        public FrmCrearReporte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                Conexion conexion = new Conexion();
                conexion.VerDatosPCombo(cmbPaciente);
                conexion.VerDatosECombo(cmbEnfermedades);
            }
            catch 
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text != "")
            {
                int valor;
                bool esNumero = Int32.TryParse(txtPeso.Text, out valor);

                // Verifica si el valor es un número y si está entre 1940 y 2029
                if (esNumero && valor >= 19 && valor <= 2029)
                {
                    // Si el valor es válido, no hagas nada
                }
                else
                {
                    // Si el valor no es válido, muestra un mensaje de error y borra el TextBox
                    MessageBox.Show("Ingrese valor de peso válido en kilogramos");
                    txtPeso.Clear();

                }
            }
            if (cmbEnfermedades.Text == "")
            {
                MessageBox.Show("Debe escribir o elegir una enfermedad.");
                return;
            }

            if (cmbEnfermedades.SelectedIndex == -1) //si la seleccion esta fuera de las enfermedades enlistadas:
            {
                Conexion conexion = new Conexion();
                conexion.AgregarEnfermedad(cmbEnfermedades.Text);

            
                try
                {
                    Reporte mireporte = new Reporte();
                    mireporte.Cod_Cita = conexion.DevolverCodCita(cmbPaciente.Text, Convert.ToDateTime(cmbCita.Text));
                    mireporte.Presion_Arterial = txtPresion.Text;
                    mireporte.Temperatura = Convert.ToDecimal(txtTemperatura.Text);
                    mireporte.Diagnostico = cmbEnfermedades.Text + ", " + txtDiagnostico.Text;
                    mireporte.Motivo = txtMotivo.Text;
                    mireporte.Peso = Convert.ToDecimal(txtPeso.Text);
                    mireporte.Talla = Convert.ToDecimal(txtEstatura.Text);

                    conexion.AgregarReporte(mireporte);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }

            else
            {
                try
                {
                    Conexion conexion = new Conexion();
                    Reporte mireporte = new Reporte();
                    mireporte.Cod_Cita = conexion.DevolverCodCita(cmbPaciente.Text, Convert.ToDateTime(cmbCita.Text));
                    mireporte.Presion_Arterial = txtPresion.Text;
                    mireporte.Temperatura = Convert.ToDecimal(txtTemperatura.Text);
                    mireporte.Diagnostico = cmbEnfermedades.Text + ", " + txtDiagnostico.Text;
                    mireporte.Motivo = txtMotivo.Text;
                    mireporte.Peso = Convert.ToDecimal(txtPeso.Text);
                    mireporte.Talla = Convert.ToDecimal(txtEstatura.Text);

                    conexion.AgregarReporte(mireporte);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            Limpiar();
        }

        private void Limpiar()
        {
            cmbEnfermedades.Items.Clear();
            Conexion conexion = new Conexion();
            conexion.VerDatosECombo(cmbEnfermedades);
            txtDiagnostico.Clear();
            txtPeso.Clear();
            txtMotivo.Clear();
            txtEstatura.Clear();
            txtTemperatura.Clear();
            txtPresion.Clear();
            cmbPaciente.SelectedIndex = -1;
            cmbCita.SelectedIndex = 0;

        }


        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCita.SelectedIndex = -1;
            cmbCita.Enabled = true;
            Conexion miConexion = new Conexion();

            try
            {
                miConexion.VerDatosFFCombo(cmbCita, cmbPaciente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            cmbCita.Enabled = true;
        }

        private void cmbEnfermedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEnfermedades.Text != "")
            {
                txtDiagnostico.Enabled = true;
            }
            else
            {
                txtDiagnostico.Enabled = false;
            }
            txtDiagnostico.Enabled = true;
        }

        private void FrmCrearReporte_Load(object sender, EventArgs e)
        {
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList; 
            cmbCita.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPaciente.TabIndex = 0;
            cmbCita.TabIndex = 1;
            txtPeso.TabIndex = 2;
            txtEstatura.TabIndex = 3;
            txtPresion.TabIndex = 4;
            txtTemperatura.TabIndex = 5;
            txtMotivo.TabIndex = 6;
            cmbEnfermedades.TabIndex = 7;
            txtDiagnostico.TabIndex = 8;

            cmbEnfermedades.Enabled = false;
           
            cmbCita.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtEstatura.Enabled = false;
            txtTemperatura.Enabled = false;
            txtEstatura.Enabled=false;
            //txtPeso.Enabled = false;
            txtPresion.Enabled = false;
            txtMotivo.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPeso.Enabled = true;
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            txtEstatura.Enabled = true;

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            txtPresion.Enabled = true;
        }

        private void txtPresion_TextChanged(object sender, EventArgs e)
        {
            txtTemperatura.Enabled = true;
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            txtMotivo.Enabled = true;
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            cmbEnfermedades.Enabled = true;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Cancela la entrada del carácter
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
