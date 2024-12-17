namespace FotoRoman
{
    partial class FormRegistrarLocalidad
    {
        private System.ComponentModel.IContainer components = null;

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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(50, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(190, 21);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Registrar Nueva Localidad";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocalidad.Location = new System.Drawing.Point(50, 100);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(300, 25);
            this.textBoxLocalidad.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(150, 150);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProvincia.Location = new System.Drawing.Point(50, 50);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(66, 19);
            this.labelProvincia.TabIndex = 3;
            this.labelProvincia.Text = "Provincia:";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(50, 70);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(300, 25);
            this.comboBoxProvincia.TabIndex = 4;
            // 
            // FormRegistrarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Localidad";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.FormRegistrarLocalidad_Load);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
    }
}
