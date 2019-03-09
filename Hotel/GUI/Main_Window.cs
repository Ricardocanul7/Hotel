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
        }

        protected override void OnClosed(EventArgs e)
        {
            this.loginWindow.Close();
        }

        public void VentanaHija(object frm_Login)
        {
            loginWindow = (Frm_Login)frm_Login;
        }
    }
}
