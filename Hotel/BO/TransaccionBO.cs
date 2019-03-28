using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BO
{
    class TransaccionBO
    {
        private int codigo_transaccion;
        private double monto;
        private string descripccion;
        private DateTime fecha;
        private TipoTransaccionBO tipo;
        private ReservasBO folio;
        private UsuarioBO usuario;

        public int Codigo_transaccion
        {
            get { return codigo_transaccion; }
            set { codigo_transaccion = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Descripccion
        {
            get { return descripccion; }
            set { descripccion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public TipoTransaccionBO Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public ReservasBO Folio
        {
            get { return folio; }
            set { folio = value; }
        }

        public UsuarioBO Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
