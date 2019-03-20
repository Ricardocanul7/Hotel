using Hotel.BO;
using System;
using System.Collections.Generic;
using System.Data;
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
            string col5 = "cliente_id";

            string commandCol = String.Format("INSERT INTO reservacion({0}, {1}, {2}, {3}, {4})", col1, col2, col3, col4, col5);
            string commandValues = String.Format(" VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", reserva.Habitacion.Num_habitacion, reserva.Fecha_entrada.ToString("yyyy-MM-dd H:mm:ss"), reserva.Fecha_salida.ToString("yyyy-MM-dd H:mm:ss"), reserva.Detalles, reserva.Cliente.Cliente_id);
            string commandSQL = commandCol + commandValues;
            return conn.EjecutarComando(commandSQL);
        }

        public int Modificar()
        {
            return 0;
        }

        public int Eliminar(ReservasBO reservaBO)
        {
            string commandSQL = String.Format("DELETE FROM reservacion WHERE folio_reserva={0}", reservaBO.Folio_reserva);
            return conn.EjecutarComando(commandSQL);
        }

        public DataTable Buscar()
        {
            string col0 = "folio_reserva";
            string col1 = "num_habitacion";
            string col2 = "fecha_entrada";
            string col3 = "fecha_salida";
            string col4 = "detalles";
            string col5 = "nombre";
            string col6 = "apaterno";
            string col7 = "amaterno";
            string col8 = "direccion";
            string col9 = "email";
            string col10 = "telefono";
    

            string selectSQL = String.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} ", col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10);
            string fromSQL = "FROM reservacion as a, cliente as b where a.cliente_id=b.cliente_id";
            string commandSQL = selectSQL + fromSQL;
            return conn.EjecutarSentencia(commandSQL);
        }
    }
}
