using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            iCentro = pCentro;
            iRadio = pRadio;
        }

        public Circulo(double pX,double pY,double pRadio)
        {
            iCentro = new Punto(pX, pY);
            iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
        }

        public double Radio
        {
            get { return this.iRadio; }
        }

        public double Area
        {
            get { return Math.Pow(this.iRadio,2)*Math.PI; }
        }
        public double Perimetro
        {
            get { return this.iRadio * 2 * Math.PI ; }
        }
    }
}
