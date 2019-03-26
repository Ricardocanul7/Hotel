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
            string ComandoSQL = string.Format("INSERT INTO  habitacion(nombre, max_ninios, max_adultos, precio_alta, precio_baja, " +
                "precio_adic_alta, precio_adic_baja, tipo_hab, descripcion, estado_hab)VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', " +
                "'{7}', '{8}', '{9}');"
                , habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos, 
                habitacionBO.PrecioTA, habitacionBO.PrecioN, habitacionBO.PrecioPATA, habitacionBO.PrecioPA, habitacionBO.Tipo.Tipo_id,
                habitacionBO.DescripHab, habitacionBO.Estado.Estado_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(HabitacionBO habitacionBO)
        {
            string ComandoSQL = string.Format("UPDATE habitacion SET nombre='{1}', max_ninios='{2}', max_adultos='{3}', precio_alta='{4}', " +
                "precio_baja='{5}', precio_adic_alta='{6}', precio_adic_baja='{7}', tipo_hab='{8}', descripcion='{9}', estado_hab='{10}'  WHERE num_habitacion={0}",
                habitacionBO.Num_habitacion, habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos, habitacionBO.PrecioTA,
                habitacionBO.PrecioN, habitacionBO.PrecioPATA, habitacionBO.PrecioPA, habitacionBO.Tipo.Tipo_id, habitacionBO.DescripHab, habitacionBO.Estado.Estado_id);
            return conexion.EjecutarComando(ComandoSQL);
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
            string col2 = "max_ninios";
            string col3 = "max_adultos";
            string col4 = "precio_alta";
            string col5 = "precio_baja";
            string col6 = "precio_adic_alta";
            string col7 = "precio_adic_baja";
            string col8 = "nombre_tipo";
            string col9 = "descripcion";
            string col10 = "estado";

            string selectSQL = String.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} ", col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10);
            string fromSQL = "FROM habitacion as a, tipo_habitacion as b, estado_habitacion as c where a.tipo_hab=b.tipo_id and a.estado_hab=c.estado_id";
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
                habitacionBO.PrecioTA = Convert.ToDouble(row[0]["precio_alta"]);
                habitacionBO.PrecioN = Convert.ToDouble(row[0]["precio_baja"]);
                habitacionBO.PrecioPATA = Convert.ToDouble(row[0]["precio_adic_alta"]);
                habitacionBO.PrecioPA = Convert.ToDouble(row[0]["precio_adic_baja"]);
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
