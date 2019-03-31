using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.BO;
using System.Data;

namespace Hotel.DAO
{
    class TransaccionDAO
    {
        Conexion Miconexion;
        public TransaccionDAO()
        {
            Miconexion = new Conexion();
        }

       public int Agregar(TransaccionBO transaccionbo)
        {
            string ComandoSQL = string.Format("INSERT INTO transaccion (monto, descripcion, fecha, hora, tipo, folio_reserva, usuario_id) VALUES({0},'{1}','{2}','{3}','{4}','{5}', '{6}');", 
                transaccionbo.Monto, transaccionbo.Descripccion, transaccionbo.Fecha.ToString("yyyy-MM-dd"), transaccionbo.Hora.ToString("HH:mm:ss"), transaccionbo.Tipo.Tipo_id, transaccionbo.Folio.Folio_reserva, transaccionbo.Usuario.Id_usuario);

          return Miconexion.EjecutarComando(ComandoSQL);

        }

        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM transaccion");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }

        public DataTable Buscar_FormatDataGridView()
        {
            string commandSQL = "SELECT codigo_transaccion, monto, descripcion, fecha, hora, nombre_transaccion, folio_reserva, nombre " +
                "FROM usuario, transaccion, tipo_transaccion WHERE usuario.usuario_id = transaccion.usuario_id and transaccion.tipo = tipo_transaccion.tipo_id";
            return Miconexion.EjecutarSentencia(commandSQL);
        }

        public DataTable Buscar_tipoTransaccion()
        {
            string ComandoSQL = string.Format("SELECT * FROM tipo_transaccion");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }

        public int Eliminar(int codigo)
        {
            string commandSQL = String.Format("DELETE FROM transaccion WHERE codigo_transaccion={0}", codigo);
            return Miconexion.EjecutarComando(commandSQL);
        }
    }
}

