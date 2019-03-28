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
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        HabitacionDAO habitacionDAO = new HabitacionDAO();
        LimpiezaBO limpiezaBO;
        LimpiezaDAO limpiezaDAO;

        bool Limpieza_mod = false;

        public frm_agregar_limpieza()
        {
            InitializeComponent();

            limpiezaBO = new LimpiezaBO();
            limpiezaDAO = new LimpiezaDAO();
            limpiezaBO.Empleado = new EmpleadoBO();
            limpiezaBO.Habitacion = new HabitacionBO();

            txt_id_limpieza.Enabled = false;
            Set_cbo_empleado();
            Set_cbo_habitacion();
        }

        private void Set_cbo_empleado()
        {
            DataRow[] rows = empleadoDAO.Buscar().Select();

            if (rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    string text = rows[i]["empleado_id"].ToString() + "-" + rows[i]["nombre"].ToString() + " " + rows[i]["apellido_patern"].ToString();
                    cbo_empleado.Items.Add(text);
                }
                cbo_empleado.SelectedIndex = 0;
            }

        }
        public void Set_cbo_habitacion()
        {
            DataRow[] rows = habitacionDAO.Buscar().Select();

            for (int i = 0; i < rows.Length; i++)
            {
                if ((string)rows[i]["estado"] == "Disponible")
                {
                    cbo_num_habitacion.Items.Add(rows[i][0] + "-" + rows[i][1]);
                }

            }
        }

        private LimpiezaBO RecuperarInformacion()
        {
            LimpiezaBO limpiezaBO = new LimpiezaBO();
            limpiezaBO.Empleado = new EmpleadoBO();
            limpiezaBO.Habitacion = new HabitacionBO();

            if (Limpieza_mod == true)
            {
                 limpiezaBO.Limpieza_id = Convert.ToInt32(txt_id_limpieza.Text);
            }

            limpiezaBO.Fecha_limpieza = dtp_fecha_limpieza.Value;
            int id_habitacion = Convert.ToInt32(cbo_num_habitacion.SelectedItem.ToString().Split('-')[0]);
            limpiezaBO.Habitacion.Num_habitacion = Convert.ToInt32(id_habitacion);
            string empleado_id = cbo_empleado.SelectedItem.ToString().Split('-')[0];
            DataRow[] tipoRow = empleadoDAO.Buscar().Select(String.Format("empleado_id = {0}", empleado_id));
            limpiezaBO.Empleado.Id_empleado = Convert.ToInt32(tipoRow[0]["empleado_id"]);

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
