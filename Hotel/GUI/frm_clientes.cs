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
        bool Cliente_mod = false;
        public frm_clientes()
        {
            InitializeComponent();
            txt_idcliente.Enabled = false;


        }

        private void Guardar_clientes(object sender, EventArgs e)
        {
            if (Cliente_mod == false)
            {
                if (clienteDAO.Agregar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha Agregado el Cliente");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }
            else
            {
                if (clienteDAO.Modificar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado el Cliente");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }


            Limpiar();
         
        }
        internal ClienteBO RecuperarInformacion()
        {
            ClienteBO clienteBO = new ClienteBO();
            ClienteDAO clienteDAO = new ClienteDAO();

            if (Cliente_mod == true)
            {
                clienteBO.Cliente_id = Convert.ToInt32(txt_idcliente.Text);
            }

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
        public void Add_cliente_mod(int id_cliente)
        {
            Cliente_mod = true;
            btn_guardar_cliente.Text = "Modificar";
            DataRow[] clienteT = clienteDAO.Buscar().Select(String.Format("cliente_id = {0}", id_cliente));

            if (clienteT.Length > 0)
            {
                txt_idcliente.Text = clienteT[0]["cliente_id"].ToString();
                txt_nom_cliente.Text = clienteT[0]["nombre"].ToString();
                txt_apaterno_cliente.Text = clienteT[0]["apaterno"].ToString();
                txt_amaterno_cliente.Text = clienteT[0]["amaterno"].ToString();
                txt_direcc_cliente.Text = clienteT[0]["direccion"].ToString();
                txt_email_cliente.Text = clienteT[0]["email"].ToString();
                txt_tele_cliente.Text = clienteT[0]["telefono"].ToString();

            }
        }

        private void Validar_telefono(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }
    }
}
