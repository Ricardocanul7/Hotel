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
    public partial class frm_agregar_puesto : MetroFramework.Forms.MetroForm
    {
        EmpleadoBO empleadoBO = new EmpleadoBO();
        EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        private DataTable datos;
        public frm_agregar_puesto()
        {
            InitializeComponent();

            datos = empleadoDAO.Buscar_Puesto();

            dgv_puestos.DataSource = datos;
            dgv_puestos.AllowUserToAddRows = false;
            dgv_puestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_puestos.ReadOnly = true;

        }
        public void Limpiar()
        {
            txt_Nuevo_Puesto.Clear();
            txt_Buscar_Puesto.Clear();
        }

        private void Guardar_Puesto(object sender, EventArgs e)
        {
            if (empleadoDAO.Agregar_Puesto(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha Agregado el Empleado");
            }
            else
            {
                MessageBox.Show("Ha sucedido un error");
            }
            dgv_puestos.DataSource = empleadoDAO.Buscar_Puesto();

            Limpiar();
        }
        internal EmpleadoBO RecuperarInformacion()
        {
            EmpleadoBO empleadoBO = new EmpleadoBO();

            empleadoBO.Puesto = txt_Nuevo_Puesto.Text;

                return empleadoBO;
        }

         private void Buscar_puestos(object sender, EventArgs e)
        {
            DataView empleados = datos.DefaultView;
            empleados.RowFilter = string.Empty;
            try
            {
                if (txt_Buscar_Puesto.Text != string.Empty)
                {
                    empleados.RowFilter = string.Format("puesto LIKE '%{0}%'", txt_Buscar_Puesto.Text);

                }

                dgv_puestos.DataSource = empleados;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Seleccionar_puesto(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Filaseleccionada = e.RowIndex;

            if (Filaseleccionada >= 0)
            {
                empleadoBO.Puesto = dgv_puestos.Rows[Filaseleccionada].Cells["puesto"].Value.ToString();

                txt_Nuevo_Puesto.Text = empleadoBO.Puesto;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void Eliminar_puestos(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
              "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (empleadoDAO.Eliminar_Puesto(empleadoBO) == 1)
                {
                    MessageBox.Show("El registro se a borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }

                dgv_puestos.DataSource = empleadoDAO.Buscar_Puesto();
            }
        }

        private void Modificar_puesto(object sender, EventArgs e)
        {
            if (empleadoDAO.Modificar_Puesto(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Registro Modificado :)");

            }
            else
            {
                MessageBox.Show("Algo a salido mal :(");
            }

            dgv_puestos.DataSource = empleadoDAO.Buscar_Puesto();
            Limpiar();
        }
    }
}

