using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class AdmCuentas
    {
        const double ACUERDO_CUENTA_CORRIENTE = 1000;
        const double ACUERDO_CAJA_AHORRO = 500;
        const double SALDO_INICIAL_CUENTA_CORRIENTE = 1460;
        const double SALDO_INICIAL_CAJA_AHORRO = 4589;

        private Cuenta iCuentaCorriente = new Cuenta(SALDO_INICIAL_CUENTA_CORRIENTE, ACUERDO_CUENTA_CORRIENTE);
        private Cuenta iCajaAhorro = new Cuenta(SALDO_INICIAL_CAJA_AHORRO, ACUERDO_CAJA_AHORRO);
        //private Cliente iCliente;


        public bool TransferirACajaAhorro(double pSaldo)
        {

                if(iCuentaCorriente.DebitarSaldo(pSaldo))
                {
                    iCajaAhorro.AcreditarSaldo(pSaldo);
                    return true;
                }

            return false;

        }

        public bool TransferirACuentaCorriente(double pSaldo)
        {
                if (iCajaAhorro.DebitarSaldo(pSaldo))
                {
                    iCuentaCorriente.AcreditarSaldo(pSaldo);
                    return true;
                }

            return false;

        }

        public double SaldoCuentaCorriente()
        {
            return iCuentaCorriente.Saldo;
        }

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
