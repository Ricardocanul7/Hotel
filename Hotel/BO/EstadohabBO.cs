using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class EstadohabBO
    {
        private int estado_id;
        private string nombre;

        public int Estado_id
        {
            get { return estado_id; }
            set { estado_id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
