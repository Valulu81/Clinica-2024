using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
    public class CitaMedica
    {
        private string paciente;
        private string medico;
        private string fecha;
        private string hora;

        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public string Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
    }
}
