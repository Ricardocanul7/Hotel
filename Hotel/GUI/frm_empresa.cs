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
    public partial class frm_empresa : MetroFramework.Forms.MetroForm
    {
        EmpresaBO empresaBO = new EmpresaBO();
        EmpresaDAO empresaDAO = new EmpresaDAO();
        bool Empresa_mod = false;

        public frm_empresa()
        {
            InitializeComponent();
        }

        internal EmpresaBO RecuperarInformacion()
        {
            EmpresaBO empresaBO = new EmpresaBO();
            EmpresaDAO empresaDAO = new EmpresaDAO();

            if (Empresa_mod == true)
            {
                empresaBO.RFC = txt_rfc_empresa.Text;
            }

            empresaBO.Nombre = txt_nombre_empresa.Text;
            empresaBO.Precio_hora = Convert.ToInt32(txt_precio_hora.Text);

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
            if (Empresa_mod == false)
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
            else
            {
                if (empresaDAO.Modificar(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Se ha modificado el Empleado");
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error");
                }
            }

        }

        public void Add_empresa_mod(int id_empresa)
        {
            Empresa_mod = true;
            btn_guardar_puesto.Text = "Modificar";
            DataRow[] empresas = empresaDAO.Buscar().Select(String.Format("rfc_proveedor = {0}", id_empresa));

            if (empresas.Length > 0)
            {
                txt_rfc_empresa.Text = empresas[0]["rfc_proveedor"].ToString();
                txt_nombre_empresa.Text = empresas[0]["nombre"].ToString();
                txt_precio_hora.Text = empresas[0]["precio_porhora"].ToString();

            }
        }
    }
}

