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
    public partial class frm_empleado : MetroFramework.Forms.MetroForm
    {
        EmpleadoBO empleadoBO = new EmpleadoBO();
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
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
            if(empleadoDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha Agregado el Empleado");
            }
            else
            {
                MessageBox.Show("Ha sucedido un error");
            }
            Limpiar();

            Frm_menu_empleados MenuEmpleados = new Frm_menu_empleados();

            DialogResult res = MenuEmpleados.ShowDialog();

            if(res == DialogResult.OK)
            {
               
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
        internal EmpleadoBO RecuperarInformacion()
        {
            EmpleadoBO empleadoBO = new EmpleadoBO();
            EmpleadoDAO empleadoDAO = new EmpleadoDAO();

            empleadoBO.Nombre = txt_nom_empleado.Text;
            empleadoBO.Apellido_Petem = txt_apellidoparteno.Text;
            empleadoBO.Apellido_Matem = txt_apellidomaterno.Text;
            empleadoBO.Direccion = txt_direcc_empleado.Text;
            empleadoBO.Telefono = txt_tele_empleado.Text;
            empleadoBO.Horario = cbo_Horario.Text;
            empleadoBO.Tipo = cbo_tipoempleado.Text;


            return empleadoBO;
        }
        public void Limpiar()
        {
            txt_apellidomaterno.Clear();
            txt_direcc_empleado.Clear();
            txt_idempleado.Clear();
            txt_nom_empleado.Clear();
            txt_tele_empleado.Clear();
            cbo_Horario.Items.Clear();
            cbo_tipoempleado.Items.Clear();
        
        }

    }
}
