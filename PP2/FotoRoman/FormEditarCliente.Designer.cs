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
            textBoxLocalidad = new TextBox();
            textBoxProvincia = new TextBox();
            textBoxDocumento = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
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
            comboBoxEstado.Location = new Point(50, 110);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(300, 23);
            comboBoxEstado.TabIndex = 2;
            // 
            // textBoxLocalidad
            // 
            textBoxLocalidad.Location = new Point(50, 150);
            textBoxLocalidad.Name = "textBoxLocalidad";
            textBoxLocalidad.PlaceholderText = "Localidad";
            textBoxLocalidad.Size = new Size(300, 23);
            textBoxLocalidad.TabIndex = 3;
            // 
            // textBoxProvincia
            // 
            textBoxProvincia.Location = new Point(50, 190);
            textBoxProvincia.Name = "textBoxProvincia";
            textBoxProvincia.PlaceholderText = "Provincia";
            textBoxProvincia.Size = new Size(300, 23);
            textBoxProvincia.TabIndex = 4;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(50, 230);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.ReadOnly = true;
            textBoxDocumento.Size = new Size(300, 23);
            textBoxDocumento.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(50, 280);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(120, 40);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(230, 280);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(120, 40);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxCorreo);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxLocalidad);
            Controls.Add(textBoxProvincia);
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
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}
