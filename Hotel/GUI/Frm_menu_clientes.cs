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
    public partial class Frm_menu_clientes : Form
    {
        ClienteBO clienteBO = new ClienteBO();
        ClienteDAO clienteDAO = new ClienteDAO();
        private DataTable datos;
        public Frm_menu_clientes()
        {
            InitializeComponent();

            datos = clienteDAO.Buscar();

            dgv_clientes.DataSource = datos;
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_clientes.ReadOnly = true;
            SetColumNames();
        }
        private void SetColumNames()
        {
            dgv_clientes.Columns[0].HeaderText = "ID";
            dgv_clientes.Columns[1].HeaderText = "Nombre";
            dgv_clientes.Columns[2].HeaderText = "Apellido Paterno";
            dgv_clientes.Columns[3].HeaderText = "Apellido Materno";
            dgv_clientes.Columns[4].HeaderText = "Direccion";
            dgv_clientes.Columns[5].HeaderText = "E-mail";
            dgv_clientes.Columns[6].HeaderText = "Telefono";
       
        }
        private void Agregar_Cliente(object sender, EventArgs e)
        {
            frm_clientes form_agregarCliente = new frm_clientes();
            if (form_agregarCliente.ShowDialog() == DialogResult.OK)
            {
                dgv_clientes.DataSource = clienteDAO.Buscar();
                dgv_clientes.Update();
            }
        }

        private void Seleccionar_Fila(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Filaseleccionada = e.RowIndex;

            if (Filaseleccionada >= 0)
            {
                clienteBO.Cliente_nombre = dgv_clientes.Rows[Filaseleccionada].Cells["nombre"].Value.ToString();
                clienteBO.Cliente_id = int.Parse(dgv_clientes.Rows[Filaseleccionada].Cells["cliente_id"].Value.ToString());
                clienteBO.Cliente_apaterno = dgv_clientes.Rows[Filaseleccionada].Cells["apaterno"].Value.ToString();
                clienteBO.Cliente_amaterno = dgv_clientes.Rows[Filaseleccionada].Cells["amaterno"].Value.ToString();
                clienteBO.Cliente_direccion = dgv_clientes.Rows[Filaseleccionada].Cells["direccion"].Value.ToString();
                clienteBO.Cliente_telefono = dgv_clientes.Rows[Filaseleccionada].Cells["telefono"].Value.ToString();
                clienteBO.Cliente_email = dgv_clientes.Rows[Filaseleccionada].Cells["email"].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void Eliminar_Clientes(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
                "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (clienteDAO.Eliminar(clienteBO) == 1)
                {
                    MessageBox.Show("El registro se a borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }

                dgv_clientes.DataSource = clienteDAO.Buscar();
            }
        }

        private void Buscar_Clientes(object sender, EventArgs e)
        {
            DataView cliente = datos.DefaultView;
            cliente.RowFilter = string.Empty;
            try
            {
                if (txt_buscarclientes.Text != string.Empty)
                {
                    cliente.RowFilter = string.Format("nombre LIKE '%{0}%' OR apaterno LIKE '%{0}%' OR amaterno LIKE '%{0}%' OR Convert(cliente_id,'System.String') LIKE '%{0}%'", txt_buscarclientes.Text);

                }

                dgv_clientes.DataSource = cliente;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
