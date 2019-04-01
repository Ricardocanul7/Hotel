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
        ReservaDAO reservas;

        private DataTable datos;
        int index = -1;

        public Frm_menu()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionDAO = new HabitacionDAO();
            reservas = new ReservaDAO();

            this.VerificarEstado_Hab_reserva();

            datos = habitacionDAO.Buscar();
            dgv_habitaciones.DataSource = datos;
            dgv_habitaciones.AllowUserToAddRows = false;
            dgv_habitaciones.ReadOnly = true;
            dgv_habitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Admin = 1
            if(DatosLogin.Tipo_usuario != 1)
            {
                this.btn_configuracion.Enabled = false;
                this.btn_eliminar_hab.Enabled = false;
                this.btn_agregar_habitaciones.Enabled = false;
                this.btn_modificar_hab.Enabled = false;
            }

            SetColumNames();
        }

        private void VerificarEstado_Hab_reserva()
        {
            DataRow[] row_reservas = reservas.Buscar().Select();

            for(int i = 0; i < row_reservas.Length; i++)
            {
                DateTime checkin = DateTime.Parse(row_reservas[i]["fecha_entrada"].ToString());
                DateTime checkout = DateTime.Parse(row_reservas[i]["fecha_salida"].ToString());

                // Si la fecha de hoy esta en el rango de reserva de una habitacion... ponerla ocupada
                if(DateTime.Now >= checkin && DateTime.Now <= checkout)
                {
                    int num_habitacion = Convert.ToInt32(row_reservas[i]["num_habitacion"]);
                    // No disponible = 1
                    // Disponible = 4
                    habitacionDAO.ModificarEstado(num_habitacion, 1);
                }
                else
                {
                    int num_habitacion = Convert.ToInt32(row_reservas[i]["num_habitacion"]);
                    // No disponible = 1
                    // Disponible = 4
                    habitacionDAO.ModificarEstado(num_habitacion, 4);
                }
            }

            LimpiezaDAO limpiezaDAO = new LimpiezaDAO();
            DataRow[] rowLimp = limpiezaDAO.Buscar().Select();

            
            for (int i = 0; i < rowLimp.Length; i++)
            {
                if (DateTime.Now.ToShortDateString() == DateTime.Parse(rowLimp[i]["fecha"].ToString()).ToShortDateString())
                {
                    int num_habitacion = Convert.ToInt32(rowLimp[i]["num_habitacion"]);
                    // Limpieza = 3
                    habitacionDAO.ModificarEstado(num_habitacion, 3);
                } 
            }

            MantenimientoDAO mantenimientoDAO = new MantenimientoDAO();
            DataRow[] rowMant = mantenimientoDAO.Buscar().Select();

            for (int i = 0; i < rowMant.Length; i++)
            {
                if (DateTime.Now.ToShortDateString() == DateTime.Parse(rowMant[i]["fecha"].ToString()).ToShortDateString())
                {
                    int num_habitacion = Convert.ToInt32(rowMant[i]["num_habitacion"]);
                    // Mantenimiento = 2
                    habitacionDAO.ModificarEstado(num_habitacion, 2);
                }
            }
        }

        private void SetColumNames()
        {
            dgv_habitaciones.Columns[0].HeaderText = "No. Habitación";
            dgv_habitaciones.Columns[1].HeaderText = "Nombre";
            dgv_habitaciones.Columns[2].HeaderText = "Precio";
            dgv_habitaciones.Columns[3].HeaderText = "Tipo de habitación";
            dgv_habitaciones.Columns[4].HeaderText = "Descripción";
            dgv_habitaciones.Columns[5].HeaderText = "Estado";
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
                habitacion.RowFilter = string.Format("nombre LIKE '%{0}%' OR convert(num_habitacion,'System.String')LIKE '%{0}%'", txt_buscar_hab.Text);
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
            else
            {
                MessageBox.Show("Selecciona un registro antes de continuar");
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

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Frm_configuracion frm_Configuracion = new Frm_configuracion();
            frm_Configuracion.Show();
        }

        private void Seleccionar_color(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgv_habitaciones.Columns[e.ColumnIndex].Name == "estado")
            {
                if(Convert.ToString(e.Value) == "Disponible")
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                if (Convert.ToString(e.Value) == "No disponible")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (Convert.ToString(e.Value) == "Mantenimiento")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToString(e.Value) == "Limpieza")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
