﻿using System;
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
                "precio_adic_alta, precio_adic_baja, tipo, descripcion, estado)VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', " +
                "'{7}', '{8}', '{9}');"
                , habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos, 
                habitacionBO.PrecioTA, habitacionBO.PrecioN, habitacionBO.PrecioPATA, habitacionBO.PrecioPA, habitacionBO.Tipo_hab,
                habitacionBO.DescripHab, 'D');
            return conexion.EjecutarComando(ComandoSQL);
        }

        public int Modificar(HabitacionBO habitacionBO)
        {
            string ComandoSQL = string.Format("UPDATE habitacion SET nombre='{1}', max_ninios='{2}', max_adultos='{3}', precio_alta='{4}', " +
                "precio_baja='{5}', precio_adic_alta='{6}', precio_adic_baja='{7}', tipo='{8}', descripcion='{9}', estado='{10}'  WHERE num_habitacion={0}",
                habitacionBO.Num_habitacion, habitacionBO.Nombre_hab, habitacionBO.Max_ninios, habitacionBO.Max_adultos, habitacionBO.PrecioTA,
                habitacionBO.PrecioN, habitacionBO.PrecioPATA, habitacionBO.PrecioPA, habitacionBO.Tipo_hab, habitacionBO.DescripHab, 'M');
            return conexion.EjecutarComando(ComandoSQL);
        }

        public bool Eliminar()
        {
            return true;
        }

        public bool Buscar()
        {
            return true;
        }
    }
}
