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
        HabitacionBO habitacionBO_mod = null;
        HabitacionDAO habitacionDAO;
        public DataGridView data;

        internal HabitacionBO SetObjectHabitacionBO { get; set; }

        public frm_habitaciones()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionBO.Tipo = new TipohabBO();
            habitacionBO.Estado = new EstadohabBO();
            habitacionDAO = new HabitacionDAO();

            Set_cbo_tipo_habitacion();
            Set_cbo_estado_habitacion();
        }

        public void Add_habitacion_mod(int numeroHab)
        {
            habitacionBO_mod = habitacionDAO.Buscar(numeroHab);
            btn_guardar.Text = "Modificar";
            habitacionBO.Num_habitacion = numeroHab;

            for (int i = 0; i < cbo_estadohab.Items.Count; i++)
            {
                if (cbo_estadohab.Items[i].ToString().Split('-')[0] == habitacionBO_mod.Tipo.Tipo_id.ToString())
                    cbo_estadohab.SelectedIndex = i;
            }
            for (int i = 0; i < cbo_tipohab.Items.Count; i++)
            {
                if (cbo_tipohab.Items[i].ToString().Split('-')[0] == habitacionBO_mod.Estado.Estado_id.ToString())
                    cbo_tipohab.SelectedIndex = i;
            }

            txt_num_habitacion.Text = habitacionBO_mod.Num_habitacion.ToString();
            txt_nombrehab.Text = habitacionBO_mod.Nombre_hab;
            txt_max_ninios.Text = habitacionBO_mod.Max_ninios.ToString();
            txt_max_adultos.Text = habitacionBO_mod.Max_adultos.ToString();
            txt_precioN.Text = habitacionBO_mod.PrecioN.ToString();
            txt_precioPA.Text = habitacionBO_mod.PrecioPA.ToString();
            txt_precioTA.Text = habitacionBO_mod.PrecioTA.ToString();
            txt_precioPATA.Text = habitacionBO_mod.PrecioPATA.ToString();
            txt_descripHab.Text = habitacionBO_mod.DescripHab;
            
        }

        private void Set_cbo_tipo_habitacion()
        {
            DataRow[] rows = habitacionDAO.BuscarTipoHabitacion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_tipohab.Items.Add(rows[i]["nombre_tipo"]);
            }

            cbo_tipohab.SelectedIndex = 0;
        }

        private void Set_cbo_estado_habitacion()
        {
            DataRow[] rows = habitacionDAO.BuscarEstadoHabitacion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_estadohab.Items.Add(rows[i]["estado"]);
            }

            cbo_estadohab.SelectedIndex = 0;
        }

        private HabitacionBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_num_habitacion.Text, out id);

            habitacionBO.Num_habitacion = id;
            habitacionBO.Nombre_hab = txt_nombrehab.Text;
            habitacionBO.Max_adultos = Convert.ToInt32(txt_max_adultos.Text);
            habitacionBO.Max_ninios = Convert.ToInt32(txt_max_ninios.Text);
            habitacionBO.Tipo.Tipo_id = cbo_tipohab.SelectedIndex+1;
            habitacionBO.Estado.Estado_id = cbo_estadohab.SelectedIndex+1;
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
            cbo_estadohab.SelectedIndex = 0;
            txt_precioN.Clear();
            txt_precioPA.Clear();
            txt_precioTA.Clear();
            txt_precioPATA.Clear();
            txt_descripHab.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (habitacionBO_mod != null)
            {
                if (habitacionDAO.Modificar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado la habitación");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al modificar la habitación!");
                }

            }
            else
            {
                if (habitacionDAO.Agregar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha registrado la habitación");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al registrar la habitación!");
                }
            }
        }
    }
}
