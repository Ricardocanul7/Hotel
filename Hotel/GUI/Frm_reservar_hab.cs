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
    public partial class Frm_reservar_hab : MetroFramework.Forms.MetroForm
    {
        ReservaDAO reservaDAO;
        HabitacionDAO habitacionDAO;

        public Frm_reservar_hab()
        {
            InitializeComponent();
            
            reservaDAO = new ReservaDAO();
            habitacionDAO = new HabitacionDAO();

            /*
            cbo_tipohab.Items.Add("SELECCIONAR");
            cbo_tipohab.Items.Add("CABAÑA");
            cbo_tipohab.Items.Add("CABAÑA ST");
            cbo_tipohab.Items.Add("SUITE JAR");
            cbo_tipohab.Items.Add("SUITE LAG");
            cbo_tipohab.Items.Add("DUPLEX");
            cbo_tipohab.Items.Add("DUPLEX LAG");
            
            cbo_tipohab.SelectedIndex = 0;
            **/

            Set_cbo_habitaciones();
        }

        public void Set_cbo_habitaciones()
        {
            DataRow[] rows = habitacionDAO.Buscar().Select();

            for (int i = 0; i < rows.Length; i++)
            {
                if((int)rows[i][10] == 4)
                {
                    cbo_habitaciones.Items.Add(rows[i][0] + "-" + rows[i][1]);
                }
                
            }
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

            int id_habitacion = Convert.ToInt32(cbo_habitaciones.SelectedItem.ToString().Split('-')[0]);

            habitacionBO.Num_habitacion = Convert.ToInt32(id_habitacion);
            clienteBO.Cliente_id = Convert.ToInt32(Txt_id_cliente.Text);

            reservasBO.Habitacion = habitacionBO;
            reservasBO.Fecha_entrada = Dtm_checkin.Value.Date;
            reservasBO.Fecha_salida = Dtm_checkout.Value.Date;
            reservasBO.Detalles = Txt_detalles_reserva.Text;
            reservasBO.Cliente = clienteBO;

            return reservasBO;
        }

        private void cbo_habitaciones_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbo_habitaciones.SelectedIndex;

            DataRow[] rows = habitacionDAO.Buscar().Select();
            DataRow[] rowsTipo = habitacionDAO.BuscarTipoHabitacion().Select();

            for(int i = 0; i < rows.Length; i++)
            {
                if ((int)rows[i][0] == Convert.ToInt32(cbo_habitaciones.Items[index].ToString().Split('-')[0]))
                {
                    int tipo_id = (int)rows[i][8] - 1;
                    txt_tipo_hab.Text = rowsTipo[tipo_id]["nombre_tipo"].ToString();
                    break;
                }
            } 
        }

        private void Txt_id_cliente_TextChanged(object sender, EventArgs e)
        {
            if(Txt_id_cliente.Text != "")
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                DataRow[] rows = clienteDAO.Buscar().Select(String.Format("cliente_id = '{0}'", Txt_id_cliente.Text));

                if(rows.Length >= Convert.ToInt32(Txt_id_cliente.Text))
                {
                    ClienteBO clienteBO = new ClienteBO();
                    clienteBO.Cliente_nombre = rows[0]["nombre"] as string;
                    clienteBO.Cliente_apaterno = rows[0]["apaterno"] as string;
                    clienteBO.Cliente_amaterno = rows[0]["amaterno"] as string;
                    clienteBO.Cliente_direccion = rows[0]["direccion"] as string;
                    clienteBO.Cliente_email = rows[0]["email"] as string;
                    clienteBO.Cliente_telefono = rows[0]["telefono"] as string;

                    Txt_nom_cliente.Text = clienteBO.Cliente_nombre;
                    Txt_apell_patern_cliente.Text = clienteBO.Cliente_apaterno;
                    txt_apelli_matern_cli.Text = clienteBO.Cliente_amaterno;
                    Txt_dir_cliente.Text = clienteBO.Cliente_direccion;
                    txt_email.Text = clienteBO.Cliente_email;
                    Txt_telefono_cliente.Text = clienteBO.Cliente_telefono;
                }
                else
                {
                    LimpiarCamposCliente();
                }
            }
            else
            {
                LimpiarCamposCliente();
            }
        }

        private void LimpiarCamposCliente()
        {
            Txt_nom_cliente.Clear();
            Txt_apell_patern_cliente.Clear();
            txt_apelli_matern_cli.Clear();
            Txt_dir_cliente.Clear();
            txt_email.Clear();
            Txt_telefono_cliente.Clear();
        }
    }
}
