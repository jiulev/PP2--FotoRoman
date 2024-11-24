namespace FotoRoman
{
    partial class FormVerPago
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelIdPedido;
        private System.Windows.Forms.TextBox textBoxIdPedido;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.GroupBox groupBoxPagos;
        private System.Windows.Forms.DataGridView dataGridViewPagos;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox textBoxDatosCliente;

        private void InitializeComponent()
        {
            labelIdPedido = new Label();
            textBoxIdPedido = new TextBox();
            labelCliente = new Label();
            comboBoxClientes = new ComboBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            buttonImprimir = new Button();
            buttonCerrar = new Button();
            groupBoxCliente = new GroupBox();
            textBoxDatosCliente = new TextBox();
            groupBoxPagos = new GroupBox();
            dataGridViewPagos = new DataGridView();
            groupBoxCliente.SuspendLayout();
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
            buttonBuscar.Location = new Point(400, 20);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(400, 60);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(116, 657);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(75, 23);
            buttonImprimir.TabIndex = 6;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(275, 657);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(75, 23);
            buttonCerrar.TabIndex = 7;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(textBoxDatosCliente);
            groupBoxCliente.Location = new Point(20, 100);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(594, 150);
            groupBoxCliente.TabIndex = 8;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Datos del Cliente";
            // 
            // textBoxDatosCliente
            // 
            textBoxDatosCliente.Location = new Point(10, 20);
            textBoxDatosCliente.Multiline = true;
            textBoxDatosCliente.Name = "textBoxDatosCliente";
            textBoxDatosCliente.ReadOnly = true;
            textBoxDatosCliente.ScrollBars = ScrollBars.Vertical;
            textBoxDatosCliente.Size = new Size(548, 124);
            textBoxDatosCliente.TabIndex = 0;
            // 
            // groupBoxPagos
            // 
            groupBoxPagos.Controls.Add(dataGridViewPagos);
            groupBoxPagos.Location = new Point(20, 269);
            groupBoxPagos.Name = "groupBoxPagos";
            groupBoxPagos.Size = new Size(594, 336);
            groupBoxPagos.TabIndex = 10;
            groupBoxPagos.TabStop = false;
            groupBoxPagos.Text = "Pagos Realizados";
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPagos.Location = new Point(10, 20);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.Size = new Size(564, 298);
            dataGridViewPagos.TabIndex = 0;
            // 
            // FormVerPago
            // 
            ClientSize = new Size(647, 710);
            Controls.Add(labelIdPedido);
            Controls.Add(textBoxIdPedido);
            Controls.Add(labelCliente);
            Controls.Add(comboBoxClientes);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonImprimir);
            Controls.Add(buttonCerrar);
            Controls.Add(groupBoxCliente);
            Controls.Add(groupBoxPagos);
            Name = "FormVerPago";
            Text = "Consultar Pedido";
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            groupBoxPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
