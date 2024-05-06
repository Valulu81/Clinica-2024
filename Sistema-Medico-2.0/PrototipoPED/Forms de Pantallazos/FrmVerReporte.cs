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
            try
            {
                datosP();
                Conexion miconexion = new Conexion();
                //miconexion.VerDatosPCombo(cmbPaciente);
                //miconexion.VerDatosDCombo(cmbDoctor);
                //cmbHorario.Items.AddRange(horarios);
            }
            catch { }
        }
        String[] horarios = { "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
        "13:00:00","13:30:00","14:00:00","14:30:00","15:00:00","15:30:00","16:00:00","16:30:00","17:00:00","17:30:00","18:00:00"};

        private void FrmVerReporte_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("data source=localhost; initial catalog=Clinica;" +
        " persist security info=True; Integrated Security=SSPI; ");
        public void datosP()
            //Muestra los nombres del paciente
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("select CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as NombreCompleto, codPaciente  from administracion.pacientes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["NombreCompleto"] = "Selecciona un paciente";
            dt.Rows.InsertAt(fila, 0);

            cmbPaciente.ValueMember = "codPaciente";
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.DataSource = dt;


        }

        public void datosM(string codPaciente)
        {
            //Filtra los datos de los médicos relacionados a ese paciente
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT m.codMedico, concat(m.primerNombre,' ', m.primerApellido) as Nombre\r\nFROM personal.medicos AS m\r\nJOIN administracion.citasMedicas AS c\r\nON m.codMedico = c.codMedico where codPaciente=@codPaciente", con);
            cmd.Parameters.AddWithValue("codPaciente", codPaciente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow dr = dt.NewRow();
            dr["Nombre"] = "Selecciona un médico";
            dt.Rows.InsertAt(dr, 0);

            cmbDoctor.ValueMember = "codMedico";
            cmbDoctor.DisplayMember = "Nombre";
            cmbDoctor.DataSource = dt;

        }

        public void fechas(string codPaciente, string codMedico)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT c.codCita AS Codigo_Cita, c.fechaHora AS Fecha_Cita\r\nFROM administracion.citasMedicas AS c\r\nwhere codPaciente=@codPaciente and codMedico=@codMedico", con);
            cmd.Parameters.AddWithValue("codPaciente", codPaciente);
            cmd.Parameters.AddWithValue("codMedico", codMedico);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

      


            cmbFecha.ValueMember ="codCita";
            cmbFecha.DisplayMember = "Fecha_Cita";
            cmbFecha.DataSource = dt;


        }

        //Eventos de cada combobox

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedValue.ToString() != null)
            {
                string codPaciente = cmbPaciente.SelectedValue.ToString();
                datosM(codPaciente);
            }

        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedValue.ToString() != null)
            {
                string codPaciente = cmbDoctor.SelectedValue.ToString();
                string codMedico = cmbDoctor.SelectedValue.ToString();
                fechas(codPaciente, codMedico);
            }

        }
    }
}
