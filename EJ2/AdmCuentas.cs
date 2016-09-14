using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    /// <summary>
    /// Encargado de gestionar los clientes
    /// </summary>
    class AdmCuentas
    {
        //Constantes de las cuentas
        const double ACUERDO_CUENTA_CORRIENTE = 1000;
        const double ACUERDO_CAJA_AHORRO = 500;
        const double SALDO_INICIAL_CUENTA_CORRIENTE = 1460;
        const double SALDO_INICIAL_CAJA_AHORRO = 4589;

        //Variables. iCuentaCorriente contiene la cuenta corriente inicializada con las constantes. iCajaAhorro contiene la caja ahorro de la cuenta inicializada con las constantes.
        private Cuenta iCuentaCorriente = new Cuenta(SALDO_INICIAL_CUENTA_CORRIENTE, ACUERDO_CUENTA_CORRIENTE);
        private Cuenta iCajaAhorro = new Cuenta(SALDO_INICIAL_CAJA_AHORRO, ACUERDO_CAJA_AHORRO);

        /// <summary>
        /// Transfiere desde la cuenta corriente a una caja ahorro el saldo especificado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea transferir</param>
        /// <returns>(True) Si se  hizo la transferencia, (false) si no se pudo concretar la transferencia</returns>
        public bool TransferirACajaAhorro(double pSaldo)
        {

                if(iCuentaCorriente.DebitarSaldo(pSaldo))
                {
                    iCajaAhorro.AcreditarSaldo(pSaldo);
                    return true;
                }

            return false;

        }

        /// <summary>
        /// Transfiere desde la caja ahorro a una cuenta corriente el saldo especificado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea transferir</param>
        /// <returns>(True) Si se  hizo la transferencia, (false) si no se pudo concretar la transferencia</returns>
        public bool TransferirACuentaCorriente(double pSaldo)
        {
                if (iCajaAhorro.DebitarSaldo(pSaldo))
                {
                    iCuentaCorriente.AcreditarSaldo(pSaldo);
                    return true;
                }

            return false;

        }

        /// <summary>
        /// Devuelve el saldo de la cuenta corriente.
        /// </summary>
        /// <returns>Saldo de la cuenta corriente</returns>
        public double SaldoCuentaCorriente()
        {
            return iCuentaCorriente.Saldo;
        }

        /// <summary>
        /// Devuelve el saldo de la caja de ahorro
        /// </summary>
        /// <returns>Saldo de la caja de ahorro</returns>
        public double SaldoCajaAhorro()
        {
            return iCajaAhorro.Saldo;
        }


        /*
        public void CrearCliente(TipoDocumento pTipoDocumento,string pNumeroDocumento, string pNombre)
        {
            iCliente = new Cliente(pTipoDocumento, pNumeroDocumento, pNombre);
        }

        public void CrearCuentas()
        {

            Cuentas iCuentas = new Cuentas();
        }
        */

    }
}
