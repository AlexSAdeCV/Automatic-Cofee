using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_V_2.Forms;

namespace GUI_V_2
{
    public partial class Form1 : Form
    {
        Form FormHijo = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (MenuVertical.Width == 250)
            //{
            //    MenuVertical.Width = 70;
            //}
            //else
            //    MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //iconrestaurar.Visible = false;
            //iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void AbrirFormEnPanel(Form Hijito)
        {
            if (FormHijo != null)
                FormHijo.Close();
            else
            {
                FormHijo = Hijito;
                FormHijo.TopLevel = false;
                FormHijo.FormBorderStyle = FormBorderStyle.None;
                FormHijo.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(FormHijo);
                panelContenedor.Tag = FormHijo;
                Hijito.BringToFront();
                Hijito.Show();
                FormHijo = null;
            }
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Productos());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Clientescs());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empleados());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
