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

            Set_cbo_puesto();
        }

        public void Set_cbo_puesto()
        {
            DataRow[] rows = empleadoDAO.PuestoEmpleado().Select();
            for(int i = 0; i < rows.Length; i++)
            {
                cbo_tipoempleado.Items.Add(rows[i][1]);
            }

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
            empleadoBO.Puesto_id = Convert.ToInt32(cbo_tipoempleado.Text);
            empleadoBO.Sueldo = Convert.ToDecimal(txt_sueldoempleado.Text);
            


            return empleadoBO;
        }
        public void Limpiar()
        {
            txt_apellidoparteno.Clear();
            txt_apellidomaterno.Clear();
            txt_direcc_empleado.Clear();
            txt_idempleado.Clear();
            txt_nom_empleado.Clear();
            txt_tele_empleado.Clear();
            txt_sueldoempleado.Clear();
            cbo_Horario.Items.Clear();
            cbo_tipoempleado.Items.Clear();
        
        }

    }
}
