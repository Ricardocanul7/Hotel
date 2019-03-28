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
    public partial class frm_programar_mantenimiento : Form
    {
        LimpiezaBO limpiezaBO = new LimpiezaBO();
        LimpiezaDAO limpiezaDAO = new LimpiezaDAO();
        MantenimientoDAO mantenimientoDAO = new MantenimientoDAO();
        MantenimientoBO mantenimientoBO = new MantenimientoBO();
        int Filaseleccionada = -1;
        private DataTable datos;
        public frm_programar_mantenimiento()
        {
             InitializeComponent();

            dgv_Limpieza.DataSource = limpiezaDAO.Buscar();
            dgv_Mantenimiento.DataSource = mantenimientoDAO.Buscar();

            dgv_Limpieza.AllowUserToAddRows = false;
            dgv_Limpieza.ReadOnly = true;
            dgv_Mantenimiento.AllowUserToAddRows = false;
            dgv_Mantenimiento.ReadOnly = true;

            this.Set_Headers_Limpieza();
            this.Set_Headers_Mantenimiento();
        }

        private void Set_Headers_Mantenimiento()
        {
            dgv_Mantenimiento.Columns[0].HeaderText = "ID";
            dgv_Mantenimiento.Columns[1].HeaderText = "Fecha";
            dgv_Mantenimiento.Columns[2].HeaderText = "Nombre";
            dgv_Mantenimiento.Columns[3].HeaderText = "RFC";
            dgv_Mantenimiento.Columns[4].HeaderText = "Num. Habitación";
        }

        private void Set_Headers_Limpieza()
        {
            dgv_Limpieza.Columns[0].HeaderText = "ID";
            dgv_Limpieza.Columns[1].HeaderText = "Fecha";
            dgv_Limpieza.Columns[2].HeaderText = "Empleado";
            dgv_Limpieza.Columns[3].HeaderText = "Num. Habitacion";
        }


        private void Abrir_Limpieza(object sender, EventArgs e)
        {
            frm_agregar_limpieza form_agregarLimpieza = new frm_agregar_limpieza();
            if (form_agregarLimpieza.ShowDialog() == DialogResult.OK)
            {
                dgv_Limpieza.DataSource = limpiezaDAO.Buscar();
                dgv_Limpieza.Update();
            }
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            frm_agregar_mantenimiento form_agregarMant = new frm_agregar_mantenimiento();
            if (form_agregarMant.ShowDialog() == DialogResult.OK)
            {
                dgv_Mantenimiento.DataSource = mantenimientoDAO.Buscar();
                dgv_Mantenimiento.Update();
            }
        }
    }
}
