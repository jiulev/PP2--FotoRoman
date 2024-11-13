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
            SuspendLayout();

            // textNombre
            textNombre.Font = new Font("Segoe UI", 14.25F);
            textNombre.Location = new Point(333, 75);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(247, 33);
            textNombre.TextChanged += textNombre_TextChanged;

            // textPassword
            textPassword.Font = new Font("Segoe UI", 14.25F);
            textPassword.Location = new Point(333, 248);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(247, 33);
            textPassword.TextChanged += textPassword_TextChanged;

            // textEmail
            textEmail.Font = new Font("Segoe UI", 14.25F);
            textEmail.Location = new Point(333, 186);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(247, 33);
            textEmail.TextChanged += textEmail_TextChanged;

            // textDocumento
            textDocumento.Font = new Font("Segoe UI", 14.25F);
            textDocumento.Location = new Point(333, 129);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(247, 33);
            textDocumento.ReadOnly = true;
            textDocumento.TextChanged += textDocumento_TextChanged;

            // Nombre
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 15.75F);
            Nombre.Location = new Point(129, 78);
            Nombre.Name = "Nombre";
            Nombre.Text = "Nombre y Apellido";

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(266, 132);
            label1.Name = "label1";
            label1.Text = "DNI";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(253, 198);
            label2.Name = "label2";
            label2.Text = "Email";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(198, 251);
            label3.Name = "label3";
            label3.Text = "Contraseña";

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(610, 24);
            label4.Name = "label4";
            label4.Text = "Editar Usuarios";

            // btnGuardar
            btnGuardar.Font = new Font("Segoe UI", 15.75F);
            btnGuardar.Location = new Point(464, 316);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 41);
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += new EventHandler(btnGuardar_Click);

            // btnCancelar
            btnCancelar.Font = new Font("Segoe UI", 15.75F);
            btnCancelar.Location = new Point(610, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 41);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new EventHandler(btnCancelar_Click);

            // FrmEditarUsuario
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Load += new EventHandler(FrmEditarUsuario_Load);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
