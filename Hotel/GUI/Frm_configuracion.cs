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
    public partial class Frm_configuracion : MetroFramework.Forms.MetroForm
    {
        TipohabBO tipohabBO;
        public Frm_configuracion()
        {
            InitializeComponent();
            tipohabBO = new TipohabBO();
        }

        private void btn_guardar_tipo_Click(object sender, EventArgs e)
        {

        }

        private TipohabBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_tipo_id.Text, out id);

            tipohabBO.Tipo_id = id;
            tipohabBO.Nombre = txt_nombre_tipo.Text;

            return tipohabBO;
        }
    }
}
