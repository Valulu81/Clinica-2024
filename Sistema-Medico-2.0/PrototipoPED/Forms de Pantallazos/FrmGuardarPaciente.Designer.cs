namespace PrototipoPED
{
    partial class FrmGuardarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuardarPaciente));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNit
            // 
            resources.ApplyResources(this.txtNit, "txtNit");
            this.txtNit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtNit.Name = "txtNit";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label7.Name = "label7";
            // 
            // txtDui
            // 
            resources.ApplyResources(this.txtDui, "txtDui");
            this.txtDui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtDui.Name = "txtDui";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label6.Name = "label6";
            // 
            // dtpFechaNacimiento
            // 
            resources.ApplyResources(this.dtpFechaNacimiento, "dtpFechaNacimiento");
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label5.Name = "label5";
            // 
            // rbtnFemenino
            // 
            resources.ApplyResources(this.rbtnFemenino, "rbtnFemenino");
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label4.Name = "label4";
            // 
            // rbtnMasculino
            // 
            resources.ApplyResources(this.rbtnMasculino, "rbtnMasculino");
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label3.Name = "label3";
            // 
            // cmbMunicipio
            // 
            resources.ApplyResources(this.cmbMunicipio, "cmbMunicipio");
            this.cmbMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Name = "cmbMunicipio";
            // 
            // cmbDepartamento
            // 
            resources.ApplyResources(this.cmbDepartamento, "cmbDepartamento");
            this.cmbDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbZona
            // 
            resources.ApplyResources(this.cmbZona, "cmbZona");
            this.cmbZona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.SelectedIndexChanged += new System.EventHandler(this.cmbZona_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtDireccion.Name = "txtDireccion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label2.Name = "label2";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.White;
            this.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtApellido2, "txtApellido2");
            this.txtApellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtApellido2.Name = "txtApellido2";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtApellido1, "txtApellido1");
            this.txtApellido1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtApellido1.Name = "txtApellido1";
            // 
            // txtNombre2
            // 
            this.txtNombre2.BackColor = System.Drawing.Color.White;
            this.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtNombre2, "txtNombre2");
            this.txtNombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtNombre2.Name = "txtNombre2";
            // 
            // txtNombre1
            // 
            this.txtNombre1.BackColor = System.Drawing.Color.White;
            this.txtNombre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtNombre1, "txtNombre1");
            this.txtNombre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtNombre1.Name = "txtNombre1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.label1.Name = "label1";
            // 
            // txtTelefono
            // 
            resources.ApplyResources(this.txtTelefono, "txtTelefono");
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(112)))));
            this.txtTelefono.Name = "txtTelefono";
            // 
            // FrmGuardarPaciente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuardarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.MaskedTextBox txtNit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}