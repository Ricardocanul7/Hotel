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
    }
}
