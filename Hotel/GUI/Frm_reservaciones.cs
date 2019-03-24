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
    public partial class Frm_reservaciones : Form
    {
        ReservaDAO reservaDAO;
        ReservasBO reservaBO;
        int index;

        public Frm_reservaciones()
        {
            InitializeComponent();
            reservaDAO = new ReservaDAO();
            reservaBO = new ReservasBO();

            dgv_reservaciones.AllowUserToAddRows = false;
            dgv_reservaciones.ReadOnly = true;
            dgv_reservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_reservaciones.DataSource = reservaDAO.Buscar();
            SetColumNames();
        }

        private void SetColumNames()
        {
            dgv_reservaciones.Columns[0].HeaderText = "No. Folio";
            dgv_reservaciones.Columns[1].HeaderText = "No. Habitación";
            dgv_reservaciones.Columns[2].HeaderText = "Entrada";
            dgv_reservaciones.Columns[3].HeaderText = "Salida";
            dgv_reservaciones.Columns[4].HeaderText = "Detalles";
            dgv_reservaciones.Columns[5].HeaderText = "Nombre";
            dgv_reservaciones.Columns[6].HeaderText = "Apellido Paterno";
            dgv_reservaciones.Columns[7].HeaderText = "Apellido Materno";
            dgv_reservaciones.Columns[8].HeaderText = "Dirección";
            dgv_reservaciones.Columns[9].HeaderText = "Email";
            dgv_reservaciones.Columns[10].HeaderText = "Telefono";
            dgv_reservaciones.Columns[11].HeaderText = "Pagado";
        }

        private void btn_reservarhab_Click(object sender, EventArgs e)
        {
            Frm_reservar_hab reservar_Hab = new Frm_reservar_hab();
            if(reservar_Hab.ShowDialog() == DialogResult.OK)
            {
                dgv_reservaciones.DataSource = reservaDAO.Buscar();
                dgv_reservaciones.Update();
            }
        }

        private void dgv_reservaciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                reservaBO.Folio_reserva = Convert.ToInt32(dgv_reservaciones.Rows[index].Cells[0].Value);
            }
        }

        private void btn_modificar_reser_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                Frm_reservar_hab modificar = new Frm_reservar_hab();
                modificar.Add_reserva_mod(reservaBO.Folio_reserva);
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    dgv_reservaciones.DataSource = reservaDAO.Buscar();
                    dgv_reservaciones.Update();
                }
            }  
        }

        private void btn_eliminar_reserv_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "¿Seguro que quieres eliminar esta reserva?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                reservaDAO.Eliminar(reservaBO);
                dgv_reservaciones.DataSource = reservaDAO.Buscar();
            }
        }
    }
}
