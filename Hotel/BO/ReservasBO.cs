using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class ReservasBO
    {
        private string nombre_hab;
        private string tipo_hab;
        private int numx_per;
        private int id_cliente;
        private string nom_cliente;
        private string apell_cliente;
        private string dir_cliente;
        private string email;
        private string tel_cliente;
        private string fecha_ent;
        private string fecha_sal;
        private string det_reserva;


        public string Nombre_hab
        {
            get { return nombre_hab; }
            set { nombre_hab = value; }
        }

        public string Tipo_hab
        {
            get { return tipo_hab; }
            set { tipo_hab = value; }
        }

        public int Numx_per
        {
            get { return numx_per; }
            set { numx_per = value; }
        }

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public string Nom_cliente
        {
            get { return nom_cliente; }
            set { nom_cliente = value; }
        }

        public string Apell_cliente
        {
            get { return apell_cliente; }
            set { apell_cliente = value; }
        }

        public string Dir_cliente
        {
            get { return dir_cliente; }
            set { dir_cliente = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Tel_cliente
        {
            get { return tel_cliente; }
            set { tel_cliente = value; }
        }

        public string Fecha_ent
        {
            get { return fecha_ent; }
            set { fecha_ent = value; }
        }

        public string Fecha_sal
        {
            get { return fecha_sal; }
            set { fecha_sal = value; }
        }

        public string Det_reserva
        {
            get { return det_reserva; }
            set { det_reserva = value; }
        }
    }
}
