using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
    internal class Medico
    {
        private string primer_nombre;
        private string primer_apellido;
        private string telefono;
        private string especialidad;

        public string Primer_Nombre
        {
            get { return primer_nombre;}
            set { primer_nombre = value; }
        }
        public string Primer_Apellido
        {
            get { return primer_apellido;}
            set { primer_apellido = value;}
        }
        public string Especialidad
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Telefono
        {
            get { return especialidad;}
            set { especialidad = value;}
        }

    }
}
