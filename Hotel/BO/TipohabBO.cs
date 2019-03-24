using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class TipohabBO
    {
        private int tipo_id;
        private string nombre;

        public int Tipo_id
        {
            get { return tipo_id; }
            set { tipo_id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
