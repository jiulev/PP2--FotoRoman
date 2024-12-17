namespace FotoRoman
{
    partial class FormReporteProducto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbMeses; // ComboBox para seleccionar el mes
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblSeleccionarMes; // Etiqueta para el ComboBox

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
            btnCerrar = new Button();
            cmbMeses = new ComboBox();
            lblSeleccionarMes = new Label();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom;
            btnCerrar.Location = new Point(395, 441);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(88, 28);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbMeses
            // 
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Location = new Point(113, 19);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(132, 23);
            cmbMeses.TabIndex = 0;
            cmbMeses.SelectedIndexChanged += comboBoxMes_SelectedIndexChanged;
            // 
            // lblSeleccionarMes
            // 
            lblSeleccionarMes.Location = new Point(12, 19);
            lblSeleccionarMes.Name = "lblSeleccionarMes";
            lblSeleccionarMes.Size = new Size(105, 19);
            lblSeleccionarMes.TabIndex = 1;
            lblSeleccionarMes.Text = "Seleccionar Mes:";
            // 
            // FormReporteProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 479);
            Controls.Add(cmbMeses);
            Controls.Add(lblSeleccionarMes);
            Controls.Add(btnCerrar);
            Name = "FormReporteProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Productos Más Vendidos";
            Load += FormReporteProducto_Load;
            Paint += FormReporteProducto_Paint;
            ResumeLayout(false);
        }
    }
}
