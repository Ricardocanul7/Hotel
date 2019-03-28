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
        EmpresaDAO empresaDAO = new EmpresaDAO();

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
    }
}
