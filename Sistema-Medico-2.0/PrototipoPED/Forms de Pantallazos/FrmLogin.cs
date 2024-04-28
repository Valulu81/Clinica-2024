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

namespace PrototipoPED
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtUsuario.Text;
            if (usuario=="admin")
            {
                FrmMainAdmin admin = new FrmMainAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                Interfaz frmInterfaz = new Interfaz();
                frmInterfaz.Show();
                this.Hide();

            }
        }
    }
}
