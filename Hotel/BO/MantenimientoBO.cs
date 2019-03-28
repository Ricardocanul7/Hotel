using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;

namespace Hotel.BO
{
    class MantenimientoBO
    {
        private int mantenimiento_id;
        private DateTime fecha_mantenimiento;
        private EmpresaBO empresa;
        private HabitacionBO habitacion;

        public int Mantenimiento_id
        {
            get { return mantenimiento_id; }
            set { mantenimiento_id = value; }
        }

        public DateTime Fecha_mantenimiento
        {
            get { return fecha_mantenimiento; }
            set { fecha_mantenimiento = value; }
        }
        public EmpresaBO Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public HabitacionBO Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }
    }
}
