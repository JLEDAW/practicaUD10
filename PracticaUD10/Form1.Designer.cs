namespace PracticaUD10
{
    partial class Form1
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelSocios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(81, 29);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(173, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(333, 29);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(185, 20);
            this.tApellidos.TabIndex = 1;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(598, 29);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(190, 20);
            this.tTelefono.TabIndex = 2;
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(34, 127);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.ReadOnly = true;
            this.tListaSocios.Size = new System.Drawing.Size(754, 261);
            this.tListaSocios.TabIndex = 3;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(662, 89);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(126, 23);
            this.BotonGuardar.TabIndex = 4;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(31, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(278, 32);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 6;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(543, 32);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelSocios
            // 
            this.labelSocios.AutoSize = true;
            this.labelSocios.Location = new System.Drawing.Point(31, 99);
            this.labelSocios.Name = "labelSocios";
            this.labelSocios.Size = new System.Drawing.Size(64, 13);
            this.labelSocios.TabIndex = 8;
            this.labelSocios.Text = "Lista Socios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSocios);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tListaSocios;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelSocios;
    }
}

