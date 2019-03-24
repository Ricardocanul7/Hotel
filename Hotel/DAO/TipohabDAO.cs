using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;

namespace Hotel.DAO
{
    class TipohabDAO
    {
        Conexion conexion;
        public TipohabDAO()
        {
            conexion = new Conexion();
        }

        public int Agregar(TipohabBO tipohabBO)
        {
            return 0;
        }

        public int Modificar(TipohabBO tipohabBO)
        {
            return 0;
        }

        public int Eliminar(TipohabBO tipohabBO)
        {
            return 0;
        }

        public int Modificar()
        {
            return 0;
        }
    }
}
