using FlatLoginWatermark;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2.Clases
{
    internal class Clientes
    {
        public string nombre { get; set; }
        public string Mensaje { get; set; }
        public int idcliente { get; set; }

        public bool Insertar()
        {
            bool operaciones = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                string sentencia = @"Insert into Cliente Values (@Nombre)";
                int resultado = 0;

                Consulta = new SqlCommand(sentencia, conexion);
                Consulta.Parameters.AddWithValue("@Nombre", nombre);

                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "registrada correctamente";
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
        public bool Modificar()
        {
            bool operaciones = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                string Sentencia = @"update Cliente set Nombre = @NombreProducto where ClienteID = @ClienteID";
                int resultado = 0;

                Consulta = new SqlCommand(Sentencia, conexion);
                Consulta.Parameters.AddWithValue("@NombreProducto", nombre);
                Consulta.Parameters.AddWithValue("@ClienteID", idcliente);


                try
                {
                    conexion.Open();

                    resultado = Consulta.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        Mensaje = "registrada correctamente";
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

        public bool Eliminar()
        {
            bool Exito = false;
            using (SqlConnection Con = Conexion.Conectar())
            {
                SqlCommand CMDSql;

                int resultado;
                string Sentencia;

                Sentencia = @"delete from Cliente where ClienteID = @ClienteID";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@ClienteID", idcliente);

                try
                {
                    Con.Open();

                    resultado = CMDSql.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Eliminacion exitosa";
                        Exito = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Exito;
        }

        public DataTable MostrarClientes()
        {
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select * from Cliente";

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
