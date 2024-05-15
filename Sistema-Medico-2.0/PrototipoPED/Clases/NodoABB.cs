using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Clases
{
    public class NodoABB
    {
        public int Valor { get; set; }
        public string Nombre { get; set; }
        public NodoABB Izquierdo { get; set; }
        public NodoABB Derecho { get; set; }
    }
}
