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
    public partial class Frm_menu_empleados : Form
    {
        public Frm_menu_empleados()
        {
            InitializeComponent();
        }

        private void btn_nvoempleado_Click(object sender, EventArgs e)
        {
            frm_empleado form_agregarEmpleado = new frm_empleado();
            form_agregarEmpleado.Show();
        }
    }
}
