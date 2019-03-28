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
    public partial class Frm_menu_caja : Form
    {
        CajaDAO cajaDAO;
        CajaBO cajaBO;

        public Frm_menu_caja()
        {
            InitializeComponent();
            cajaDAO = new CajaDAO();
            cajaBO = new CajaBO();
        }

        private void seleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            Frm_corte_caja corte_Caja = new Frm_corte_caja();
            if (corte_Caja.ShowDialog() == DialogResult.OK)
            {
                dgv_transacciones.DataSource = cajaDAO.Buscar();
                dgv_transacciones.Update();
            }
        }

        private void btn_nvatransaccion_Click(object sender, EventArgs e)
        {
            Frm_Transacciones frm_Transacciones = new Frm_Transacciones();
            
            if(frm_Transacciones.DialogResult == DialogResult.OK)
            {
                // AQUI CODIGO PARA ACTUALIZAR EL GRID
                // AL CERRAR LA VENTANA DESPUES DE GUARDAR
            }
        }
    }
}
