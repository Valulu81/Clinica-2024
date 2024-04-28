using PrototipoPED.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace PrototipoPED.ConexionBD
{
    public class Conexion
    {
        private string ConecStr = "data source=localhost; initial catalog=Clinica;" +
        " persist security info=True; Integrated Security=SSPI; ";

        public void AgregarPaciente(Paciente paciente)
        {
            string query = "exec administracion.InscribirPaciente " +
                "@pnom, @snom, @pape, @sape, @dir, @tel, @sex, @fecha, @dui, @nit";

            using (SqlConnection cnn = new SqlConnection(ConecStr))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@pnom", paciente.Primer_Nombre);
                    cmd.Parameters.AddWithValue("@snom", paciente.Segundo_Nombre);
                    cmd.Parameters.AddWithValue("@pape", paciente.Primer_Apellido);
                    cmd.Parameters.AddWithValue("@sape", paciente.Segundo_Apellido);
                    cmd.Parameters.AddWithValue("@dir", paciente.Direccion);
                    cmd.Parameters.AddWithValue("@tel", paciente.Telefono);
                    cmd.Parameters.AddWithValue("@sex", paciente.Sexo);
                    cmd.Parameters.AddWithValue("@fecha", paciente.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@dui", paciente.DUI);
                    cmd.Parameters.AddWithValue("@nit", paciente.NIT);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
            }
        }

        public Paciente DatosPaciente(string codPaciente)
        {
            string query = "select primerNombre, segundoNombre, " +
                "primerApellido, segundoApellido, direccion, telefono, sexo, " +
                "fechaNacimiento, edad from administracion.pacientes" +
                " where codPaciente=@id";

            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", codPaciente);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    Paciente per = new Paciente();
                    reader.Read();

                    per.Primer_Nombre = reader.GetString(0);
                    per.Segundo_Nombre = reader.GetString(1);
                    per.Primer_Apellido = reader.GetString(2);
                    per.Segundo_Apellido = reader.GetString(3);
                    per.Direccion = reader.GetString(4);
                    per.Telefono = reader.GetString(5);
                    per.Sexo = reader.GetString(6);
                    per.Fecha_Nacimiento = reader.GetDateTime(7);

                    reader.Close();
                    conn.Close();

                    return per;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd: " + ex.Message);
                }

            }
        }

        public void AgregarMedico(string pnom, string pape, string tel, string esp, string clave)
        {
            string query = "exec personal.InscribirMedico " +
                "@pnom, @pape, @tel, @esp, @clave"; ;

            using (SqlConnection cnn = new SqlConnection(ConecStr))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@pnom", pnom);
                    cmd.Parameters.AddWithValue("@pape", pape);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@esp", esp);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
            }

        }

        public string[] TraerPaciente(string nom)
        {
            string query = " select CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as NombreCompleto " +
                "from administracion.pacientes where\r\n primerNombre Like '%@nom' or primerApellido like '%nom'";

            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nom", nom);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> pacientes = new List<string>();

                    reader.Read();

                    string paciente = reader.GetString(0);
                    pacientes.Add(paciente);

                    reader.Close();
                    conn.Close();

                    return pacientes.ToArray();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd: " + ex.Message);
                }

            }
        }

    }
}
