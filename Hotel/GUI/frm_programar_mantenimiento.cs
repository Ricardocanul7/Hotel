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
    public partial class frm_programar_mantenimiento : Form
    {
        LimpiezaBO limpiezaBO = new LimpiezaBO();
        LimpiezaDAO limpiezaDAO = new LimpiezaDAO();
        int Filaseleccionada = -1;
        private DataTable datos;
        public frm_programar_mantenimiento()
        {
             InitializeComponent();
        }


        private void Abrir_Limpieza(object sender, EventArgs e)
        {
            frm_agregar_limpieza form_agregarLimpieza = new frm_agregar_limpieza();
            if (form_agregarLimpieza.ShowDialog() == DialogResult.OK)
            {
                dgv_Limpieza.DataSource = limpiezaDAO.Buscar();
                dgv_Limpieza.Update();
            }
        }
    }
}
