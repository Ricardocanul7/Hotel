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
    public partial class Frm_Login : MetroFramework.Forms.MetroForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /** Validar usuario y contraseña */ //PENDIENTE
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            string email = txt_correo.Text;
            string pass = txt_password.Text;

            DataRow[] row = usuarioDAO.Buscar().Select(string.Format("email = '{0}'", email));

            if(row.Length > 0)
            {
                if(row[0]["password"].ToString() == pass)
                {
                    DatosLogin.Email = email;
                    DatosLogin.Password = pass;
                    DatosLogin.Id_usuario = (int)row[0]["usuario_id"];
                    DatosLogin.Nombre = row[0]["nombre"].ToString();
                    DatosLogin.Apaterno = row[0]["apellido_patern"].ToString();
                    DatosLogin.Amaterno = row[0]["apellido_matern"].ToString();
                    DatosLogin.Tipo_usuario = (int)row[0]["usuario_tipo"];
                    
                    Main_Window menu = new Main_Window();
                    menu.VentanaHija(this);
                    this.Hide();
                    this.txt_correo.Clear();
                    this.txt_password.Clear();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta!");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado!");
            }

            // CODIGO PROVISIONAL
            /*
            Main_Window menu = new Main_Window();
            menu.VentanaHija(this);
            this.Hide();
            menu.Show();
            */
        }
    }
}
