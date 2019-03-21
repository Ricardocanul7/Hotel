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
        CajaBO cajabo = new CajaBO();
        UsuarioDAO usuariodao = new UsuarioDAO();
        UsuarioBO usuariobo = new UsuarioBO();
        Conexion Miconexion = new Conexion();



        public Frm_corte_caja()
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

        

        private void btn_guardar_empresa_Click(object sender, EventArgs e)
        {
            cajabo.Monto = Convert.ToDouble(txt_monto.Text);
            cajabo.Fecha = dtp_fecha.Value.Date;
            cajabo.Fecha = dtp_hora.Value.Date;
            usuariobo.Id_usuario = cbo_usuario.SelectedIndex;


            cajaDAO.Agregar(cajabo);
            if (cajaDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha registrado el Corte de Caja");
            }
            else
            {
                MessageBox.Show("Ha habido un error al hacer el Corte de Caja");
            }
            Limpiar();
        }

        private CajaBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_idcorte.Text, out id);

            cajabo.Corte_id = id;
            cajabo.Monto = Convert.ToDouble(txt_monto.Text);
            cajabo.Fecha = dtp_fecha.Value.Date;
            cajabo.Hora = dtp_hora.Value.Date;
            cajabo.Usuario = usuariobo;

            return cajabo;
        }

        /*internal CajaBO Recuperar_Informacion()
        {
            CajaBO cajabo = new CajaBO();
            UsuarioBO usuariobo = new UsuarioBO();

            cajabo.Monto = Convert.ToDouble(txt_monto.Text);
            cajabo.Fecha = dtp_fecha.Value.Date;
            cajabo.Hora = dtp_hora.Value.Date;
            cajabo.Usuario = usuariobo;

            return cajabo;

        }*/

        public void Limpiar()
        {
            txt_monto.Clear();
        }

        private void cbo_usuario_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
