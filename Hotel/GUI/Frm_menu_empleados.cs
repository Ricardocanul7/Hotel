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

namespace Hotel.GUI
{
    public partial class Frm_menu_empleados : Form
    {
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        EmpleadoBO empleadoBO = new EmpleadoBO();

        private DataTable datos;
        public string nombre = "";

        public Frm_menu_empleados()
        {
            InitializeComponent();

            datos = empleadoDAO.Buscar();

            dgv_empleados.DataSource = datos;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.ReadOnly = true;
        }

        private void btn_nvoempleado_Click(object sender, EventArgs e)
        {
            frm_empleado form_agregarEmpleado = new frm_empleado();
            form_agregarEmpleado.Show();
        }

        private void Buscar_empleados_click(object sender, EventArgs e)
        {
            DataView empleados = datos.DefaultView;
            empleados.RowFilter = string.Empty;

            if(txt_buscarempleados.Text != string.Empty)
            {
                empleados.RowFilter = string.Format("nombre LIKE '%{0}%'", txt_buscarempleados.Text);
            }
            dgv_empleados.DataSource = empleados;

        }

        private void Seleccionar_empleado(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Filaseleccionada = e.RowIndex;
            nombre = dgv_empleados.Rows[Filaseleccionada].Cells["nombre"].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Dispose();

        }


    }
}
