using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class ReservasBO
    {
        private int folio_reserva;
        private HabitacionBO habitacion;
        private DateTime fecha_entrada;
        private DateTime fecha_salida;
        private string detalles;
        private ClienteBO cliente;

        public int Folio_reserva {
            get { return folio_reserva; }
            set { folio_reserva = value; }
        }

        public HabitacionBO Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

        public DateTime Fecha_entrada
        {
            get { return fecha_entrada; }
            set { fecha_entrada = value; }
        }

        public DateTime Fecha_salida
        {
            get { return fecha_salida; }
            set { fecha_salida = value; }
        }

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        public ClienteBO Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}
