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

        private void btn_guardar_transaccion_Click(object sender, EventArgs e)
        {
            if (transaccionDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha registrado la transaccion");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha habido un error al hacer la transacción");
            }
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
    }
}
