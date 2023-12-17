using FlatLoginWatermark;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Clases
{
    internal class Ventas
    {
        public int idventa { get; set; }
        public string Fecha { get; set; }
        public string Metododepago { get; set; }
        public string idproducto { get; set; }
        public int idempleado { get; set; }
        public int idcliente { get; set; }
        public string Mensaje { get; set; }
        public double precio { get; set; }

        public bool ReadAll(Producto producto)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Productos where ProductoID = @Id;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Id", producto.idproducto);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                    if (tablaProductos.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Producto No encontrado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public bool Insertar()
        {
            bool operaciones = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                string sentencia = @"Insert into Ventas Values(@FechaVenta, @Precio, @TipoPago, @EmpleadoID, @ClienteID)";
                int resultado = 0;

                Consulta = new SqlCommand(sentencia, conexion);
                Consulta.Parameters.AddWithValue("@FechaVenta", Fecha);
                Consulta.Parameters.AddWithValue("@Precio", precio);
                Consulta.Parameters.AddWithValue("@TipoPago", Metododepago);
                Consulta.Parameters.AddWithValue("@EmpleadoID", idempleado);
                Consulta.Parameters.AddWithValue("@ClienteID", idcliente);

                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "venta registrada correctamente";
                        operaciones = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return operaciones;
        }

        public DataTable MostrarVentas()
        {
            DataTable ventas = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"Select * from Ventas";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(ventas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return ventas;
        }
    }
}
