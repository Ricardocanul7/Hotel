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
    public partial class frm_habitaciones : MetroFramework.Forms.MetroForm
    {
        HabitacionBO habitacionBO;
        HabitacionBO habitacionBO_mod = null;
        HabitacionDAO habitacionDAO;
        public DataGridView data;

        internal HabitacionBO SetObjectHabitacionBO { get; set; }

        public frm_habitaciones()
        {
            InitializeComponent();
            habitacionBO = new HabitacionBO();
            habitacionBO.Tipo = new TipohabBO();
            habitacionBO.Estado = new EstadohabBO();
            habitacionDAO = new HabitacionDAO();

            Set_cbo_tipo_habitacion();
            Set_cbo_estado_habitacion();
        }

        public void Add_habitacion_mod(int numeroHab)
        {
            habitacionBO_mod = habitacionDAO.Buscar(numeroHab);
            btn_guardar.Text = "Modificar";
            habitacionBO.Num_habitacion = numeroHab;

            txt_num_habitacion.Text = habitacionBO_mod.Num_habitacion.ToString();
            txt_nombrehab.Text = habitacionBO_mod.Nombre_hab;
            txt_max_ninios.Text = habitacionBO_mod.Max_ninios.ToString();
            txt_max_adultos.Text = habitacionBO_mod.Max_adultos.ToString();
            txt_precioN.Text = habitacionBO_mod.PrecioN.ToString();
            cbo_tipohab.Text = habitacionBO_mod.Tipo.Nombre;
            cbo_estadohab.Text = habitacionBO_mod.Estado.Nombre;
            txt_descripHab.Text = habitacionBO_mod.DescripHab;
            
        }

        private void Set_cbo_tipo_habitacion()
        {
            DataRow[] rows = habitacionDAO.BuscarTipoHabitacion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_tipohab.Items.Add(rows[i]["nombre_tipo"]);
            }

            cbo_tipohab.SelectedIndex = 0;
        }

        private void Set_cbo_estado_habitacion()
        {
            DataRow[] rows = habitacionDAO.BuscarEstadoHabitacion().Select();
            for (int i = 0; i < rows.Length; i++)
            {
                cbo_estadohab.Items.Add(rows[i]["estado"]);
            }

            // 4 == Disponible
            cbo_estadohab.SelectedIndex = 3;
        }

        private HabitacionBO RecuperarInformacion()
        {
            int id = 0;
            int.TryParse(txt_num_habitacion.Text, out id);

            habitacionBO.Num_habitacion = id;
            habitacionBO.Nombre_hab = txt_nombrehab.Text;
            habitacionBO.Max_adultos = Convert.ToInt32(txt_max_adultos.Text);
            habitacionBO.Max_ninios = Convert.ToInt32(txt_max_ninios.Text);
            habitacionBO.Tipo.Tipo_id = cbo_tipohab.SelectedIndex+1;
            habitacionBO.Estado.Estado_id = cbo_estadohab.SelectedIndex+1;
            habitacionBO.PrecioN = Convert.ToDouble(txt_precioN.Text);
            habitacionBO.DescripHab = txt_descripHab.Text;

            return habitacionBO;
        }

        private void btn_hab_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombrehab.Clear();
            txt_max_adultos.Clear();
            txt_max_ninios.Clear();
            cbo_tipohab.SelectedIndex = 0;
            cbo_estadohab.SelectedIndex = 0;
            txt_precioN.Clear();
            txt_descripHab.Clear();
        }
        public void ValidarTexbox()
        {
            if(txt_nombrehab.Text =="" | txt_precioN.Text == "" | txt_max_adultos.Text =="" | txt_max_ninios.Text =="")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (habitacionBO_mod != null)
                {
                    if (habitacionDAO.Modificar(RecuperarInformacion()) == 1)
                    {
                        MessageBox.Show("Se ha modificado la habitación");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al modificar la habitación!");
                    }

                }
                else
                {
                    if (habitacionDAO.Agregar(RecuperarInformacion()) == 1)
                    {
                        MessageBox.Show("Se ha registrado la habitación");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ha habido un error al registrar la habitación!");
                    }
                }

            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ValidarTexbox();
        }

        private void Validar_maxniños(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }

        private void validar_maxadultos(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }

        private void Validar_Precio(object sender, KeyPressEventArgs e)
        {
            ValidacionBO.SoloNumeros(e);
        }
    }
}
