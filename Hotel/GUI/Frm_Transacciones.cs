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
    public partial class Frm_Transacciones : MetroFramework.Forms.MetroForm
    {
        TransaccionDAO transaccionDAO = new TransaccionDAO();
        TransaccionBO transaccionbo = new TransaccionBO();
        UsuarioDAO usuariodao = new UsuarioDAO();
        UsuarioBO usuariobo = new UsuarioBO();
        ReservaDAO reservaDAO = new ReservaDAO();
        ReservasBO reservaBO = new ReservasBO();
        TipoTransaccionBO tipotransaccionBO = new TipoTransaccionBO();
        TipoTransaccionDAO tipotransaccionDAO = new TipoTransaccionDAO();
        Conexion Miconexion = new Conexion();
        public Frm_Transacciones()
        {
            InitializeComponent();
            transaccionbo.Usuario = new UsuarioBO();
            transaccionbo.Tipo = new TipoTransaccionBO();

            Set_cbo_tipo();

            dtp_fecha.Value = DateTime.Now;
            dtp_hora.Value = DateTime.Now;
        }

        public void Set_cbo_tipo()
        {
            DataRow[] rows = transaccionDAO.Buscar_tipoTransaccion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_tipo.Items.Add(rows[i]["nombre_transaccion"]);
            }
            cbo_tipo.SelectedIndex = 0;
        }

        private void Validar_monto(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }
        public void ValidarTextBox()
        {
            if(Txt_folio_reserva.Text =="" | txt_monto.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (transaccionDAO.Agregar(RecuperarInformacion()) == 1)
                {
                    int folio = Convert.ToInt32(Txt_folio_reserva.Text);
                    reservaDAO.PagarReserva(folio); // La reserva cambia de estado a pagado

                    MessageBox.Show("Se ha registrado la transaccion");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha habido un error al hacer la transacción");
                }
            }
        }
        private void btn_guardar_transaccion_Click(object sender, EventArgs e)
        {
            ValidarTextBox();
        }

        private TransaccionBO RecuperarInformacion()
        {
            TransaccionBO transaccionTemp = new TransaccionBO();
            transaccionTemp.Tipo = new TipoTransaccionBO();
            transaccionTemp.Usuario = new UsuarioBO();
            transaccionTemp.Folio = new ReservasBO();

            if(txt_num_transaccion.Text != "")
            {
                int id = 0;
                int.TryParse(txt_num_transaccion.Text, out id);

                transaccionTemp.Codigo_transaccion = id;
            }

            transaccionTemp.Monto = Convert.ToDouble(txt_monto.Text);
            transaccionTemp.Fecha = dtp_fecha.Value;
            transaccionTemp.Hora = DateTime.Now;
            transaccionTemp.Descripccion= Txt_Descripcion.Text;
            transaccionTemp.Folio.Folio_reserva = Convert.ToInt32(Txt_folio_reserva.Text);

            DataRow[] tipo_row = tipotransaccionDAO.Buscar().Select(String.Format("nombre_transaccion = '{0}'", cbo_tipo.Text));
            transaccionTemp.Tipo.Tipo_id = Convert.ToInt32(tipo_row[0]["tipo_id"]);

            DataRow[] us_row = usuariodao.Buscar().Select(string.Format("usuario_id = {0}", DatosLogin.Id_usuario));
            transaccionTemp.Usuario.Id_usuario = Convert.ToInt32(us_row[0]["usuario_id"]);

            return transaccionTemp;
        }

        public void Limpiar()
        {
            txt_monto.Clear();
            Txt_folio_reserva.Clear();
            txt_num_transaccion.Clear();
            txt_num_transaccion.Clear();
            Txt_Descripcion.Clear();
        }

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            if(Txt_folio_reserva.Text != string.Empty)
            {
                ReservaDAO reserva = new ReservaDAO();
                DataRow[] res_row = reserva.Buscar().Select(String.Format("folio_reserva = {0}", Txt_folio_reserva.Text));

                if(res_row.Length > 0)
                {
                    bool estado = Convert.ToBoolean(res_row[0]["estado_pagado"]);
                    if (estado == false)
                    {
                        int num_habitacion = Convert.ToInt32(res_row[0]["num_habitacion"]); // Numero de habitacion
                        HabitacionDAO habitacion = new HabitacionDAO();
                        DataRow[] hab_row = habitacion.Buscar().Select(String.Format("num_habitacion = {0}", num_habitacion));

                        decimal precio = Convert.ToDecimal(hab_row[0]["precio_baja"]);  // Precio Habitacion
                        DateTime entrada = DateTime.Parse(res_row[0]["fecha_entrada"].ToString());
                        DateTime salida = DateTime.Parse(res_row[0]["fecha_salida"].ToString());

                        TimeSpan timeSpan = salida.Subtract(entrada);
                        int num_dias = timeSpan.Days;

                        // OPERACION (PRECIO + IVA) * DIAS
                        decimal monto = 0.00m;
                        monto = (precio * 1.16m) * num_dias;

                        txt_monto.Text = monto.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La reserva ya ha sido pagada");
                        txt_monto.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Folio no existente");
                    txt_monto.Clear();
                }
            }
            else
            {
                MessageBox.Show("Folio de reserva necesario!");
            }
            
        }
    }
}
