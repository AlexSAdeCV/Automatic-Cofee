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
using FlatLoginWatermark;
using System.Security.Cryptography;
using GUI_V_2.Forms;

namespace GUI_V_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (InicioSesion.IniciaSesion(txtuser.Text, txtpass.Text))
                {
                    txtpass.Text = "";
                    txtuser.Text = "";
                    this.Hide();

                    if (InicioSesion.nivel == 0)
                    {
                        Form1 Ha = new Form1();
                        Ha.ShowDialog();
                    }
                    if (InicioSesion.nivel == 1)
                    {
                        FormsHomEmpleado home = new FormsHomEmpleado();
                        home.ShowDialog();
                    }
                }

                this.Show();
            }
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
