using FlatLoginWatermark;
using GUI_V_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            MostarCatalago();
            CargaCombo();
            Mostrar(1, false);
        }

        public void Mostrar(int s, bool tf)
        {
            foreach (Control c in this.panel3.Controls)
            {
                c.Enabled = tf;
                if (c is Button)
                {
                    if (tf == true)
                    {
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Enabled = true;
                    }
                }
            }

            switch (s)
            {
                case 1:
                    BtnGuardar.Enabled = false;
                    BtnCancelar.Enabled = false;

                    break;
                case 2:
                    BtnGuardar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    break;
            }

        }

        private void MostarCatalago()
        {
            Producto producto = new Producto();

            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = producto.MostrarProductos();
        }

        private void CargaCombo()
        {
            DataTable Almacen = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Categoria";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Almacen);
                    CmbCategoria.DataSource = Almacen;
                    CmbCategoria.DisplayMember = Almacen.Columns[1].ToString();
                    CmbCategoria.ValueMember = Almacen.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
