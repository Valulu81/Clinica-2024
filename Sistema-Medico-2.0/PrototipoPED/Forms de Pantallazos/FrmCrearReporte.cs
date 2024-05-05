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
            Conexion conexion = new Conexion();
            conexion.VerDatosPCombo(cmbPaciente);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCrearReporte_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private string ConecStr = "data source=localhost; initial catalog=Clinica;" +
       " persist security info=True; Integrated Security=SSPI; ";

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre seleccionado de la combobox
            string nombreCompleto = cmbPaciente.SelectedItem.ToString();
            string[] nombres = nombreCompleto.Split(' ');

            // Construir la consulta SQL para obtener el código de la última cita del paciente
            string query = @"USE Clinica
                        SELECT TOP 1 p.primerNombre, p.primerApellido, cm.codCita
                        FROM administracion.pacientes p
                        JOIN administracion.citasMedicas cm ON p.codPaciente = cm.codPaciente
                        WHERE p.primerNombre = @PrimerNombre
                        AND p.primerApellido = @PrimerApellido
                        ORDER BY cm.fechaHora DESC";

            // Ejecutar la consulta SQL
            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PrimerNombre", nombres[0]);
                cmd.Parameters.AddWithValue("@PrimerApellido", nombres[1]);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string codCita = reader.GetString(reader.GetOrdinal("codCita"));

                        // Llamar al procedimiento almacenado con los datos ingresados y el código de cita obtenido
                        using (SqlConnection conn2 = new SqlConnection(ConecStr))
                        {
                            SqlCommand cmd2 = new SqlCommand("medico.CrearReporte2p", conn2);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@codcita", codCita);
                            cmd2.Parameters.AddWithValue("@mot", txtMotivo.Text);
                            cmd2.Parameters.AddWithValue("@diag", txtDiagnostico.Text);
                            cmd2.Parameters.AddWithValue("@peso", decimal.Parse(txtPeso.Text));
                            cmd2.Parameters.AddWithValue("@tal", decimal.Parse(txtEstatura.Text));
                            cmd2.Parameters.AddWithValue("@temp", decimal.Parse(txtTemperatura.Text));
                            cmd2.Parameters.AddWithValue("@presi", txtPresion.Text);

                            conn2.Open();
                            cmd2.ExecuteNonQuery();
                            conn2.Close();

                            // Mostrar un mensaje indicando que el reporte se ha ingresado correctamente
                            MessageBox.Show("El reporte se ha ingresado correctamente.", "Reporte ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron citas para el paciente seleccionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la cita del paciente: " + ex.Message);
                }
            }
        }
    }
}
