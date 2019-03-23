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

        private DataTable datos;
        
        public Frm_mantenimiento()
        {
            InitializeComponent();
            datos = empresaDAO.Buscar();

            dgv_empresas.DataSource = datos;
            dgv_empresas.AllowUserToAddRows = false;
            dgv_empresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_empresas.ReadOnly = true;
        }

        private void Guardar_Empresa(object sender, EventArgs e)
        {
            if (empresaDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha Agregado el Empleado");
            }
            else
            {
                MessageBox.Show("Ha sucedido un error");
            }
            dgv_empresas.DataSource = empresaDAO.Buscar();
            Limpiar();
        }
        internal EmpresaBO RecuperarInformacion()
        {
            EmpresaBO empresaBO = new EmpresaBO();
            EmpresaDAO empresaDAO = new EmpresaDAO();

            empresaBO.RFC = txt_rfc_empresa.Text;
            empresaBO.Nombre = txt_nombre_empresa.Text;
            empresaBO.Precio_hora = Convert.ToDecimal(txt_precio_hora.Text);

            return empresaBO;
        }
        public void Limpiar()
        {
            txt_nombre_empresa.Clear();
            txt_precio_hora.Clear();
            txt_rfc_empresa.Clear();
        }

        private void Seleccionar_fila(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Filaseleccionada = e.RowIndex;

            if (Filaseleccionada >= 0)
            {
                empresaBO.RFC = dgv_empresas.Rows[Filaseleccionada].Cells["rfc_proveedor"].Value.ToString();
                empresaBO.Nombre = dgv_empresas.Rows[Filaseleccionada].Cells["nombre"].Value.ToString();
                empresaBO.Precio_hora = Convert.ToInt32(dgv_empresas.Rows[Filaseleccionada].Cells["precio_porhora"].Value.ToString());

                txt_nombre_empresa.Text = empresaBO.Nombre;
                txt_rfc_empresa.Text = empresaBO.RFC;
                txt_precio_hora.Text = Convert.ToString(empresaBO.Precio_hora);
                
                this.DialogResult = DialogResult.OK;
            }
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

        private void Actualizar_Empresa(object sender, EventArgs e)
        {
            if (empresaDAO.Modificar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Registro Modificado :)");

            }
            else
            {
                MessageBox.Show("Algo a salido mal :(");
            }

            dgv_empresas.DataSource = empresaDAO.Buscar();
            Limpiar();
        }
    }
}          
