namespace FotoRoman
{
    partial class FmCliente
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
            groupBoxCliente = new GroupBox();
            comboBoxLocalidad = new ComboBox();
            comboBoxProvincia = new ComboBox();
            labelNombre = new Label();
            textNombre = new TextBox();
            labelDocumento = new Label();
            textDocumento = new TextBox();
            labelCorreo = new Label();
            textCorreo = new TextBox();
            labelLocalidad = new Label();
            labelProvincia = new Label();
            RegistrarCliente = new Button();
            CancelarCliente = new Button();
            groupBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(comboBoxLocalidad);
            groupBoxCliente.Controls.Add(comboBoxProvincia);
            groupBoxCliente.Controls.Add(labelNombre);
            groupBoxCliente.Controls.Add(textNombre);
            groupBoxCliente.Controls.Add(labelDocumento);
            groupBoxCliente.Controls.Add(textDocumento);
            groupBoxCliente.Controls.Add(labelCorreo);
            groupBoxCliente.Controls.Add(textCorreo);
            groupBoxCliente.Controls.Add(labelLocalidad);
            groupBoxCliente.Controls.Add(labelProvincia);
            groupBoxCliente.Controls.Add(RegistrarCliente);
            groupBoxCliente.Controls.Add(CancelarCliente);
            groupBoxCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCliente.Location = new Point(30, 30);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(500, 320);
            groupBoxCliente.TabIndex = 0;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Datos del Cliente";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(180, 209);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(280, 29);
            comboBoxLocalidad.TabIndex = 13;
            comboBoxLocalidad.SelectedIndexChanged += comboBoxLocalidad_SelectedIndexChanged;
            // 
            // comboBoxProvincia
            // 
            comboBoxProvincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProvincia.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProvincia.DisplayMember = "Nombre";
            comboBoxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvincia.FormattingEnabled = true;
            comboBoxProvincia.Location = new Point(180, 160);
            comboBoxProvincia.Name = "comboBoxProvincia";
            comboBoxProvincia.Size = new Size(280, 29);
            comboBoxProvincia.TabIndex = 12;
            comboBoxProvincia.ValueMember = "IDProvincia";
            comboBoxProvincia.SelectedIndexChanged += comboBoxProvincia_SelectedIndexChanged;
            // 
            // labelNombre
            // 
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.Location = new Point(20, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(150, 25);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Apellido y Nombre:";
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 10F);
            textNombre.Location = new Point(180, 40);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(280, 25);
            textNombre.TabIndex = 1;
            // 
            // labelDocumento
            // 
            labelDocumento.Font = new Font("Segoe UI", 10F);
            labelDocumento.Location = new Point(20, 80);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(150, 25);
            labelDocumento.TabIndex = 2;
            labelDocumento.Text = "Documento:";
            // 
            // textDocumento
            // 
            textDocumento.Font = new Font("Segoe UI", 10F);
            textDocumento.Location = new Point(180, 80);
            textDocumento.Name = "textDocumento";
            textDocumento.Size = new Size(280, 25);
            textDocumento.TabIndex = 3;
            // 
            // labelCorreo
            // 
            labelCorreo.Font = new Font("Segoe UI", 10F);
            labelCorreo.Location = new Point(20, 120);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(150, 25);
            labelCorreo.TabIndex = 4;
            labelCorreo.Text = "Correo Electrónico:";
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Segoe UI", 10F);
            textCorreo.Location = new Point(180, 120);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(280, 25);
            textCorreo.TabIndex = 5;
            // 
            // labelLocalidad
            // 
            labelLocalidad.Font = new Font("Segoe UI", 10F);
            labelLocalidad.Location = new Point(20, 215);
            labelLocalidad.Name = "labelLocalidad";
            labelLocalidad.Size = new Size(150, 25);
            labelLocalidad.TabIndex = 6;
            labelLocalidad.Text = "Localidad:";
            // 
            // labelProvincia
            // 
            labelProvincia.Font = new Font("Segoe UI", 10F);
            labelProvincia.Location = new Point(20, 175);
            labelProvincia.Name = "labelProvincia";
            labelProvincia.Size = new Size(150, 25);
            labelProvincia.TabIndex = 8;
            labelProvincia.Text = "Provincia:";
            // 
            // RegistrarCliente
            // 
            RegistrarCliente.BackColor = Color.LightGray;
            RegistrarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RegistrarCliente.Location = new Point(180, 250);
            RegistrarCliente.Name = "RegistrarCliente";
            RegistrarCliente.Size = new Size(120, 40);
            RegistrarCliente.TabIndex = 10;
            RegistrarCliente.Text = "Registrar";
            RegistrarCliente.UseVisualStyleBackColor = false;
            RegistrarCliente.Click += button1_Click;
            // 
            // CancelarCliente
            // 
            CancelarCliente.BackColor = Color.LightGray;
            CancelarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CancelarCliente.Location = new Point(340, 250);
            CancelarCliente.Name = "CancelarCliente";
            CancelarCliente.Size = new Size(120, 40);
            CancelarCliente.TabIndex = 11;
            CancelarCliente.Text = "Cancelar";
            CancelarCliente.UseVisualStyleBackColor = false;
            CancelarCliente.Click += CancelarCliente_Click;
            // 
            // FmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 400);
            Controls.Add(groupBoxCliente);
            Name = "FmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += FmCliente_Load;
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textNombre;
        private TextBox textDocumento;
        private TextBox textCorreo;
        private Button RegistrarCliente;
        private Button CancelarCliente;
        private GroupBox groupBoxCliente;
        private Label labelNombre;
        private Label labelDocumento;
        private Label labelCorreo;
        private Label labelLocalidad;
        private Label labelProvincia;
        private ComboBox comboBoxLocalidad;
        private ComboBox comboBoxProvincia;
    }
}
