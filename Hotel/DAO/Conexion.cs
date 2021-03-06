﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DAO
{
    class Conexion
    {
        MySqlConnection conn;
        MySqlCommand comand;

        public Conexion()
        {
            string servidor = "localhost";
            string userid = "root";
            string pass = "12345";
            string bd = "db_hotel";

            conn = new MySqlConnection("Server=" + servidor + "; User ID=" + userid
                                        + "; Persist Security info=true; password=" + pass +
                                        ";Database=" + bd);
            comand = new MySqlCommand();
        }

        public MySqlConnection EstablecerConexion()
        {
            return conn;
        }

        public void AbrirConexion()
        {
            this.conn.Open();
        }

        public void CerrarConexion()
        {
            this.conn.Close();
        }

        public int EjecutarComando(string comandoSQL) // INSERT, UPDATE, DELETE
        {
            try
            {
                this.comand.CommandText = comandoSQL;
                this.comand.Connection = this.conn;
                this.AbrirConexion();
                this.comand.ExecuteNonQuery();
                this.CerrarConexion();
                return 1;
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
                return 0;
            }
            finally
            {
                this.CerrarConexion();
            }
        }

        public DataTable EjecutarSentencia(String comandoSQL)
        {
            // SELECT
            MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSQL, this.conn);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}
