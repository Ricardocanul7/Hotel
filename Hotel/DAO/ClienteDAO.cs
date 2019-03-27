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
            string ComandoSQL = string.Format("INSERT INTO cliente (cliente_id, nombre, apaterno, amaterno, direccion, email, telefono)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", clientebo.Cliente_id, clientebo.Cliente_nombre, clientebo.Cliente_apaterno, clientebo.Cliente_amaterno, clientebo.Cliente_direccion, clientebo.Cliente_email, clientebo.Cliente_telefono);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(ClienteBO clientebo)
        {
            String ComandoSQL = string.Format("UPDATE cliente SET nombre='{1}', apaterno='{2}', amaterno='{3}', direccion='{4}', email='{5}', telefono='{6}'  WHERE cliente_id={0}", clientebo.Cliente_id, clientebo.Cliente_nombre, clientebo.Cliente_apaterno, clientebo.Cliente_amaterno, clientebo.Cliente_direccion, clientebo.Cliente_email, clientebo.Cliente_telefono);
            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Eliminar(ClienteBO cliente)
        {
            string ComandoSQL = string.Format("DELETE FROM cliente WHERE cliente_id ={0}", cliente.Cliente_id);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM cliente");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */



    }
}
