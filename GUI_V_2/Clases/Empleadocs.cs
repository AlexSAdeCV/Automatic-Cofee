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
    internal class Empleadocs
    {
        public string Mensaje { get; set; }
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Nivel_Usuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string CodePostal { get; set; }
        public string Colonia { get; set; }
        public double Sueldo { get; set; }

        public bool Insertar()
        {
            bool operaciones = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                string sentencia = @"Insert into Empleados Values (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @Calle, @Colonia, @CodePostal, @Sueldo, @Usuario, @Contraseña, @rol)";

                int resultado = 0;

                Consulta = new SqlCommand(sentencia, conexion);
                Consulta.Parameters.AddWithValue("@Nombre", Nombre);
                Consulta.Parameters.AddWithValue("@ApellidoPaterno", ApellidoP);
                Consulta.Parameters.AddWithValue("@ApellidoMaterno", ApellidoM);
                Consulta.Parameters.AddWithValue("@Telefono", Telefono);
                Consulta.Parameters.AddWithValue("@Calle", Calle);
                Consulta.Parameters.AddWithValue("@Colonia", Colonia);
                Consulta.Parameters.AddWithValue("@CodePostal", CodePostal);
                Consulta.Parameters.AddWithValue("@Sueldo", Sueldo);
                Consulta.Parameters.AddWithValue("@Usuario", Usuario);
                Consulta.Parameters.AddWithValue("@Contraseña", Contraseña);
                Consulta.Parameters.AddWithValue("@rol", Nivel_Usuario);


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
                string sentencia = @"UPDATE Empleados SET NombreEmpleado = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Telefono = @Telefono, Calle = @Calle, Colonia = @Colonia, CodigoPostal = @CodePostal,Sueldo = @Sueldo, Usuario = @Usuario, Contraseña = @Contraseña , rol = @rol WHERE EmpleadoID = @EmpleadoID";

                int resultado = 0;

                Consulta = new SqlCommand(sentencia, conexion); 
                Consulta.Parameters.AddWithValue("@Nombre", Nombre);
                Consulta.Parameters.AddWithValue("@ApellidoPaterno", ApellidoP);
                Consulta.Parameters.AddWithValue("@ApellidoMaterno", ApellidoM);
                Consulta.Parameters.AddWithValue("@Telefono", Telefono);
                Consulta.Parameters.AddWithValue("@Calle", Calle);
                Consulta.Parameters.AddWithValue("@Colonia", Colonia);
                Consulta.Parameters.AddWithValue("@CodePostal", CodePostal);
                Consulta.Parameters.AddWithValue("@Sueldo", Sueldo);
                Consulta.Parameters.AddWithValue("@Usuario", Usuario);
                Consulta.Parameters.AddWithValue("@Contraseña", Contraseña);
                Consulta.Parameters.AddWithValue("@rol", Nivel_Usuario);
                Consulta.Parameters.AddWithValue("@EmpleadoID", IdEmpleado);

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

                Sentencia = @"delete from Empleados where EmpleadoID = @EmpleadoID";
                CMDSql = new SqlCommand(Sentencia, Con);

                CMDSql.Parameters.AddWithValue("@EmpleadoID", IdEmpleado);

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

        public DataTable MostrarEmpleados()
        {
            DataTable Productos = new DataTable();

            using (SqlConnection Conectar = Conexion.Conectar())
            {
                string Cadena;
                SqlCommand CmdSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                Cadena = @"select EmpleadoID, (NombreEmpleado + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno) as Nombre, Telefono, (Calle + ' ' + Colonia+ ' ' + ' ' + ' ' + CodigoPostal) as Domicilio, Sueldo from Empleados";

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
