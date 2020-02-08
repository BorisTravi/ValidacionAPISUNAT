using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebapiSunat
{
    public class clsConexion
    {
        public SqlConnection conexion { set; get; }
        public clsConexion()
        {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        public void Cerrar()
        {
            conexion.Close();
        }

    }
}

