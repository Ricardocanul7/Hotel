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
            string ComandoSQL = string.Format("INSERT INTO empleado (nombre, apellido_patern, apellido_matern, direccion, telefono, horario, sueldo, puesto_id)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}', {7});", empleado.Nombre, empleado.Apellido_Petem, empleado.Apellido_Matem,empleado.Direccion, empleado.Telefono, empleado.Horario,empleado.Sueldo, empleado.Puesto_id);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("UPDATE empleado SET nombre='{1}', apellido_patern='{2}', apellido_matern='{3}', direccion='{4}', telefono='{5}', horario='{6}', sueldo='{7}', puesto_id='{8}' WHERE empleado_id = {0} ", empleado.Id_empleado, empleado.Nombre, empleado.Apellido_Petem, empleado.Apellido_Matem, empleado.Direccion, empleado.Telefono, empleado.Horario, empleado.Sueldo, empleado.Puesto_id);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("DELETE FROM empleado WHERE empleado_id ={0}", empleado.Id_empleado);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT empleado_id, nombre, apellido_patern, apellido_matern, direccion, " +
                "telefono, horario, sueldo, puesto FROM empleado, puesto_empleado WHERE empleado.puesto_id = puesto_empleado.puesto_id");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }

        public DataTable PuestoEmpleado()
        {
            string ComandoSQL = "SELECT * FROM puesto_empleado";
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }

        public int Agregar_Puesto(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("INSERT INTO puesto_empleado (puesto) VALUES ('{0}')", empleado.Puesto);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar_Puesto(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("UPDATE puesto_empleado SET puesto = '{1}' WHERE puesto_id = '{0}'", empleado.Puesto_id, empleado.Puesto);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar_Puesto(EmpleadoBO empleado)
        {
            string ComandoSQL = string.Format("DELETE FROM puesto_empleado WHERE puesto_id = '{0}'", empleado.Puesto_id);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar_Puesto()
        {
            string ComandoSQL = string.Format("SELECT * FROM puesto_empleado");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }
    }
}
