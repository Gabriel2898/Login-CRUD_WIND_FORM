using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class CD_Conexion
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GV5PGTP\SQLEXPRESS;Initial Catalog=CRUDWIN;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
            
                conn.Open();
                return conn;
          
        }
        public SqlConnection CerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
          
                conn.Close();
                return conn;
          
        }
    }
}
