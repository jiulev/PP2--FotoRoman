namespace FotoRoman
{
    partial class FormEditarCliente
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si se deben eliminar los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxNombre = new TextBox();
            textBoxCorreo = new TextBox();
            comboBoxEstado = new ComboBox();
            textBoxDocumento = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            comboBoxLocalidad = new ComboBox();
            comboBoxprovincia = new ComboBox();
            textBoxTelefono = new TextBox();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(50, 30);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Apellido y Nombre";
            textBoxNombre.Size = new Size(300, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(50, 70);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Correo";
            textBoxCorreo.Size = new Size(300, 23);
            textBoxCorreo.TabIndex = 1;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBoxEstado.Location = new Point(50, 151);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(300, 23);
            comboBoxEstado.TabIndex = 2;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(50, 273);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.ReadOnly = true;
            textBoxDocumento.Size = new Size(300, 23);
            textBoxDocumento.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(50, 311);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 40);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(219, 311);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(120, 40);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.ForeColor = SystemColors.ControlDark;
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(50, 232);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(300, 23);
            comboBoxLocalidad.TabIndex = 8;
            comboBoxLocalidad.Text = "Localidad";
            // 
            // comboBoxprovincia
            // 
            comboBoxprovincia.ForeColor = SystemColors.ControlDark;
            comboBoxprovincia.FormattingEnabled = true;
            comboBoxprovincia.Location = new Point(50, 192);
            comboBoxprovincia.Name = "comboBoxprovincia";
            comboBoxprovincia.Size = new Size(300, 23);
            comboBoxprovincia.TabIndex = 9;
            comboBoxprovincia.Text = "Provincia";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(50, 110);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(300, 23);
            textBoxTelefono.TabIndex = 10;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 380);
            Controls.Add(textBoxTelefono);
            Controls.Add(comboBoxprovincia);
            Controls.Add(comboBoxLocalidad);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCorreo);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxDocumento);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonCancelar);
            Name = "FormEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private ComboBox comboBoxLocalidad;
        private ComboBox comboBoxprovincia;
        private TextBox textBoxTelefono;
    }
}
