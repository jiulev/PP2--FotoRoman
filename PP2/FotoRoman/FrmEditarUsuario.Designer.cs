namespace FotoRoman
{
    partial class FrmEditarUsuario
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
        private TextBox textNombre;
        private TextBox textPassword;
        private TextBox textEmail;
        private TextBox textDocumento;
        private Label Nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textNombre = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            textDocumento = new TextBox();
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            cmbRol = new ComboBox();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 14.25F);
            textNombre.Location = new Point(333, 75);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(247, 33);
            textNombre.TabIndex = 10;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 14.25F);
            textPassword.Location = new Point(333, 248);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(247, 33);
            textPassword.TabIndex = 9;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 14.25F);
            textEmail.Location = new Point(333, 186);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(247, 33);
            textEmail.TabIndex = 8;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // textDocumento
            // 
            textDocumento.Font = new Font("Segoe UI", 14.25F);
            textDocumento.Location = new Point(333, 129);
            textDocumento.Name = "textDocumento";
            textDocumento.ReadOnly = true;
            textDocumento.Size = new Size(247, 33);
            textDocumento.TabIndex = 7;
            textDocumento.TextChanged += textDocumento_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 15.75F);
            Nombre.Location = new Point(129, 78);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(187, 30);
            Nombre.TabIndex = 6;
            Nombre.Text = "Nombre y Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(266, 132);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 5;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(253, 198);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(198, 251);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(610, 24);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 2;
            label4.Text = "Editar Usuarios";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 15.75F);
            btnGuardar.Location = new Point(470, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 41);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
        
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F);
            btnCancelar.Location = new Point(610, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(266, 319);
            label5.Name = "label5";
            label5.Size = new Size(42, 30);
            label5.TabIndex = 11;
            label5.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Director", "Vendedor" });
            cmbRol.Location = new Point(333, 316);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(247, 33);
            cmbRol.TabIndex = 13;
            cmbRol.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRol);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Controls.Add(textDocumento);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textNombre);
            Name = "FrmEditarUsuario";
            Text = "Editar Usuario";
            Load += FrmEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label5;
        private ComboBox cmbRol;
    }
}
