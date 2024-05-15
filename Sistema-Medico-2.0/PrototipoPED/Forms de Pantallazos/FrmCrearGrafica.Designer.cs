namespace PrototipoPED.Forms_de_Pantallazos
{
    partial class FrmCrearGrafica
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
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnfermedad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.btnreporte = new System.Windows.Forms.Button();
            this.cmbSulfiltro = new System.Windows.Forms.ComboBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(35, 117);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(132, 28);
            this.cmbFiltro.TabIndex = 65;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbZona_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Filtro de área";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtEdad.Location = new System.Drawing.Point(39, 310);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(107, 28);
            this.txtEdad.TabIndex = 63;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(35, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Rango de edad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(35, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Lapso de tiempo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEnfermedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.Location = new System.Drawing.Point(35, 50);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.Size = new System.Drawing.Size(163, 28);
            this.cmbEnfermedad.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Enfermedad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(717, 312);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(87, 37);
            this.btnCrear.TabIndex = 57;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(611, 312);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 37);
            this.btnBorrar.TabIndex = 56;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // pnlGrafica
            // 
            this.pnlGrafica.BackColor = System.Drawing.Color.White;
            this.pnlGrafica.Location = new System.Drawing.Point(352, 22);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(452, 275);
            this.pnlGrafica.TabIndex = 69;
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.CadetBlue;
            this.btnreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Location = new System.Drawing.Point(473, 312);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(118, 37);
            this.btnreporte.TabIndex = 70;
            this.btnreporte.Text = "Ver Reporte";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // cmbSulfiltro
            // 
            this.cmbSulfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSulfiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbSulfiltro.FormattingEnabled = true;
            this.cmbSulfiltro.Location = new System.Drawing.Point(186, 117);
            this.cmbSulfiltro.Name = "cmbSulfiltro";
            this.cmbSulfiltro.Size = new System.Drawing.Size(120, 28);
            this.cmbSulfiltro.TabIndex = 71;
            this.cmbSulfiltro.Visible = false;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.lblSub.Location = new System.Drawing.Point(182, 86);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(77, 20);
            this.lblSub.TabIndex = 72;
            this.lblSub.Text = "Subfiltro";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSub.Visible = false;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Location = new System.Drawing.Point(39, 197);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(285, 26);
            this.dtpFecha1.TabIndex = 73;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Location = new System.Drawing.Point(39, 229);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(285, 26);
            this.dtpFecha2.TabIndex = 74;
            // 
            // FrmCrearGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(838, 371);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.cmbSulfiltro);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.pnlGrafica);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEnfermedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearGrafica";
            this.Text = "FrmCrearGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEnfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.ComboBox cmbSulfiltro;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
    }
}