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
        }

        private void Guardar_clientes(object sender, EventArgs e)
        {

        }
    }
}
