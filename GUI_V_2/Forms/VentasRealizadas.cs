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
    public partial class VentasRealizadas : Form
    {
        public VentasRealizadas()
        {
            InitializeComponent();
            llenardgv();
        }

        public void llenardgv()
        {
            Ventas ventas = new Ventas();

            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = ventas.MostrarVentas();
        }
    }
}
