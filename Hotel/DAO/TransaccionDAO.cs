using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class TransaccionDAO
    {
        Conexion Miconexion;
        public TransaccionDAO()
        {
            Miconexion = new Conexion();
        }

       public int Agregar(TransaccionBO transaccionbo)
        {
            string ComandoSQL = string.Format("INSERT INTO transaccion (codigo_transaccion, monto, descripcion, fecha, tipo, folio_reserva, usuario_id)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", transaccionbo.Codigo_transaccion, transaccionbo.Monto, transaccionbo.Descripccion, transaccionbo.Fecha.ToString("yyyy-MM-dd"), transaccionbo.Tipo, transaccionbo.Folio, transaccionbo.Usuario);

          return Miconexion.EjecutarComando(ComandoSQL);

        }



        /* public bool Eliminar()
         {
             return true;
         }*/
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM transaccion");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }

        public DataTable Buscar_tipoTransaccion()
        {
            string ComandoSQL = string.Format("SELECT * FROM tipo_transaccion");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */
    }
}

