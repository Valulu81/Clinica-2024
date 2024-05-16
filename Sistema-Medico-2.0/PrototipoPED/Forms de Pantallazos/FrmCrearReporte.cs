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
            if(cmbPaciente.SelectedIndex==-1)
            {
                MessageBox.Show("Debe de elegir un paciente");
                return;
            }
            if (cmbCita.SelectedIndex == -1)
            {
                MessageBox.Show("Debe de elegir una cita del paciente");
                return;
            }
            if(txtDiagnostico.Text==""|| txtMotivo.Text == "" || txtPeso.Text == "" || txtPresion.Text == "" ||txtTemperatura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de guardar");
                return;

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
                    //MessageBox.Show(ex.Message);
                    Limpiar();
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
                    //MessageBox.Show(ex.Message);
                    Limpiar();
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
            cmbEnfermedades.Text = "";
            txtDiagnostico.Clear();
            txtPeso.Clear();
            txtMotivo.Clear();
            txtEstatura.Clear();
            txtTemperatura.Clear();
            txtPresion.Clear();
            //cmbPaciente.SelectedIndex = -1;
            cmbCita.SelectedIndex = -1;
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
            /*if (cmbEnfermedades.Text != "")
            {
                txtDiagnostico.Enabled = true;
            }
            else
            {
                txtDiagnostico.Enabled = false;
            }*/

        }

        //MAM0001
        //1000MAM

        private void FrmCrearReporte_Load(object sender, EventArgs e)
        {
            cmbPaciente.Focus();
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
            //txtDiagnostico.Enabled = false;
            txtEstatura.Enabled = false;
            txtTemperatura.Enabled = false;
            txtEstatura.Enabled = false;
            txtPeso.Enabled = false;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPresion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_MouseLeave(object sender, EventArgs e)
        {
            if (txtPeso.Text != "")
            {
                float valor;
                bool esNumero = float.TryParse(txtPeso.Text, out valor);


                if (esNumero && valor >= 1 && valor <= 200)
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

        }

        private void txtEstatura_MouseLeave(object sender, EventArgs e)
        {
            if (txtEstatura.Text != "")
            {
                float valor;
                bool esNumero = float.TryParse(txtEstatura.Text, out valor);

                if (esNumero && valor >= 0.30 && valor <= 2.00)
                {
                    // Si el valor es válido, no hagas nada
                }
                else
                {
                    // Si el valor no es válido, muestra un mensaje de error y borra el TextBox
                    MessageBox.Show("Ingrese valor de altura válido en metros");
                    txtEstatura.Clear();

                }
            }

        }

        private void txtTemperatura_MouseLeave(object sender, EventArgs e)
        {
            if (txtTemperatura.Text != "")
            {
                float valor;
                bool esNumero = float.TryParse(txtTemperatura.Text, out valor);

                if (esNumero && valor >= 30 && valor <= 45)
                {
                    // Si el valor es válido, no hagas nada
                }
                else
                {
                    // Si el valor no es válido, muestra un mensaje de error y borra el TextBox
                    MessageBox.Show("Ingrese valor de temperatura válido");
                    txtTemperatura.Clear();

                }

            }
        }
    }
}