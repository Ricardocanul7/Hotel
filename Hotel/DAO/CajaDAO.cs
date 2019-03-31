using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hotel.BO;

namespace Hotel.DAO
{
    class CajaDAO
    {
        Conexion Miconexion;
        public CajaDAO()
        {
            Miconexion = new Conexion();
        }

        public int Agregar(CajaBO cajabo)
        {
            string ComandoSQL = string.Format("INSERT INTO corte_caja (monto, fecha, hora, usuario_id) VALUES({0}, '{1}', '{2}' , {3});", cajabo.Monto, cajabo.Fecha.ToString("yyyy-MM-dd"), cajabo.Hora.ToString("HH:mm:ss"), cajabo.Usuario.Id_usuario);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

       

       /* public bool Eliminar()
        {
            return true;
        }*/
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM corte_caja");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */

    }
}
