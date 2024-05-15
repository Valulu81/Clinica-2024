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
        }

        private void S_Load(object sender, EventArgs e)
        {

        }

       public static void temperaturas(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Convierte el caracter a entero
                int valor = (int)Char.GetNumericValue(e.KeyChar);

                // Verifica si el valor está entre 9 y 20
                if (valor >= 35 && valor <= 42)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese valores válidos para la temperatura");
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FrmCrearReporte.temperaturas(e);
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
        }
    }
}
