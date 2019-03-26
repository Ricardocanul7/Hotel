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
            return 0;
        }

        public int Eliminar(EstadohabBO estadohabBO)
        {
            return 0;
        }

        public DataTable Buscar()
        {
            string commandSQL = "SELECT * from estado_habitacion";
            return conexion.EjecutarSentencia(commandSQL);
        }
    }
}
