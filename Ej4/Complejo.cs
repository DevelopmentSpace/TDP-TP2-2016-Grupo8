using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class Complejo
    {

        /// <summary>
        /// Variables para guardar la parte real y la parte imaginaria;
        /// </summary>

        readonly private double iReal, iImaginario;

        /// <summary>
        /// Constructor privado de la clase.
        /// </summary>
        /// <param name="pReal">Parte real</param>
        /// <param name="pImaginario">Parte imaginaria</param>
        /// 
        private Complejo(double pReal, double pImaginario)
        {
            iReal = pReal;
            iImaginario = pImaginario;
        }

        /// <summary>
        /// Metodo para crear una instancia de un numero complejo.
        /// </summary>
        /// <param name="pReal">Parte real</param>
        /// <param name="pImaginario">Parte imaginaria</param>

        public static Complejo Crear(double pReal,double pImaginario)
        {
            return new Complejo(pReal, pImaginario);
        }

        /// <summary>
        /// Property parte real (solo lectura)
        /// </summary>
        public double Real
        {
            get { return this.iReal; }
        }

        /// <summary>
        /// Property parte imaginaria (solo lectura)
        /// </summary>
        public double Imaginario
        {
            get { return this.iImaginario; }
        }

        /// <summary>
        /// Devuelve el numero complejo en radianes
        /// </summary>
        public double ArgumentoEnRadianes
        {
            get { return Math.Atan(this.Imaginario / this.Real); }
        }

        /// <summary>
        /// Devuelve el numero complejo en grados
        /// </summary>
        public double ArgumentoEnGrados
        {
            get { return this.ArgumentoEnRadianes * 180 / Math.PI; }

        }

        /// <summary>
        /// Devuelve el conjugado de un numero complejo
        /// </summary>
        public Complejo Conjugado
        {
            get { return Complejo.Crear(this.Real, -this.Imaginario); }
        }

        /// <summary>
        /// Devuelve la magnitud de un numero complejo
        /// </summary>
        public double Magnitud
        {
            get { return Math.Pow(Math.Pow(this.Imaginario, 2) + Math.Pow(this.Real, 2), 1 / 2); }
        }


        /// <summary>
        /// Permite conocer si el numero es real
        /// </summary>
        /// <returns>true (es real), false (no es real)</returns>
        public bool EsReal()
        {
            if (this.Real == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Permite conocer si el numero es imaginario
        /// </summary>
        /// <returns>true (es imaginario), false (no es imaginario)</returns>
        public bool EsImaginario()
        {
            if (this.Imaginario == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Permite conocer si un numero complejo es igual a otro numero complejo
        /// </summary>
        /// <param name="pOtroComplejo"> Numero complejo con el cual comparar</param>
        /// <returns>true (es igual), false (no es igual)</returns>
        public bool EsIgual(Complejo pOtroComplejo)
        {
            if (this.Imaginario == pOtroComplejo.Imaginario && this.Real == pOtroComplejo.Real)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Permite conocer si un numero complejo es igual a dos numero reales
        /// </summary>
        /// <param name="pReal">Parte real</param>
        /// <param name="pImaginario">Parte imaginaria</param>
        /// <returns>true (es igual), false (no es igual)</returns>
        public bool EsIgual(double pReal, double pImaginario)
        {
            if (this.Imaginario == pImaginario && this.Real == pReal)
                return true;
            else
                return false;
        }
        
        /// <summary>
        /// Permite sumar dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo"> Numero complejo a sumar</param>
        /// <returns>Nuevo complejo con el resultado de la suma</returns>
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            return Complejo.Crear(this.Real + pOtroComplejo.Real, this.Imaginario + pOtroComplejo.Imaginario);
        }

        /// <summary>
        /// Permite restar dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo"> Numero complejo a resta</param>
        /// <returns>Nuevo complejo con el resultado de la resta</returns>
        public Complejo Restar(Complejo pOtroComplejo)
        {
            return Complejo.Crear(this.Real - pOtroComplejo.Real, this.Imaginario - pOtroComplejo.Imaginario);
        }

        /// <summary>
        /// Permite multiplicar dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo que multiplica</param>
        /// <returns>Nuevo complejo con el resultado de la multiplicacion</returns>
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            //Formula multiplicacion complejos: (A + Bi) * (C + Di) = (A*C-B*D) + (A*D+BC)i

            return Complejo.Crear( (this.Real * pOtroComplejo.Real) - (this.Real *pOtroComplejo.Imaginario), ( (this.Real * pOtroComplejo.Imaginario) + (this.Imaginario * pOtroComplejo.Real) ));
        }

        /// <summary>
        /// Permite dividir dos numeros complejos
        /// </summary>
        /// <param name="pOtroComplejo">Numero complejo que divide</param>
        /// <returns>Nuevo complejo con el resultado de la division</returns>
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            //Formula division complejos: (A + Bi) / (C + Di) = ( (A*C + B*D) / (C^2 + D^2) ) + ( (B*C - A*D) / (C^2+D^2) )

            return Complejo.Crear( (((this.Real * pOtroComplejo.Real) + (this.Imaginario * pOtroComplejo.Imaginario)) / ( Math.Pow(pOtroComplejo.Imaginario,2) + Math.Pow(pOtroComplejo.Real,2) ) ), (((this.Imaginario * pOtroComplejo.Real) - (this.Real * pOtroComplejo.Imaginario)) / (Math.Pow(pOtroComplejo.Imaginario, 2) + Math.Pow(pOtroComplejo.Real, 2))));
        }

    }
}
