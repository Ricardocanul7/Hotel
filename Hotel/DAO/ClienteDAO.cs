using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hotel.BO;

namespace Hotel.DAO
{
    class ClienteDAO
    {
        Conexion Miconexion;
        public ClienteDAO()
        {
            Miconexion = new Conexion();
        }

        public int Agregar(ClienteBO clientebo)
        {
            string ComandoSQL = string.Format("INSERT INTO clientes (cliente_id, cliente_nombre, cliente_apaterno, cliente_amaterno, cliente_direccion, cliente_email, cliente_telefono)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", clientebo.Cliente_id, clientebo.Cliente_nombre, clientebo.Cliente_apaterno, clientebo.Cliente_amaterno, clientebo.Cliente_direccion, clientebo.Cliente_email, clientebo.Cliente_telefono);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public bool Modificar(ClienteBO cliente)
        {
            return true;
        }

        public bool Eliminar()
        {
            return true;
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM clientes");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */

       

    }
}
