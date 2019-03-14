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
    public partial class frm_clientes : Form
    {
        ClienteBO clientebo = new ClienteBO();
        ClienteDAO clientedao = new ClienteDAO();
        public frm_clientes()
        {
            InitializeComponent();
            txt_idcliente.Enabled = false;
            DataTable datos = clientedao.Buscar();
            // Creo una nueva fila al datatable
           DataRow dr = datos.NewRow();
            dr["cliente_nombre"] = "Seleccionar";
            dr["cliente_id"] = 0;
            Grd_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grd_clientes.ReadOnly = true;
            Grd_clientes.AllowUserToAddRows = false;
            
        }

        private ClienteBO RecuperarInformacion()
        {
            int id = 0;

            int.TryParse(txt_idcliente.Text, out id);

            ClienteBO clientebo = new ClienteBO();
            clientebo.Cliente_id = id;
            clientebo.Cliente_nombre = txt_nom_cliente.Text;

            return clientebo;
        }


        private void Guardar_clientes(object sender, EventArgs e)
        {
            clientebo.Cliente_nombre = txt_nom_cliente.Text;
            clientebo.Cliente_apaterno = txt_apaterno_cliente.Text;
            clientebo.Cliente_amaterno = txt_amaterno_cliente.Text;
            clientebo.Cliente_direccion = txt_direcc_cliente.Text;
            clientebo.Cliente_email = txt_email_cliente.Text;
            clientebo.Cliente_telefono= txt_tele_cliente.Text;

            limpiar();
        }
        public void limpiar()
        {
            txt_nom_cliente.Clear();
            txt_apaterno_cliente.Clear();
            txt_amaterno_cliente.Clear();
            txt_direcc_cliente.Clear();
            txt_email_cliente.Clear();
            txt_tele_cliente.Clear();
        }

        private void Modificar_clientes(object sender, EventArgs e)
        {
            txt_nom_cliente.Text = clientebo.Cliente_nombre;
            txt_apaterno_cliente.Text = clientebo.Cliente_apaterno;
            txt_amaterno_cliente.Text = clientebo.Cliente_amaterno;
            txt_direcc_cliente.Text = clientebo.Cliente_direccion;
            txt_email_cliente.Text = clientebo.Cliente_email;
            txt_email_cliente.Text = clientebo.Cliente_telefono;
        }

        private void Grd_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = e.RowIndex;

            clientebo.Cliente_id= int.Parse(Grd_clientes.Rows[rowSelected].Cells["cliente_id"].Value.ToString());

            clientebo.Cliente_nombre= Grd_clientes.Rows[rowSelected].Cells["cliente_nombre"].Value.ToString();

            txt_idcliente.Text = clientebo.Cliente_id.ToString();
            txt_nom_cliente.Text = clientebo.Cliente_nombre;
        }
    }
}
