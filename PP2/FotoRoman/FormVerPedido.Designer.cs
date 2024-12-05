namespace FotoRoman
{
    partial class FormVerPedido
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
        private System.Windows.Forms.GroupBox groupBoxDetallePedido;
        private System.Windows.Forms.DataGridView dataGridViewDetallePedido;
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
            groupBoxDetallePedido = new GroupBox();
            dataGridViewDetallePedido = new DataGridView();
            groupBoxPagos = new GroupBox();
            dataGridViewPagos = new DataGridView();
            textBoxCorreo = new TextBox();
            textBoxLocalidad = new TextBox();
            textBoxProvincia = new TextBox();
            groupBoxCliente.SuspendLayout();
            groupBoxDetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedido).BeginInit();
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
            buttonBuscar.Location = new Point(400, 9);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(83, 34);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 12F);
            buttonLimpiar.Location = new Point(400, 51);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(83, 34);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Font = new Font("Segoe UI", 12F);
            buttonImprimir.Location = new Point(634, 624);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(83, 34);
            buttonImprimir.TabIndex = 6;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Segoe UI", 12F);
            buttonCerrar.Location = new Point(739, 624);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(83, 34);
            buttonCerrar.TabIndex = 7;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(textBoxProvincia);
            groupBoxCliente.Controls.Add(textBoxLocalidad);
            groupBoxCliente.Controls.Add(textBoxCorreo);
            groupBoxCliente.Controls.Add(textBoxDatosCliente);
            groupBoxCliente.Location = new Point(20, 100);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(830, 150);
            groupBoxCliente.TabIndex = 8;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Datos del Cliente";
            // 
            // textBoxDatosCliente
            // 
            textBoxDatosCliente.Location = new Point(344, 22);
            textBoxDatosCliente.Multiline = true;
            textBoxDatosCliente.Name = "textBoxDatosCliente";
            textBoxDatosCliente.ReadOnly = true;
            textBoxDatosCliente.ScrollBars = ScrollBars.Vertical;
            textBoxDatosCliente.Size = new Size(261, 25);
            textBoxDatosCliente.TabIndex = 0;
            // 
            // groupBoxDetallePedido
            // 
            groupBoxDetallePedido.Controls.Add(dataGridViewDetallePedido);
            groupBoxDetallePedido.Location = new Point(20, 270);
            groupBoxDetallePedido.Name = "groupBoxDetallePedido";
            groupBoxDetallePedido.Size = new Size(830, 150);
            groupBoxDetallePedido.TabIndex = 9;
            groupBoxDetallePedido.TabStop = false;
            groupBoxDetallePedido.Text = "Detalle del Pedido";
            // 
            // dataGridViewDetallePedido
            // 
            dataGridViewDetallePedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDetallePedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetallePedido.Location = new Point(10, 20);
            dataGridViewDetallePedido.Name = "dataGridViewDetallePedido";
            dataGridViewDetallePedido.Size = new Size(800, 120);
            dataGridViewDetallePedido.TabIndex = 0;
            // 
            // groupBoxPagos
            // 
            groupBoxPagos.Controls.Add(dataGridViewPagos);
            groupBoxPagos.Location = new Point(20, 440);
            groupBoxPagos.Name = "groupBoxPagos";
            groupBoxPagos.Size = new Size(830, 165);
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
            dataGridViewPagos.Size = new Size(800, 127);
            dataGridViewPagos.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(344, 53);
            textBoxCorreo.Multiline = true;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.ReadOnly = true;
            textBoxCorreo.ScrollBars = ScrollBars.Vertical;
            textBoxCorreo.Size = new Size(261, 25);
            textBoxCorreo.TabIndex = 1;
            // 
            // textBoxLocalidad
            // 
            textBoxLocalidad.Location = new Point(344, 84);
            textBoxLocalidad.Multiline = true;
            textBoxLocalidad.Name = "textBoxLocalidad";
            textBoxLocalidad.ReadOnly = true;
            textBoxLocalidad.ScrollBars = ScrollBars.Vertical;
            textBoxLocalidad.Size = new Size(261, 25);
            textBoxLocalidad.TabIndex = 2;
            // 
            // textBoxProvincia
            // 
            textBoxProvincia.Location = new Point(344, 119);
            textBoxProvincia.Multiline = true;
            textBoxProvincia.Name = "textBoxProvincia";
            textBoxProvincia.ReadOnly = true;
            textBoxProvincia.ScrollBars = ScrollBars.Vertical;
            textBoxProvincia.Size = new Size(261, 25);
            textBoxProvincia.TabIndex = 3;
            // 
            // FormVerPedido
            // 
            ClientSize = new Size(900, 670);
            Controls.Add(labelIdPedido);
            Controls.Add(textBoxIdPedido);
            Controls.Add(labelCliente);
            Controls.Add(comboBoxClientes);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonImprimir);
            Controls.Add(buttonCerrar);
            Controls.Add(groupBoxCliente);
            Controls.Add(groupBoxDetallePedido);
            Controls.Add(groupBoxPagos);
            Name = "FormVerPedido";
            Text = "Consultar Pedido";
            Load += FormVerPedido_Load;
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            groupBoxDetallePedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedido).EndInit();
            groupBoxPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxLocalidad;
        private TextBox textBoxCorreo;
        private TextBox textBoxProvincia;
    }
}
