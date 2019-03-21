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
        }

        private void cbo_usuario_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
