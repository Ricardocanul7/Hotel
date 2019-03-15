using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class ClienteBO
    {
        private int cliente_id;
        private string cliente_nombre;
        private string cliente_apaterno;
        private string cliente_amaterno;
        private string cliente_direccion;
        private string cliente_email;
        private string cliente_telefono;


        public int Cliente_id
        {
            get { return cliente_id; }
            set { cliente_id = value; }
        }

        public string Cliente_nombre
        {
            get { return cliente_nombre; }
            set { cliente_nombre = value; }
        }

        public string Cliente_apaterno
        {
            get { return cliente_apaterno; }
            set { cliente_apaterno = value; }
        }

        public string Cliente_amaterno
        {
            get { return cliente_amaterno; }
            set { cliente_amaterno = value; }
        }

        public string Cliente_direccion
        {
            get { return cliente_direccion; }
            set { cliente_direccion = value; }
        }

        public string Cliente_email
        {
            get { return cliente_email; }
            set { cliente_email = value; }
        }

        public string Cliente_telefono
        {
            get { return cliente_telefono; }
            set { cliente_telefono = value; }
        }
    }
}
