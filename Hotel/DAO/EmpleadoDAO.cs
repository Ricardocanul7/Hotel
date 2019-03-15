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
            string ComandoSQL = string.Format("INSERT INTO empleado (id_empleado, nombre, apellido_patern, apellido_matern, direccion, telefono, horario, tipo)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",empleado.Id_empleado, empleado.Nombre, empleado.Apellido_Petem, empleado.Apellido_Matem,empleado.Direccion, empleado.Telefono, empleado.Horario,empleado.Tipo);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("UPDATE empleado SET nombre='{1}', apellido_patern='{2}', apellido_matern='{3},' direccion='{4}', telefono='{5}', horario='{6}', tipo='{7}' WHERE id_empleado = {0} ", empleado.Id_empleado, empleado.Nombre, empleado.Apellido_Petem, empleado.Apellido_Matem, empleado.Direccion, empleado.Telefono, empleado.Horario, empleado.Tipo);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("DELETE FROM empleado WHERE id_empleado={0}", empleado.Id_empleado);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM empleado");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
    }
}
