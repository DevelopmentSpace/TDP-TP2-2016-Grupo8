using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Triangulo
    {
        //iPunto1,iPunto2,iPunto3 representan los punto del triangulo
        private Punto iPunto1, iPunto2, iPunto3;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pPunto1">Punto 1 del triangulo</param>
        /// <param name="pPunto2">Punto 2 del triangulo</param>
        /// <param name="pPunto3">Punto 3 del triangulo</param>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3 )
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;

        }

        /// <summary>
        /// Devuelve el primer punto del triangulo
        /// </summary>
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }

        /// <summary>
        /// Devuelve el segundo punto del triangulo
        /// </summary>
        public Punto Punto2
        {
            get { return this.iPunto2; }
        }

        /// <summary>
        /// Devuelve el tercer punto del triangulo
        /// </summary>
        public Punto Punto3
        {
            get { return this.iPunto3; }
        }

        /// <summary>
        /// Devuelve el area del triangulo
        /// </summary>
        public double Area
        {
            get {
                return (double)0.5 * Math.Abs( 
                                          this.iPunto1.X * this.iPunto2.Y 
                                        + this.iPunto1.Y * this.iPunto3.X 
                                        + this.iPunto2.X * this.iPunto3.Y
                                        - this.iPunto2.Y * this.iPunto3.X
                                        - this.iPunto1.Y * this.iPunto3.X
                                        - this.iPunto2.X * this.iPunto1.Y
                                     );

                }
        }

        /// <summary>
        /// Devuelve el permitro de un triangulo
        /// </summary>
        public double Perimetro
        {
            get { return this.iPunto1.CalcularDistanciaDesde(this.iPunto2)
                    + this.iPunto2.CalcularDistanciaDesde(this.iPunto3)
                    + this.iPunto3.CalcularDistanciaDesde(this.iPunto1); }
        }



    }
}
