using Hotel.BO;
using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.GUI
{
    public partial class frm_agregar_mantenimiento : MetroFramework.Forms.MetroForm
    {
        HabitacionDAO habitacionDAO = new HabitacionDAO();
        MantenimientoDAO mantenimientoDAO = new MantenimientoDAO();
        EmpresaDAO empresaDAO = new EmpresaDAO();
        bool Mantenimiento_mod = false;

        public frm_agregar_mantenimiento()
        {
            InitializeComponent();

            Set_cbo_habitacion();
            Set_cbo_empresa();
        }

        public void Set_cbo_habitacion()
        {
            DataRow[] rows = habitacionDAO.Buscar().Select();

            if(rows.Length > 0)
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    if ((string)rows[i]["estado"] == "Disponible")
                    {
                        cbo_num_habitacion.Items.Add(rows[i][0] + "-" + rows[i][1]);
                    }
                }
                cbo_num_habitacion.SelectedIndex = 0;
            }
            
        }

        public void Set_cbo_empresa()
        {
            DataRow[] rows = empresaDAO.Buscar().Select();

            if(rows.Length > 0)
            {
                for(int i = 0; i < rows.Length; i++)
                {
                    cbo_empresa.Items.Add(rows[i]["nombre"].ToString());
                }
                cbo_empresa.SelectedIndex = 0;
            }
        }

        private MantenimientoBO RecuperarInformacion()
        {
            MantenimientoBO mantenimientoBO = new MantenimientoBO();
            mantenimientoBO.Habitacion = new HabitacionBO();
            mantenimientoBO.Empresa = new EmpresaBO();

            if (Mantenimiento_mod == true)
            {
                mantenimientoBO.Mantenimiento_id = Convert.ToInt32(txt_id_mantenimiento.Text);
            }

            mantenimientoBO.Fecha_mantenimiento = dtp_fecha_mantenimiento.Value;
            int id_habitacion = Convert.ToInt32(cbo_num_habitacion.SelectedItem.ToString().Split('-')[0]);
            mantenimientoBO.Habitacion.Num_habitacion = Convert.ToInt32(id_habitacion);

            DataRow[] rowsEmp = empresaDAO.Buscar().Select(String.Format("nombre = '{0}'", cbo_empresa.Text));
            mantenimientoBO.Empresa.RFC = rowsEmp[0]["rfc_proveedor"].ToString();


            return mantenimientoBO;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Mantenimiento_mod == false)
            {
                if (mantenimientoDAO.Agregar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se programado un mantenimiento");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
            else
            {
                if (mantenimientoDAO.Modificar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado el registro de mantenimiento");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
        }
    }
}
