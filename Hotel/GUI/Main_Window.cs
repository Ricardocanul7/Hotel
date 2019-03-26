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
    public partial class Main_Window : MetroFramework.Forms.MetroForm
    {
        Frm_Login loginWindow;
        public Main_Window()
        {
            InitializeComponent();
            AbrirPantallaInicial();
            lbl_nombre_usuario.Text = DatosLogin.Nombre + " " + DatosLogin.Apaterno;
        }

        protected override void OnClosed(EventArgs e)
        {
            this.loginWindow.Close();
        }

        public void VentanaHija(object frm_Login)
        {
            loginWindow = (Frm_Login)frm_Login;
        }

        public void AbrirPantallaInicial()
        {
            this.panel_principal.Controls.Clear();
            this.WindowState = FormWindowState.Maximized;
            var ventana = new Frm_reservaciones();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "RESERVACIONES";
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            var ventana = new Frm_menu_empleados();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "EMPLEADOS";
        } 

        private void btn_reservaciones_Click(object sender, EventArgs e)
        {
            AbrirPantallaInicial();
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            var ventana = new Frm_mantenimiento();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "MANTENIMIENTO";
        }

        private void btn_habitaciones_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            var ventana = new Frm_menu();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "HABITACIONES";
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            var ventana = new Frm_menu_caja();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "CAJA";

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            this.panel_principal.Controls.Clear();
            var ventana = new frm_clientes();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.FormBorderStyle = FormBorderStyle.None;
            this.panel_principal.Controls.Add(ventana);
            ventana.Show();
            lbl_titulo.Text = "CLIENTES";

        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.loginWindow.Show();
            this.Dispose();
        }
    }
}
