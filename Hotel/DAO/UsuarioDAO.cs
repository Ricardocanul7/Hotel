using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hotel.BO;

namespace Hotel.DAO
{
    class UsuarioDAO
    {
        Conexion Miconexion;
        public UsuarioDAO()
        {
            Miconexion = new Conexion();
        }

        public int Agregar(UsuarioBO usuariobo)
        {
            string ComandoSQL = string.Format("INSERT INTO usuario (usuario_id, usuario_tipo, nombre, apellido_patern, apellido_matern, email, password)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", usuariobo.Id_usuario, usuariobo.Tipo_usuario, usuariobo.Nombre, usuariobo.Apaterno, usuariobo.Amaterno, usuariobo.Email, usuariobo.Password);

            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public int Modificar(UsuarioBO usuariobo)
        {
            String ComandoSQL = string.Format("UPDATE usuario SET usuario_tipo='{1}', nombre='{2}', apellido_patern='{3}', apellido_matern='{4}', email='{5}', password='{6}'  WHERE usuario_id={0}", usuariobo.Id_usuario, usuariobo.Tipo_usuario, usuariobo.Nombre, usuariobo.Apaterno, usuariobo.Amaterno, usuariobo.Email, usuariobo.Password);
            return Miconexion.EjecutarComando(ComandoSQL);

        }

        public bool Eliminar()
        {
            return true;
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM usuario");
            return Miconexion.EjecutarSentencia(ComandoSQL);

        }
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */
        /*  -Agregar
           -Modificar
           -Eliminar
           -Buscar  */

        public bool Agregar()
        {
            return true;
        }

        public bool Modificar()
        {
            return true;
        }

       
    }
}
