using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
    public class Paciente
    {
        private string primer_nombre;
        private string segundo_nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private string direccion;
        private string telefono;
        private string sexo;
        private string dui;
        private string nit;
        private DateTime fecha_nacimiento;

        public string Primer_Nombre
        {
            get { return primer_nombre; }
            set { primer_nombre = value; }
        }
        public string Segundo_Nombre
        {
            get { return segundo_nombre; }
            set { segundo_nombre = value; }
        }
        public string Primer_Apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value; }
        }
        public string Segundo_Apellido
        {
            get { return segundo_apellido; }
            set { segundo_apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public DateTime Fecha_Nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        public string DUI
        {
            get { return dui; }
            set { dui = value; }
        }
        public string NIT
        {
            get { return nit; }
            set { nit = value; }
        }
    }
}
