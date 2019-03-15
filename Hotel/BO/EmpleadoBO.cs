﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class EmpleadoBO
    {
        private int id_empleado;
        private string nombre;
        private string apellido_patem;
        private string apellido_matem;
        private string direccion;
        private string telefono;
        private string horario;
        private string tipo;

        public int Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido_Petem
        {
            get { return apellido_patem; }
            set { apellido_patem = value; }
        }

        public string Apellido_Matem
        {
            get { return apellido_matem; }
            set { apellido_matem = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
