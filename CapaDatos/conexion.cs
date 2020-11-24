using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
    public class conexion
    {
        public static SqlConnection getConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["CN"].ConnectionString);
        }
    }
}
