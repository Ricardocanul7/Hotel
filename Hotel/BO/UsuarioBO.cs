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
        protected string email;
        protected string password;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
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
