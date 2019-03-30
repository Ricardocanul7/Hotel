﻿using System;
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
        TransaccionBO transaccioBO;
        TransaccionDAO transaccionDAO;
        UsuarioBO usuarioBO;
        TipoTransaccionBO tipotransaccionBO;
        TipoTransaccionDAO tipotransaccionDAO;
        private DataTable datos;
        int Filaseleccionada_trans = -1;
        int Filaseleccionada_corte = -1;
        public Frm_menu_caja()

        {
            InitializeComponent();
            cajaDAO = new CajaDAO();
            cajaBO = new CajaBO();
            transaccioBO = new TransaccionBO();
            transaccionDAO = new TransaccionDAO();
            usuarioBO = new UsuarioBO();
            tipotransaccionBO = new TipoTransaccionBO();
            tipotransaccionDAO = new TipoTransaccionDAO();

            dgv_transacciones.DataSource = transaccionDAO.Buscar();
            dgv_transacciones.AllowUserToAddRows = false;
            dgv_transacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_transacciones.ReadOnly = true;

            dgv_corte.DataSource = cajaDAO.Buscar();
            dgv_corte.AllowUserToAddRows = false;
            dgv_corte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_corte.ReadOnly = true;
        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            Frm_corte_caja corte_Caja = new Frm_corte_caja();
            if (corte_Caja.ShowDialog() == DialogResult.OK)
            {
                dgv_corte.DataSource = cajaDAO.Buscar();
                dgv_corte.Update();
            }
        }

        private void btn_nvatransaccion_Click(object sender, EventArgs e)
        {
            Frm_Transacciones transacciones = new Frm_Transacciones();
            if (transacciones.ShowDialog() == DialogResult.OK)
            {
                dgv_transacciones.DataSource = transaccionDAO.Buscar();
                dgv_transacciones.Update();
            }
        }

        private void Seleccionar_fila_trans(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filaseleccionada_trans = e.RowIndex;

            if (Filaseleccionada_trans >= 0)
            {
                transaccioBO.Codigo_transaccion = int.Parse(dgv_transacciones.Rows[Filaseleccionada_trans].Cells["Codigo"].Value.ToString());
                transaccioBO.Monto = double.Parse(dgv_transacciones.Rows[Filaseleccionada_trans].Cells["monto"].Value.ToString());
                transaccioBO.Fecha = DateTime.Parse(dgv_transacciones.Rows[Filaseleccionada_trans].Cells["fecha"].Value.ToString());
                transaccioBO.Descripccion = dgv_transacciones.Rows[Filaseleccionada_trans].Cells["Descripccion"].Value.ToString();
                tipotransaccionBO.Tipo_id = int.Parse(dgv_transacciones.Rows[Filaseleccionada_trans].Cells["Tipo"].Value.ToString());
            }
        }

        private void Selecionar_fila_corte(object sender, DataGridViewCellMouseEventArgs e)
        {
            Filaseleccionada_corte = e.RowIndex;

            if (Filaseleccionada_corte >= 0)
            {
                cajaBO.Corte_id = int.Parse(dgv_corte.Rows[Filaseleccionada_corte].Cells["corte_id"].Value.ToString());
                cajaBO.Monto = double.Parse(dgv_corte.Rows[Filaseleccionada_corte].Cells["monto"].Value.ToString());
                cajaBO.Fecha = DateTime.Parse(dgv_corte.Rows[Filaseleccionada_corte].Cells["fecha"].Value.ToString());
                cajaBO.Hora = DateTime.Parse(dgv_corte.Rows[Filaseleccionada_corte].Cells["hora"].Value.ToString());
                usuarioBO.Id_usuario = int.Parse(dgv_corte.Rows[Filaseleccionada_corte].Cells["usuario_id"].Value.ToString());
            }
        }
    }
}
