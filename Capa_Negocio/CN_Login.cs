using Capa_Datos;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class CN_Login
    {
        private CD_Login usu =new  CD_Login();
        private int id;
        private string usuario;
        private string pass;

        public CN_Login()
        {

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader loguear;
            loguear = usu.iniciarSesion(Usuario, Password);
            return loguear;
        }
    }
}
