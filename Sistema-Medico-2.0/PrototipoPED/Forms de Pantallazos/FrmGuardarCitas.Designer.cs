namespace PrototipoPED
{
    partial class FrmGuardarCitas
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
            this.gdvCitas = new System.Windows.Forms.DataGridView();
            this.txtdoctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAgendada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbpaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvCitas
            // 
            this.gdvCitas.BackgroundColor = System.Drawing.Color.White;
            this.gdvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCitas.Location = new System.Drawing.Point(352, 22);
            this.gdvCitas.Name = "gdvCitas";
            this.gdvCitas.Size = new System.Drawing.Size(452, 275);
            this.gdvCitas.TabIndex = 55;
            // 
            // txtdoctor
            // 
            this.txtdoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtdoctor.FormattingEnabled = true;
            this.txtdoctor.Location = new System.Drawing.Point(35, 135);
            this.txtdoctor.Name = "txtdoctor";
            this.txtdoctor.Size = new System.Drawing.Size(120, 28);
            this.txtdoctor.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre del Doctor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txthorario
            // 
            this.txthorario.BackColor = System.Drawing.Color.White;
            this.txthorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txthorario.Location = new System.Drawing.Point(35, 269);
            this.txthorario.Multiline = true;
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(107, 28);
            this.txthorario.TabIndex = 52;
            this.txthorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Horario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaAgendada
            // 
            this.dtpFechaAgendada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAgendada.Location = new System.Drawing.Point(35, 205);
            this.dtpFechaAgendada.Name = "dtpFechaAgendada";
            this.dtpFechaAgendada.Size = new System.Drawing.Size(296, 22);
            this.dtpFechaAgendada.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(35, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha Agendada\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbpaciente
            // 
            this.cmbpaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbpaciente.FormattingEnabled = true;
            this.cmbpaciente.Location = new System.Drawing.Point(35, 65);
            this.cmbpaciente.Name = "cmbpaciente";
            this.cmbpaciente.Size = new System.Drawing.Size(120, 28);
            this.cmbpaciente.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(35, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre del Paciente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(717, 312);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(87, 37);
            this.btnguardar.TabIndex = 46;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.Location = new System.Drawing.Point(611, 312);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(87, 37);
            this.btnborrar.TabIndex = 45;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // FrmGuardarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(838, 371);
            this.Controls.Add(this.gdvCitas);
            this.Controls.Add(this.txtdoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaAgendada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbpaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnborrar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuardarCitas";
            this.Text = "FrmGuardarCitas";
            ((System.ComponentModel.ISupportInitialize)(this.gdvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvCitas;
        private System.Windows.Forms.ComboBox txtdoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaAgendada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbpaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
    }
}