using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    /// <summary>
    /// Encargado de hacer calculos relacionados con figuras
    /// </summary>
    class CalculosFiguras
    {
        /// <summary>
        /// Calcula el perimetro de un circulo
        /// </summary>
        /// <param name="pX">Coordenada en X</param>
        /// <param name="pY">Coordenada en Y</param>
        /// <param name="pRadio">Radio del circulo</param>
        /// <returns></returns>
        public double PerimetroCirculo(double pX, double pY, double pRadio)
        {
            Circulo c = new Circulo(pX,pY,pRadio);
            return c.Perimetro;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="pX">Coordenada en X</param>
        /// <param name="pY">Coordenada en Y</param>
        /// <param name="pRadio">Radio del circulo</param>
        /// <returns></returns>
        public double AreaCirculo(double pX, double pY, double pRadio)
        {
            Circulo c = new Circulo(pX, pY, pRadio);
            return c.Area;
        }

        /// <summary>
        /// Calcula el perimetro de un triangulo
        /// </summary>
        /// <param name="pPX1">Coordenada X (Punto 1)</param>
        /// <param name="pPX2">Coordenada X (Punto 2)</param>
        /// <param name="pPX3">Coordenada X (Punto 3)</param>
        /// <param name="pPY1">Coordenada y (Punto 1)</param>
        /// <param name="pPY2">Coordenada y (Punto 2)</param>
        /// <param name="pPY3">Coordenada y (Punto 3)</param>
        /// <returns></returns>
        public double PerimetroTriangulo(double pPX1, double pPX2, double pPX3,double pPY1, double pPY2,double pPY3)
        {
            Triangulo t = new Triangulo(new Punto(pPX1,pPY1), new Punto(pPX2, pPY2), new Punto(pPX3, pPY3));
            return t.Perimetro;
        }

        /// <summary>
        /// Calcula el area de un triangulo
        /// </summary>
        /// <param name="pPX1">Coordenada X (Punto 1)</param>
        /// <param name="pPX2">Coordenada X (Punto 2)</param>
        /// <param name="pPX3">Coordenada X (Punto 3)</param>
        /// <param name="pPY1">Coordenada y (Punto 1)</param>
        /// <param name="pPY2">Coordenada y (Punto 2)</param>
        /// <param name="pPY3">Coordenada y (Punto 3)</param>
        /// <returns></returns>
        public double AreaTriangulo(double pPX1, double pPX2, double pPX3, double pPY1, double pPY2, double pPY3)
        {
            Triangulo t = new Triangulo(new Punto(pPX1, pPY1), new Punto(pPX2, pPY2), new Punto(pPX3, pPY3));
            return t.Area;
        }

    }
}
