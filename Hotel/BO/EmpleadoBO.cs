using System;
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
        private string apellido;
        private string direccion;
        private string telefono;
        private string horario;

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

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
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
    }
}
