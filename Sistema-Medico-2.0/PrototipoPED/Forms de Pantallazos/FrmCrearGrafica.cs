using PrototipoPED.Clases;
using PrototipoPED.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrototipoPED.Forms_de_Pantallazos
{
    public partial class FrmCrearGrafica : Form
    {
        string[] filtros = { "País", "Zona"};
        string[] zonas = { "Occidente", "Central", "Oriente" };
        string[] depasOccidente = { "Ahuachapán", "Santa_Ana", "Sonsonate" };
        string[] depasCentral = { "Chalatenango", "Cuscatlán", "Cabañas", "La_libertad", "La_Paz", "San_Vicente", "San_Salvador" };
        string[] depasOriental = { "Morazán", "La_Unión", "San_Miguel", "Usulután" };

        private void Limpiar()
        {
            cmbEnfermedad.SelectedIndex = -1;
            cmbFiltro.SelectedIndex = -1;
            txtEdad.Text = "";
        }

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
            cmbFiltro.Items.AddRange(filtros);
            try
            {
                Conexion cnn = new Conexion();
                cnn.VerDatosECombo(cmbEnfermedad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if(cmbFiltro.Text == "Pais")
            {
                cmbSulfiltro.Text = "";
            }

            else if(cmbFiltro.Text == "Zona")
            {
                lblSub.Visible = true;
                cmbSulfiltro.Visible = true;
                cmbSulfiltro.Items.Clear();
                LlenarCmbZona();
                cmbSulfiltro.SelectedIndex = -1;
            }
        }

        private void Filtrar(FiltroGráfica filtroG, string[] arreglo)
        {
            Conexion cnn = new Conexion();
            try
            {
                ABB arbolFiltro = cnn.DevolverCantidadesPais(arreglo, filtroG);
                //int[] cantidades = cnn.DevolverCantidadesPais(arreglo, filtroG);

                string cantidad = arbolFiltro.RecorridoInordenValor().Trim();
                string lugares = arbolFiltro.RecorridoInordenFiltro().Trim();
                string[] parte_lug = lugares.Split(' ');
                string[] parte_cant = cantidad.Split(' ');
                int[] valores = new int[parte_cant.Length];

                int contador = 0;
                foreach(string p in parte_cant)
                {
                    valores[contador] = Convert.ToInt32(p);
                    contador++;
                }

                string cadena = "";

                for(int i = 0; i < valores.Length; i++)
                {
                    cadena += parte_lug[i]+" : "+valores[i].ToString()+" \n";
                }
                //Aqui puedes usar las cadenas parte_cant y parte_lug para la gráfica, ejecutar abajo


                // Llena el Chart con los datos
                chart1.Series.Clear();
                chart1.ChartAreas[0].AxisX.Interval = 1;

                int minValorY = valores.Min();
                int maxValorY = valores.Max();
                chart1.ChartAreas[0].AxisY.Minimum = minValorY - 1;
                chart1.ChartAreas[0].AxisY.Maximum = maxValorY + 2;

                Series serie = chart1.Series.Add("Valores");
                serie.ChartType = SeriesChartType.Column;

                for (int i = 0; i < parte_lug.Length; i++)
                {
                    serie.Points.AddXY(parte_lug[i], valores[i]);
                }

                // Hace visible el Chart
                chart1.Visible = true;

                //MessageBox.Show(cadena);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Limpiar();
                return;
            }

            Limpiar();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string enfermedad = cmbEnfermedad.Text;
            string filtro = cmbFiltro.Text;
            string subfiltro = cmbSulfiltro.Text;

            DateTime fecha1 = Convert.ToDateTime(dtpFecha1.Text);
            DateTime fecha2 = Convert.ToDateTime(dtpFecha2.Text);

            if(cmbEnfermedad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una enfermedad primero");
                return;
            }

            if(cmbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un filtro primero");
                return;
            }

            if(txtEdad.Text == "")
            {
                MessageBox.Show("Debe ingresar una edad como parámetro minimo");
                txtEdad.Focus();
                return;
            }

            if(Convert.ToInt32(txtEdad.Text) < 0)
            {
                MessageBox.Show("Debe ingresar una edad válida");
                txtEdad.Clear();
                txtEdad.Focus();
                return;
            }

            int edad = Convert.ToInt32(txtEdad.Text);

            FiltroGráfica filtroG = new FiltroGráfica(enfermedad, filtro, subfiltro, fecha1, fecha2, edad);

            switch (filtro)
            {
                case "País":
                    Filtrar(filtroG,zonas);
                    break;

                case "Zona":

                    switch (subfiltro)
                    {
                        case "Occidente":
                            Filtrar(filtroG, depasOccidente);
                            break;

                        case "Central":
                            Filtrar(filtroG, depasCentral);
                            break;

                        case "Oriente":
                            Filtrar(filtroG, depasOriental);
                            break;
                    }

                    break;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
