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
    public partial class Frm_mantenimiento : Form
    {
        public Frm_mantenimiento()
        {
            InitializeComponent();
        }

        private void Nueva_Empresa_Click(object sender, EventArgs e)
        {
            this.panel_mantenimiento.Controls.Clear();
            var ventana = new frm_Empresa();
            ventana.Show();

        }
    }
}
