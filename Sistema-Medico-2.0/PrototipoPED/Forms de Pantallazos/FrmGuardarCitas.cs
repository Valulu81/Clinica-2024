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
        String[] horarios = { "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
        "13:00:00","13:30:00","14:00:00","14:30:00","15:00:00","15:30:00","16:00:00","16:30:00","17:00:00","17:30:00","18:00:00"};

        string[] meses = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };


        public FrmGuardarCitas()
        {
            InitializeComponent();
            try
            {
                Conexion miconexion = new Conexion();
                miconexion.VerDatosPCombo(cmbPaciente);
                miconexion.VerDatosDCombo(cmbDoctor);
                cmbHorario.Items.AddRange(horarios);
            }
            catch { }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuardarCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fechaHora;
            fechaHora = cmbAño.Text ;

            MessageBox.Show(fechaHora);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
