using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;

namespace Hotel.DAO
{
    class TransaccionDAO
    {
        Conexion Miconexion;
        public TransaccionDAO()
        {
            Miconexion = new Conexion();
        }

      /*  public int Agregar(TransaccionBO transaccionbo)
        {
            //string ComandoSQL = string.Format("INSERT INTO corte_caja (corte_id, monto, fecha, hora, usuario_id)VALUES('{0}','{1}','{2}','{3}','1');", cajabo.Corte_id, cajabo.Monto, cajabo.Fecha.ToString("yyyy-MM-dd"), cajabo.Hora.ToString("HH:mm:ss"), cajabo.Usuario);

          return Miconexion.EjecutarComando(ComandoSQL);

        }*/



        /* public bool Eliminar()
         {
             return true;
         }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM corte_caja");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }*/
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */
    }
}

