using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    /// <summary>
    /// Contiene las cuentas de un cliente
    /// </summary>
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

        /// <summary>
        /// Obtiene la cuenta corriente de un cliente.
        /// </summary>
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        /// <summary>
        /// Obtiene la caja de ahorro de un cliente.
        /// </summary>
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

    }
}
