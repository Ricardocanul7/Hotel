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
        EmpleadoBO empleadoBO = new EmpleadoBO();
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        public frm_empleado()
        {
            InitializeComponent();
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.DataSource = empleadoDAO.Buscar();


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
            dgv_empleados.DataSource = empleadoDAO.Buscar();
            Limpiar();
        }
        internal EmpleadoBO RecuperarInformacion()
        {
            EmpleadoBO empleadoBO = new EmpleadoBO();
            EmpleadoDAO empleadoDAO = new EmpleadoDAO();

            empleadoBO.Id_empleado = Convert.ToInt32(txt_idempleado.Text);
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
        private void Seleccionar_fila(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionar = e.RowIndex;

            empleadoBO.Id_empleado = int.Parse(dgv_empleados.Rows[filaSeleccionar].Cells["id_empleado"].Value.ToString());
            empleadoBO.Nombre = dgv_empleados.Rows[filaSeleccionar].Cells["nombre"].Value.ToString();
            empleadoBO.Apellido_Petem = dgv_empleados.Rows[filaSeleccionar].Cells["apellido_patern"].Value.ToString();
            empleadoBO.Apellido_Matem = dgv_empleados.Rows[filaSeleccionar].Cells["apellido_matern"].Value.ToString();
            empleadoBO.Direccion = dgv_empleados.Rows[filaSeleccionar].Cells["direccion"].Value.ToString();
            empleadoBO.Telefono = dgv_empleados.Rows[filaSeleccionar].Cells["telefono"].Value.ToString();
            empleadoBO.Horario = dgv_empleados.Rows[filaSeleccionar].Cells["horario"].Value.ToString();
            empleadoBO.Tipo = dgv_empleados.Rows[filaSeleccionar].Cells["tipo"].Value.ToString();

            txt_idempleado.Text = Convert.ToString(empleadoBO.Id_empleado);
            txt_nom_empleado.Text = empleadoBO.Nombre;
            txt_apellidoparteno.Text = empleadoBO.Apellido_Petem;
            txt_apellidomaterno.Text = empleadoBO.Apellido_Matem;
            txt_direcc_empleado.Text = empleadoBO.Direccion;
            txt_tele_empleado.Text = empleadoBO.Telefono;
            cbo_Horario.Text = empleadoBO.Horario;
            cbo_tipoempleado.Text = empleadoBO.Tipo;
       
        }

        private void Eliminar_empleados(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
                "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (empleadoDAO.Eliminar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("El registro se a borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }

                dgv_empleados.DataSource = empleadoDAO.Buscar();
                Limpiar(); 
            }
        }

        private void Modificar_empleados(object sender, EventArgs e)
        {
            if (empleadoDAO.Modificar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Registro Modificado :)");

            }
            else
            {
                MessageBox.Show("Algo a salido mal :(");
            }

            dgv_empleados.DataSource =empleadoDAO.Buscar();
            Limpiar();
        }
    }
}
