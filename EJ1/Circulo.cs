using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    /// <summary>
    /// Modela un circulo
    /// </summary>
    class Circulo
    {
        // iRadio es el radio del circulo. 
        // iCentro es un punto en el que se encuentra el centro del mismo.
        private double iRadio;
        private Punto iCentro;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCentro">Punto en el que se localiza el centro del circulo</param>
        /// <param name="pRadio">Radio del circulo</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            iCentro = pCentro;
            iRadio = pRadio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pX">Coordenada x del punto del centro</param>
        /// <param name="pY">Coordenada y del punto del centro</param>
        /// <param name="pRadio">Radio del circulo</param>
        public Circulo(double pX,double pY,double pRadio)
        {
            iCentro = new Punto(pX, pY);
            iRadio = pRadio;
        }

        /// <summary>
        /// Devuelve el punto del centro del circlo
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
        }

        /// <summary>
        /// Devuelve el radio del circulo
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
        }

        /// <summary>
        /// Devuelve el area del circulo
        /// </summary>
        public double Area
        {
            get { return Math.Pow(this.iRadio,2)*Math.PI; }
        }

        /// <summary>
        /// Devuelve el perimetro del circulo
        /// </summary>
        public double Perimetro
        {
            get { return this.iRadio * 2 * Math.PI ; }
        }
    }
}
