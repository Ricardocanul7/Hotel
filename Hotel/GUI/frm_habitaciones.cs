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

namespace Hotel.GUI
{
    public partial class frm_habitaciones : Form
    {
        HabitacionBO habitacionBO;
        public frm_habitaciones()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();

            cbo_tipohab.Items.Add("SELECCIONAR");
            cbo_tipohab.Items.Add("CABAÑA");
            cbo_tipohab.Items.Add("CABAÑA ST");
            cbo_tipohab.Items.Add("SUITE JAR");
            cbo_tipohab.Items.Add("SUITE LAG");
            cbo_tipohab.Items.Add("DUPLEX");
            cbo_tipohab.Items.Add("DUPLEX LAG");

            cbo_tipohab.SelectedIndex = 0;

        }

        private void btn_hab_guardar_Click(object sender, EventArgs e)
        {
            habitacionBO.Nombre_hab = txt_nombrehab.Text;
            habitacionBO.Numx_per = Convert.ToInt32(txt_numx_per.Text);
            habitacionBO.Tipo_hab = cbo_tipohab.Text;
            habitacionBO.PrecioN = Convert.ToDouble(txt_precioN.Text);
            habitacionBO.PrecioPA = Convert.ToDouble(txt_precioPA.Text);
            habitacionBO.PrecioTA = Convert.ToDouble(txt_precioTA.Text);
            habitacionBO.PrecioPATA = Convert.ToDouble(txt_precioPATA.Text);
            habitacionBO.DescripHab = txt_descripHab.Text;
        }

        private void btn_hab_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombrehab.Clear();
            txt_numx_per.Clear();
            cbo_tipohab.SelectedIndex = 0;
            txt_precioN.Clear();
            txt_precioPA.Clear();
            txt_precioTA.Clear();
            txt_precioPATA.Clear();
            txt_descripHab.Clear();
        }
    }
}
