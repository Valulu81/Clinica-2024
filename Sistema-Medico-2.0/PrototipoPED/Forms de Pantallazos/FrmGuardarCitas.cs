﻿using PrototipoPED.ConexionBD;
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
    public partial class FrmGuardarCitas : Form
    {
        string[] horarios = { "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
        "13:00:00","13:30:00","14:00:00","14:30:00","15:00:00","15:30:00","16:00:00","16:30:00","17:00:00","17:30:00","18:00:00"};

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Julio", "Junio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        string[] dias = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };

        

        public FrmGuardarCitas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
                miconexion.VerDatosDCombo(cmbDoctor);
                cmbHorario.Items.AddRange(horarios);
                cmbMes.Items.AddRange(meses);
                cmbDia.Items.AddRange(dias);
                LlenarCmbCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            cmbPaciente.Text = "";
            cmbDoctor.Text = "";
            cmbHorario.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbDia.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
            txtAño.Clear();
        }

        private void LlenarCmbCitas()
        {
            Conexion conn = new Conexion();
            dgvCitas.DataSource = conn.TraerCitas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             if (cmbPaciente.SelectedIndex == -1)
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Por favor, seleccione un paciente.");
                cmbPaciente.Focus();
                btnGuardar.Enabled = true;
            }

            if (cmbDoctor.SelectedIndex == -1 || cmbHorario.SelectedIndex == -1 || cmbDia.SelectedIndex == -1 || cmbMes.SelectedIndex == -1 )
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Por favor, complete los campos.");
                btnGuardar.Enabled = true;
            }

            else
            {
                //btnGuardar.Enabled = true;

                string fechaHora;
                fechaHora = txtAño.Text + "-" + (cmbMes.SelectedIndex + 1).ToString() + "-" + cmbDia.Text + " " + cmbHorario.Text + ".000";
                Conexion miConexion = new Conexion();
                try
                {
                    miConexion.AgregarCita(cmbPaciente.Text, cmbDoctor.Text, fechaHora);
                    Limpiar();
                    cmbDoctor.Enabled = false;
                    cmbHorario.Enabled = false;
                    cmbMes.Enabled = false;
                    txtAño.Enabled = false;
                    cmbDia.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
            LlenarCmbCitas();
            Limpiar();
            }


        }

        private void FrmGuardarCitas_Load(object sender, EventArgs e)
        {
            cmbDoctor.Enabled = false;
            cmbHorario.Enabled = false;
            cmbMes.Enabled = false;
            txtAño.Enabled = false;
            cmbDia.Enabled = false;
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPaciente.TabIndex = 0;
            cmbDoctor.TabIndex = 1;
            txtAño.TabIndex = 2;
            cmbMes.TabIndex = 3;
            cmbDia.TabIndex = 4;
            cmbHorario.TabIndex = 5;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbDoctor.Enabled = false;
            cmbHorario.Enabled = false;
            cmbMes.Enabled = false;
            txtAño.Enabled = false;
            cmbDia.Enabled = false;
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Enabled = true;
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAño.Enabled=true;
        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            cmbMes.Enabled=true;
            
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDia.Enabled=true;
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHorario.Enabled=true;
        }

        

        private void txtAño_MouseLeave_1(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtAño.Text, out valor))
            {
                if (valor < 2024 || valor > 2026)
                {
                    // Si el valor está fuera del rango, borra el texto del MaskedTextBox
                    txtAño.Text = "";
                    MessageBox.Show("Ingrese un valor válido de año para la cita, entre 2024 y 2026 ");
                }

            }
            else
            {
                // Si el texto no es un número válido, también borra el texto del MaskedTextBox
                txtAño.Text = "";
            }

            // Regresa el foco al MaskedTextBox
            txtAño.Focus();

        }
    }
}

