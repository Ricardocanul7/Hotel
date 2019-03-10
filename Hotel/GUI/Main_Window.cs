﻿using System;
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
    public partial class Main_Window : MetroFramework.Forms.MetroForm
    {
        Frm_Login loginWindow;
        public Main_Window()
        {
            InitializeComponent();
            AbrirPantallaInicial();
        }

        protected override void OnClosed(EventArgs e)
        {
            this.loginWindow.Close();
        }

        public void VentanaHija(object frm_Login)
        {
            loginWindow = (Frm_Login)frm_Login;
        }

        

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            AbrirPantallaInicial();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            AbrirPantallaEmpleado();
        } 

        private void btn_reservaciones_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            AbrirPantallaReservaciones();
        }

        public void AbrirPantallaInicial()
        {
            var ventana = new Frm_menu();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "INICIO";
        }

        public void AbrirPantallaEmpleado()
        {
            var ventana = new Frm_menu_empleados();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "EMPLEADOS";
        }

        public void AbrirPantallaReservaciones()
        {
            var ventana = new Frm_reservaciones();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "RESERVACIONES";
        }
    }
}
