using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuentas
    {

        //private Cliente iCliente;
        private Cuenta iCuentaCorriente = null;
        private Cuenta iCajaAhorro = null;


        public Cuentas(/*Cliente pCliente,Cuenta pCuentaCorriente, Cuenta pCuentaAhorro*/)
        {
            /*iCliente = pCliente;
            iCuentaCorriente = pCuentaCorriente;
            iCajaAhorro = pCuentaAhorro;*/

        }

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

    }
}
