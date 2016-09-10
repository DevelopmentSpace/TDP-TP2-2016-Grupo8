using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Punto
    {
        private double iX, iY;

        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        public double X
        {
            get { return this.iX; }
        }

        public double Y
        {
            get { return this.iY; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.iX - pPunto.X, 2) + Math.Pow(this.iY - pPunto.Y, 2));
        }
    }
}
