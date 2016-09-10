using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Palabra
    {
        static String[] PALABRAS = { "castillo", "hermana", "mesa", "computadora", "television", "oraculo", "ahorcado", "pizarron","atomico","billetera",
                                      "australopitecus","cuarzo","magma","lobo","ataud","alcohol","siniestro","topo","martillo","hierro",
                                      "portero","atraco","herrero","estufa","peluqueria","maraton","hortaliza","trampa","tactica","iluminacion"};




        private string iPalabra, iPalabraConocida;

        public Palabra()
        {

            Random iRandom = new Random();
            int indice = iRandom.Next(0, PALABRAS.Length - 1);
            iPalabra = PALABRAS[indice];

            //Creamos la vista de la palabra con todo oculto
            iPalabraConocida = new string('_', iPalabra.Length);
        }

        public string PalabraConocida
        {
            get { return this.iPalabraConocida;}
        }

        public bool PalabraCompleta()
        {

            if (iPalabraConocida == iPalabra)
                return true;
            else
                return false;

        }

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
