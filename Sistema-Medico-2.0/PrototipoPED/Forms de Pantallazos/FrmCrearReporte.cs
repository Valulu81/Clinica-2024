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
using System.Windows.Forms;

namespace PrototipoPED
{
    public partial class S : Form
    {
        public S()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Conexion conexion = new Conexion();
            conexion.VerDatosPCombo(cmbPaciente);
        }



        private string ConecStr = "data source=localhost; initial catalog=Clinica;" +
       " persist security info=True; Integrated Security=SSPI; ";

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                Reporte mireporte = new Reporte();
                mireporte.Cod_Cita = conexion.DevolverCodCita(cmbPaciente.Text,cmbCita.Text);
                mireporte.Presion_Arterial = txtPresion.Text;
                mireporte.Temperatura = Convert.ToDecimal(txtTemperatura.Text);
                mireporte.Diagnostico = txtDiagnostico.Text;
                mireporte.Motivo = txtMotivo.Text;
                mireporte.Peso = Convert.ToDecimal(txtPeso.Text);
                mireporte.Talla = Convert.ToDecimal(txtEstatura.Text);

                conexion.AgregarReporte(mireporte);

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


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
    }
}
