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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            Documento = new Label();
            Email = new Label();
            Contraseña = new Label();
            textNombre = new TextBox();
            textDocumento = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            Rol = new Label();
            cmbRol = new ComboBox();
            label1 = new Label();
            aceptarCrearUsuario = new Button();
            cancelarCrearUsuario = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ControlLight;
            Nombre.BorderStyle = BorderStyle.FixedSingle;
            Nombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.ForeColor = Color.Maroon;
            Nombre.Location = new Point(113, 49);
            Nombre.Margin = new Padding(10);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(215, 34);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre y apellido";
            Nombre.Click += Label1_Click;
            // 
            // Documento
            // 
            Documento.AutoSize = true;
            Documento.BackColor = SystemColors.ControlLight;
            Documento.BorderStyle = BorderStyle.FixedSingle;
            Documento.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Documento.ForeColor = Color.Maroon;
            Documento.Location = new Point(186, 110);
            Documento.Margin = new Padding(10);
            Documento.Name = "Documento";
            Documento.Size = new Size(142, 34);
            Documento.TabIndex = 1;
            Documento.Text = "Documento";
            Documento.Click += Label2_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ControlLight;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.Maroon;
            Email.Location = new Point(255, 174);
            Email.Margin = new Padding(10);
            Email.Name = "Email";
            Email.Size = new Size(73, 34);
            Email.TabIndex = 2;
            Email.Text = "Email";
            Email.Click += Label3_Click;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.BackColor = SystemColors.ControlLight;
            Contraseña.BorderStyle = BorderStyle.FixedSingle;
            Contraseña.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contraseña.ForeColor = Color.Maroon;
            Contraseña.Location = new Point(192, 240);
            Contraseña.Margin = new Padding(10);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(136, 34);
            Contraseña.TabIndex = 3;
            Contraseña.Text = "Contraseña";
            Contraseña.Click += Label4_Click;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.Location = new Point(348, 54);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(134, 29);
            textNombre.TabIndex = 4;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textDocumento
            // 
            textDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDocumento.Location = new Point(348, 110);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(134, 29);
            textDocumento.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(348, 174);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(134, 29);
            textEmail.TabIndex = 6;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(348, 240);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(134, 29);
            textPassword.TabIndex = 7;
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.BackColor = SystemColors.ControlLight;
            Rol.BorderStyle = BorderStyle.FixedSingle;
            Rol.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rol.ForeColor = Color.Maroon;
            Rol.Location = new Point(269, 299);
            Rol.Margin = new Padding(10);
            Rol.Name = "Rol";
            Rol.Size = new Size(59, 34);
            Rol.TabIndex = 8;
            Rol.Text = "ROL";
            Rol.Click += Rol_Click;
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Vendedor", "Director" });
            cmbRol.Location = new Point(348, 299);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(134, 29);
            cmbRol.TabIndex = 9;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(651, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 10;
            label1.Text = "Registrar usuario";
            label1.Click += Label1_Click;
            // 
            // aceptarCrearUsuario
            // 
            aceptarCrearUsuario.Location = new Point(437, 362);
            aceptarCrearUsuario.Name = "aceptarCrearUsuario";
            aceptarCrearUsuario.Size = new Size(110, 37);
            aceptarCrearUsuario.TabIndex = 11;
            aceptarCrearUsuario.Text = "Aceptar";
            aceptarCrearUsuario.UseVisualStyleBackColor = true;
            aceptarCrearUsuario.Click += aceptar_Click;
            // 
            // cancelarCrearUsuario
            // 
            cancelarCrearUsuario.Location = new Point(610, 362);
            cancelarCrearUsuario.Name = "cancelarCrearUsuario";
            cancelarCrearUsuario.Size = new Size(110, 37);
            cancelarCrearUsuario.TabIndex = 12;
            cancelarCrearUsuario.Text = "Cancelar";
            cancelarCrearUsuario.UseVisualStyleBackColor = true;
            cancelarCrearUsuario.Click += cancelar_click;
            // 
            // FormCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarCrearUsuario);
            Controls.Add(aceptarCrearUsuario);
            Controls.Add(label1);
            Controls.Add(cmbRol);
            Controls.Add(Rol);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(textDocumento);
            Controls.Add(textNombre);
            Controls.Add(Contraseña);
            Controls.Add(Email);
            Controls.Add(Documento);
            Controls.Add(Nombre);
            Name = "FormCrearUsuario";
            Text = "FormCrearUsuario";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label Documento;
        private Label Email;
        private Label Contraseña;
        private TextBox textNombre;
        private TextBox textDocumento;
        private TextBox textEmail;
        private TextBox textPassword;
        private Label Rol;
        private ComboBox cmbRol;
        private Label label1;
        private Button aceptarCrearUsuario;
        private Button cancelarCrearUsuario;
    }
}