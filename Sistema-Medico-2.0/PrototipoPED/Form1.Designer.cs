namespace PrototipoPED
{
    partial class Interfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btnBarraLateral = new FontAwesome.Sharp.IconButton();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.btnRegistrarPacientes = new FontAwesome.Sharp.IconButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btncrearreporte = new FontAwesome.Sharp.IconButton();
            this.btnguardarcitas = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.pnlNav.SuspendLayout();
            this.pnlBarraLateral.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
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
            this.pnlNav.TabIndex = 0;
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
            this.btnBarraLateral.UseVisualStyleBackColor = true;
            this.btnBarraLateral.Click += new System.EventHandler(this.btnBarraLateral_Click);
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.pnlBarraLateral.Controls.Add(this.iconButton4);
            this.pnlBarraLateral.Controls.Add(this.btnguardarcitas);
            this.pnlBarraLateral.Controls.Add(this.btncrearreporte);
            this.pnlBarraLateral.Controls.Add(this.btnRegistrarPacientes);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(85, 371);
            this.pnlBarraLateral.TabIndex = 2;
            this.pnlBarraLateral.Visible = false;
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
            this.btnRegistrarPacientes.Size = new System.Drawing.Size(85, 85);
            this.btnRegistrarPacientes.TabIndex = 1;
            this.btnRegistrarPacientes.UseVisualStyleBackColor = true;
            this.btnRegistrarPacientes.Click += new System.EventHandler(this.btnRegistrarPacientes_Click);
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
            this.pnlForm.TabIndex = 1;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(74)))), ((int)(((byte)(129)))));
            this.pnlUsuario.Controls.Add(this.iconButton3);
            this.pnlUsuario.Controls.Add(this.btnLogin);
            this.pnlUsuario.Controls.Add(this.btnSalir);
            this.pnlUsuario.Location = new System.Drawing.Point(710, 5);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(121, 169);
            this.pnlUsuario.TabIndex = 4;
            this.pnlUsuario.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 110);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(121, 55);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Ajustes";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
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
            // btncrearreporte
            // 
            this.btncrearreporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncrearreporte.FlatAppearance.BorderSize = 2;
            this.btncrearreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearreporte.ForeColor = System.Drawing.Color.Transparent;
            this.btncrearreporte.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btncrearreporte.IconColor = System.Drawing.Color.White;
            this.btncrearreporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearreporte.Location = new System.Drawing.Point(0, 85);
            this.btncrearreporte.Name = "btncrearreporte";
            this.btncrearreporte.Size = new System.Drawing.Size(85, 85);
            this.btncrearreporte.TabIndex = 2;
            this.btncrearreporte.UseVisualStyleBackColor = true;
            this.btncrearreporte.Click += new System.EventHandler(this.btncrearreporte_Click);
            // 
            // btnguardarcitas
            // 
            this.btnguardarcitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnguardarcitas.FlatAppearance.BorderSize = 2;
            this.btnguardarcitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcitas.ForeColor = System.Drawing.Color.Transparent;
            this.btnguardarcitas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnguardarcitas.IconColor = System.Drawing.Color.White;
            this.btnguardarcitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardarcitas.Location = new System.Drawing.Point(0, 170);
            this.btnguardarcitas.Name = "btnguardarcitas";
            this.btnguardarcitas.Size = new System.Drawing.Size(85, 85);
            this.btnguardarcitas.TabIndex = 3;
            this.btnguardarcitas.UseVisualStyleBackColor = true;
            this.btnguardarcitas.Click += new System.EventHandler(this.btnguardarcitas_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 2;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 255);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(85, 85);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlNav);
            this.Name = "Interfaz";
            this.Text = "Form1";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlBarraLateral.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private FontAwesome.Sharp.IconButton btnBarraLateral;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private FontAwesome.Sharp.IconButton btnRegistrarPacientes;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlUsuario;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnguardarcitas;
        private FontAwesome.Sharp.IconButton btncrearreporte;
    }
}

