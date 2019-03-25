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
    public partial class frm_empresa : MetroFramework.Forms.MetroForm
    {
        EmpresaBO empresaBO = new EmpresaBO();
        EmpresaDAO empresaDAO = new EmpresaDAO();

        public frm_empresa()
        {
            InitializeComponent();
        }

        internal EmpresaBO RecuperarInformacion()
        {
            empresaBO.RFC = txt_rfc_empresa.Text;
            empresaBO.Nombre = txt_nombre_empresa.Text;
            empresaBO.Precio_hora = Convert.ToDecimal(txt_precio_hora.Text);

            return empresaBO;
        }
        public void Limpiar()
        {
            txt_nombre_empresa.Clear();
            txt_precio_hora.Clear();
            txt_rfc_empresa.Clear();
        }

        private void Guardar_empresa(object sender, EventArgs e)
        {
            if (empresaDAO.Agregar(RecuperarInformacion()) == 1)
            {
                MessageBox.Show("Se ha Agregado el Empleado");
            }
            else
            {
                MessageBox.Show("Ha sucedido un error");
            }
        }
    }
}
