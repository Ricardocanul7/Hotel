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
    public partial class frm_habitaciones : MetroFramework.Forms.MetroForm
    {
        HabitacionBO habitacionBO;
        HabitacionDAO habitacionDAO;
        public frm_habitaciones()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionDAO = new HabitacionDAO();

            Set_cbo_tipo_habitacion();
        }

        private void Set_cbo_tipo_habitacion()
        {
            DataRow[] rows = habitacionDAO.BuscarTipoHabitacion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_tipohab.Items.Add(rows[i][0]);
            }

            cbo_tipohab.SelectedIndex = 0;
        }

        private void btn_hab_guardar_Click(object sender, EventArgs e)
        {
            if (habitacionDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Registro Agregado");
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private HabitacionBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_num_habitacion.Text, out id);

            habitacionBO.Num_habitacion = id;
            habitacionBO.Nombre_hab = txt_nombrehab.Text;
            habitacionBO.Max_adultos = Convert.ToInt32(txt_max_adultos.Text);
            habitacionBO.Max_ninios = Convert.ToInt32(txt_max_ninios.Text);
            habitacionBO.Tipo_hab = cbo_tipohab.Text;
            habitacionBO.PrecioN = Convert.ToDouble(txt_precioN.Text);
            habitacionBO.PrecioPA = Convert.ToDouble(txt_precioPA.Text);
            habitacionBO.PrecioTA = Convert.ToDouble(txt_precioTA.Text);
            habitacionBO.PrecioPATA = Convert.ToDouble(txt_precioPATA.Text);
            habitacionBO.DescripHab = txt_descripHab.Text;

            return habitacionBO;
        }

        private void btn_hab_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombrehab.Clear();
            txt_max_adultos.Clear();
            txt_max_ninios.Clear();
            cbo_tipohab.SelectedIndex = 0;
            txt_precioN.Clear();
            txt_precioPA.Clear();
            txt_precioTA.Clear();
            txt_precioPATA.Clear();
            txt_descripHab.Clear();
        }
    }
}
