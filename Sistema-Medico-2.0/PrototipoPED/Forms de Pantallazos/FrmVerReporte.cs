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


        //SqlConnection con = new SqlConnection("data source=localhost; initial catalog=Clinica;" +
        //" persist security info=True; Integrated Security=SSPI; ");

        //public void datosP()
        ////Muestra los nombres del paciente
        //{
        //    con.Open();


        //    SqlCommand cmd = new SqlCommand("select CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as NombreCompleto, codPaciente  from administracion.pacientes", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();

        //    DataRow fila = dt.NewRow();
        //    fila["NombreCompleto"] = "Selecciona un paciente";
        //    dt.Rows.InsertAt(fila, 0);

        //    cmbPaciente.ValueMember = "codPaciente";
        //    cmbPaciente.DisplayMember = "NombreCompleto";
        //    cmbPaciente.DataSource = dt;


        //}
        public void datosM(string codPaciente)
        {
            ////Filtra los datos de los médicos relacionados a ese paciente
            //con.Open();

            //SqlCommand cmd = new SqlCommand("SELECT  m.codMedico, concat(m.primerNombre,' ', m.primerApellido) as Nombre\r\nFROM personal.medicos AS m\r\nJOIN administracion.citasMedicas AS c\r\nON m.codMedico = c.codMedico where codPaciente=@codPaciente", con);
            //cmd.Parameters.AddWithValue("codPaciente", codPaciente);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

            //DataRow dr = dt.NewRow();
            //dr["Nombre"] = "Selecciona un médico";
            //dt.Rows.InsertAt(dr, 0);

            //cmbDoctor.ValueMember = "codMedico";
            //cmbDoctor.DisplayMember = "Nombre";
            //cmbDoctor.DataSource = dt;

        }
        public void fechas(string codPaciente, string codMedico)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT m.codMedico, FechaHora, concat(m.primerNombre,' ', m.primerApellido) as Nombre FROM personal.medicos m " +
            //  "JOIN administracion.citasMedicas  c "+
            //  "ON m.codMedico = c.codMedico "+
            //  "where c.codPaciente = @codPaciente", con);
            //cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
            //cmd.Parameters.AddWithValue("@codMedico", codMedico);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();

      


            //cmbFecha.ValueMember ="codCita";
            //cmbFecha.DisplayMember = "FechaHora";
            //cmbFecha.DataSource = dt;


        }
        //Eventos de cada combobox
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
            //if (cmbPaciente.SelectedValue.ToString() != null)
            //{
            //    string codPaciente = cmbPaciente.SelectedValue.ToString();
            //    datosM(codPaciente);
            //}
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

            //if (cmbDoctor.SelectedValue.ToString() != null)
            //{
            //    string codPaciente = cmbDoctor.SelectedValue.ToString();
            //    string codMedico = cmbDoctor.SelectedValue.ToString();
            //    fechas(codPaciente, codMedico);
            //}

        }
        private void cmbFecha_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Conexion miconexion = new Conexion();
            //    miconexion.VerDatosFCombo(cmbFecha, cmbDoctor.Text, cmbPaciente.Text);
                
            //}
            //catch { }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            Reporte miReporte = new Reporte();
            miReporte = miConexion.VerReporte(cmbPaciente.Text, cmbDoctor.Text, Convert.ToDateTime(cmbFecha.Text));
            txtDiagnostico.Text = miReporte.Diagnostico;
            txtEstatura.Text = (miReporte.Talla).ToString();
            txtMotivo.Text= miReporte.Motivo;
            txtPeso.Text = (miReporte.Peso).ToString();
            txtPresion.Text = miReporte.Presion_Arterial;
            txtTemperatura.Text = (miReporte.Temperatura).ToString();
        }
    }
}
