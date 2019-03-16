using Hotel.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAO;
using Hotel.BO;

namespace Hotel
{
    public partial class Frm_menu : Form
    {
        HabitacionDAO habitacionDAO;
        HabitacionBO habitacionBO;

        private DataTable datos;


        public Frm_menu()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionDAO = new HabitacionDAO();

            datos = habitacionDAO.Buscar();
            dgv_habitaciones.DataSource = datos;
            dgv_habitaciones.AllowUserToAddRows = false;
            dgv_habitaciones.ReadOnly = true;
        }

        private void btn_reservaciones_Click(object sender, EventArgs e)
        {
            Frm_reservaciones form_reservas = new Frm_reservaciones();
            form_reservas.Owner = this;
            form_reservas.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void btn_agregar_habitaciones_Click(object sender, EventArgs e)
        {
            frm_habitaciones frm_agregar_habit = new frm_habitaciones();
            frm_agregar_habit.Show();
        }

        private void btn_buscar_hab_Click(object sender, EventArgs e)
        {
            DataView habitacion = datos.DefaultView;
            habitacion.RowFilter = string.Empty;

            if(txt_buscar_hab.Text!= string.Empty)
            {
                habitacion.RowFilter = string.Format("num_habitacion LIKE '%{0}%'", txt_buscar_hab.Text);
            }
            dgv_habitaciones.DataSource = habitacion;
        }

        private void btn_modificar_hab_Click(object sender, EventArgs e)
        {
            frm_habitaciones frm_agregar_habit = new frm_habitaciones();
            frm_agregar_habit.Show();
        }

        private void seleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionar = e.RowIndex;
            habitacionBO.Num_habitacion = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["num_habitacion"].Value.ToString());
            habitacionBO.Nombre_hab = dgv_habitaciones.Rows[filaSeleccionar].Cells["nombre"].Value.ToString();
            habitacionBO.Max_ninios = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["max_ninios"].Value.ToString());
            habitacionBO.Max_adultos = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["max_adultos"].Value.ToString());
            habitacionBO.PrecioTA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_alta"].Value.ToString());
            habitacionBO.PrecioN = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_baja"].Value.ToString());
            habitacionBO.PrecioPATA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_adic_alta"].Value.ToString());
            habitacionBO.PrecioPA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_adic_baja"].Value.ToString());
            habitacionBO.Tipo_hab = dgv_habitaciones.Rows[filaSeleccionar].Cells["tipo"].Value.ToString();
            habitacionBO.DescripHab = dgv_habitaciones.Rows[filaSeleccionar].Cells["descripcion"].Value.ToString();
            
            
        }
    }
}
