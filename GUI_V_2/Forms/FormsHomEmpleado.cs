using FlatLoginWatermark;
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
    public partial class FormsHomEmpleado : Form
    {
        Form FormHijo = null;
        public FormsHomEmpleado()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.usuario = InicioSesion.idusuario;
            AbrirFormEnPanel(venta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentasRealizadas());
        }

        private void FormsHomEmpleado_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }
    }
}
