using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class LimpiezaBO
    {
        private int limpieza_id;
        private DateTime fecha_limpieza;
        private EmpleadoBO empleado;
        private HabitacionBO habitacion;

        public int Limpieza_id
        {
            get { return limpieza_id; }
            set { limpieza_id = value; }
        }

        public DateTime Fecha_limpieza
        {
            get { return fecha_limpieza; }
            set { fecha_limpieza = value; }
        }
        public EmpleadoBO Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }
        public HabitacionBO Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }
    }
}
