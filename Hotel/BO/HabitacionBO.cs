using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class HabitacionBO
    {
        private int num_habitacion;
        private string estado;

        public int Num_habitacion
        {
            get { return num_habitacion; }
            set { num_habitacion = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


    }
}
