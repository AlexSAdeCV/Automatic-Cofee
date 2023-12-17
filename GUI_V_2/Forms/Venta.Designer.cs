namespace GUI_V_2.Forms
{
    partial class Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.NudPro = new System.Windows.Forms.NumericUpDown();
            this.TxtProductos = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificarCan = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.CmbCLientes = new System.Windows.Forms.ComboBox();
            this.CmbMetodoP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPro)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducto
            // 
            this.DgvProducto.AllowUserToAddRows = false;
            this.DgvProducto.AllowUserToDeleteRows = false;
            this.DgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.EnableHeadersVisualStyles = false;
            this.DgvProducto.Location = new System.Drawing.Point(11, 75);
            this.DgvProducto.Margin = new System.Windows.Forms.Padding(2);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProducto.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProducto.RowTemplate.Height = 28;
            this.DgvProducto.Size = new System.Drawing.Size(555, 407);
            this.DgvProducto.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(889, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 42);
            this.label1.TabIndex = 115;
            this.label1.Text = "$";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.ForeColor = System.Drawing.SystemColors.Window;
            this.Lbl_Total.Location = new System.Drawing.Point(934, 379);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(39, 42);
            this.Lbl_Total.TabIndex = 114;
            this.Lbl_Total.Text = "0";
            // 
            // NudPro
            // 
            this.NudPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NudPro.ForeColor = System.Drawing.Color.White;
            this.NudPro.Location = new System.Drawing.Point(602, 242);
            this.NudPro.Name = "NudPro";
            this.NudPro.Size = new System.Drawing.Size(109, 20);
            this.NudPro.TabIndex = 113;
            // 
            // TxtProductos
            // 
            this.TxtProductos.Location = new System.Drawing.Point(278, 34);
            this.TxtProductos.Name = "TxtProductos";
            this.TxtProductos.Size = new System.Drawing.Size(184, 20);
            this.TxtProductos.TabIndex = 118;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(478, 23);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 40);
            this.BtnBuscar.TabIndex = 119;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(798, 280);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(121, 40);
            this.BtnModificar.TabIndex = 120;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(672, 326);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 40);
            this.BtnEliminar.TabIndex = 121;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificarCan
            // 
            this.BtnModificarCan.Location = new System.Drawing.Point(672, 280);
            this.BtnModificarCan.Name = "BtnModificarCan";
            this.BtnModificarCan.Size = new System.Drawing.Size(109, 40);
            this.BtnModificarCan.TabIndex = 122;
            this.BtnModificarCan.Text = "Modificar Cantidad";
            this.BtnModificarCan.UseVisualStyleBackColor = true;
            this.BtnModificarCan.Click += new System.EventHandler(this.BtnModificarCan_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(798, 326);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 40);
            this.BtnCancelar.TabIndex = 123;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Location = new System.Drawing.Point(896, 439);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(86, 40);
            this.BtnTerminar.TabIndex = 125;
            this.BtnTerminar.Text = "Terminar venta";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // CmbCLientes
            // 
            this.CmbCLientes.FormattingEnabled = true;
            this.CmbCLientes.Location = new System.Drawing.Point(728, 242);
            this.CmbCLientes.Name = "CmbCLientes";
            this.CmbCLientes.Size = new System.Drawing.Size(121, 21);
            this.CmbCLientes.TabIndex = 126;
            // 
            // CmbMetodoP
            // 
            this.CmbMetodoP.FormattingEnabled = true;
            this.CmbMetodoP.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.CmbMetodoP.Location = new System.Drawing.Point(871, 241);
            this.CmbMetodoP.Name = "CmbMetodoP";
            this.CmbMetodoP.Size = new System.Drawing.Size(121, 21);
            this.CmbMetodoP.TabIndex = 127;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(228)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1032, 532);
            this.Controls.Add(this.CmbMetodoP);
            this.Controls.Add(this.CmbCLientes);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnModificarCan);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtProductos);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.NudPro);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.NumericUpDown NudPro;
        private System.Windows.Forms.TextBox TxtProductos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificarCan;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.ComboBox CmbCLientes;
        private System.Windows.Forms.ComboBox CmbMetodoP;
    }
}