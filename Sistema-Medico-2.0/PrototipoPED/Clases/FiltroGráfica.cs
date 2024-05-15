using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
    public class FiltroGráfica
    {
        private string enfermedad;
        private string filtro;
        private string subfiltro;
        private DateTime fecha1;
        private DateTime fecha2;
        private int edad;

        public string Enfermedad
        {
            get { return enfermedad; }
            set { enfermedad = value; }
        }

        public string Filtro
        {
            get { return filtro; }
            set { filtro = value; }
        }

        public string Subfiltro
        {
            get { return subfiltro; }
            set { subfiltro = value; }
        }

        public DateTime Fecha1
        {
            get { return fecha1; }
            set { fecha1 = value; }
        }

        public DateTime Fecha2
        {
            get { return fecha2; }
            set { fecha2 = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; } 
        }

        public FiltroGráfica(string enfermedad, string filtro, string subfiltro, DateTime fecha1, DateTime fecha2, int edad)
        {
            this.enfermedad = enfermedad;
            this.filtro = filtro;
            this.subfiltro = subfiltro;
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.edad = edad;
        }

        public FiltroGráfica(string enfermedad, string filtro, DateTime fecha1, DateTime fecha2, int edad)
        {
            this.enfermedad = enfermedad;
            this.filtro = filtro;
            this.subfiltro = "";
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.edad = edad;
        }
    }
}
