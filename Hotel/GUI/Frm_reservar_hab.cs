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
        ReservasBO reservaBO_mod = null;
        ReservasBO reservasBO = new ReservasBO();

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
                if((string)rows[i][10] == "Disponible")
                {
                    cbo_habitaciones.Items.Add(rows[i][0] + "-" + rows[i][1]);
                }
                
            }
        }

        private void btn_guardar_res_Click(object sender, EventArgs e)
        {
            if(reservaBO_mod != null)
            {
                if(reservaDAO.Modificar(Recuperar_Informacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado la reserva");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al modificar la reserva!");
                }

            }
            else
            {
                if (reservaDAO.Agregar(Recuperar_Informacion()) == 1)
                {
                    MessageBox.Show("Se ha registrado la reserva");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al hacer la reserva!");
                }
            } 
        }

        internal ReservasBO Recuperar_Informacion()
        {
            
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
            if (rdb_pagado.Checked == true)
                reservasBO.Estado = true;
            else
                reservasBO.Estado = false;

            return reservasBO;
        }

        public void Add_reserva_mod(int folio)
        {
            reservaBO_mod = reservaDAO.Buscar(folio);
            btn_guardar.Text = "Modificar";
            reservasBO.Folio_reserva = folio;

            for(int i = 0; i < cbo_habitaciones.Items.Count; i++)
            {
                if (cbo_habitaciones.Items[i].ToString().Split('-')[0] == reservaBO_mod.Habitacion.Num_habitacion.ToString())
                    cbo_habitaciones.SelectedIndex = i;
            }

            Txt_id_cliente.Text = reservaBO_mod.Cliente.Cliente_id.ToString();
            Dtm_checkin.Value = reservaBO_mod.Fecha_entrada;
            Dtm_checkout.Value = reservaBO_mod.Fecha_salida;
            Txt_detalles_reserva.Text = reservaBO_mod.Detalles;
            if (reservaBO_mod.Estado == true)
                rdb_pagado.Checked = true;
            else
                rdb_pago_pendiente.Checked = true;
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

                if(rows.Length > 0)
                {
                    if(Txt_nom_cliente.Text != rows[0]["nombre"].ToString())
                    {
                        Txt_id_cliente.Text = rows[0]["cliente_id"].ToString();
                        Txt_nom_cliente.Text = rows[0]["nombre"] as string; ;
                        Txt_apell_patern_cliente.Text = rows[0]["apaterno"] as string;
                        txt_apelli_matern_cli.Text = rows[0]["amaterno"] as string;
                        Txt_dir_cliente.Text = rows[0]["direccion"] as string;
                        txt_email.Text = rows[0]["email"] as string;
                        Txt_telefono_cliente.Text = rows[0]["telefono"] as string;
                    }
                    
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

        private void Txt_nom_cliente_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            DataRow[] rows = clienteDAO.Buscar().Select(String.Format("nombre LIKE '{0}%'", Txt_nom_cliente.Text));
            foreach (var item in rows)
                Txt_nom_cliente.AutoCompleteCustomSource.Add(item["nombre"].ToString());

            if (Txt_nom_cliente.Text != "")
            {
                if (rows.Length > 0)
                {
                    //Txt_id_cliente.Text = (int)rows[0]["cliente_id"];
                    if(Txt_nom_cliente.Text == rows[0]["nombre"] as string)
                    {
                        Txt_id_cliente.Text = rows[0]["cliente_id"].ToString();
                    }
                    else
                    {
                        Txt_id_cliente.Clear();
                    }

                    Txt_nom_cliente.DeselectAll();
                    Txt_nom_cliente.SelectionStart = Txt_nom_cliente.Text.Length;
                    Txt_apell_patern_cliente.Text = rows[0]["apaterno"] as string;
                    txt_apelli_matern_cli.Text = rows[0]["amaterno"] as string;
                    Txt_dir_cliente.Text = rows[0]["direccion"] as string;
                    txt_email.Text = rows[0]["email"] as string;
                    Txt_telefono_cliente.Text = rows[0]["telefono"] as string;
                }
            }
            else
            {
                LimpiarCamposCliente();
            }
        }
    }
}
