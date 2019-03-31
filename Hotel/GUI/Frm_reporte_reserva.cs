using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Reportes;
using Hotel.DAO;
using MySql.Data.MySqlClient;

namespace Hotel.GUI
{
    public partial class Frm_reporte_reserva : Form
    {
        Conexion conn = new Conexion();
        public Frm_reporte_reserva()
        {
            InitializeComponent();
            GenerarReporte();
        }

        public void GenerarReporte()
        {
            ReservaDAO reservaDAO = new ReservaDAO();

            string col0 = "folio_reserva";
            string col1 = "num_habitacion";
            string col2 = "fecha_entrada";
            string col3 = "fecha_salida";
            string col4 = "detalles";
            string col5 = "nombre";
            string col6 = "apaterno";
            string col7 = "amaterno";
            string col8 = "direccion";
            string col9 = "email";
            string col10 = "telefono";
            string col11 = "estado_pagado";


            string selectSQL = String.Format("SELECT {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11} ", col0, col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11);
            string fromSQL = "FROM reservacion as a, cliente as b where a.cliente_id=b.cliente_id";
            string sql = selectSQL + fromSQL;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn.EstablecerConexion());

            DataSet_reservas Ds = new DataSet_reservas();
            adapter.Fill(Ds, "reservacion");

            Reporte_recervas reporte = new Reporte_recervas();
            reporte.SetDataSource(Ds);

            Contenedor_reporte_reservas.ReportSource = reporte;
        }
    }
}
