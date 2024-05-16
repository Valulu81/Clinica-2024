using PrototipoPED.ConexionBD;
using PrototipoPED.Forms_de_Pantallazos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrototipoPED
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txtContraseña.PasswordChar = '*';

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contra;
            usuario = txtUsuario.Text;
            contra=txtContraseña.Text;

            if (usuario == "admin" && contra == "admin")
            {
                FrmMainAdmin admin = new FrmMainAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                Conexion miConexion = new Conexion();
                string username = txtUsuario.Text;
                string password = txtContraseña.Text;

                if (miConexion.IniciarSesion(username, password))
                {
                    MessageBox.Show("Inicio de sesión exitoso!");
                    Interfaz frmInterfaz = new Interfaz();
                    frmInterfaz.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");

                    return;
                }

            }

            


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            txtContraseña.Enabled= false;

            txtUsuario.TabIndex=0;
            txtContraseña.TabIndex=1;
            btnIngresar.TabIndex=2;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.Enabled = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                btnIngresar_Click(sender, e);
            }
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
