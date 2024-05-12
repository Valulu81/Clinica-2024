using PrototipoPED.Forms_de_Pantallazos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PrototipoPED.Forms_de_mensaje
{
    public partial class MensajeAgregarMedico : Form
    {
        public MensajeAgregarMedico()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);

            // Inicia el Timer
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Detiene el Timer
            timer.Stop();

            // Cierra el formulario
            this.Close();

            FrmAgregarDoctor AD = new FrmAgregarDoctor();
            AD.Show();
        }

        Timer timer;
        private void MensajeAgregarMedico_Load(object sender, EventArgs e)
        {
           

        }
    }
}
