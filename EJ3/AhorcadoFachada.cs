using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class AhorcadoFachada
    {

        //Constante de Clase
        static public int MAX_FALLOS = 10;


        // iPartida es la partida actual, iPalabra es la palabra a adivinar, iListaPartidas es una lista de partidas ya jugadas, iMaxFallos es la cantidad maxima de fallos.
        private Partida iPartida;
        private Palabra iPalabra;
        private List<Partida> iListaPartidas = new List<Partida>();
        private int iMaxFallos = MAX_FALLOS;

        /// <summary>
        /// Crea un nuevo juego
        /// </summary>
        /// <param name="pNombre">Nombre del jugador</param>
        public void NuevoJuego(string pNombre)
        {
            iPartida = new Partida(pNombre,iMaxFallos);
            iPalabra = new Palabra();
            
        }

        /// <summary>
        /// Devuelve o configura la cantidad maxima de fallos
        /// </summary>
        public int CantidadMaximaFallos
        {
            get { return this.iMaxFallos; }
            set { this.iMaxFallos= value; }
        }

        /// <summary>
        /// Funcion para ingresar caracteres dentro del juego.
        /// </summary>
        /// <param name="pLetra"></param>
        /// <returns>(true) si se termino la partida, (false) si no se termino la partida</returns>
        public bool IngresarCaracter(char pLetra)
        {
            if (iPalabra.VerificarLetra(pLetra))
            {
                if (iPalabra.PalabraCompleta())
                {
                    iPartida.TerminarPartida(true);
                    registrarPartida();
                    return false;
                }
                else
                    return true;
            }
            else
            {
                if (iPartida.SumarFallo())
                    return true;
                else
                {
                    iPartida.TerminarPartida(false);
                    registrarPartida();
                    return false;
                }
            }
        }
        
        /// <summary>
        /// Devuelve la palabra conocida
        /// </summary>
        /// <returns></returns>
        public string ObtenerPalabra()
        {
            return iPalabra.PalabraConocida;
        }

        /// <summary>
        /// Devuelve la duracion de la partida
        /// </summary>
        /// <returns></returns>
        public TimeSpan Duracion()
        {
            return iPartida.Duracion;
        }

        /// <summary>
        /// Devuelve la cantidad de fallos de una partida
        /// </summary>
        /// <returns></returns>
        public int Fallos()
        {
            return iPartida.Fallos;
        }
        
        /// <summary>
        /// Registra la partida en la lista y la ordena
        /// </summary>
        private void registrarPartida()
        {
            iListaPartidas.Add(iPartida);
            iListaPartidas.Sort();

        }

        /// <summary>
        /// Crea una lista con las mejores 5 partidas
        /// </summary>
        /// <param name="pCantidadPartidas">Cantidad de partidas a mostrar</param>
        /// <returns>Lista con las mejores n partidas</returns>
        public List<Dictionary<string,string>> ListaMejores(int pCantidadPartidas)
        {
            int i = 1;
            Dictionary<string, string> diccionario;
            List<Dictionary<string, string>> lista = new List<Dictionary<string, string>>();
            foreach (Partida partida in iListaPartidas)
            {
                if (partida.Resultado == true && i <= pCantidadPartidas)
                {
                    diccionario = new Dictionary<string, string>();
                    diccionario.Add("nombre", partida.Jugador);
                    diccionario.Add("tiempo", partida.Duracion.TotalSeconds.ToString());
                    diccionario.Add("posicion", i.ToString());

                    lista.Add(diccionario);
                    i++;
                }
            }
            return lista;

        }



    }
}
