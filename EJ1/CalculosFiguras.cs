using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CalculosFiguras
    {
        public double PerimetroCirculo(double pX, double pY, double pRadio)
        {
            Circulo c = new Circulo(pX,pY,pRadio);
            return c.Perimetro;
        }

        public double AreaCirculo(double pX, double pY, double pRadio)
        {
            Circulo c = new Circulo(pX, pY, pRadio);
            return c.Area;
        }

        public double PerimetroTriangulo(double pPX1, double pPX2, double pPX3,double pPY1, double pPY2,double pPY3)
        {
            Triangulo t = new Triangulo(new Punto(pPX1,pPY1), new Punto(pPX2, pPY2), new Punto(pPX3, pPY3));
            return t.Perimetro;
        }

        public double AreaTriangulo(double pPX1, double pPX2, double pPX3, double pPY1, double pPY2, double pPY3)
        {
            Triangulo t = new Triangulo(new Punto(pPX1, pPY1), new Punto(pPX2, pPY2), new Punto(pPX3, pPY3));
            return t.Area;
        }

    }
}
