using Hotel.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    class ReservaDAO
    {
        Conexion conn;
        public int Agregar(ReservasBO reserva)
        {
            string commandSQL = String.Format("INSERT INTO reservacion(num_habitacion, fecha_entrada, fecha_salida, detalles, cliente)" +
                                               "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", reserva.Habitacion);
            return conn.EjecutarComando(commandSQL);
        }
    }
}
