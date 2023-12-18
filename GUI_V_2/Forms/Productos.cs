using FlatLoginWatermark;
using GUI_V_2.Clases;
using iText.StyledXmlParser.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class Productos : Form
    {
        int op;
        public Productos()
        {
            InitializeComponent();
            MostarCatalago();
            CargaCombo();
            Mostrar(1, false, Color.Gray);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 1;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar(2, true, Color.White);

            op = 2;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto();
            int renglon;
            string id;

            switch (op)
            {
                case 1:
                    pr.nombre = txtnombre.Text;
                    pr.precio = Convert.ToDouble(TxtPrecio.Text);
                    pr.idcategoria = Convert.ToInt32(CmbCategoria.SelectedValue);

                    if (pr.Insertar())
                    {
                        MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaCampos();
                        HabilitaBotones();
                        MostarCatalago();
                        Mostrar(1, false, Color.Gray);
                    }
                    break;
                case 2:
                    renglon = dgvproductos.CurrentRow.Index;
                    id = dgvproductos.Rows[renglon].Cells[0].Value.ToString();
                    pr.nombre = txtnombre.Text;
                    pr.precio = Convert.ToDouble(TxtPrecio.Text);
                    pr.idcategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                    pr.idproducto = Convert.ToInt32(id);

                    if (pr.Modificar())
                    {
                        MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaCampos();
                        HabilitaBotones();
                        MostarCatalago();
                        Mostrar(1, false, Color.Gray);
                    }
                    break;
            }
        }

        public void Mostrar(int s, bool tf, Color color)
        {
            foreach (Control c in this.panel3.Controls)
            {
                c.Enabled = tf;
                if (c is TextBox)
                {
                    c.BackColor = color;
                }
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

            dgvproductos.AutoSize = true;
            dgvproductos.DataSource = producto.MostrarProductos();
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

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(".") > -1) //aqui nos detecta el punto decimal; lo del sender as text box nos sirve para detectar todas la textbox pero es necesario pasar el codigo al evento de la textbox
                e.Handled = true;
        }
        private void LimpiaCampos()
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                {
                    TextBox x;
                    x = (TextBox)c;
                    x.Clear();
                }
            }
        }
        private void HabilitaBotones()
        {
            foreach (Control b in panel3.Controls)
            {
                if (b is Button)
                {
                    b.Enabled = true;
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Producto pr = new Producto();
            int renglon;
            string id;

            renglon = dgvproductos.CurrentRow.Index;
            id = dgvproductos.Rows[renglon].Cells[0].Value.ToString();
            pr.idproducto = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (pr.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostarCatalago();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
                else
                {
                    MessageBox.Show(pr.Mensaje);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
        }
    }
}
