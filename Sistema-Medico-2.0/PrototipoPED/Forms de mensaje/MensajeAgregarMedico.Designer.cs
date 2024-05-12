namespace PrototipoPED.Forms_de_mensaje
{
    partial class MensajeAgregarMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDoctor = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregando perfil médico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDoctor.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoctor.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarDoctor.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnAgregarDoctor.IconColor = System.Drawing.Color.White;
            this.btnAgregarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(330, 113);
            this.btnAgregarDoctor.TabIndex = 5;
            this.btnAgregarDoctor.UseVisualStyleBackColor = true;
            // 
            // MensajeAgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(164)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(330, 196);
            this.Controls.Add(this.btnAgregarDoctor);
            this.Controls.Add(this.label1);
            this.Name = "MensajeAgregarMedico";
            this.Load += new System.EventHandler(this.MensajeAgregarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAgregarDoctor;
    }
}