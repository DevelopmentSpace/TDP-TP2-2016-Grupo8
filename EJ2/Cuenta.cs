using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuenta
    {
        private double iSaldo, iAcuerdo;


        public Cuenta(double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = 0;
        }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = pSaldoInicial;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (iSaldo + iAcuerdo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
                return true;
            }
            else
                return false;
        }

    }
}
