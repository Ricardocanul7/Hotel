﻿using System;
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
        int Filaseleccionada = -1;

        private DataTable datos;
        public string nombre = "";

        public Frm_menu_empleados()
        {
            InitializeComponent();

            datos = empleadoDAO.Buscar();

            dgv_empleados.DataSource = datos;
            dgv_empleados.AllowUserToAddRows = false;
            dgv_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empleados.ReadOnly = true;
            SetColumNames();
        }
        private void SetColumNames()
        {
            dgv_empleados.Columns[0].HeaderText = "ID";
            dgv_empleados.Columns[1].HeaderText = "Nombre";
            dgv_empleados.Columns[2].HeaderText = "Apellido Paterno";
            dgv_empleados.Columns[3].HeaderText = "Apellido Materno";
            dgv_empleados.Columns[4].HeaderText = "Direccion";
            dgv_empleados.Columns[5].HeaderText = "Telefono";
            dgv_empleados.Columns[6].HeaderText = "Horario";
            dgv_empleados.Columns[7].HeaderText = "Sueldo";
            dgv_empleados.Columns[8].HeaderText = "Puesto";
          
        }

        private void btn_nvoempleado_Click(object sender, EventArgs e)
        {
            frm_empleado form_agregarEmpleado = new frm_empleado();
            if(form_agregarEmpleado.ShowDialog() == DialogResult.OK)
            {
                dgv_empleados.DataSource = empleadoDAO.Buscar();
                dgv_empleados.Update();
            }
 
        }

        private void Buscar_empleados_click(object sender, EventArgs e)
        {
            DataView empleados = datos.DefaultView;
            empleados.RowFilter = string.Empty;
            try
            {
                if (txt_buscarempleados.Text != string.Empty)
                {
                    empleados.RowFilter = string.Format("nombre LIKE '%{0}%' OR apellido_patern LIKE '%{0}%' OR apellido_matern LIKE '%{0}%' OR Convert(empleado_id,'System.String') LIKE '%{0}%'", txt_buscarempleados.Text);

                }

                dgv_empleados.DataSource = empleados;
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void Seleccionar_empleado(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filaseleccionada = e.RowIndex;

            if(Filaseleccionada >= 0)
            {
                empleadoBO.Nombre = dgv_empleados.Rows[Filaseleccionada].Cells["nombre"].Value.ToString();
                empleadoBO.Id_empleado = int.Parse(dgv_empleados.Rows[Filaseleccionada].Cells["empleado_id"].Value.ToString());
                empleadoBO.Apellido_Petem = dgv_empleados.Rows[Filaseleccionada].Cells["apellido_patern"].Value.ToString();
                empleadoBO.Apellido_Matem = dgv_empleados.Rows[Filaseleccionada].Cells["apellido_matern"].Value.ToString();
                empleadoBO.Direccion = dgv_empleados.Rows[Filaseleccionada].Cells["direccion"].Value.ToString();
                empleadoBO.Telefono = dgv_empleados.Rows[Filaseleccionada].Cells["telefono"].Value.ToString();
                empleadoBO.Horario = dgv_empleados.Rows[Filaseleccionada].Cells["horario"].Value.ToString();
                empleadoBO.Sueldo = int.Parse(dgv_empleados.Rows[Filaseleccionada].Cells["sueldo"].Value.ToString());

                string puesto = dgv_empleados.Rows[Filaseleccionada].Cells["puesto"].Value.ToString();
                int puesto_id = Convert.ToInt32(empleadoDAO.PuestoEmpleado().Select(String.Format("puesto = '{0}'", puesto))[0]["puesto_id"]);
                empleadoBO.Puesto_id = puesto_id;

                this.DialogResult = DialogResult.OK;
            }

        }
        private void Eliminar_Empleado(object sender, EventArgs e)
        {
            if(Filaseleccionada >= 0)
            {
                if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
                  "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (empleadoDAO.Eliminar(empleadoBO) == 1)
                    {
                        MessageBox.Show("El registro se a borrado");
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal");
                    }

                    dgv_empleados.DataSource = empleadoDAO.Buscar();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro antes para eliminar");
            }
            
        }

        private void Modicicar_Empleados(object sender, EventArgs e)
        {
            if(Filaseleccionada >= 0)
            {
                frm_empleado modificar = new frm_empleado();
                modificar.Add_empleado_mod(empleadoBO.Id_empleado);
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    dgv_empleados.DataSource = empleadoDAO.Buscar();
                    dgv_empleados.Update();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro antes de modificar empleado!");
            }
        }

        private void Forms_Puesto(object sender, EventArgs e)
        {
            frm_agregar_puesto Agregar_puesto = new frm_agregar_puesto();
            Agregar_puesto.Show();
        }
    }
}

