using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class HabitacionDAO
    {

        Conexion conexion;

        public HabitacionDAO()
        {
            conexion = new Conexion();
        }

        public int Agregar(HabitacionBO habitacionBO)
        {
            string ComandoSQL = string.Format("INSERT INTO  habitacion(nombre, max_ninios, max_adultos, precio_baja, " +
                "tipo_hab, descripcion, estado_hab)VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"
                , habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos, 
                habitacionBO.PrecioN, habitacionBO.Tipo.Tipo_id,
                habitacionBO.DescripHab, habitacionBO.Estado.Estado_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(HabitacionBO habitacionBO)
        {
            string ComandoSQL = string.Format("UPDATE habitacion SET nombre='{1}', max_ninios='{2}', max_adultos='{3}', " +
                "precio_baja='{4}', tipo_hab='{5}', descripcion='{6}', estado_hab='{7}'  WHERE num_habitacion={0}",
                habitacionBO.Num_habitacion, habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos,
                habitacionBO.PrecioN, habitacionBO.Tipo.Tipo_id, habitacionBO.DescripHab, habitacionBO.Estado.Estado_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int ModificarEstado(int num_habitacion, int estado)
        {
            string comandSQL = string.Format("UPDATE habitacion SET estado_hab = '{0}' WHERE num_habitacion = {1}", estado, num_habitacion.ToString());
            return conexion.EjecutarComando(comandSQL);
        }

        public int Eliminar(HabitacionBO habitacionBO)
        {
            string ComandoSQL = string.Format("DELETE FROM habitacion WHERE num_habitacion={0}", habitacionBO.Num_habitacion);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public DataTable Buscar()
        {
            //string ComandoSQL = string.Format("SELECT * FROM habitacion");
            //return conexion.EjecutarSentencia(ComandoSQL);
            string col0 = "num_habitacion";
            string col1 = "nombre";
            //string col2 = "max_ninios";
            //string col3 = "max_adultos";
            string col2 = "precio_baja";
            string col3 = "nombre_tipo";
            string col4 = "descripcion";
            string col5 = "estado";

            string selectSQL = String.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5} ", col0, col1, col2, col3, col4,  col5);
            string fromSQL = "FROM habitacion as a, tipo_habitacion as b, estado_habitacion as c WHERE a.tipo_hab=b.tipo_id and a.estado_hab=c.estado_id";
            string commandSQL = selectSQL + fromSQL;
            return conexion.EjecutarSentencia(commandSQL);
        }

        public DataTable BuscarTipoHabitacion()
        {
            string commandSQL = "SELECT * from tipo_habitacion";
            return conexion.EjecutarSentencia(commandSQL);
        }

        public DataTable BuscarEstadoHabitacion()
        {
            string commandSQL = "SELECT * from estado_habitacion";
            return conexion.EjecutarSentencia(commandSQL);
        }

        public HabitacionBO Buscar(int numeroHab)
        {
            string commandSQL = String.Format("SELECT * FROM habitacion WHERE num_habitacion={0}", numeroHab);
            DataTable table = conexion.EjecutarSentencia(commandSQL);

            if (table.Rows.Count > 0)
            {
                DataRowCollection row = table.Rows;

                HabitacionBO habitacionBO = new HabitacionBO();
                habitacionBO.Tipo = new TipohabBO();
                habitacionBO.Estado = new EstadohabBO();

                habitacionBO.Num_habitacion = Convert.ToInt32(row[0]["num_habitacion"]);
                habitacionBO.Nombre_hab = row[0]["nombre"].ToString();
                habitacionBO.Max_ninios = Convert.ToInt32(row[0]["max_ninios"]);
                habitacionBO.Max_adultos = Convert.ToInt32(row[0]["max_adultos"]);
                habitacionBO.PrecioN = Convert.ToDouble(row[0]["precio_baja"]);
                habitacionBO.Tipo.Nombre = row[0]["tipo_hab"].ToString();
                habitacionBO.DescripHab = row[0]["descripcion"].ToString();
                habitacionBO.Estado.Nombre = row[0]["estado_hab"].ToString();

                return habitacionBO;
            }
            else
            {
                return null;
            }
        }
    }
}
