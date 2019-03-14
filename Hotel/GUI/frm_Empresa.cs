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
    public partial class frm_Empresa : MetroFramework.Forms.MetroForm
    {
        EmpresaBO empresa = new EmpresaBO();
        EmpresaDAO empresas = new EmpresaDAO();

        public frm_Empresa()
        {
            InitializeComponent();
        }

        private void Guardar_click(object sender, EventArgs e)
        {
            empresa.Nombre = txt_nombre_empresa.Text;
            empresa.RFC = txt_rfc_empresa.Text;

            empresas.Agregar(empresa);

            limpiar();
        }
        public void limpiar()
        {
            txt_nombre_empresa.Clear();
            txt_rfc_empresa.Clear();
        }

        private void Modifica_empresa(object sender, EventArgs e)
        {
            txt_nombre_empresa.Text = empresa.Nombre;
            txt_rfc_empresa.Text = empresa.RFC;

            empresas.Modificar(empresa);
        }
    }
}
