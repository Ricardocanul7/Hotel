﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        decimal precioMasIVA = 0.00m;
        double num_noches = 1;

        public Frm_reservar_hab()
        {
            InitializeComponent();
            
            reservaDAO = new ReservaDAO();
            habitacionDAO = new HabitacionDAO();

            this.LimitDate();

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

            
        }

        public void LimitDate()
        {
            Dtm_checkout.MinDate = DateTime.Now.AddDays(1);
            num_noches = 1;
            lbl_num_noches.Text = num_noches.ToString();
            Lbl_total_pago.Text = (precioMasIVA * (decimal)num_noches).ToString();
        }

        public void Set_cbo_habitaciones()
        {
            DataRow[] rows = habitacionDAO.Buscar().Select();

            for (int i = 0; i < rows.Length; i++)
            {
                if((string)rows[i]["estado"] == "Disponible")
                {
                    cbo_habitaciones.Items.Add(rows[i][0] + "-" + rows[i][1]);
                }

                if(reservaBO_mod != null)
                {
                    if (reservaBO_mod.Habitacion.Num_habitacion == Convert.ToInt32(rows[i]["num_habitacion"]))
                    {
                        cbo_habitaciones.Items.Add(rows[i][0] + "-" + rows[i][1]);
                    }
                }
            }
        }
        public void ValidarTexbox()
        {
            if(txt_apelli_matern_cli.Text =="" | Txt_apell_patern_cliente.Text =="" | Txt_dir_cliente.Text =="" | txt_email.Text =="" | Txt_nom_cliente.Text =="" |Txt_id_cliente.Text =="" | Txt_telefono_cliente.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (reservaBO_mod != null)
                {
                    if (reservaDAO.Modificar(Recuperar_Informacion()) == 1)
                    {
                        MessageBox.Show("Se ha modificado la reserva");
                        this.DialogResult = DialogResult.OK;
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
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al hacer la reserva!");
                    }
                }
            }
        }

        private void btn_guardar_res_Click(object sender, EventArgs e)
        {
            ValidarTexbox();
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
            reservasBO.Estado = false;  // Preterminado pago no hecho

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

            this.Dtm_checkout.MinDate = reservaBO_mod.Fecha_entrada.AddDays(1);
            Dtm_checkout.Value = reservaBO_mod.Fecha_salida;
            Txt_detalles_reserva.Text = reservaBO_mod.Detalles;
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
                    //int tipo_id = (int)rows[i][8] - 1;
                    txt_tipo_hab.Text = rows[i]["nombre_tipo"].ToString();
                    break;
                }
            }

            // Establecer precio de habitacion
            int num_habitacion = Convert.ToInt32(cbo_habitaciones.Items[index].ToString().Split('-')[0]);
            DataRow[] rowHab = habitacionDAO.Buscar().Select(string.Format("num_habitacion = '{0}'", num_habitacion));
            decimal precio = Convert.ToDecimal(rowHab[0]["precio_baja"]);
            lbl_precio_res.Text = (precio * 1.00m).ToString();
            decimal iva = precio * 0.16m;
            lbl_iva.Text = iva.ToString();

            precioMasIVA = precio + iva;
            Lbl_total_pago.Text = (precioMasIVA * (decimal)num_noches).ToString();
        }

        private void Txt_id_cliente_TextChanged(object sender, EventArgs e)
        {
            /**
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
    */
        }

        private void LimpiarCamposCliente()
        {
            Txt_id_cliente.Clear();
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

        private void Dtm_checkout_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = Dtm_checkout.Value.Subtract(Dtm_checkin.Value);
            double num_noches = Math.Ceiling( span.TotalDays); // Pendiente de calcular
            lbl_num_noches.Text = num_noches.ToString();
            Lbl_total_pago.Text = (precioMasIVA * (decimal)num_noches).ToString();
        }

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                DataRow[] rows = clienteDAO.Buscar().Select(String.Format("cliente_id = '{0}'", Txt_id_cliente.Text));

                if (rows.Length > 0)
                {
                    Txt_id_cliente.Text = rows[0]["cliente_id"].ToString();
                    Txt_nom_cliente.Text = rows[0]["nombre"] as string; ;
                    Txt_apell_patern_cliente.Text = rows[0]["apaterno"] as string;
                    txt_apelli_matern_cli.Text = rows[0]["amaterno"] as string;
                    Txt_dir_cliente.Text = rows[0]["direccion"] as string;
                    txt_email.Text = rows[0]["email"] as string;
                    Txt_telefono_cliente.Text = rows[0]["telefono"] as string;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado!");
                    LimpiarCamposCliente();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error, ingresa solo valores numericos");
            }
            
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            DataRow[] rows = clienteDAO.Buscar().Select(String.Format("nombre LIKE '{0}%'", Txt_nom_cliente.Text));

            try
            {
                if (rows.Length > 0)
                {
                    Txt_id_cliente.Text = rows[0]["cliente_id"].ToString();
                    Txt_nom_cliente.Text = rows[0]["nombre"] as string;
                    Txt_apell_patern_cliente.Text = rows[0]["apaterno"] as string;
                    txt_apelli_matern_cli.Text = rows[0]["amaterno"] as string;
                    Txt_dir_cliente.Text = rows[0]["direccion"] as string;
                    txt_email.Text = rows[0]["email"] as string;
                    Txt_telefono_cliente.Text = rows[0]["telefono"] as string;
                }
                else
                {
                    LimpiarCamposCliente();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Validar_telefono(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }

        private void Frm_reservar_hab_Load(object sender, EventArgs e)
        {
            Set_cbo_habitaciones();

            if(reservaBO_mod != null)
            {
                for (int i = 0; i < cbo_habitaciones.Items.Count; i++)
                {
                    if (cbo_habitaciones.Items[i].ToString().Split('-')[0] == reservaBO_mod.Habitacion.Num_habitacion.ToString())
                        cbo_habitaciones.SelectedIndex = i;
                }
            }
        }
    }
}
