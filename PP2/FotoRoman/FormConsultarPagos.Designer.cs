using Org.BouncyCastle.Asn1.Crmf;

namespace FotoRoman
{
    partial class FormConsultarPagos
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de componentes
        private System.Windows.Forms.Label labelIdPedido;
        private System.Windows.Forms.TextBox textBoxIdPedido;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.GroupBox groupBoxPagos;
        private System.Windows.Forms.DataGridView dataGridViewPagos;

        // Método para inicializar los componentes
        private void InitializeComponent()
        {
            labelIdPedido = new Label();
            textBoxIdPedido = new TextBox();
            labelCliente = new Label();
            comboBoxClientes = new ComboBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            buttonCerrar = new Button();
            groupBoxPagos = new GroupBox();
            dataGridViewPagos = new DataGridView();
            button1 = new Button();
            groupBoxPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            SuspendLayout();
            // 
            // labelIdPedido
            // 
            labelIdPedido.Location = new Point(20, 20);
            labelIdPedido.Name = "labelIdPedido";
            labelIdPedido.Size = new Size(150, 23);
            labelIdPedido.TabIndex = 0;
            labelIdPedido.Text = "Buscar por ID de Pedido:";
            // 
            // textBoxIdPedido
            // 
            textBoxIdPedido.Location = new Point(180, 20);
            textBoxIdPedido.Name = "textBoxIdPedido";
            textBoxIdPedido.Size = new Size(200, 23);
            textBoxIdPedido.TabIndex = 1;
            // 
            // labelCliente
            // 
            labelCliente.Location = new Point(20, 60);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(150, 23);
            labelCliente.TabIndex = 2;
            labelCliente.Text = "Buscar por Cliente:";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClientes.Location = new Point(180, 60);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(200, 23);
            comboBoxClientes.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Segoe UI", 12F);
            buttonBuscar.Location = new Point(400, 15);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(83, 34);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.Click += ButtonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 12F);
            buttonLimpiar.Location = new Point(400, 55);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(83, 34);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Segoe UI", 12F);
            buttonCerrar.Location = new Point(400, 95);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(83, 34);
            buttonCerrar.TabIndex = 6;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.Click += ButtonCerrar_Click;
            // 
            // groupBoxPagos
            // 
            groupBoxPagos.Controls.Add(dataGridViewPagos);
            groupBoxPagos.Location = new Point(20, 150);
            groupBoxPagos.Name = "groupBoxPagos";
            groupBoxPagos.Size = new Size(600, 300);
            groupBoxPagos.TabIndex = 7;
            groupBoxPagos.TabStop = false;
            groupBoxPagos.Text = "Pagos Realizados";
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPagos.BackgroundColor = SystemColors.Control;
            dataGridViewPagos.BorderStyle = BorderStyle.None;
            dataGridViewPagos.Location = new Point(10, 20);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.Size = new Size(580, 260);
            dataGridViewPagos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(493, 456);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 8;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormConsultarPagos
            // 
            ClientSize = new Size(650, 500);
            Controls.Add(button1);
            Controls.Add(labelIdPedido);
            Controls.Add(textBoxIdPedido);
            Controls.Add(labelCliente);
            Controls.Add(comboBoxClientes);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonCerrar);
            Controls.Add(groupBoxPagos);
            Name = "FormConsultarPagos";
            Text = "Ver Pagos";
            Load += FormVerPagos_Load;
            groupBoxPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}
