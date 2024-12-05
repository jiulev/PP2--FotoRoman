namespace FotoRoman
{
    partial class FormCrearUsuario
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new Label();
            this.Nombre = new Label();
            this.Documento = new Label();
            this.Email = new Label();
            this.Contraseña = new Label();
            this.Rol = new Label();
            this.textNombre = new TextBox();
            this.textDocumento = new TextBox();
            this.textEmail = new TextBox();
            this.textPassword = new TextBox();
            this.cmbRol = new ComboBox();
            this.aceptarCrearUsuario = new Button();
            this.cancelarCrearUsuario = new Button();
            this.SuspendLayout();

            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelTitulo.Location = new Point(200, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new Size(200, 30);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Registrar Usuario";
            this.labelTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Nombre.Location = new Point(50, 80);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new Size(140, 21);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre y Apellido:";

            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Documento.Location = new Point(50, 130);
            this.Documento.Name = "Documento";
            this.Documento.Size = new Size(92, 21);
            this.Documento.TabIndex = 2;
            this.Documento.Text = "Documento:";

            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Email.Location = new Point(50, 180);
            this.Email.Name = "Email";
            this.Email.Size = new Size(51, 21);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email:";

            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Contraseña.Location = new Point(50, 230);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new Size(92, 21);
            this.Contraseña.TabIndex = 4;
            this.Contraseña.Text = "Contraseña:";

            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Rol.Location = new Point(50, 280);
            this.Rol.Name = "Rol";
            this.Rol.Size = new Size(36, 21);
            this.Rol.TabIndex = 5;
            this.Rol.Text = "Rol:";

            // 
            // textNombre
            // 
            this.textNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textNombre.Location = new Point(200, 80);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new Size(250, 29);
            this.textNombre.TabIndex = 6;

            // 
            // textDocumento
            // 
            this.textDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textDocumento.Location = new Point(200, 130);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.Size = new Size(250, 29);
            this.textDocumento.TabIndex = 7;

            // 
            // textEmail
            // 
            this.textEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textEmail.Location = new Point(200, 180);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new Size(250, 29);
            this.textEmail.TabIndex = 8;

            // 
            // textPassword
            // 
            this.textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.textPassword.Location = new Point(200, 230);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new Size(250, 29);
            this.textPassword.TabIndex = 9;
            this.textPassword.UseSystemPasswordChar = true;

            // 
            // cmbRol
            // 
            this.cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] { "Director", "Vendedor" });
            this.cmbRol.Location = new Point(200, 280);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new Size(250, 29);
            this.cmbRol.TabIndex = 10;

            // 
            // aceptarCrearUsuario
            // 
            this.aceptarCrearUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.aceptarCrearUsuario.Location = new Point(200, 340);
            this.aceptarCrearUsuario.Name = "aceptarCrearUsuario";
            this.aceptarCrearUsuario.Size = new Size(100, 35);
            this.aceptarCrearUsuario.TabIndex = 11;
            this.aceptarCrearUsuario.Text = "Aceptar";
            this.aceptarCrearUsuario.UseVisualStyleBackColor = true;
            this.aceptarCrearUsuario.Click += new System.EventHandler(this.aceptar_Click);

            // 
            // cancelarCrearUsuario
            // 
            this.cancelarCrearUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cancelarCrearUsuario.Location = new Point(350, 340);
            this.cancelarCrearUsuario.Name = "cancelarCrearUsuario";
            this.cancelarCrearUsuario.Size = new Size(100, 35);
            this.cancelarCrearUsuario.TabIndex = 12;
            this.cancelarCrearUsuario.Text = "Cancelar";
            this.cancelarCrearUsuario.UseVisualStyleBackColor = true;
            this.cancelarCrearUsuario.Click += new System.EventHandler(this.cancelar_click);

            // 
            // FormCrearUsuario
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 450);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.aceptarCrearUsuario);
            this.Controls.Add(this.cancelarCrearUsuario);
            this.Name = "FormCrearUsuario";
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label Nombre;
        private Label Documento;
        private Label Email;
        private Label Contraseña;
        private Label Rol;
        private TextBox textNombre;
        private TextBox textDocumento;
        private TextBox textEmail;
        private TextBox textPassword;
        private ComboBox cmbRol;
        private Button aceptarCrearUsuario;
        private Button cancelarCrearUsuario;
    }
}
