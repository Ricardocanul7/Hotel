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

namespace Hotel.GUI
{
    public partial class Frm_Transacciones : MetroFramework.Forms.MetroForm
    {
        public Frm_Transacciones()
        {
            InitializeComponent();
        }

        private void Validar_monto(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }
    }
}
