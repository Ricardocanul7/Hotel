using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.GUI
{
    public partial class Frm_Login : MetroFramework.Forms.MetroForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /** Validar usuario y contraseña */ //PENDIENTE

            // CODIGO PROVISIONAL
            Frm_menu menu = new Frm_menu();
            menu.Owner = this;
            this.Hide();
            menu.Show();
        }
    }
}
