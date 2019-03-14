using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;


namespace Hotel.DAO
{
    class EmpleadoDAO
    {
        Conexion Miconexion;

        public EmpleadoDAO()
        {
            Miconexion = new Conexion();
        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */

        public int Agregar(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("INSERT INTO empleado (id_empleado, nombre, apellido_patern, apellido_matern, direccion, telefono, horario, tipo)VALUES('12','aaron','herrera','gonzalez','calle','9995343467','8am-4pm','recepsionista');",empleado.Id_empleado, empleado.Nombre, empleado.Apellido_Petem, empleado.Apellido_Matem,empleado.Direccion, empleado.Telefono, empleado.Horario,empleado.Tipo);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public bool Modificar(EmpleadoBO empleado)
        {
            return true;
        }

        public bool Eliminar()
        {
            return true;
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM empleado");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
    }
}
