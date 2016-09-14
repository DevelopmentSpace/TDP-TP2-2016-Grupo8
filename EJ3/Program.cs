using System;
using System.Collections.Generic;

namespace EJ3
{
    class Program
    {
        static AhorcadoFachada ahorcado = new AhorcadoFachada();

        static void Main(string[] args)
        {
            char opc;
            //Menu principal del programa
            do
            {
                Console.Clear();

                Console.WriteLine("El numero maximo de fallos actual es: " + ahorcado.CantidadMaximaFallos);
                Console.WriteLine("Ingrese una opcion:");

                Console.WriteLine("1 - Jugar Partida.");
                Console.WriteLine("2 - Configurar maximo de fallos.");
                Console.WriteLine("3 - Mostrar 5 mejores partidas.");
                
                Console.WriteLine("0 - Salir.");

                opc = Console.ReadKey().KeyChar;

                

                switch (opc)
                {
                    case '1':
                        {
                            JugarPartida();
                            break;
                        }
                    case '2':
                        {
                            CambiarMaxFallos();
                            break;
                        }
                    case '3':
                        {
                            MostrarCinco();
                            break;
                        }
                }


            }

            while (opc != '0');

        }
        



        //Menu configuracion de fallos.
        static private void CambiarMaxFallos()
        {
            Console.Clear();

            Console.Write("Ingrese el numero de fallos nuevo: ");
            int fallos;
            int.TryParse(Console.ReadLine(), out fallos);
            ahorcado.CantidadMaximaFallos = fallos;
        }

        //Interfaz para jugar partida.
        static private void JugarPartida()
        {
            Console.Clear();

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            ahorcado.NuevoJuego(nombre);

            char letra;
            do
            {
                Console.WriteLine("Palabra:     " + ahorcado.ObtenerPalabra() + "     Fallos: " + ahorcado.Fallos() + "   Numero maximo: " + ahorcado.CantidadMaximaFallos);
                Console.WriteLine();
                Console.Write("Ingrese una letra: ");
                letra = Console.ReadKey().KeyChar;
                Console.Clear();
            }
            while (ahorcado.IngresarCaracter(letra));

            Console.WriteLine("Termino en " + ahorcado.Duracion().TotalSeconds);
            Console.ReadLine();
        }

        //Interfaz que muestra las 5 mejores partidas
        static private void MostrarCinco()
        {
            Console.Clear();

            List<Dictionary<string, string>> lista = ahorcado.ListaMejores(5);

            if (lista.Count == 0)
                Console.WriteLine("No hay partidas actualmente");
            else
                foreach (var partida in lista)
                    Console.WriteLine("Numero: " + partida["posicion"] + " - Nombre: " + partida["nombre"] + " - Tiempo (seg): " + partida["tiempo"]);
      
            Console.ReadKey();
        }
    }
}
