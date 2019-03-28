using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.BO;
using Hotel.DAO;

namespace Hotel.GUI
{
    public partial class frm_agregar_limpieza : MetroFramework.Forms.MetroForm
    {
        EmpleadoBO empleadoBO = new EmpleadoBO();
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        HabitacionBO habitacionBO = new HabitacionBO();
        HabitacionDAO habitacionDAO = new HabitacionDAO();
        LimpiezaBO limpiezaBO = new LimpiezaBO();
        LimpiezaDAO limpiezaDAO = new LimpiezaDAO();

        bool Limpieza_mod = false;

        public frm_agregar_limpieza()
        {

            InitializeComponent();

            txt_id_limpieza.Enabled = false;
            Set_cbo_puesto();
            Set_cbo_habitacion();
        }
        public void Set_cbo_puesto()
        {
            DataRow[] rows = empleadoDAO.PuestoEmpleado().Select();
            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    cbo_empleado.Items.Add(rows[i][1]);
                }

                cbo_empleado.SelectedIndex = 0;
            }

        }
        public void Set_cbo_habitacion()
        {
            DataRow[] rows = habitacionDAO.Buscar().Select();

            for (int i = 0; i < rows.Length; i++)
            {
                if ((string)rows[i][10] == "Disponible")
                {
                    cbo_num_habitacion.Items.Add(rows[i][0] + "-" + rows[i][1]);
                }

            }
        }
        internal LimpiezaBO RecuperarInformacion()
        {
            EmpleadoBO empleadoBO = new EmpleadoBO();
            EmpleadoDAO empleadoDAO = new EmpleadoDAO();
            HabitacionBO habitacionBO = new HabitacionBO();
            HabitacionDAO habitacionDAO = new HabitacionDAO();
            LimpiezaBO limpiezaBO = new LimpiezaBO();

            if (Limpieza_mod == true)
            {
                 limpiezaBO.Limpieza_id= Convert.ToInt32(txt_id_limpieza.Text);
            }

            limpiezaBO.Fecha_limpieza = dtp_fecha_limpieza.MinDate;

            int id_habitacion = Convert.ToInt32(cbo_num_habitacion.SelectedItem.ToString().Split('-')[0]);

            habitacionBO.Num_habitacion = Convert.ToInt32(id_habitacion);

            DataRow[] tipoRow = empleadoDAO.PuestoEmpleado().Select(String.Format("puesto = '{0}'", cbo_empleado.Text));

            empleadoBO.Puesto_id = Convert.ToInt32(tipoRow[0]["puesto_id"]);

            return limpiezaBO;
        }

        private void Guardar_Limpieza(object sender, EventArgs e)
        {
            if (Limpieza_mod == false)
            {
                if (limpiezaDAO.Agregar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha Agregado el Empleado");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
            else
            {
                if (limpiezaDAO.Modificar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado el Empleado");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
        }
    }
}
