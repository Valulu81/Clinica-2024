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
    public partial class FrmCrearGrafica : Form
    {
        string[] filtros = { "País", "Zona", "Departamento"};
        string[] zonas = { "Occidente", "Central", "Oriente" };
        string[] depasOccidente = { "Ahuachapán", "Santa Ana", "Sonsonate" };
        string[] depasCentral = { "Chalatenango", "Cuscatlán", "Cabañas", "La libertad", "La Paz", "San Vicente", "San Salvador" };
        string[] depasOriental = { "Morazán", "La Unión", "San Miguel", "Usulután" };

        private void LlenarCmbZona()
        {
            cmbSulfiltro.Items.AddRange(zonas);
        }

        private void LlenarCmbDepartamento()
        {
            cmbSulfiltro.Items.AddRange(depasOccidente);
            cmbSulfiltro.Items.AddRange(depasOriental);
            cmbSulfiltro.Items.AddRange(depasCentral);
        }

        public FrmCrearGrafica()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FrmVerReporte form = new FrmVerReporte();
            form.ShowDialog();
        }

        private void cmbZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSub.Visible = false;
            cmbSulfiltro.Visible = false;
            if(cmbZona.Text == "Zona")
            {
                lblSub.Visible = true;
                cmbSulfiltro.Visible = true;
                cmbZona.Items.Clear();
                LlenarCmbZona();
                cmbSulfiltro.SelectedIndex = -1;
            }
            else if(cmbZona.Text == "Departamento")
            {
                lblSub.Visible = true;
                cmbSulfiltro.Visible = true;
                cmbZona.Items.Clear();
                LlenarCmbDepartamento();
                cmbSulfiltro.SelectedIndex = -1;
            }
        }
    }
}
