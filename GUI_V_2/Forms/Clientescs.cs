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

namespace GUI_V_2.Forms
{
    public partial class Clientescs : Form
    {
        int op;
        public Clientescs()
        {
            InitializeComponent();
            MostrarClientes();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            int renglon;
            string id;

            renglon = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[renglon].Cells[0].Value.ToString();
            cl.idcliente = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (cl.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarClientes();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
                else
                {
                    MessageBox.Show(cl.Mensaje);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            int renglon;
            string id;

            if (ValidaCampos())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:
                        cl.nombre = txtnombre.Text;

                        if (cl.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            HabilitaBotones();
                            MostrarClientes();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 2:
                        renglon = dataGridView1.CurrentRow.Index;
                        id = dataGridView1.Rows[renglon].Cells[0].Value.ToString();
                        cl.nombre = txtnombre.Text;
                        cl.idcliente = Convert.ToInt32(id);

                        if (cl.Modificar())
                        {
                            MessageBox.Show("Registro modificado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            HabilitaBotones();
                            MostrarClientes();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Mostrar(1, false, Color.Gray);
            LimpiaCampos();
            errorProvider1.Clear();
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

        private void MostrarClientes()
        {
            Clientes clientes = new Clientes();

            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = clientes.MostrarClientes(); 
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

        private bool ValidaCampos()
        {
            bool valido = true;
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length <= 0)
                    {
                        errorProvider1.SetError(c, "Campo no puede estar en blanco");
                        valido = false;
                    }
                }
            }
            return valido;
        }
    }
}
