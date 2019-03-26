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
    public partial class Frm_configuracion : MetroFramework.Forms.MetroForm
    {
        TipohabBO tipohabBO;
        TipohabDAO tipohabDAO;
        EstadohabBO estadohabBO;
        EstadohabDAO estadohabDAO;
        private DataTable datos;
        private DataTable datos2;
        int index;

        public Frm_configuracion()
        {
            InitializeComponent();
            tipohabBO = new TipohabBO();
            tipohabDAO = new TipohabDAO();
            estadohabBO = new EstadohabBO();
            estadohabDAO = new EstadohabDAO();

            datos = tipohabDAO.Buscar();
            datos2 = estadohabDAO.Buscar();

            dgv_tipo_hab.DataSource = datos;
            dgv_tipo_hab.AllowUserToAddRows = false;
            dgv_tipo_hab.ReadOnly = true;
            dgv_tipo_hab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_estado_hab.DataSource = datos2;
            dgv_estado_hab.AllowUserToAddRows = false;
            dgv_estado_hab.ReadOnly = true;
            dgv_estado_hab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            setColumNames();
        }

        private void setColumNames()
        {
            dgv_tipo_hab.Columns[0].HeaderText = "ID";
            dgv_tipo_hab.Columns[1].HeaderText = "Nombre";
            dgv_estado_hab.Columns[0].HeaderText = "ID";
            dgv_estado_hab.Columns[1].HeaderText = "Nombre";
        }

        private void btn_guardar_tipo_Click(object sender, EventArgs e)
        {
            if (tipohabDAO.Agregar(RecuperarInformacionTipo()) == 1)
            {
                MessageBox.Show("Se ha registrado la habitación");
            }
            else
            {
                MessageBox.Show("Ha habido un error al registrar la habitación!");
            }
            dgv_tipo_hab.DataSource = tipohabDAO.Buscar();
            dgv_tipo_hab.Update();
        }

        private TipohabBO RecuperarInformacionTipo()
        {
            int id = 0;
            int.TryParse(txt_tipo_id.Text, out id);

            tipohabBO.Tipo_id = id;
            tipohabBO.Nombre = txt_nombre_tipo.Text;

            return tipohabBO;
        }

        private void btn_eliminar_tipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
            "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (tipohabDAO.Eliminar(tipohabBO) == 1)
                {
                    MessageBox.Show("El registro se ha borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }
                dgv_tipo_hab.DataSource = tipohabDAO.Buscar();
            }
        }

        private void dgv_tipo_hab_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tipohabBO.Tipo_id = Convert.ToInt32(dgv_tipo_hab.Rows[index].Cells[0].Value);
            }
        }

        private void btn_buscar_tipo_Click(object sender, EventArgs e)
        {
            DataView tipohab = datos.DefaultView;
            tipohab.RowFilter = string.Empty;

            if (txt_buscar_tipo.Text != string.Empty)
            {
                tipohab.RowFilter = string.Format("convert(tipo_id,'System.String')LIKE '%{0}%'", txt_buscar_tipo.Text);
            }
            dgv_tipo_hab.DataSource = tipohab;
        }

        private void btn_modificar_estado_Click(object sender, EventArgs e)
        {

        }

        private EstadohabBO RecuperarInformacionEstado()
        {
            int id = 0;
            int.TryParse(txt_tipo_id.Text, out id);

            estadohabBO.Estado_id = id;
            estadohabBO.Nombre = txt_nombre_estado.Text;

            return estadohabBO;
        }

        private void btn_agregar_estado_Click(object sender, EventArgs e)
        {
            if (estadohabDAO.Agregar(RecuperarInformacionEstado()) == 1)
            {
                MessageBox.Show("Se ha registrado la habitación");
            }
            else
            {
                MessageBox.Show("Ha habido un error al registrar la habitación!");
            }
            dgv_estado_hab.DataSource = estadohabDAO.Buscar();
            dgv_estado_hab.Update();
        }
    }
}
