using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    /// <summary>
    /// Modela una palabra
    /// </summary>
    class Palabra
    {
       //Constante de la clase que contiene las 30 palabras.
        static String[] PALABRAS = { "castillo", "hermana", "mesa", "computadora", "television", "oraculo", "ahorcado", "pizarron","atomico","billetera",
                                      "australopitecus","cuarzo","magma","lobo","ataud","alcohol","siniestro","topo","martillo","hierro",
                                      "portero","atraco","herrero","estufa","peluqueria","maraton","hortaliza","trampa","tactica","iluminacion"};



        //iPalabra es una palabra seleccionada de la lista. iPalabra conocida es la palabra que la fachada conoce.
        private string iPalabra, iPalabraConocida;

        /// <summary>
        /// Crea una palabra e inicializa sus atributos.
        /// </summary>
        public Palabra()
        {

            Random iRandom = new Random();
            int indice = iRandom.Next(0, PALABRAS.Length - 1);
            iPalabra = PALABRAS[indice];

            //Creamos la vista de la palabra con todo oculto
            iPalabraConocida = new string('_', iPalabra.Length);
        }

        /// <summary>
        /// Devuelve la palabra conocida.
        /// </summary>
        public string PalabraConocida
        {
            get { return this.iPalabraConocida;}
        }

        /// <summary>
        /// Comprueba si la palabra esta completa.
        /// </summary>
        /// <returns>(true) si la palabra esta completa, (false) si la palabra no esta completa</returns>
        public bool PalabraCompleta()
        {

            if (iPalabraConocida == iPalabra)
                return true;
            else
                return false;

        }

        /// <summary>
        /// Verifica una letra en la palabra y hace que palabraconocida se revele si existe.
        /// </summary>
        /// <param name="pLetra">Letra que se le pasa.</param>
        /// <returns>(true) si la letra existe en la palabra, (falso) si la letra no existe en la palabra</returns>
        public bool VerificarLetra(char pLetra)
        {
            if (iPalabra.Contains(pLetra.ToString()))
            {
                //Hacemos visible el caracter
                this.MostrarCaracter(pLetra);
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Revelea el caracter de la palabra
        /// </summary>
        /// <param name="pLetra">Letra que se revela</param>
        private void MostrarCaracter(char pLetra)
        {
            for (int i = 0; i < iPalabra.Length; i++)
            {
                if (iPalabra[i] == pLetra)
                {
                    char[] aux = iPalabraConocida.ToCharArray();
                    aux.SetValue(pLetra, i);
                    iPalabraConocida = new string(aux);
                }
            }
        }






    }
}
