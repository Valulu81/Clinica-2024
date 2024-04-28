using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoPED.Clases
{
    internal class Reporte
    {
        private string cod_Cita;
        private decimal peso;
        private decimal talla;
        private decimal temperatura;
        private string presion_Arterial;
        private string motivo;
        private string diagnostico;

        public string Cod_Cita
        {
            get { return cod_Cita; }
            set { cod_Cita = value; }
        }
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public decimal Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public decimal Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public string Presion_Arterial
        {
            get { return presion_Arterial; }
            set { presion_Arterial = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
    }
}
