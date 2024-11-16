namespace FotoRoman
{
    partial class FormCrearPedido
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            numero = new Label();
            num = new Label();
            cliente = new Label();
            label3 = new Label();
            categoria = new Label();
            producto = new Label();
            comboCliente = new ComboBox();
            comboCategoria = new ComboBox();
            comboProducto = new ComboBox();
            label2 = new Label();
            textDni = new TextBox();
            textLocalidad = new TextBox();
            dni4 = new Label();
            localidad5 = new Label();
            textCantidad1 = new TextBox();
            textPrecio1 = new TextBox();
            precio4 = new Label();
            buttonAgregar = new Button();
            dataGridView1 = new DataGridView();
            productos1 = new DataGridViewTextBoxColumn();
            Precio1 = new DataGridViewTextBoxColumn();
            Subtotal1 = new DataGridViewTextBoxColumn();
            total = new Label();
            eliminar1 = new Button();
            crear1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(914, 25);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Numero Pedido";
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numero.Location = new Point(638, 35);
            numero.Name = "numero";
            numero.Size = new Size(0, 21);
            numero.TabIndex = 1;
            // 
            // num
            // 
            num.AutoSize = true;
            num.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num.Location = new Point(1058, 25);
            num.Name = "num";
            num.Size = new Size(22, 21);
            num.TabIndex = 2;
            num.Text = "--";
            // 
            // cliente
            // 
            cliente.AutoSize = true;
            cliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cliente.Location = new Point(29, 35);
            cliente.Name = "cliente";
            cliente.Size = new Size(77, 30);
            cliente.TabIndex = 3;
            cliente.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 111);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // categoria
            // 
            categoria.AutoSize = true;
            categoria.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoria.Location = new Point(4, 114);
            categoria.Name = "categoria";
            categoria.Size = new Size(102, 30);
            categoria.TabIndex = 5;
            categoria.Text = "Categoria";
            // 
            // producto
            // 
            producto.AutoSize = true;
            producto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            producto.Location = new Point(9, 189);
            producto.Name = "producto";
            producto.Size = new Size(97, 30);
            producto.TabIndex = 6;
            producto.Text = "Producto";
            // 
            // comboCliente
            // 
            comboCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(112, 32);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(312, 33);
            comboCliente.TabIndex = 7;
            comboCliente.SelectedIndexChanged += comboCliente_SelectedIndexChanged;
            // 
            // comboCategoria
            // 
            comboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(112, 111);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(312, 33);
            comboCategoria.TabIndex = 8;
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            // 
            // comboProducto
            // 
            comboProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProducto.FormattingEnabled = true;
            comboProducto.Location = new Point(112, 186);
            comboProducto.Name = "comboProducto";
            comboProducto.Size = new Size(312, 33);
            comboProducto.TabIndex = 9;
            comboProducto.SelectedIndexChanged += comboProducto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(715, 192);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 10;
            label2.Text = "Cantidad";
            // 
            // textDni
            // 
            textDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDni.Location = new Point(480, 32);
            textDni.Name = "textDni";
            textDni.Size = new Size(168, 33);
            textDni.TabIndex = 12;
            // 
            // textLocalidad
            // 
            textLocalidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLocalidad.Location = new Point(682, 32);
            textLocalidad.Name = "textLocalidad";
            textLocalidad.Size = new Size(168, 33);
            textLocalidad.TabIndex = 13;
            // 
            // dni4
            // 
            dni4.AutoSize = true;
            dni4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dni4.Location = new Point(480, 8);
            dni4.Name = "dni4";
            dni4.Size = new Size(37, 21);
            dni4.TabIndex = 14;
            dni4.Text = "DNI";
            // 
            // localidad5
            // 
            localidad5.AutoSize = true;
            localidad5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localidad5.Location = new Point(682, 8);
            localidad5.Name = "localidad5";
            localidad5.Size = new Size(76, 21);
            localidad5.TabIndex = 15;
            localidad5.Text = "Localidad";
            // 
            // textCantidad1
            // 
            textCantidad1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCantidad1.Location = new Point(817, 190);
            textCantidad1.Name = "textCantidad1";
            textCantidad1.Size = new Size(168, 33);
            textCantidad1.TabIndex = 16;
            // 
            // textPrecio1
            // 
            textPrecio1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPrecio1.Location = new Point(523, 189);
            textPrecio1.Name = "textPrecio1";
            textPrecio1.Size = new Size(168, 33);
            textPrecio1.TabIndex = 17;
            // 
            // precio4
            // 
            precio4.AutoSize = true;
            precio4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precio4.Location = new Point(447, 189);
            precio4.Name = "precio4";
            precio4.Size = new Size(70, 30);
            precio4.TabIndex = 18;
            precio4.Text = "Precio";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregar.Location = new Point(1005, 185);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(101, 44);
            buttonAgregar.TabIndex = 19;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productos1, Precio1, Subtotal1 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(638, 126);
            dataGridView1.TabIndex = 20;
            // 
            // productos1
            // 
            productos1.HeaderText = "Producto";
            productos1.Name = "productos1";
            // 
            // Precio1
            // 
            Precio1.HeaderText = "Precio";
            Precio1.Name = "Precio1";
            // 
            // Subtotal1
            // 
            Subtotal1.HeaderText = "Subtotal";
            Subtotal1.Name = "Subtotal1";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(950, 400);
            total.Name = "total";
            total.Size = new Size(83, 37);
            total.TabIndex = 21;
            total.Text = "$0.00";
            // 
            // eliminar1
            // 
            eliminar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eliminar1.Location = new Point(779, 322);
            eliminar1.Name = "eliminar1";
            eliminar1.Size = new Size(135, 32);
            eliminar1.TabIndex = 22;
            eliminar1.Text = "Eliminar Item";
            eliminar1.UseVisualStyleBackColor = true;
            eliminar1.Click += eliminar1_Click;
            // 
            // crear1
            // 
            crear1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crear1.Location = new Point(682, 448);
            crear1.Name = "crear1";
            crear1.Size = new Size(240, 80);
            crear1.TabIndex = 23;
            crear1.Text = "Crear Pedido";
            crear1.UseVisualStyleBackColor = true;
            crear1.Click += crear1_Click;
            // 
            // FormCrearPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 540);
            Controls.Add(crear1);
            Controls.Add(eliminar1);
            Controls.Add(total);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAgregar);
            Controls.Add(precio4);
            Controls.Add(textPrecio1);
            Controls.Add(textCantidad1);
            Controls.Add(localidad5);
            Controls.Add(dni4);
            Controls.Add(textLocalidad);
            Controls.Add(textDni);
            Controls.Add(label2);
            Controls.Add(comboProducto);
            Controls.Add(comboCategoria);
            Controls.Add(comboCliente);
            Controls.Add(producto);
            Controls.Add(categoria);
            Controls.Add(label3);
            Controls.Add(cliente);
            Controls.Add(num);
            Controls.Add(numero);
            Controls.Add(label1);
            Name = "FormCrearPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear pedido";
            Load += FormCrearPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label numero;
        private Label num;
        private Label cliente;
        private Label label3;
        private Label categoria;
        private Label producto;
        private ComboBox comboCliente;
        private ComboBox comboCategoria;
        private ComboBox comboProducto;
        private Label label2;
        private TextBox textDni;
        private TextBox textLocalidad;
        private Label dni4;
        private Label localidad5;
        private TextBox textCantidad1;
        private TextBox textPrecio1;
        private Label precio4;
        private Button buttonAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productos1;
        private DataGridViewTextBoxColumn Precio1;
        private DataGridViewTextBoxColumn Subtotal1;
        private Label total;
        private Button eliminar1;
        private Button crear1;
    }
}