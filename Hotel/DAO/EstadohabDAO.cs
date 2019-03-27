using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hotel.BO;

namespace Hotel.DAO
{
    class EstadohabDAO
    {
        Conexion conexion;
        public EstadohabDAO()
        {
            conexion = new Conexion();
        }

        public int Agregar(EstadohabBO estadohabBO)
        {
            string ComandoSQL = string.Format("INSERT INTO  estado_habitacion(estado)VALUES('{0}');", estadohabBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(EstadohabBO estadohabBO)
        {
            string ComandoSQL = string.Format("UPDATE estado_habitacion SET estado='{1}' WHERE estado_id={0}", estadohabBO.Estado_id, estadohabBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(EstadohabBO estadohabBO)
        {
            string ComandoSQL = string.Format("DELETE FROM estado_habitacion WHERE estado_id={0}", estadohabBO.Estado_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public DataTable Buscar()
        {
            string commandSQL = "SELECT * from estado_habitacion";
            return conexion.EjecutarSentencia(commandSQL);
        }

        public EstadohabBO Buscar(int estado_id)
        {
            string commandSQL = String.Format("SELECT * FROM estado_habitacion WHERE estado_id={0}", estado_id);
            DataTable table = conexion.EjecutarSentencia(commandSQL);

            if (table.Rows.Count > 0)
            {
                DataRowCollection row = table.Rows;

                EstadohabBO estadohabBO = new EstadohabBO();

                estadohabBO.Estado_id = Convert.ToInt32(row[0]["estado_id"]);
                estadohabBO.Nombre = row[0]["estado"].ToString();

                return estadohabBO;
            }
            else
            {
                return null;
            }
        }
    }
}
