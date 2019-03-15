﻿using Hotel.BO;
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
            string commandSQL = String.Format("INSERT INTO reservacion(num_habitacion, fecha_entrada, fecha_salida, detalles, cliente) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", reserva.Habitacion.Num_habitacion, reserva.Fecha_entrada.ToString("yyyy-MM-dd H:mm:ss"), reserva.Fecha_salida.ToString("yyyy-MM-dd H:mm:ss"), reserva.Detalles, reserva.Cliente.Cliente_id);
            return conn.EjecutarComando(commandSQL);
        }
    }
}
