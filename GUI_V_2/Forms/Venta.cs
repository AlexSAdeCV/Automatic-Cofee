using FlatLoginWatermark;
using GUI_V_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using iText.Layout;
using iText.Kernel.Pdf.Extgstate;
using iText.Bouncycastleconnector;

namespace GUI_V_2.Forms
{
    public partial class Venta : Form
    {
        int i = 0;
        public int usuario;
        public Venta()
        {
            InitializeComponent();
            llenarcmbclientes();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            DgvProducto.Columns.Add("ID del Producto", "ID del Producto");
            DgvProducto.Columns.Add("Nombre del Producto", "Nombre del Producto");
            DgvProducto.Columns.Add("Precio", "Precio");
            DgvProducto.Columns.Add("Unidades", "Existencia");
        }

        public void Bloquear(bool i, bool j)
        {
            NudPro.Enabled = i;
            BtnModificar.Enabled = i;
            TxtProductos.Enabled = j;
            BtnBuscar.Enabled = j;
            BtnModificarCan.Enabled = j;
            BtnEliminar.Enabled = j;
            BtnEliminar.Enabled = j;

        }
        public void buscar()
        {
            DataTable dt = new DataTable();
            Ventas ventas = new Ventas();
            Producto producto = new Producto(); 
            producto.idproducto = Convert.ToInt32(TxtProductos.Text);
            if (ventas.ReadAll(producto))
            {
                dt = producto.Mostrar_Pro();
                i = 1;

                //Eventos para colocar los datos en el datagrid
                string txt_Cantidad;
                int num_Cantidad;
                int pro = DgvProducto.Rows.Count;
                int j;
                //Buscar si ya hay un producto con el mismo id
                for (j = 0; j < pro; j++)
                {
                    if (TxtProductos.Text == DgvProducto.Rows[j].Cells[0].Value.ToString())
                    {
                        txt_Cantidad = DgvProducto.Rows[j].Cells[5].Value.ToString();
                        num_Cantidad = Convert.ToInt32(txt_Cantidad);
                        num_Cantidad++;
                        DgvProducto.Rows[j].Cells[3].Value = num_Cantidad;
                        j = pro + 1;
                        pro--;
                    }
                }
                //Cuando no hay ningun producto con el mismo id
                if (j == pro)
                {
                    DgvProducto.Rows.Add(dt.Rows[0].ItemArray);
                    DgvProducto.Rows[pro].Cells[3].Value = 1;
                }
                TxtProductos.Text = "";

                Lbl_Total.Text = Convert.ToString(Sumar(pro));
            }
        }

        public double Sumar(int pro)
        {
            double total = 0;
            double Cantidad;
            double Precio;
            string Conversion;
            for (int j = 0; j <= pro; j++)
            {
                Conversion = DgvProducto.Rows[j].Cells[3].Value.ToString();
                Cantidad = Convert.ToDouble(Conversion);
                Conversion = DgvProducto.Rows[j].Cells[2].Value.ToString();
                Precio = Convert.ToDouble(Conversion);
                Precio = Precio * Cantidad;
                total = total + Precio;
            }
            return total;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void BtnModificarCan_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                int RenglonSeleccionado = DgvProducto.CurrentRow.Index;
                NudPro.Text = DgvProducto.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
                Bloquear(true, false);
            }
            else
            {
                MessageBox.Show("No hay nada a Modificar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int i;
            i = DgvProducto.Rows.Count;
            if (i > 0)
            {
                int RenglonSeleccionado = DgvProducto.CurrentRow.Index;
                string pro = DgvProducto.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar el Producto " + pro + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    DgvProducto.Rows.RemoveAt(RenglonSeleccionado);
                }
                i--;
                if (i != 0)
                {
                    i--;
                    Lbl_Total.Text = Convert.ToString(Sumar(i));
                }
                else
                {
                    Lbl_Total.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("No hay nada a Modificar");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Desea cancelar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                Bloquear(false, true);
                NudPro.Text = "0";
                TxtProductos.Text = "";
                Lbl_Total.Text = "0";
                DgvProducto.Rows.Clear();
                i = 0;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int RenglonSeleccionado = DgvProducto.CurrentRow.Index;
            int Cantidad = Convert.ToInt32(NudPro.Text);
            DgvProducto.Rows[RenglonSeleccionado].Cells[3].Value = Cantidad;
            int pro = DgvProducto.Rows.Count;
            pro--;
            Lbl_Total.Text = Convert.ToString(Sumar(pro));
            Cancelar();
        }
        public void Cancelar()
        {
            Bloquear(false, true);
            NudPro.Text = "0";
            TxtProductos.Text = "";
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            Ventas Venta = new Ventas();
            Producto pr = new Producto(); 
            int i = 0;


            if (Lbl_Total.Text != "0")
            {
                DialogResult Resultado = MessageBox.Show("¿Desea terminar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {

                    Venta.idempleado = usuario;
                    Venta.precio = Convert.ToDouble(Lbl_Total.Text);
                    Venta.Fecha = DateTime.Now.ToString("yyyy") + "/" + DateTime.Now.ToString("MM") + "/" + DateTime.Now.ToString("dd");
                    Venta.idcliente = Convert.ToInt32(CmbCLientes.SelectedIndex) + 1;
                    Venta.Metododepago = CmbMetodoP.Text.ToString();
                    Venta.Insertar();
                    Resultado = MessageBox.Show("¿Desea Ticket?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.Yes)
                    {
                        IPDF();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede facturar con importe de $ 0 ");
            }
        }

        public void llenarcmbclientes()
        {
            DataTable Clientes = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapterLibros = new SqlDataAdapter();

                string sentencia = "Select * from Cliente";

                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapterLibros.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapterLibros.Fill(Clientes);
                    CmbCLientes.DataSource = Clientes;
                    CmbCLientes.DisplayMember = Clientes.Columns[1].ToString();
                    CmbCLientes.ValueMember = Clientes.Columns[0].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void IPDF()
        {
            //El PDF se genera con una utileria llamad iText, la cual se tiene que incluir antes de utilizar.
            //para instalar ir a Herramientas -> admininistrador de paquetes Nuget -> Consola del administrador de paquetes Nuget
            //en el prompot pm> teclear el comando Install-Package itext7, dar enter y esperar

            //Mas información en https://kb.itextpdf.com/home/it7kb/examples
            //este es un ejemplo básico.

            Ventas ventas = new Ventas();
            SaveFileDialog GuardaArchivoPdf = new SaveFileDialog();
            string rp = @"Ticket " + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            GuardaArchivoPdf.Filter = "Archivos PDF|*.pdf";
            GuardaArchivoPdf.FileName = rp;
            if (GuardaArchivoPdf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(GuardaArchivoPdf.FileName, FileMode.Create))
                {
                    PdfWriter pdfWriter = new PdfWriter(stream);
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    PageSize pageSize = PageSize.A7.Rotate();
                    
                    Document MiDocumento = new Document(pdfDocument);
                    PdfCanvas canvas = new PdfCanvas(pdfDocument.AddNewPage());

                    Table TblVenta = new Table(UnitValue.CreatePercentArray(6));

                    MiDocumento.Add(new Paragraph("Ticket No " + " " + DateTime.Now.ToLongDateString()));

                    if (DgvProducto.RowCount > 0)
                    {
                        for (int i = 0; i < DgvProducto.Columns.Count; i++)
                        {
                            TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Columns[i].Name)));
                        }
                        for (int row = 0; row < DgvProducto.RowCount; row++)
                        {

                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[0].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[1].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[2].Value.ToString()).SetMargins(0, 0, 0, 0)));
                            TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph(DgvProducto.Rows[row].Cells[3].Value.ToString()).SetMargins(0, 0, 0, 0)));
                        }
                        MiDocumento.Add(TblVenta);
                        MiDocumento.Add(new Paragraph("El total de la compra fue de $ " + Lbl_Total.Text+" MXN"));
                        MiDocumento.Add(new Paragraph("Que tenga excelente dia"));

                    }
                    else
                    {
                        TblVenta.AddHeaderCell(new Cell().SetKeepTogether(true).Add(new Paragraph("Error")));
                        TblVenta.AddCell(new Cell().SetKeepTogether(true).Add(new Paragraph("No hay usuarios por listar")));
                        MiDocumento.Add(TblVenta);

                    }
                    MiDocumento.Close();
                }
            }
        }
    }
}
