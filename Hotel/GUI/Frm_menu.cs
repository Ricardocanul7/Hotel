using Hotel.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void btn_reservaciones_Click(object sender, EventArgs e)
        {
            Frm_reservaciones form_reservas = new Frm_reservaciones();
            form_reservas.Owner = this;
            form_reservas.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void btn_agregar_habitaciones_Click(object sender, EventArgs e)
        {
            frm_habitaciones frm_agregar_habit = new frm_habitaciones();
            frm_agregar_habit.Show();
        }
    }
}
