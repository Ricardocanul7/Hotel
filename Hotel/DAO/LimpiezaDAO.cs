using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{

    class LimpiezaDAO
    {
        Conexion Miconexion;

        public LimpiezaDAO()
        {
            Miconexion = new Conexion();
        }
        public int Agregar(LimpiezaBO limpieza)
        {
            string ComandoSQL = string.Format("INSERT INTO limpieza (fecha, empleado_id, num_habitacion) VALUES('{0}', '{1}', '{2}')", limpieza.Fecha_limpieza.ToString("yyyy-MM-dd H:mm:ss"), limpieza.Empleado.Id_empleado, limpieza.Habitacion.Num_habitacion);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(LimpiezaBO limpieza)
        {
            string ComandoSQL = string.Format("UPDATE limpieza SET fecha={0}, empleado_id='{1}', num_habitacionnum='{2}' WHERE limpieza_id= {3}",
                limpieza.Fecha_limpieza.ToString("yyyy-MM-dd"),
                limpieza.Empleado.Id_empleado,
                limpieza.Habitacion.Num_habitacion,
                limpieza.Limpieza_id);
              
                return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(LimpiezaBO limpieza)
        {
            string ComandoSQL = string.Format("DELETE FROM limpieza WHERE limpieza_id ={0}", limpieza.Limpieza_id);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT limpieza_id, fecha, empleado_id, num_habitacion WHERE limpieza.limpieza_id = empleado.empleado_id, limpieza.limpieza.id = habitaciones.num_habitacion");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }

    }
}
