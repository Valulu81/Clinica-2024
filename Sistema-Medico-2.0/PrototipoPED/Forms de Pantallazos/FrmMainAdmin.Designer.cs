namespace PrototipoPED.Forms_de_Pantallazos
{
    partial class FrmMainAdmin
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btnBarraLateral = new FontAwesome.Sharp.IconButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnAjustes = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.btnAgregarDoctor = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCitas = new FontAwesome.Sharp.IconButton();
            this.btnVerDatosPaciente = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarPacientes = new FontAwesome.Sharp.IconButton();
            this.pnlNav.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlBarraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.pnlNav.Controls.Add(this.label1);
            this.pnlNav.Controls.Add(this.btnUsuario);
            this.pnlNav.Controls.Add(this.btnBarraLateral);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(838, 70);
            this.pnlNav.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(657, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario Tal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnUsuario.IconColor = System.Drawing.Color.White;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsuario.IconSize = 70;
            this.btnUsuario.Location = new System.Drawing.Point(759, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(79, 70);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnBarraLateral
            // 
            this.btnBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(161)))));
            this.btnBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBarraLateral.FlatAppearance.BorderSize = 0;
            this.btnBarraLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarraLateral.ForeColor = System.Drawing.Color.Transparent;
            this.btnBarraLateral.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.btnBarraLateral.IconColor = System.Drawing.Color.White;
            this.btnBarraLateral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.btnBarraLateral.Name = "btnBarraLateral";
            this.btnBarraLateral.Size = new System.Drawing.Size(85, 70);
            this.btnBarraLateral.TabIndex = 0;
            this.btnBarraLateral.UseVisualStyleBackColor = false;
            this.btnBarraLateral.Click += new System.EventHandler(this.btnBarraLateral_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlUsuario);
            this.pnlForm.Controls.Add(this.pnlBarraLateral);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 70);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(838, 371);
            this.pnlForm.TabIndex = 2;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(74)))), ((int)(((byte)(129)))));
            this.pnlUsuario.Controls.Add(this.btnAjustes);
            this.pnlUsuario.Controls.Add(this.btnLogin);
            this.pnlUsuario.Controls.Add(this.btnSalir);
            this.pnlUsuario.Location = new System.Drawing.Point(710, 5);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(121, 169);
            this.pnlUsuario.TabIndex = 4;
            this.pnlUsuario.Visible = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnAjustes.IconColor = System.Drawing.Color.White;
            this.btnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjustes.Location = new System.Drawing.Point(0, 110);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(121, 55);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 55);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(132)))), ((int)(((byte)(134)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 55);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.pnlBarraLateral.Controls.Add(this.btnAgregarDoctor);
            this.pnlBarraLateral.Controls.Add(this.btnGuardarCitas);
            this.pnlBarraLateral.Controls.Add(this.btnVerDatosPaciente);
            this.pnlBarraLateral.Controls.Add(this.btnRegistrarPacientes);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(85, 371);
            this.pnlBarraLateral.TabIndex = 2;
            this.pnlBarraLateral.Visible = false;
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDoctor.FlatAppearance.BorderSize = 2;
            this.btnAgregarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoctor.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarDoctor.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnAgregarDoctor.IconColor = System.Drawing.Color.White;
            this.btnAgregarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(0, 276);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(85, 92);
            this.btnAgregarDoctor.TabIndex = 4;
            this.btnAgregarDoctor.UseVisualStyleBackColor = true;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnGuardarCitas
            // 
            this.btnGuardarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardarCitas.FlatAppearance.BorderSize = 2;
            this.btnGuardarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCitas.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardarCitas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnGuardarCitas.IconColor = System.Drawing.Color.White;
            this.btnGuardarCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCitas.Location = new System.Drawing.Point(0, 184);
            this.btnGuardarCitas.Name = "btnGuardarCitas";
            this.btnGuardarCitas.Size = new System.Drawing.Size(85, 92);
            this.btnGuardarCitas.TabIndex = 3;
            this.btnGuardarCitas.UseVisualStyleBackColor = true;
            this.btnGuardarCitas.Click += new System.EventHandler(this.btnguardarcitas_Click);
            // 
            // btnVerDatosPaciente
            // 
            this.btnVerDatosPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerDatosPaciente.FlatAppearance.BorderSize = 2;
            this.btnVerDatosPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDatosPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerDatosPaciente.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnVerDatosPaciente.IconColor = System.Drawing.Color.White;
            this.btnVerDatosPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerDatosPaciente.Location = new System.Drawing.Point(0, 92);
            this.btnVerDatosPaciente.Name = "btnVerDatosPaciente";
            this.btnVerDatosPaciente.Size = new System.Drawing.Size(85, 92);
            this.btnVerDatosPaciente.TabIndex = 2;
            this.btnVerDatosPaciente.UseVisualStyleBackColor = true;
            this.btnVerDatosPaciente.Click += new System.EventHandler(this.btncrearreporte_Click);
            // 
            // btnRegistrarPacientes
            // 
            this.btnRegistrarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarPacientes.FlatAppearance.BorderSize = 2;
            this.btnRegistrarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPacientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPacientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistrarPacientes.IconColor = System.Drawing.Color.White;
            this.btnRegistrarPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarPacientes.Name = "btnRegistrarPacientes";
            this.btnRegistrarPacientes.Size = new System.Drawing.Size(85, 92);
            this.btnRegistrarPacientes.TabIndex = 1;
            this.btnRegistrarPacientes.UseVisualStyleBackColor = true;
            this.btnRegistrarPacientes.Click += new System.EventHandler(this.btnRegistrarPacientes_Click);
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainAdmin";
            this.Text = "FrmMainAdmin";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlBarraLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnBarraLateral;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlUsuario;
        private FontAwesome.Sharp.IconButton btnAjustes;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private FontAwesome.Sharp.IconButton btnAgregarDoctor;
        private FontAwesome.Sharp.IconButton btnGuardarCitas;
        private FontAwesome.Sharp.IconButton btnVerDatosPaciente;
        private FontAwesome.Sharp.IconButton btnRegistrarPacientes;
    }
}