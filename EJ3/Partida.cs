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
        /// 
        /// </summary>
        public int Fallos
        {
            get { return this.iCantidadFallos;}
        }

        public TimeSpan Duracion
        {
            get { return iFechaFin.Subtract(iFechaInicio); }
        }

        public bool Resultado
        {
            get { return iResultado; }
        }

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
       
        public void TerminarPartida(bool pResultado)
        {
            iResultado = pResultado;
            iFechaFin = DateTime.Now;
        }

        public int CompareTo(Partida comparePartida)
        {
            // A null value means that this object is greater.
            if (comparePartida == null)
                return 1;
            else
                return TimeSpan.Compare(this.Duracion, comparePartida.Duracion);
                //return this.Duracion.CompareTo(comparePart.Duracion);
        }


    }
}
