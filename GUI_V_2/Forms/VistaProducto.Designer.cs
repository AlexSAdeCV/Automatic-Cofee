namespace GUI_V_2.Forms
{
    partial class VistaProducto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblnombre = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.PicboxProducto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 461);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.lblnombre);
            this.panel3.Controls.Add(this.precio);
            this.panel3.Controls.Add(this.lblid);
            this.panel3.Controls.Add(this.LblPrecio);
            this.panel3.Controls.Add(this.LblCodigo);
            this.panel3.Controls.Add(this.LblProducto);
            this.panel3.Location = new System.Drawing.Point(19, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 423);
            this.panel3.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(146, 67);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(10, 13);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "-";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(146, 146);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(10, 13);
            this.precio.TabIndex = 7;
            this.precio.Text = "-";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(146, 106);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(10, 13);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "-";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(37, 146);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(47, 13);
            this.LblPrecio.TabIndex = 4;
            this.LblPrecio.Text = "PRECIO";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(37, 106);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(49, 13);
            this.LblCodigo.TabIndex = 2;
            this.LblCodigo.Text = "CODIGO";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(37, 67);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(68, 13);
            this.LblProducto.TabIndex = 1;
            this.LblProducto.Text = "PRODUCTO";
            // 
            // PicboxProducto
            // 
            this.PicboxProducto.Image = global::GUI_V_2.Properties.Resources.cafeamericano;
            this.PicboxProducto.Location = new System.Drawing.Point(428, 28);
            this.PicboxProducto.Name = "PicboxProducto";
            this.PicboxProducto.Size = new System.Drawing.Size(195, 184);
            this.PicboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicboxProducto.TabIndex = 24;
            this.PicboxProducto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 86);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VistaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicboxProducto);
            this.Controls.Add(this.panel2);
            this.Name = "VistaProducto";
            this.Text = "VistaProducto";
            this.Load += new System.EventHandler(this.VistaProducto_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblProducto;
        public System.Windows.Forms.PictureBox PicboxProducto;
        private System.Windows.Forms.Button button1;
    }
}