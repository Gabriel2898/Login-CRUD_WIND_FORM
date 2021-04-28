using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();
        DataTable tabla = new DataTable();
        public DataTable MostrarProd()
        {

           
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string nombre, string desc, string marca, string precio, string stock)
        {

            objetoCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarPRod(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
