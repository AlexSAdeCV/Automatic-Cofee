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
    public partial class VistaProducto : Form
    {
        public int id;
        public VistaProducto()
        {
            InitializeComponent();
        }

        private void LLenar()
        {
            Producto pr = new Producto();
            pr.idproducto = id;
            if (id != 1)
                pr.idproducto -= 1;
            if (pr.MostrarCatalogo())
            {
                lblid.Text = pr.idproducto.ToString();
                lblnombre.Text = pr.nombre;
                precio.Text = pr.precio.ToString();
            }

        }

        private void VistaProducto_Load(object sender, EventArgs e)
        {
            LLenar();
        }
    }
}
