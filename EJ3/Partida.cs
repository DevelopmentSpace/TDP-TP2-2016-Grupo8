using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Partida : IComparable<Partida>
    {
  
        private string iJugador;
        private DateTime iFechaInicio, iFechaFin;
        private bool iResultado = false;
        private int iCantidadFallos = 0;
        private int iMaxFallos;

        /// <summary>
        /// Constructor de la partida
        /// </summary>
        /// <param name="pJugador">Nombre del jugador</param>
        /// <param name="pMaxFallos">Maxima cantidad de fallos de la partida</param>
        public Partida(string pJugador, int pMaxFallos)
        {
            iJugador = pJugador;
            iMaxFallos = pMaxFallos;

  
            //Fecha de inicio actual
            iFechaInicio = DateTime.Now;
        }

        /// <summary>
        /// Propiedad nombre jugador (solo lectura)
        /// </summary>
        public String Jugador
        {
            get { return this.iJugador; }
        }

        /// <summary>
        /// Devuelve la cantidad de fallos de una partida
        /// </summary>
        public int Fallos
        {
            get { return this.iCantidadFallos;}
        }

        /// <summary>
        /// Devuelve la duracion de una partida
        /// </summary>
        public TimeSpan Duracion
        {
            get { return iFechaFin.Subtract(iFechaInicio); }
        }

        /// <summary>
        /// Devuelve el resultado de una partida. (true) si se gano, (false) si se perdio.
        /// </summary>
        public bool Resultado
        {
            get { return iResultado; }
        }

        /// <summary>
        /// Suma un fallo a la partida.
        /// </summary>
        /// <returns> (true) si la puede sumar, (falso) si perdio la partida</returns>
        public bool SumarFallo()
        {
            if (iCantidadFallos < iMaxFallos-1)
            {
                iCantidadFallos += 1;
                return true;
            }
            else
            {
                return false;
            }
             
        }
       
        /// <summary>
        /// Termina la partida y se le pasa el resultado.
        /// </summary>
        /// <param name="pResultado">Si se le pasa verdadero gana, si se le pasa false pierde.</param>
        public void TerminarPartida(bool pResultado)
        {
            iResultado = pResultado;
            iFechaFin = DateTime.Now;
        }

        /// <summary>
        /// Compara dos partidas por su duracion.
        /// </summary>
        /// <param name="comparePartida">Partida a comprar.</param>
        /// <returns>-1 si es menor, 0 si es igual, 1 si es mayor</returns>
        public int CompareTo(Partida comparePartida)
        {
            // Un valor nulo significa que este partida tiene mayor duracion.
            if (comparePartida == null)
                return 1;
            else
                return TimeSpan.Compare(this.Duracion, comparePartida.Duracion);
        }


    }
}
