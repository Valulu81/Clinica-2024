namespace PrototipoPED
{
    partial class FrmCrearReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbCita = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnfermedades = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(37, 64);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(312, 33);
            this.cmbPaciente.TabIndex = 38;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre del Paciente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.White;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtPeso.Location = new System.Drawing.Point(37, 145);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(143, 34);
            this.txtPeso.TabIndex = 47;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Peso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(37, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Estatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.White;
            this.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtTemperatura.Location = new System.Drawing.Point(37, 389);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperatura.Multiline = true;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(143, 34);
            this.txtTemperatura.TabIndex = 53;
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemperatura.TextChanged += new System.EventHandler(this.txtTemperatura_TextChanged);
            this.txtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperatura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(37, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Temperatura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEstatura
            // 
            this.txtEstatura.BackColor = System.Drawing.Color.White;
            this.txtEstatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtEstatura.Location = new System.Drawing.Point(37, 226);
            this.txtEstatura.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstatura.Multiline = true;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(143, 34);
            this.txtEstatura.TabIndex = 49;
            this.txtEstatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstatura.TextChanged += new System.EventHandler(this.txtEstatura_TextChanged);
            this.txtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatura_KeyPress);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.White;
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtMotivo.Location = new System.Drawing.Point(341, 145);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(321, 217);
            this.txtMotivo.TabIndex = 54;
            this.txtMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.White;
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtDiagnostico.Location = new System.Drawing.Point(695, 145);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(387, 217);
            this.txtDiagnostico.TabIndex = 55;
            this.txtDiagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPresion
            // 
            this.txtPresion.BackColor = System.Drawing.Color.White;
            this.txtPresion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtPresion.Location = new System.Drawing.Point(37, 315);
            this.txtPresion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPresion.Multiline = true;
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(143, 34);
            this.txtPresion.TabIndex = 57;
            this.txtPresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPresion.TextChanged += new System.EventHandler(this.txtPresion_TextChanged);
            this.txtPresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(37, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Presion Arterial";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label7.Location = new System.Drawing.Point(336, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "Motivo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label8.Location = new System.Drawing.Point(685, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Diagnostico";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(965, 379);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 46);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(824, 379);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 46);
            this.btnBorrar.TabIndex = 60;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cmbCita
            // 
            this.cmbCita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCita.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbCita.FormattingEnabled = true;
            this.cmbCita.Location = new System.Drawing.Point(371, 64);
            this.cmbCita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCita.Name = "cmbCita";
            this.cmbCita.Size = new System.Drawing.Size(291, 33);
            this.cmbCita.TabIndex = 63;
            this.cmbCita.SelectedIndexChanged += new System.EventHandler(this.cmbCita_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(371, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Cita:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEnfermedades
            // 
            this.cmbEnfermedades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEnfermedades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEnfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEnfermedades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbEnfermedades.FormattingEnabled = true;
            this.cmbEnfermedades.Location = new System.Drawing.Point(843, 100);
            this.cmbEnfermedades.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEnfermedades.Name = "cmbEnfermedades";
            this.cmbEnfermedades.Size = new System.Drawing.Size(213, 33);
            this.cmbEnfermedades.TabIndex = 64;
            this.cmbEnfermedades.SelectedIndexChanged += new System.EventHandler(this.cmbEnfermedades_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label9.Location = new System.Drawing.Point(685, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Enfermedad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCrearReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1117, 457);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEnfermedades);
            this.Controls.Add(this.cmbCita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCrearReporte";
            this.Text = "FrmCrearReporte";
            this.Load += new System.EventHandler(this.FrmCrearReporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEnfermedades;
        private System.Windows.Forms.Label label9;
    }
}