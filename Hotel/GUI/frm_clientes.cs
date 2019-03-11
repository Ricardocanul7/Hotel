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
        ClienteBO cliente = new ClienteBO();
        ClienteDAO clientes = new ClienteDAO();
        public frm_clientes()
        {
            InitializeComponent();
            txt_idcliente.Enabled = false;
        }

        private void Guardar_clientes(object sender, EventArgs e)
        {
            cliente.Nombre = txt_nom_cliente.Text;
            cliente.Apellidos = txt_apell_clinte.Text;
            cliente.Direccion = txt_direcc_cliente.Text;
            cliente.Telefono = txt_tele_cliente.Text;

            clientes.Agregar(cliente);

            limpiar();
        }
        public void limpiar()
        {
            txt_apell_clinte.Clear();
            txt_direcc_cliente.Clear();
            txt_nom_cliente.Clear();
            txt_tele_cliente.Clear();
        }

        private void Modificar_clientes(object sender, EventArgs e)
        {
            txt_nom_cliente.Text = cliente.Nombre;
            txt_apell_clinte.Text = cliente.Apellidos;
            txt_direcc_cliente.Text = cliente.Direccion;
            txt_tele_cliente.Text = cliente.Telefono;
        }
    }
}
