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
    public partial class frm_clientes : MetroFramework.Forms.MetroForm
    {
        ClienteBO clienteBO = new ClienteBO();
        ClienteDAO clienteDAO = new ClienteDAO();
        Conexion Miconexion = new Conexion();
        public frm_clientes()
        {
            InitializeComponent();
            txt_idcliente.Enabled = false;


        }

        private void Guardar_clientes(object sender, EventArgs e)
        {
            if (clienteDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha Agregado el Empleado");
            }
            else
            {
                MessageBox.Show("Ha sucedido un error");
            }

            Limpiar();
        }
        internal ClienteBO RecuperarInformacion()
        {
            ClienteBO clienteBO = new ClienteBO();
            ClienteDAO clienteDAO = new ClienteDAO();

            clienteBO.Cliente_nombre = txt_nom_cliente.Text;
            clienteBO.Cliente_apaterno = txt_apaterno_cliente.Text;
            clienteBO.Cliente_amaterno = txt_amaterno_cliente.Text;
            clienteBO.Cliente_direccion = txt_direcc_cliente.Text;
            clienteBO.Cliente_email = txt_email_cliente.Text;
            clienteBO.Cliente_telefono = txt_tele_cliente.Text;

            return clienteBO;
        }
        public void Limpiar()
        {
            txt_nom_cliente.Clear();
            txt_apaterno_cliente.Clear();
            txt_amaterno_cliente.Clear();
            txt_direcc_cliente.Clear();
            txt_email_cliente.Clear();
            txt_tele_cliente.Clear();
        }

    }
}
