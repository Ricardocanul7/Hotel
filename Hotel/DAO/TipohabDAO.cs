﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class TipohabDAO
    {
        Conexion conexion;
        public TipohabDAO()
        {
            conexion = new Conexion();
        }

        public int Agregar(TipohabBO tipohabBO)
        {
            string ComandoSQL = string.Format("INSERT INTO  tipo_habitacion(nombre_tipo)VALUES('{0}');",tipohabBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(TipohabBO tipohabBO)
        {
            string ComandoSQL = string.Format("UPDATE tipo_habitacion SET nombre_tipo='{1}' WHERE tipo_id={0}", tipohabBO.Tipo_id, tipohabBO.Nombre);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Eliminar(TipohabBO tipohabBO)
        {
            string ComandoSQL = string.Format("DELETE FROM tipo_habitacion WHERE tipo_id={0}", tipohabBO.Tipo_id);
            return conexion.EjecutarComando(ComandoSQL);
        }

        public DataTable Buscar()
        {
            string commandSQL = "SELECT * from tipo_habitacion";
            return conexion.EjecutarSentencia(commandSQL);
        }
    }
}
