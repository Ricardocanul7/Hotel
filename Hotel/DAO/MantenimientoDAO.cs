using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class MantenimientoDAO
    {
        Conexion Miconexion;

        public MantenimientoDAO()
        {
            Miconexion = new Conexion();
        }
        public int Agregar(MantenimientoBO mantenimiento)
        {
            string ComandoSQL = string.Format("INSERT INTO mantenimiento (fecha, proveedor_rfc, num_habitacion) VALUES('{0}', '{1}', '{2}')", mantenimiento.Fecha_mantenimiento.ToString("yyyy-MM-dd H:mm:ss"), mantenimiento.Empresa.RFC, mantenimiento.Habitacion.Num_habitacion);
            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(MantenimientoBO mantenimiento)
        {
            string ComandoSQL = string.Format("UPDATE mantenimiento SET fecha={0}, proveedor_rfc='{1}', num_habitacion='{2}' WHERE mantenimiento_id= {3}",
                mantenimiento.Fecha_mantenimiento.ToString("yyyy-MM-dd"),
                mantenimiento.Empresa.RFC,
                mantenimiento.Habitacion.Num_habitacion,
                mantenimiento.Mantenimiento_id);

            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(MantenimientoBO mantenimiento)
        {
            string ComandoSQL = string.Format("DELETE FROM mantenimiento WHERE mantenimiento_id ={0}", mantenimiento.Mantenimiento_id);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT limpieza_id, fecha, empleado_id, num_habitacion WHERE limpieza.limpieza_id = empleado.empleado_id, limpieza.limpieza.id = habitaciones.num_habitacion");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }
    }
}
