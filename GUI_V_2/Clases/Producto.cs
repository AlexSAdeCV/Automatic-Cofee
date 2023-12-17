using FlatLoginWatermark;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Clases
{
    internal class Producto
    {
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int idcategoria { get; set; }
        public string Mensaje { get; set; }

        public bool MostrarCatalogo()
        {
            bool exito = false;
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select * from Productos where ProductoID = @ProductoID";

                CmdSQL = new SqlCommand(Cadena, Conectar);
                CmdSQL.Parameters.AddWithValue("@ProductoID", idproducto);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);

                    //idproducto -= 1;
                    int renglon = idproducto -1;

                    if (Productos.Rows.Count > 0)
                    {
                        nombre = Productos.Rows[renglon]["NombreProducto"].ToString();
                        precio = Convert.ToDouble(Productos.Rows[renglon]["Precio"]);

                        exito = true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return exito;
        }

        public DataTable Mostrar_Pro()
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Productos WHERE ProductoID = @Id";
                cmdSelect = new SqlCommand(sentencia, conexion);
                cmdSelect.Parameters.AddWithValue("@Id", idproducto);
                try
                {
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tablaProductos;
        }
        public int Extraer_Catidad(string id)
        {
            object tmp;
            int IdProveedor = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select EXISTENCIA from Productos where IdPRODUCTO = @User";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    cmdCreate.Parameters.AddWithValue("@User", id);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdProveedor = 0;
                    }
                    else
                    {
                        IdProveedor = Convert.ToInt32(tmp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdProveedor;
        }

        public bool Mod_Ex_PRO(string Existencia, string id)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;

                int filasafectadas;
                string sentencia = @"Update PRODUCTOS set EXISTENCIA = @Existencia where ProductoID = @Id";
                cmdCreate = new SqlCommand(sentencia, conexion);

                cmdCreate.Parameters.AddWithValue("@Existencia", Existencia);
                cmdCreate.Parameters.AddWithValue("@Id", id);

                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Cantidad actualizada exitosamente";
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }

        public DataTable MostrarProductos()
        {
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select ProductoID, NombreProducto, Precio, NombreCategoria from Productos inner join Categoria on idcategoria = CategoriaID";

                CmdSQL = new SqlCommand(Cadena, Conectar);

                try
                {
                    Conectar.Open();

                    sqlDataAdapter.SelectCommand = CmdSQL;

                    sqlDataAdapter.Fill(Productos);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }

            return Productos;
        }
    }
}
