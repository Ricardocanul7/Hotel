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
            string col6 = "estado_pagado";

            string commandCol = String.Format("INSERT INTO reservacion({0}, {1}, {2}, {3}, {4}, {5})", col1, col2, col3, col4, col5, col6);
            string commandValues = String.Format(" VALUES( {0}, '{1}', '{2}', '{3}', {4}, {5});", reserva.Habitacion.Num_habitacion, reserva.Fecha_entrada.ToString("yyyy-MM-dd H:mm:ss"), reserva.Fecha_salida.ToString("yyyy-MM-dd H:mm:ss"), reserva.Detalles, reserva.Cliente.Cliente_id, reserva.Estado);
            string commandSQL = commandCol + commandValues;
            return conn.EjecutarComando(commandSQL);
        }

        public int Modificar(ReservasBO reserva)
        {
            string commandSQL = string.Format("UPDATE reservacion SET num_habitacion={0}, fecha_entrada='{1}', fecha_salida='{2}', detalles='{3}', estado_pagado={4}, cliente_id={5} WHERE folio_reserva={6}", 
                reserva.Habitacion.Num_habitacion, 
                reserva.Fecha_entrada.ToString("yyyy-MM-dd"), 
                reserva.Fecha_salida.ToString("yyyy-MM-dd"), 
                reserva.Detalles,
                Convert.ToInt16(reserva.Estado), 
                reserva.Cliente.Cliente_id, 
                reserva.Folio_reserva);
            return conn.EjecutarComando(commandSQL);
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
            string col11 = "estado_pagado";


            string selectSQL = String.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11} ", col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11);
            string fromSQL = "FROM reservacion as a, cliente as b where a.cliente_id=b.cliente_id";
            string commandSQL = selectSQL + fromSQL;
            return conn.EjecutarSentencia(commandSQL);
        }

        public ReservasBO Buscar(int folio_reserva)
        {
            string commandSQL = String.Format("SELECT * FROM reservacion WHERE folio_reserva={0}", folio_reserva);
            DataTable table = conn.EjecutarSentencia(commandSQL);

            if(table.Rows.Count > 0)
            {
                DataRowCollection row = table.Rows;
                ReservasBO reserva = new ReservasBO();
                reserva.Habitacion = new HabitacionBO();
                reserva.Cliente = new ClienteBO();

                reserva.Folio_reserva = Convert.ToInt32(row[0]["folio_reserva"]);
                reserva.Fecha_salida = DateTime.Parse(row[0]["fecha_salida"].ToString());
                reserva.Fecha_entrada = DateTime.Parse(row[0]["fecha_entrada"].ToString());
                reserva.Habitacion.Num_habitacion = Convert.ToInt32(row[0]["num_habitacion"]);
                reserva.Detalles = row[0]["detalles"].ToString();
                reserva.Cliente.Cliente_id = Convert.ToInt32(row[0]["cliente_id"]);
                reserva.Estado = Convert.ToBoolean(row[0]["estado_pagado"]);

                return reserva;
            }
            else
            {
                return null;
            }
        }

        public int PagarReserva(int folio)
        {
            string commandSQL = String.Format("UPDATE reservacion SET estado_pagado = {1} WHERE folio_reserva = {0}", folio, 1);
            return conn.EjecutarComando(commandSQL);
        }
    }
}
