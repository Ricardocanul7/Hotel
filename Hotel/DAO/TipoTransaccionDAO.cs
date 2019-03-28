using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class TipoTransaccionDAO
    {

        Conexion conexion;
        public TipoTransaccionDAO()
        {
            conexion = new Conexion();
        }

        public int Agregar(TipoTransaccionBO tipotransaccionBO)
        {
            string ComandoSQL = string.Format("INSERT INTO  tipo_transaccion(nombre_tipo)VALUES('{0}');", tipotransaccionBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(TipoTransaccionBO tipotransaccionBO)
        {
            string ComandoSQL = string.Format("UPDATE tipo_transaccion SET nombre_transaccion='{1}' WHERE tipo_id={0}", tipotransaccionBO.Tipo_id, tipotransaccionBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(TipoTransaccionBO tipotransaccionBO)
        {
            string ComandoSQL = string.Format("DELETE FROM tipo_transaccion WHERE tipo_id={0}", tipotransaccionBO.Tipo_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public DataTable Buscar()
        {
            string commandSQL = "SELECT * from tipo_transaccion";
            return conexion.EjecutarSentencia(commandSQL);
        }

        public TipoTransaccionBO Buscar(int tipo_id)
        {
            string commandSQL = String.Format("SELECT * FROM tipo_transaccion WHERE tipo_id={0}", tipo_id);
            DataTable table = conexion.EjecutarSentencia(commandSQL);

            if (table.Rows.Count > 0)
            {
                DataRowCollection row = table.Rows;

                TipoTransaccionBO tipotransaccionBO = new TipoTransaccionBO();

                tipotransaccionBO.Tipo_id = Convert.ToInt32(row[0]["tipo_id"]);
                tipotransaccionBO.Nombre = row[0]["nombre_transaccion"].ToString();

                return tipotransaccionBO;
            }
            else
            {
                return null;
            }
        }
    }
}
