using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return 0;
        }

        public int Modificar(EstadohabBO estadohabBO)
        {
            return 0;
        }

        public int Eliminar(EstadohabBO estadohabBO)
        {
            return 0;
        }

        public int Buscar()
        {
            return 0;
        }
    }
}
