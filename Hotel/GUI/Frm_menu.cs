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
            frm_agregar_habit.data = dgv_habitaciones;
            frm_agregar_habit.Show();
        }

        private void btn_buscar_hab_Click(object sender, EventArgs e)
        {
            DataView habitacion = datos.DefaultView;
            habitacion.RowFilter = string.Empty;

            if(txt_buscar_hab.Text!= string.Empty)
            {
                habitacion.RowFilter = string.Format( "convert(num_habitacion,'System.String')LIKE '%{0}%'" , txt_buscar_hab.Text);
            }
            dgv_habitaciones.DataSource = habitacion;
        }

        private void btn_modificar_hab_Click(object sender, EventArgs e)
        {
            frm_habitaciones frm_agregar_habit = new frm_habitaciones();
            frm_agregar_habit.data = dgv_habitaciones;
            frm_agregar_habit.SetObjectHabitacionBO = habitacionBO;
            
            frm_agregar_habit.Show();
        }

        private void seleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionar = e.RowIndex;
            if(filaSeleccionar > 0)
            {
                habitacionBO.Num_habitacion = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["num_habitacion"].Value.ToString());
                habitacionBO.Nombre_hab = dgv_habitaciones.Rows[filaSeleccionar].Cells["nombre"].Value.ToString();
                habitacionBO.Max_ninios = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["max_ninios"].Value.ToString());
                habitacionBO.Max_adultos = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["max_adultos"].Value.ToString());
                habitacionBO.PrecioTA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_alta"].Value.ToString());
                habitacionBO.PrecioN = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_baja"].Value.ToString());
                habitacionBO.PrecioPATA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_adic_alta"].Value.ToString());
                habitacionBO.PrecioPA = int.Parse(dgv_habitaciones.Rows[filaSeleccionar].Cells["precio_adic_baja"].Value.ToString());
                habitacionBO.Tipo_hab = Convert.ToInt32( dgv_habitaciones.Rows[filaSeleccionar].Cells["tipo_hab"].Value.ToString());
                habitacionBO.DescripHab = dgv_habitaciones.Rows[filaSeleccionar].Cells["descripcion"].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_eliminar_hab_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
            "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (habitacionDAO.Eliminar(habitacionBO) == 1)
                {
                    MessageBox.Show("El registro se ha borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }
                dgv_habitaciones.DataSource = habitacionDAO.Buscar();
            }
        }
    }
}
