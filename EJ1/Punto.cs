using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Punto
    {
        //iX es la coordenada en el eje x. iY es la coordeana en el eje y.
        private double iX, iY;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pX">Coordenada en x del punto</param>
        /// <param name="pY">Coordenada en y del punto</param>
        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        /// <summary>
        /// Devuelve la coordenada en x del punto.
        /// </summary>
        public double X
        {
            get { return this.iX; }
        }


        /// <summary>
        /// Devuelve la coordenada en y del punto.
        /// </summary>
        public double Y
        {
            get { return this.iY; }
        }

        /// <summary>
        /// Calcula la distancia entre dos puntos
        /// </summary>
        /// <param name="pPunto">Otro punto al cual se desea conocer su distancia</param>
        /// <returns></returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.iX - pPunto.X, 2) + Math.Pow(this.iY - pPunto.Y, 2));
        }
    }
}
