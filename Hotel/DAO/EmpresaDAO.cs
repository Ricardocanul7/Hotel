using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using Hotel.DAO;
using System.Data;

namespace Hotel.DAO
{
    class EmpresaDAO
    {
        Conexion Miconexion;

        public EmpresaDAO()
        {
            Miconexion = new Conexion();
        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */

        public int Agregar(EmpresaBO empresa)
        {
            string ComandoSQL = string.Format("INSERT INTO proveedor (rfc_proveedor, nombre, precio_porhora) VALUES('{0}','{1}', {2})", empresa.RFC, empresa.Nombre, empresa.Precio_hora);

            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(EmpresaBO empresa)
        {
            string ComandoSQL = string.Format("UPDATE proveedor SET nombre='{1}', precio_porhora= {2}  WHERE id_empleado = '{0}' ", empresa.RFC, empresa.Nombre, empresa.Precio_hora);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(EmpresaBO  empresa)
        {
            string ComandoSQL = string.Format("DELETE FROM proveedor WHERE rfc_proveedor ='{0}'", empresa.RFC);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM proveedor");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }
    }
}
