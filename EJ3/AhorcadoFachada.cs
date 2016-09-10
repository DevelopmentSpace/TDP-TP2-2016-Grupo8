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



        private Partida iPartida;
        private Palabra iPalabra;
        private List<Partida> iListaPartidas = new List<Partida>();
        private int iMaxFallos = MAX_FALLOS;


        public void NuevoJuego(string pNombre)
        {
            iPartida = new Partida(pNombre,iMaxFallos);
            iPalabra = new Palabra();
            
        }

        public int CantidadMaximaFallos
        {
            get { return this.iMaxFallos; }
            set { this.iMaxFallos= value; }
        }

        //Devuelve Falso si se termino la partida, en caso contrario Verdadero.
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
        

        public string ObtenerPalabra()
        {
            return iPalabra.PalabraConocida;
        }

        public TimeSpan Duracion()
        {
            return iPartida.Duracion;
        }

        public int Fallos()
        {
            return iPartida.Fallos;
        }
        
        private void registrarPartida()
        {
            iListaPartidas.Add(iPartida);
            iListaPartidas.Sort();

        }
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
