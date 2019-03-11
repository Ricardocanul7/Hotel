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

namespace Hotel.GUI
{
    public partial class Frm_reservar_hab : Form
    {
        ReservasBO reservasBO;
        public Frm_reservar_hab()
        {
            InitializeComponent();
            reservasBO = new ReservasBO();
            cbo_tipohab.Items.Add("SELECCIONAR");
            cbo_tipohab.Items.Add("CABAÑA");
            cbo_tipohab.Items.Add("CABAÑA ST");
            cbo_tipohab.Items.Add("SUITE JAR");
            cbo_tipohab.Items.Add("SUITE LAG");
            cbo_tipohab.Items.Add("DUPLEX");
            cbo_tipohab.Items.Add("DUPLEX LAG");

            cbo_tipohab.SelectedIndex = 0;
        }

        private void btn_guardar_res_Click(object sender, EventArgs e)
        {
            reservasBO.Nombre_hab = cbo_habitaciones.Text;
            reservasBO.Tipo_hab = cbo_tipohab.Text;
            reservasBO.Numx_per = Convert.ToInt32(cbo_nump.Text);
            reservasBO.Id_cliente = Convert.ToInt32(Txt_id_cliente);
            reservasBO.Nom_cliente = Txt_nom_cliente.Text;
            reservasBO.Apell_cliente = Txt_apell_cliente.Text;
            reservasBO.Dir_cliente = Txt_dir_cliente.Text;
            reservasBO.Email = txt_email.Text;
            reservasBO.Tel_cliente = Txt_telefono_cliente.Text;
            reservasBO.Fecha_ent = Dtm_checkin.Text;
            reservasBO.Fecha_sal = Dtm_checkout.Text;
        }
    }
}
