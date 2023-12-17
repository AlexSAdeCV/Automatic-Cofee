namespace GUI_V_2.Forms
{
    partial class Menus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFrias = new System.Windows.Forms.Button();
            this.BtnCalientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(86)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.BtnFrias);
            this.panel1.Controls.Add(this.BtnCalientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 40);
            this.panel1.TabIndex = 22;
            // 
            // BtnFrias
            // 
            this.BtnFrias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFrias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFrias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFrias.Location = new System.Drawing.Point(277, 0);
            this.BtnFrias.Name = "BtnFrias";
            this.BtnFrias.Size = new System.Drawing.Size(100, 40);
            this.BtnFrias.TabIndex = 1;
            this.BtnFrias.Text = "Bebidas Frias";
            this.BtnFrias.UseVisualStyleBackColor = true;
            // 
            // BtnCalientes
            // 
            this.BtnCalientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCalientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCalientes.Location = new System.Drawing.Point(94, 0);
            this.BtnCalientes.Name = "BtnCalientes";
            this.BtnCalientes.Size = new System.Drawing.Size(100, 40);
            this.BtnCalientes.TabIndex = 0;
            this.BtnCalientes.Text = "Bebidas Calientes";
            this.BtnCalientes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 523);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_V_2.Properties.Resources.cafeamericano;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menus";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFrias;
        private System.Windows.Forms.Button BtnCalientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}