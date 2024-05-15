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
    public partial class FrmVerReporte : Form
    {
        public FrmVerReporte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cmbDoctor.Enabled = false;
            cmbFecha.Enabled = false;
            try
            {
                //datosP();
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
                //miconexion.VerDatosDCombo(cmbDoctor);
            }
            catch { }
        }


        
        
        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.SelectedIndex = -1;
            cmbDoctor.Enabled = true;
            cmbFecha .SelectedIndex = -1;
            cmbFecha .Enabled =false;
            Conexion miConexion = new Conexion();

            try
            {
                miConexion.VerDatosDDCombo(cmbDoctor, cmbPaciente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }
        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFecha.SelectedIndex = -1;
            cmbFecha.Enabled = true;
            Conexion miConexion = new Conexion();

            try
            {
                miConexion.VerDatosFCombo(cmbFecha, cmbDoctor.Text, cmbPaciente.Text);
                //miConexion.VerDatosDDCombo(cmbDoctor, cmbPaciente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex==-1 || cmbDoctor.SelectedIndex==-1 || cmbFecha.SelectedIndex==-1)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            else
            {
                Conexion miConexion = new Conexion();
                Reporte miReporte = new Reporte();
                miReporte = miConexion.VerReporte(cmbPaciente.Text, cmbDoctor.Text, Convert.ToDateTime(cmbFecha.Text));
                txtDiagnostico.Text = miReporte.Diagnostico;
                txtEstatura.Text = (miReporte.Talla).ToString();
                txtMotivo.Text = miReporte.Motivo;
                txtPeso.Text = (miReporte.Peso).ToString();
                txtPresion.Text = miReporte.Presion_Arterial;
                txtTemperatura.Text = (miReporte.Temperatura).ToString();

            }
            
        }

        private void FrmVerReporte_Load(object sender, EventArgs e)
        {
            txtDiagnostico.Enabled = false;
            txtEstatura.Enabled = false;
            txtTemperatura.Enabled = false;
            txtEstatura.Enabled = false;
            txtPeso.Enabled = false;
            txtPresion.Enabled = false;
            txtMotivo.Enabled = false;
        }
        private void Limpiar()
        {
            
            Conexion conexion = new Conexion();
           
            txtDiagnostico.Clear();
            txtPeso.Clear();
            txtMotivo.Clear();
            txtEstatura.Clear();
            txtTemperatura.Clear();
            txtPresion.Clear();
            cmbPaciente.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            cmbFecha.SelectedIndex = -1;
           
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
