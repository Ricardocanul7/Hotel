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
            Set_cbo_usuario();
        }

        public void Set_cbo_usuario()
        {
            DataRow[] rows = usuariodao.Buscar().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_usuario.Items.Add(rows[i][0]);
            }

            cbo_usuario.SelectedIndex = 0;
        }

        private void Validar_monto(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }

        private void btn_guardar_transaccion_Click(object sender, EventArgs e)
        {
            transaccionbo.Descripccion = Txt_Descripcion.Text;
            transaccionbo.Monto = Convert.ToDouble(txt_monto.Text);
            transaccionbo.Fecha = dtp_fecha.Value.Date;
            tipotransaccionBO.Tipo_id = cmb_tipo.SelectedIndex;
            reservaBO.Folio_reserva = Convert.ToInt32(Txt_folio_reserva.Text);
            usuariobo.Id_usuario = cbo_usuario.SelectedIndex;


            transaccionDAO.Agregar(transaccionbo);
            if (transaccionDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha registrado el Corte de Caja");
            }
            else
            {
                MessageBox.Show("Ha habido un error al hacer el Corte de Caja");
            }
            Limpiar();
        }

        private TransaccionBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_num_transaccion.Text, out id);

            transaccionbo.Codigo_transaccion = id;
            transaccionbo.Monto = Convert.ToDouble(txt_monto.Text);
            transaccionbo.Fecha = dtp_fecha.Value.Date;
            transaccionbo.Descripccion= Txt_Descripcion.Text;
            transaccionbo.Tipo = tipotransaccionBO;
            transaccionbo.Folio = reservaBO;
            transaccionbo.Usuario = usuariobo;

            return transaccionbo;
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
