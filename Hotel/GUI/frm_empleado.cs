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
    public partial class frm_empleado : Form
    {
        EmpleadoBO empleado = new EmpleadoBO();
        EmpleadoDAO empleados = new EmpleadoDAO();

        public frm_empleado()
        {
            InitializeComponent();
            txt_idempleado.Enabled = false;

            cbo_Horario.Items.Add("8 am - 4 pm");
            cbo_Horario.Items.Add("4 pm - 12 pm");
            cbo_Horario.Items.Add("12 am - 8 am");
            cbo_Horario.SelectedIndex = 0;

            cbo_tipoempleado.Items.Add("Administrador");
            cbo_tipoempleado.Items.Add("Recepcionista");
            cbo_tipoempleado.Items.Add("Mantenimiento");
            cbo_tipoempleado.Items.Add("Limpieza");
            cbo_tipoempleado.Items.Add("Guardias");
            cbo_tipoempleado.SelectedIndex = 0;

        }

        private void Guardar_Empleados(object sender, EventArgs e)
        {
            empleado.Nombre = txt_nom_empleado.Text;
            empleado.Apellido = txt_apell_empleado.Text;
            empleado.Direccion = txt_direcc_empleado.Text;
            empleado.Telefono = txt_tele_empleado.Text;
            empleado.Horario = cbo_Horario.Text;
            empleado.Tipo = cbo_tipoempleado.Text;

            empleados.Agregar(empleado);

            Limpiar();

        }
        public void Limpiar()
        {
            txt_apell_empleado.Clear();
            txt_direcc_empleado.Clear();
            txt_idempleado.Clear();
            txt_nom_empleado.Clear();
            txt_tele_empleado.Clear();
            cbo_Horario.Items.Clear();
            cbo_tipoempleado.Items.Clear();
        
        }

        private void Modificar_empleados(object sender, EventArgs e)
        {
            txt_nom_empleado.Text = empleado.Nombre;
            txt_direcc_empleado.Text = empleado.Direccion;
            txt_tele_empleado.Text = empleado.Telefono;
            txt_apell_empleado.Text = empleado.Apellido;

            empleados.Modificar(empleado);
        }
    }
}
