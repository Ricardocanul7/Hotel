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
        int index;

        public Frm_menu()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionDAO = new HabitacionDAO();

            datos = habitacionDAO.Buscar();
            dgv_habitaciones.DataSource = datos;
            dgv_habitaciones.AllowUserToAddRows = false;
            dgv_habitaciones.ReadOnly = true;
            dgv_habitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SetColumNames();
        }

        private void SetColumNames()
        {
            dgv_habitaciones.Columns[0].HeaderText = "No. Habitación";
            dgv_habitaciones.Columns[1].HeaderText = "Nombre";
            dgv_habitaciones.Columns[2].HeaderText = "Max. niños";
            dgv_habitaciones.Columns[3].HeaderText = "Max adultos";
            dgv_habitaciones.Columns[4].HeaderText = "precio temp. \nalta";
            dgv_habitaciones.Columns[5].HeaderText = "precio temp. \nbaja";
            dgv_habitaciones.Columns[6].HeaderText = "precio persona \nadic. temp. alta";
            dgv_habitaciones.Columns[7].HeaderText = "precio persona \nadic. temp. baja";
            dgv_habitaciones.Columns[8].HeaderText = "tipo de \nhabitación";
            dgv_habitaciones.Columns[9].HeaderText = "Descripción";
            dgv_habitaciones.Columns[10].HeaderText = "Estado de \nhabitación";
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
          
            if (frm_agregar_habit.ShowDialog() == DialogResult.OK)
            {
                dgv_habitaciones.DataSource = habitacionDAO.Buscar();
                dgv_habitaciones.Update();
            }
        }

        private void btn_buscar_hab_Click(object sender, EventArgs e)
        {
            DataView habitacion = datos.DefaultView;
            habitacion.RowFilter = string.Empty;

            if (txt_buscar_hab.Text != string.Empty)
            {
                habitacion.RowFilter = string.Format("convert(num_habitacion,'System.String')LIKE '%{0}%'", txt_buscar_hab.Text);
            }
            dgv_habitaciones.DataSource = habitacion;
        }

        private void seleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                habitacionBO.Num_habitacion = Convert.ToInt32(dgv_habitaciones.Rows[index].Cells[0].Value);
            }
        }

        private void btn_modificar_hab_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                frm_habitaciones modificar = new frm_habitaciones();
                modificar.Add_habitacion_mod(habitacionBO.Num_habitacion);
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    dgv_habitaciones.DataSource = habitacionDAO.Buscar();
                    dgv_habitaciones.Update();
                }
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
