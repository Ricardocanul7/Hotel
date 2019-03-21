using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class CajaBO
    {
        private int corte_id;
        private double monto;
        private DateTime fecha;
        private DateTime hora;
        private UsuarioBO usuario;

        public int Corte_id
        {
            get { return corte_id; }
            set { corte_id = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public UsuarioBO Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
