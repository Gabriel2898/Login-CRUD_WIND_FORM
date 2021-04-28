using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Datos
{
   public class CD_Login
    {
        private CD_Conexion con = new CD_Conexion();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string usuario, string password)
        {
            SqlCommand comando = new SqlCommand("IniciarSesion",con.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usu", usuario);
            comando.Parameters.AddWithValue("@pass", password);
            leer = comando.ExecuteReader();
            return leer;

        }
    }
}
