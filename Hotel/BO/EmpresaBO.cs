using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class EmpresaBO
    {
        private string nombre;
        private string rfc;
        private int precio_hora;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public int Precio_hora
        {
            get { return precio_hora; }
            set { precio_hora = value; }
        }
    }
}
