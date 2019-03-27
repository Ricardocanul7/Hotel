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
    public partial class Frm_mantenimiento : Form
    {
        EmpresaBO empresaBO = new EmpresaBO();
        EmpresaDAO empresaDAO = new EmpresaDAO();
        int Filaseleccionada = -1;
        private DataTable datos;
        
        public Frm_mantenimiento()
        {
            InitializeComponent();
            datos = empresaDAO.Buscar();

            dgv_empresas.DataSource = datos;
            dgv_empresas.AllowUserToAddRows = false;
            dgv_empresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empresas.ReadOnly = true;
            SetColumNames();

        }
        private void SetColumNames()
        {
            dgv_empresas.Columns[0].HeaderText = "RFC";
            dgv_empresas.Columns[1].HeaderText = "Nombre Empresa";
            dgv_empresas.Columns[2].HeaderText = "Precio Hora";

        }

        private void Buscar_Empresa(object sender, EventArgs e)
        {
            DataView empresa = datos.DefaultView;
            empresa.RowFilter = string.Empty;
          
                if (txt_Buscar_Empresa.Text != string.Empty)
                {
                    empresa.RowFilter = string.Format("rfc_proveedor LIKE '%{0}%' OR nombre LIKE '%{0}%' OR Convert(precio_porhora,'System.String') LIKE '%{0}%'", txt_Buscar_Empresa.Text);

                }

                dgv_empresas.DataSource = empresa;
        }

        private void Eliminar_Empresa(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
                "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (empresaDAO.Eliminar(empresaBO) == 1)
                {
                    MessageBox.Show("El registro se a borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }

                dgv_empresas.DataSource = empresaDAO.Buscar();
            }
        }

        private void Agregar_Empresa(object sender, EventArgs e)
        {
            frm_empresa form_agregarEmpleado = new frm_empresa();
            if (form_agregarEmpleado.ShowDialog() == DialogResult.OK)
            {
                dgv_empresas.DataSource = empresaDAO.Buscar();
                dgv_empresas.Update();
            }
        }

        private void Seleccionar_Fila(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filaseleccionada = e.RowIndex;

            if (Filaseleccionada >= 0)
            {
                empresaBO.RFC = dgv_empresas.Rows[Filaseleccionada].Cells["rfc_proveedor"].Value.ToString();
                empresaBO.Nombre = dgv_empresas.Rows[Filaseleccionada].Cells["nombre"].Value.ToString();
                empresaBO.Precio_hora = Convert.ToInt32(dgv_empresas.Rows[Filaseleccionada].Cells["precio_porhora"].Value.ToString());

                this.DialogResult = DialogResult.OK;
            }
        }

        private void Actualizar_Empresa(object sender, EventArgs e)
        {
            if (Filaseleccionada >= 0)
            {
                frm_empresa modificar = new frm_empresa();
                modificar.Add_empresa_mod(Convert.ToInt32(empresaBO.RFC));
                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    dgv_empresas.DataSource = empresaDAO.Buscar();
                    dgv_empresas.Update();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro antes de modificar Empresa!");
            }
        }
    }
}          
