using PrototipoPED.Clases;
using PrototipoPED.Forms_de_Pantallazos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
                    cmd.Parameters.AddWithValue("@fecha",paciente.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@dui", paciente.DUI);
                    cmd.Parameters.AddWithValue("@nit", paciente.NIT);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
            }
        }
        public void AgregarMedico(Medico medico)
        {
            string query = "exec personal.InscribirMedico " +
                "@pnom, @pape, @tel, @esp";

            using (SqlConnection cnn = new SqlConnection(ConecStr))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@pnom", medico.Primer_Nombre);
                    cmd.Parameters.AddWithValue("@pape", medico.Primer_Apellido);
                    cmd.Parameters.AddWithValue("@tel", medico.Telefono);
                    cmd.Parameters.AddWithValue("@esp", medico.Especialidad);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
            }

        }
        public string ObtenerCodigoM(string primerNombre, string primerApellido)
        {
            string codigoMedico = "";
            using (SqlConnection connection = new SqlConnection(ConecStr))
            {
                string query = "SELECT codMedico FROM personal.medicos WHERE primerNombre = @primerNombre AND primerApellido = @primerApellido";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@primerNombre", primerNombre);
                command.Parameters.AddWithValue("@primerApellido", primerApellido);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    codigoMedico = reader["codMedico"].ToString();
                }
                reader.Close();
            }

            return codigoMedico;
        }

        public string ObtenerClaveM(string codigoMedico)
        {
            string claveMedico = "";
            using (SqlConnection connection = new SqlConnection(ConecStr))
            {
                string query = "SELECT clave FROM personal.medicos WHERE codMedico = @codigoMedico";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigoMedico", codigoMedico);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    claveMedico = reader["clave"].ToString();
                }
                reader.Close();
            }
            return claveMedico;
        }
        public void VerDatosPCombo(System.Windows.Forms.ComboBox caja)
        {

            string query = "select primerNombre, segundoNombre, primerApellido, segundoApellido from administracion.pacientes";
            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader lector;
                    lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        caja.Items.Add(lector.GetString(0)+" "+ lector.GetString(1)+" "+lector.GetString(2)+" "+lector.GetString(3));
                    }

                }
                catch { }
                
            } 
        }
        public void VerDatosDCombo(System.Windows.Forms.ComboBox caja)
        {

            string query = "select primerNombre, primerApellido from personal.medicos";
            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader lector;
                    lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        caja.Items.Add(lector.GetString(0) + " " + lector.GetString(1));
                    }

                }
                catch { }

            }
        }

        public Paciente DatosPaciente(string nombre_comp)
        {
            string[] partes = nombre_comp.Split(' ');//desgloso el nombre
            string query = "select primerNombre, segundoNombre, " +
                "primerApellido, segundoApellido, direccion, telefono, sexo, " +
                "fechaNacimiento, edad, dui, nit from administracion.pacientes" +
                " where  primernombre= '" + partes[0] +
                "' and segundonombre='" + partes[1] +
                "' and primerapellido='" + partes[2] +
                "' and segundoapellido='" + partes[3]+"'";



            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader lector;
                    lector = cmd.ExecuteReader();
                    Paciente datos = new Paciente();

                    if (lector.Read())//si hay datos
                    {
                        datos.Primer_Nombre = lector["primernombre"].ToString();
                        datos.Segundo_Nombre = lector["segundonombre"].ToString();
                        datos.Primer_Apellido = lector["primerapellido"].ToString();
                        datos.Segundo_Apellido = lector["segundoapellido"].ToString();
                        datos.Direccion = lector["direccion"].ToString();
                        datos.Telefono = lector["telefono"].ToString();
                        datos.Sexo = lector["sexo"].ToString();
                        datos.Fecha_Nacimiento = lector["fechanacimiento"].ToString(); ;
                        datos.DUI = lector["dui"].ToString();
                        datos.NIT = lector["nit"].ToString();
                        datos.Edad = lector["edad"].ToString();

                        conn.Close();
                        return datos;

                    }
                    else
                    {
                        return null;
                    }
                }
                catch(Exception ex)
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

        //Mi obra de arteee
        public void AgregarCita(string Ndoctor, string Npaciente, string FechaHora)
        {
            string[] doc = Ndoctor.Split(' ');//desgloso el nombre
            string[] pac = Npaciente.Split(' ');//desgloso el nombre
            string query = "declare @codPaciente varchar(8) " +
                "declare @codMedico varchar(8) " +
                "declare @especialidad varchar(8) " +
                "select @codPaciente = codpaciente from administracion.pacientes" +
                " where  primernombre= '" + doc[0] +
                "' and segundonombre='" + doc[1] +
                "' and primerapellido='" + doc[2] +
                "' and segundoapellido='" + doc[3]+"' "+

                "select @codMedico= codMedico from personal.medicos" +
                " where  primernombre= '" + pac[0] +
                "' and primerapellido= '" + pac[1] +"'" +

                "select @especialidad= especialidad from personal.medicos" +
                " where  primernombre= '" + pac[0] +
                "' and primerapellido= '" + pac[1] + "'" +

                "exec administracion.IngresarCita " +
                " @codPaciente,@codMedico,@fechaHora,@especialidad";



            using (SqlConnection cnn = new SqlConnection(ConecStr))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@fechaHora", FechaHora);
                    cmd.ExecuteNonQuery();

                    cnn.Close();
                }
                catch (Exception ex) { throw new Exception("Error en la bd: " + ex.Message); }
            }
        }
        
        public List<CitaMedica> TraerCitas()
        {
            List<CitaMedica> citas = new List<CitaMedica>();

            string query = "select concat(m.primerNombre, ' ', m.primerApellido)as [Médico]," +
                " concat(p.primerNombre,' ', p.primerApellido) as Paciente," +
                " fechaHora as Fecha, hora\r\n" +
                "from administracion.pacientes as p \r\n" +
                "inner join administracion.citasMedicas as cm " +
                "on p.codPaciente = cm.codPaciente\r\n" +
                "inner join personal.medicos as m " +
                "on m.codMedico = cm.codMedico\r\n" +
                "where fechaHora > GETDATE()";

            using (SqlConnection conn = new SqlConnection(ConecStr))
            {
                SqlCommand cmd = new SqlCommand(query,conn);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CitaMedica cita = new CitaMedica();

                        cita.Medico = reader.GetString(0);
                        cita.Paciente = reader.GetString(1);
                        cita.Fecha = reader.GetDateTime(2).ToShortDateString().ToString();
                        cita.Hora = reader.GetString(3);

                        citas.Add(cita);
                    }
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //Trae el error y lo muestra en pantalla
                    throw new Exception("Hay un error en la bd" + ex.Message);
                }
            }
            return citas;
        }
    }
}
