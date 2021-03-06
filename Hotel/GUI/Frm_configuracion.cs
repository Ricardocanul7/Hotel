﻿using System;
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
        TipohabBO tipohabBO_mod=null;
        TipohabDAO tipohabDAO;

        EstadohabBO estadohabBO;
        EstadohabBO estadohabBO_mod = null;
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

        private TipohabBO RecuperarInformacionTipo()
        {
            int id = 0;
            int.TryParse(txt_tipo_id.Text, out id);

            tipohabBO.Tipo_id = id;
            tipohabBO.Nombre = txt_nombre_tipo.Text;

            return tipohabBO;
        }
        public void ValidarTexboxTipo()
        {
            if(txt_nombre_tipo.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (tipohabBO_mod != null)
                {
                    if (tipohabDAO.Modificar(RecuperarInformacionTipo()) == 1)
                    {
                        MessageBox.Show("Se ha modificado el tipo de habitación");
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al modificar el tipo de habitación!");
                    }
                    tipohabBO_mod = null;
                }
                else
                {
                    if (tipohabDAO.Agregar(RecuperarInformacionTipo()) == 1)
                    {
                        MessageBox.Show("Se ha registrado el tipo de habitación");
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al registrar el tipo de habitación!");
                    }
                }
                Clean();
                dgv_tipo_hab.DataSource = tipohabDAO.Buscar();
                dgv_tipo_hab.Update();
            }
        }

        private void btn_guardar_tipo_Click(object sender, EventArgs e)
        {
            ValidarTexboxTipo();
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
                tipohab.RowFilter = string.Format("nombre_tipo LIKE '%{0}%' OR convert(tipo_id,'System.String')LIKE '%{0}%'", txt_buscar_tipo.Text);
            }
            dgv_tipo_hab.DataSource = tipohab;
        }

        private void btn_modificar_tipo_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Add_tipohab_mod(tipohabBO.Tipo_id);
                dgv_tipo_hab.DataSource = tipohabDAO.Buscar();
                dgv_tipo_hab.Update();
            }
        }

        public void Add_tipohab_mod(int tipo_id)
        {
            tipohabBO_mod = tipohabDAO.Buscar(tipo_id);
            btn_guardar_tipo.Text = "Guardar";
            tipohabBO.Tipo_id = tipo_id;

            txt_tipo_id.Text = tipohabBO_mod.Tipo_id.ToString();
            txt_nombre_tipo.Text = tipohabBO_mod.Nombre;
        }

        private EstadohabBO RecuperarInformacionEstado()
        {
            int id = 0;
            int.TryParse(txt_estado_id.Text, out id);

            estadohabBO.Estado_id = id;
            estadohabBO.Nombre = txt_nombre_estado.Text;

            return estadohabBO;
        }
        public void ValidarTexboxEstado()
        {
            if( txt_nombre_estado.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                 if (estadohabBO_mod != null)
            {
                if (estadohabDAO.Modificar(RecuperarInformacionEstado()) == 1)
                { 
                    MessageBox.Show("Se ha modificado el estado de habitación");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al modificar el estado de habitación!");
                }
                estadohabBO_mod = null;
            }
            else
            {
                if (estadohabDAO.Agregar(RecuperarInformacionEstado()) == 1)
                {
                    MessageBox.Show("Se ha registrado el estado de habitación");
                }
                else
                {
                    MessageBox.Show("Ha habido un error al registrar el estado de habitación!");
                }
            }
            Clean();
            dgv_estado_hab.DataSource = estadohabDAO.Buscar();
            dgv_estado_hab.Update();
            }
        }

        private void btn_agregar_estado_Click(object sender, EventArgs e)
        {
            ValidarTexboxEstado();
        }

        private void btn_buscar_estado_Click(object sender, EventArgs e)
        {
            DataView estadohab = datos2.DefaultView;
            estadohab.RowFilter = string.Empty;

            if (txt_buscar_estado.Text != string.Empty)
            {
                estadohab.RowFilter = string.Format("estado LIKE '%{0}%' OR convert(estado_id,'System.String')LIKE '%{0}%'", txt_buscar_estado.Text);
            }
            dgv_estado_hab.DataSource = estadohab;
        }

        private void btn_eliminar_estado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro? el cambio sera permanente",
            "Se requiere confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (estadohabDAO.Eliminar(estadohabBO) == 1)
                {
                    MessageBox.Show("El registro se ha borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }
                dgv_estado_hab.DataSource = estadohabDAO.Buscar();
            }
        }

        private void dgv_estado_hab_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                estadohabBO.Estado_id = Convert.ToInt32(dgv_estado_hab.Rows[index].Cells[0].Value);
            }
        }

        private void btn_modificar_estado_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Add_estadohab_mod(estadohabBO.Estado_id);
                dgv_estado_hab.DataSource = estadohabDAO.Buscar();
                dgv_estado_hab.Update();
            }
        }

        public void Add_estadohab_mod(int estado_id)
        {
            estadohabBO_mod = estadohabDAO.Buscar(estado_id);
            btn_agregar_estado.Text = "Guardar";

            txt_estado_id.Text = estadohabBO_mod.Estado_id.ToString();
            txt_nombre_estado.Text = estadohabBO_mod.Nombre;
        }

        private void Clean()
        {
            txt_tipo_id.Clear();
            txt_nombre_tipo.Clear();
            txt_estado_id.Clear();
            txt_nombre_estado.Clear();
        }
    }
}
