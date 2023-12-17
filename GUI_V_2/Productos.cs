using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalientes_Click(object sender, EventArgs e)
        {
            if (!pCaliente.Visible)
                pCaliente.Visible = true;
            else
                pCaliente.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "001";
            file.Cells[1].Value = "Cafe Capuchino";
            file.Cells[2].Value = "25";
            file.Cells[3].Value = "25";
            dgvProd.Rows.Add(file);

            label1.Text = "25";
            label5.Text = "Cafe Capuchino";
            label2.Text = "001";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "002";
            file.Cells[1].Value = "Cafe Americano";
            file.Cells[2].Value = "40";
            file.Cells[3].Value = "40";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "40";
            LblProducto.Text = "Cafe Americano";
            LblCodigo.Text = "002";
        }

        private void pCaliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "003";
            file.Cells[1].Value = "Latte";
            file.Cells[2].Value = "30";
            file.Cells[3].Value = "30";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "30";
            LblProducto.Text = "Latte";
            LblCodigo.Text = "003";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "004";
            file.Cells[1].Value = "Espresso";
            file.Cells[2].Value = "50";
            file.Cells[3].Value = "50";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "50";
            LblProducto.Text = "Espresso";
            LblCodigo.Text = "004";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "005";
            file.Cells[1].Value = "Cafe con Leche";
            file.Cells[2].Value = "20";
            file.Cells[3].Value = "20";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "20";
            LblProducto.Text = "Cafe con Leche";
            LblCodigo.Text = "005";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "005";
            file.Cells[1].Value = "Mocha";
            file.Cells[2].Value = "40";
            file.Cells[3].Value = "40";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "40";
            LblProducto.Text = "Mocha";
            LblCodigo.Text = "005";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "006";
            file.Cells[1].Value = "Chai Latte";
            file.Cells[2].Value = "35";
            file.Cells[3].Value = "35";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "35";
            LblProducto.Text = "Chai Latte";
            LblCodigo.Text = "006";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "007";
            file.Cells[1].Value = "Te verde";
            file.Cells[2].Value = "20";
            file.Cells[3].Value = "20";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "20";
            LblProducto.Text = "Te verde";
            LblCodigo.Text = "007";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvProd);

            file.Cells[0].Value = "008";
            file.Cells[1].Value = "Chocolate Caliente";
            file.Cells[2].Value = "30";
            file.Cells[3].Value = "30";
            dgvProd.Rows.Add(file);

            LblPrecio.Text = "30";
            LblProducto.Text = "Chocolate Caliente";
            LblCodigo.Text = "008";
        }

        private void BtnFrias_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
