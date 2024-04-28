using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin()
        {
            InitializeComponent();
            AbrirFormulario(new FrmAuxiliar());

        }
        bool btnBLPulsado = true, btnUPulsado = false;
        private Form FormAbierto = null;


        private void AbrirFormulario(Form FormHijo)
        {
            if (FormAbierto != null)
            {
                FormAbierto.Close();
            }
            FormAbierto = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(FormHijo);
            pnlForm.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

            BarraLateral(ref btnBLPulsado);
        }
        private void BarraLateral(ref bool btnBlPulsado)
        {
            if (btnBLPulsado)
            {
                btnBarraLateral.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
                pnlBarraLateral.Visible = false;
            }
            else
            {
                btnBarraLateral.IconChar = FontAwesome.Sharp.IconChar.Xmark;
                pnlBarraLateral.Visible = true;
            }
            btnBLPulsado = !btnBLPulsado;
        }


        private void btncrearreporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmVerDatosPaciente());
        }

        private void btnguardarcitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGuardarCitas());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarDoctor());
        }

        private void btnBarraLateral_Click(object sender, EventArgs e)
        {
            BarraLateral(ref btnBLPulsado);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (btnUPulsado)
            {
                pnlUsuario.Visible = false;
            }
            else
            {
                pnlUsuario.BringToFront();
                pnlUsuario.Visible = true;
            }
            btnUPulsado = !btnUPulsado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();

        }

        private void btnRegistrarPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGuardarPaciente());

        }
    }
}
