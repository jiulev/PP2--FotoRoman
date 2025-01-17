﻿namespace FotoRoman
{
    partial class FormCrearProducto
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
            txtNombreProducto = new TextBox();
            comboBoxCategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecioProducto = new TextBox();
            btnRegistrarProducto = new Button();
            btnCancelarProducto = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Arial", 12F);
            txtNombreProducto.Location = new Point(304, 172);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(291, 26);
            txtNombreProducto.TabIndex = 1;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.Font = new Font("Arial", 12F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(304, 118);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(291, 26);
            comboBoxCategoria.TabIndex = 2;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.Location = new Point(107, 176);
            label1.Name = "label1";
            label1.Size = new Size(191, 22);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 140);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F);
            label3.Location = new Point(304, 226);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F);
            label4.Location = new Point(128, 118);
            label4.Name = "label4";
            label4.Size = new Size(170, 22);
            label4.TabIndex = 6;
            label4.Text = "Elija Una Categoria";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Font = new Font("Arial", 12F);
            txtPrecioProducto.Location = new Point(401, 222);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(194, 26);
            txtPrecioProducto.TabIndex = 7;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.Font = new Font("Arial", 14.25F);
            btnRegistrarProducto.Location = new Point(390, 297);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(108, 43);
            btnRegistrarProducto.TabIndex = 8;
            btnRegistrarProducto.Text = "Registrar";
            btnRegistrarProducto.UseVisualStyleBackColor = true;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Font = new Font("Arial", 14.25F);
            btnCancelarProducto.Location = new Point(524, 297);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(109, 43);
            btnCancelarProducto.TabIndex = 9;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 22;
            iconPictureBox1.Location = new Point(618, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 22);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(658, 16);
            label5.Name = "label5";
            label5.Size = new Size(139, 18);
            label5.TabIndex = 11;
            label5.Text = "Registrar Producto";
            label5.Click += label5_Click;
            // 
            // FormCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(iconPictureBox1);
            Controls.Add(btnCancelarProducto);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCategoria);
            Controls.Add(txtNombreProducto);
            Name = "FormCrearProducto";
            Text = "Registrar un Nuevo producto";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private ComboBox comboBoxCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrecioProducto;
        private Button btnRegistrarProducto;
        private Button btnCancelarProducto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
    }
}