using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    /// <summary>
    /// Encargado de gestionar los clientes y sus cuentas
    /// </summary>
    class AdmCuentas
    {
   
        //Variables. iCuentas contiene las cuentas de un cliente, iCliente contiene el cliente. iCliente seria tipo una sesion o algo asi se me ocurre.
        private Cuentas iCuentas = null;
        private Cliente iCliente;

        /// <summary>
        /// Transfiere desde la cuenta corriente a una caja ahorro el saldo especificado.
        /// </summary>
        /// <param name="pSaldo">Saldo que se desea transferir</param>
        /// <returns>(True) Si se  hizo la transferencia, (false) si no se pudo concretar la transferencia</returns>
        public bool TransferirACajaAhorro(double pSaldo)
        {
            if (ExisteCajaAhorro() && ExisteCuentaCorriente())
            { 
                if(iCuentas.CuentaCorriente.DebitarSaldo(pSaldo))
                {
                    iCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
                    return true;
                }
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
            if (ExisteCajaAhorro() && ExisteCuentaCorriente())
                if (iCuentas.CajaAhorro.DebitarSaldo(pSaldo))
                {
                    iCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
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
            return iCuentas.CuentaCorriente.Saldo;
        }

        /// <summary>
        /// Devuelve el saldo de la caja de ahorro
        /// </summary>
        /// <returns>Saldo de la caja de ahorro</returns>
        public double SaldoCajaAhorro()
        {
            return iCuentas.CajaAhorro.Saldo;
        }

        /// <summary>
        /// Crea un cliente
        /// </summary>
        /// <param name="pTipoDocumento">Tipo de documento</param>
        /// <param name="pNumeroDocumento">Numero de documento</param>
        /// <param name="pNombre">Nombre del cliente</param>
        public void CrearCliente(TipoDocumento pTipoDocumento,string pNumeroDocumento, string pNombre)
        {
            iCliente = new Cliente(pTipoDocumento, pNumeroDocumento, pNombre);
        }

        /// <summary>
        /// Devuelve el cliente.
        /// </summary>
        public Cliente Cliente
        {
            get { return iCliente; }

         }

        /// <summary>
        /// Devuelve la caja de ahorro.
        /// </summary>
        public Cuenta CajaDeAhorro
        {
            get { return iCuentas.CajaAhorro; }

        }

        /// <summary>
        /// Devuelve la cuenta corriente.
        /// </summary>
        public Cuenta CuentaCorriente
        {
            get { return iCuentas.CuentaCorriente; }

        }

        /// <summary>
        /// Crea las cuentas de un cliente determinado
        /// </summary>
        /// <param name="pCliente">Cliente al que se le asigna la cuenta</param>
        /// <param name="pCuentaCorriente">Una cuenta que sera la cuenta corriente</param>
        /// <param name="pCajaAhorro">Una cuenta que sera la caja de ahorro</param>
        public void CrearCuentas(Cliente pCliente,Cuenta pCuentaCorriente, Cuenta pCajaAhorro)
        {
            iCuentas = new Cuentas(pCliente,pCuentaCorriente,pCajaAhorro);
        }

        /// <summary>
        /// Crea una cuenta
        /// </summary>
        /// <param name="pAcuerdo">Acuerdo de dicha cuenta</param>
        /// <returns></returns>
        public Cuenta CrearCuenta(double pAcuerdo)
        {
            Cuenta cuenta;
            return cuenta = new Cuenta(pAcuerdo);
        }

        /// <summary>
        /// Crea una cuenta
        /// </summary>
        /// <param name="pSaldoInicial">Saldo inicial</param>
        /// <param name="pAcuerdo">Acuerdo de dicha cuenta</param>
        /// <returns></returns>
        public Cuenta CrearCuenta(double pSaldoInicial,double pAcuerdo)
        {
            Cuenta cuenta;
            return cuenta = new Cuenta(pSaldoInicial, pAcuerdo);
        }

        /// <summary>
        /// Responde la existencia de una caja de ahorro
        /// </summary>
        /// <returns>(true) existe una caja de ahorro, (false) no existe una caja de ahorro</returns>
        public bool ExisteCajaAhorro()
        {
            if (iCuentas.CajaAhorro != null)
                return true;
            return false;
        }

        /// <summary>
        /// Responde la existencia de una cuenta corriente
        /// </summary>
        /// <returns>(true) existe una cuenta corriente, (false) no existe una cuenta corriente</returns>
        public bool ExisteCuentaCorriente()
        {
            if (iCuentas.CuentaCorriente != null)
                return true;
            return false;
        }

    }
}
