using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatLoginWatermark
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion;
            SqlConnectionStringBuilder CadenaConexion = new SqlConnectionStringBuilder();

            CadenaConexion.DataSource = @"(localdb)\MSSQLLocalDB";
            CadenaConexion.IntegratedSecurity = true;
            CadenaConexion.InitialCatalog = "PA_CAF";
            conexion = new SqlConnection(CadenaConexion.ConnectionString);
            return conexion;
        }
    }
}
