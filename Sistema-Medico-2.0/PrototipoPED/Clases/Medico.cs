using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
     public  class Medico
    {
        public string primer_nombre;
        public string primer_apellido;
        public string telefono;
        public string especialidad;

        public string Primer_Nombre
        {
            get { return primer_nombre; }
            set { primer_nombre = value; }
        }
        public string Primer_Apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

    }
}
