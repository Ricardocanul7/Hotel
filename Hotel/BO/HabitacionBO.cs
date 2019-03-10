using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class HabitacionBO
    {
        private string nombre_hab;
        private int numx_per;
        private string tipo_hab;
        private double precioN;
        private double precioPA;
        private double precioTA;
        private double precioPATA;
        private string descripHab;

        public string Nombre_hab
        {
            get { return nombre_hab; }
            set { nombre_hab = value; }
        }

        public int Numx_per
        {
            get { return numx_per; }
            set { numx_per = value; }
        }

        public string Tipo_hab
        {
            get { return tipo_hab; }
            set { tipo_hab = value; }
        }

        public double PrecioN
        {
            get { return precioN; }
            set { precioN = value; }
        }

        public double PrecioPA
        {
            get { return precioPA; }
            set { precioPA = value; }
        }

        public double PrecioTA
        {
            get { return precioTA; }
            set { precioTA = value; }
        }

        public double PrecioPATA
        {
            get { return precioPATA; }
            set { precioPATA = value; }
        }

        public string DescripHab
        {
            get { return descripHab; }
            set { descripHab = value; }
        }
    }
}
