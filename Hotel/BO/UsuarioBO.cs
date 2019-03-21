using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class UsuarioBO
    {
        private int id_usuario;
        private int tipo_usuario;
        private string nombre;
        private string apaterno;
        private string amaterno;
        protected string email;
        protected string password;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public int Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }

        public string Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
