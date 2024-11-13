namespace FotoRoman
{
    partial class FmCliente
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
            textNombre = new TextBox();
            textDocumento = new TextBox();
            textCorreo = new TextBox();
            textLocalidad = new TextBox();
            RegistrarCliente = new Button();
            CancelarCliente = new Button();
            textProvincia = new TextBox();
            Nombre = new Label();
            Documento = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.Location = new Point(290, 25);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(185, 33);
            textNombre.TabIndex = 0;
            // 
            // textDocumento
            // 
            textDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDocumento.Location = new Point(290, 74);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(185, 33);
            textDocumento.TabIndex = 1;
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCorreo.Location = new Point(290, 127);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(185, 33);
            textCorreo.TabIndex = 2;
            // 
            // textLocalidad
            // 
            textLocalidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLocalidad.Location = new Point(290, 190);
            textLocalidad.Name = "textLocalidad";
            textLocalidad.Size = new Size(185, 33);
            textLocalidad.TabIndex = 5;
            textLocalidad.TextChanged += textLocalidad_TextChanged;
            // 
            // RegistrarCliente
            // 
            RegistrarCliente.Location = new Point(638, 318);
            RegistrarCliente.Name = "RegistrarCliente";
            RegistrarCliente.Size = new Size(112, 41);
            RegistrarCliente.TabIndex = 6;
            RegistrarCliente.Text = "Registrar";
            RegistrarCliente.UseVisualStyleBackColor = true;
            RegistrarCliente.Click += button1_Click;
            // 
            // CancelarCliente
            // 
            CancelarCliente.Location = new Point(480, 318);
            CancelarCliente.Name = "CancelarCliente";
            CancelarCliente.Size = new Size(112, 41);
            CancelarCliente.TabIndex = 7;
            CancelarCliente.Text = "Cancelar";
            CancelarCliente.UseVisualStyleBackColor = true;
            // 
            // textProvincia
            // 
            textProvincia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textProvincia.Location = new Point(290, 254);
            textProvincia.Name = "textProvincia";
            textProvincia.Size = new Size(185, 33);
            textProvincia.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BorderStyle = BorderStyle.Fixed3D;
            Nombre.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(179, 25);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(105, 34);
            Nombre.TabIndex = 9;
            Nombre.Text = "Nombre";
            // 
            // Documento
            // 
            Documento.AutoSize = true;
            Documento.BackColor = Color.Transparent;
            Documento.BorderStyle = BorderStyle.Fixed3D;
            Documento.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Documento.Location = new Point(141, 74);
            Documento.Name = "Documento";
            Documento.Size = new Size(143, 34);
            Documento.TabIndex = 10;
            Documento.Text = "Documento";
            Documento.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 127);
            label1.Name = "label1";
            label1.Size = new Size(74, 34);
            label1.TabIndex = 11;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 189);
            label3.Name = "label3";
            label3.Size = new Size(119, 34);
            label3.TabIndex = 13;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 254);
            label4.Name = "label4";
            label4.Size = new Size(115, 34);
            label4.TabIndex = 14;
            label4.Text = "provincia";
            // 
            // FmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Documento);
            Controls.Add(Nombre);
            Controls.Add(textProvincia);
            Controls.Add(CancelarCliente);
            Controls.Add(RegistrarCliente);
            Controls.Add(textLocalidad);
            Controls.Add(textCorreo);
            Controls.Add(textDocumento);
            Controls.Add(textNombre);
            Name = "FmCliente";
            Text = "FmCliente";
            Load += FmCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textDocumento;
        private TextBox textCorreo;
        private TextBox textLocalidad;
        private Button RegistrarCliente;
        private Button CancelarCliente;
        private TextBox textProvincia;
        private Label Nombre;
        private Label Documento;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}