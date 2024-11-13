namespace FotoRoman
{
    partial class FormCategoriaa
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
            label1 = new Label();
            label2 = new Label();
            comboBoxCategoria = new ComboBox();
            CrearCategoria = new Button();
            CancelarCategoria = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(591, 38);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 1;
            label1.Text = "Pantalla Crear Categoria";
            label1.TextAlign = ContentAlignment.BottomRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 156);
            label2.Name = "label2";
            label2.Size = new Size(305, 39);
            label2.TabIndex = 2;
            label2.Text = "Nombre de la Categoria";
            label2.Click += label2_Click;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(418, 159);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(246, 33);
            comboBoxCategoria.TabIndex = 3;
            // 
            // CrearCategoria
            // 
            CrearCategoria.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearCategoria.Location = new Point(418, 290);
            CrearCategoria.Name = "CrearCategoria";
            CrearCategoria.Size = new Size(115, 55);
            CrearCategoria.TabIndex = 5;
            CrearCategoria.Text = "Registar";
            CrearCategoria.UseVisualStyleBackColor = true;
            CrearCategoria.Click += CrearCategoria_Click;
            // 
            // CancelarCategoria
            // 
            CancelarCategoria.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarCategoria.Location = new Point(573, 290);
            CancelarCategoria.Name = "CancelarCategoria";
            CancelarCategoria.Size = new Size(115, 55);
            CancelarCategoria.TabIndex = 6;
            CancelarCategoria.Text = "Cancelar";
            CancelarCategoria.UseVisualStyleBackColor = true;
            CancelarCategoria.Click += CancelarCategoria_Click;
            // 
            // FormCategoriaa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarCategoria);
            Controls.Add(CrearCategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCategoriaa";
            Text = "FormCategoriaa";
            Load += FormCategoriaa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Label label2;
        private ComboBox comboBoxCategoria;
        private Button CrearCategoria;
        private Button CancelarCategoria;
    }
}
