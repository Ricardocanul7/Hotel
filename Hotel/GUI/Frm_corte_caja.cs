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
    public partial class Frm_corte_caja : MetroFramework.Forms.MetroForm
    {
        CajaDAO cajaDAO = new CajaDAO();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        TransaccionDAO transaccionDAO = new TransaccionDAO();

        public Frm_corte_caja()
        {
            InitializeComponent();

            dtp_fecha.Value = DateTime.Now;
            dtp_hora.Value = DateTime.Now;

            CargarDatos();
        }

        public void CargarDatos()
        {
            decimal total = 0;

            DataRow[] trans_rows = transaccionDAO.Buscar().Select(String.Format("fecha = '{0}'", DateTime.Now.ToString("yyyy-MM-dd")));
            if (trans_rows.Length > 0)
            {
                for (int i = 0; i < trans_rows.Length; i++)
                {
                    total += Convert.ToDecimal(trans_rows[i]["monto"]);
                }
                // Al terminar de acumular mostrar la cantidad todal cobrado hoy
                this.txt_monto.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("No hay transacciones el dia de hoy");
            }
        }

        private void btn_guardar_empresa_Click(object sender, EventArgs e)
        {
            if (cajaDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha registrado el Corte de Caja");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha habido un error al hacer el Corte de Caja");
            }
            Limpiar();
        }

        private CajaBO RecuperarInformacion()
        {
            CajaBO cajaBO = new CajaBO();
            int id = 0;
            int.TryParse(txt_idcorte.Text, out id);

            cajaBO.Corte_id = id;
            cajaBO.Monto = Convert.ToDouble(txt_monto.Text);
            cajaBO.Fecha = dtp_fecha.Value;
            cajaBO.Hora = DateTime.Now;

            cajaBO.Usuario = new UsuarioBO();
            cajaBO.Usuario.Id_usuario = DatosLogin.Id_usuario;

            return cajaBO;
        }

        public void Limpiar()
        {
            txt_monto.Clear();
        }

        private void Validar_monto(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }
    }
}
