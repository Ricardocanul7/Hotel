using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class HabitacionBO
    {
        private int num_habitacion;
        private string nombre_hab;
        private int max_adultos;
        private int max_ninios;
        private string tipo_hab;
        private double precioN;
        private double precioPA; //PA=persona adicional
        private double precioTA; //TA=temporada alta
        private double precioPATA; //PATA=persona adicional temporada alta
        private string descripHab;

        public int Num_habitacion
        {
            get { return num_habitacion; }
            set { num_habitacion = value; }
        }

        public string Nombre_hab
        {
            get { return nombre_hab; }
            set { nombre_hab = value; }
        }

        public int Max_adultos
        {
            get { return max_adultos; }
            set { max_adultos = value; }
        }

        public int Max_ninios
        {
            get { return max_ninios; }
            set { max_ninios = value; }
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

        public double PrecioPA //PA=persona adicional
        {
            get { return precioPA; }
            set { precioPA = value; }
        }

        public double PrecioTA //TA=temporada alta
        {
            get { return precioTA; }
            set { precioTA = value; }
        }

        public double PrecioPATA //PATA=persona adicional temporada alta
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
