using GUI_V_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Forms
{
    public partial class Empleados : Form
    {
        int op;
        public Empleados()
        {
            InitializeComponent();
            MostrarEmpleados();
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
            Empleadocs ep = new Empleadocs();
            int renglon;
            string id;

            renglon = dataGridView1.CurrentRow.Index;
            id = dataGridView1.Rows[renglon].Cells[0].Value.ToString();
            ep.IdEmpleado = Convert.ToInt32(id);

            DialogResult Resultado = MessageBox.Show("¿Desea elimar el registro " + id + " ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (ep.Eliminar())
                {
                    MessageBox.Show("Registro eliminado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEmpleados();
                    HabilitaBotones();
                    Mostrar(1, false, Color.Gray);
                }
                else
                {
                    MessageBox.Show(ep.Mensaje);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Empleadocs ep = new Empleadocs();

            int renglon;
            string id;

            if (ValidaCampos())
            {
                errorProvider1.Clear();
                switch (op)
                {
                    case 1:
                        ep.Nombre = txtnombre.Text;
                        ep.ApellidoP = TxtApellidoP.Text;
                        ep.ApellidoM = TxtApellidoM.Text;
                        ep.Telefono = TxtTelefono.Text;
                        ep.Calle = TxtCalle.Text;
                        ep.Colonia = TxtColonia.Text;
                        ep.CodePostal = TxtCp.Text;
                        ep.Sueldo = Convert.ToDouble(TxtSueldo.Text);
                        ep.Nivel_Usuario = Convert.ToInt32(comboBox1.SelectedValue);
                        ep.Usuario = TxtUser.Text;
                        ep.Contraseña = TxtContraseña.Text;

                        if (ep.Insertar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            HabilitaBotones();
                            MostrarEmpleados();
                            Mostrar(1, false, Color.Gray);
                        }
                        break;
                    case 2:
                        renglon = dataGridView1.CurrentRow.Index;
                        id = dataGridView1.Rows[renglon].Cells[0].Value.ToString();
                        ep.IdEmpleado = Convert.ToInt32(id);
                        ep.Nombre = txtnombre.Text;
                        ep.ApellidoP = TxtApellidoP.Text;
                        ep.ApellidoM = TxtApellidoM.Text;
                        ep.Telefono = TxtTelefono.Text;
                        ep.Calle = TxtCalle.Text;
                        ep.Colonia = TxtColonia.Text;
                        ep.CodePostal = TxtCp.Text;
                        ep.Sueldo = Convert.ToDouble(TxtSueldo.Text);
                        ep.Usuario = TxtUser.Text;
                        ep.Contraseña = TxtContraseña.Text;

                        if (ep.Modificar())
                        {
                            MessageBox.Show("Registro agregado exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiaCampos();
                            HabilitaBotones();
                            MostrarEmpleados();
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

        private void MostrarEmpleados()
        {
            Empleadocs ep = new Empleadocs();

            //dataGridView1.AutoSize = true;
            dataGridView1.DataSource = ep.MostrarEmpleados();
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

        private void TxtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(".") > -1) //aqui nos detecta el punto decimal; lo del sender as text box nos sirve para detectar todas la textbox pero es necesario pasar el codigo al evento de la textbox
                e.Handled = true;
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void TxtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
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
