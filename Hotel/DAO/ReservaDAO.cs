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
        Conexion conn = new Conexion();

        public int Agregar(ReservasBO reserva)
        {
            string col1 = "num_habitacion";
            string col2 = "fecha_entrada";
            string col3 = "fecha_salida";
            string col4 = "detalles";
            string col5 = "cliente";

            string commandCol = String.Format("INSERT INTO reservacion({0}, {1}, {2}, {3}, {4})", col1, col2, col3, col4, col5);
            string commandValues = String.Format(" VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", reserva.Habitacion.Num_habitacion, reserva.Fecha_entrada.ToString("yyyy-MM-dd H:mm:ss"), reserva.Fecha_salida.ToString("yyyy-MM-dd H:mm:ss"), reserva.Detalles, reserva.Cliente.Cliente_id);
            string commandSQL = commandCol + commandValues;
            return conn.EjecutarComando(commandSQL);
        }
    }
}
