﻿using Hotel.BO;
using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.GUI
{
    public partial class Frm_reservaciones : Form
    {
        ReservaDAO reservaDAO;
        ReservasBO reservaBO;

        public Frm_reservaciones()
        {
            InitializeComponent();
            reservaDAO = new ReservaDAO();
            reservaBO = new ReservasBO();

            Grd_Reservaciones.DataSource = reservaDAO.Buscar();
        }

        private void btn_reservarhab_Click(object sender, EventArgs e)
        {
            Frm_reservar_hab reservar_Hab = new Frm_reservar_hab();
            if(reservar_Hab.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
