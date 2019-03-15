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
    public partial class Frm_reservar_hab : Form
    {
        ReservaDAO reservaDAO;

        public Frm_reservar_hab()
        {
            InitializeComponent();
            
            reservaDAO = new ReservaDAO();

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
            if(reservaDAO.Agregar(Recuperar_Informacion()) == 1)
            {
                MessageBox.Show("Se ha registrado la reserva");
            }
            else
            {
                MessageBox.Show("Ha habido un error al hacer la reserva!");
            }
        }

        internal ReservasBO Recuperar_Informacion()
        {
            ReservasBO reservasBO = new ReservasBO();
            HabitacionBO habitacionBO = new HabitacionBO();
            ClienteBO clienteBO = new ClienteBO();

            habitacionBO.Nombre_hab = cbo_habitaciones.Text;
            habitacionBO.Tipo_hab = cbo_tipohab.Text;
            habitacionBO.Max_adultos = Convert.ToInt32(cbo_max_adult.Text);
            habitacionBO.Max_ninios = Convert.ToInt32(cbo_max_ninios.Text);
            clienteBO.Cliente_id = Convert.ToInt32(Txt_id_cliente.Text);
            clienteBO.Cliente_nombre = Txt_nom_cliente.Text;
            clienteBO.Cliente_apaterno = Txt_apell_patern_cliente.Text;
            clienteBO.Cliente_amaterno = txt_apelli_matern_cli.Text;
            clienteBO.Cliente_direccion = Txt_dir_cliente.Text;
            clienteBO.Cliente_email = txt_email.Text;
            clienteBO.Cliente_telefono = Txt_telefono_cliente.Text;


            reservasBO.Cliente = clienteBO;
            reservasBO.Habitacion = habitacionBO;
            reservasBO.Fecha_entrada = Dtm_checkin.Value.Date;
            reservasBO.Fecha_salida = Dtm_checkout.Value.Date;
            reservasBO.Detalles = Txt_detalles_reserva.Text;

            return reservasBO;
        }
    }
}
