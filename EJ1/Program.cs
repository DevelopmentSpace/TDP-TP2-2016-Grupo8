using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {

        static CalculosFiguras fachada = new CalculosFiguras();

        static void Main(string[] args)
        {
            char opc;


            do
            {
                Console.WriteLine("Ingrese una opcion:" );
                Console.WriteLine("1 - Circulo.");
                Console.WriteLine("2 - Triangulo:");
                Console.WriteLine("0 - Salir");

                opc = Console.ReadKey().KeyChar;

                switch (opc)
                    {case '1':
                        {
                            MenuCirculo();
                            break;
                        }
                    case '2':
                        {
                            MenuTriangulo();
                            break;
                        }
                }

                Console.Clear();

            }
            while (opc != '0');

        }

        private static void MenuCirculo()
        {
            double pX, pY, radio;

            Console.WriteLine("Ingrese el centro del circulo(x,y):");

            Console.Write(" - X: ");
            Double.TryParse(Console.ReadLine(), out pX);
            Console.Write(" - Y: ");
            Double.TryParse(Console.ReadLine(), out pY);

            Console.WriteLine("Ingrese el radio del circulo:");

            Console.Write(" - Radio: ");
            Double.TryParse(Console.ReadLine(), out radio);

            Console.WriteLine("Perimetro: " + fachada.PerimetroCirculo(pX,pY,radio));
            Console.WriteLine("Area: " + fachada.AreaCirculo(pX, pY, radio));

            Console.ReadKey();

        }

        private static void MenuTriangulo()
        {

            double pX1, pX2, pX3, pY1, pY2, pY3;

            Console.WriteLine("Ingrese los puntos del triangulo (x,y):");
            Console.WriteLine("Punto 1:");

            Console.Write(" - X: ");
            Double.TryParse(Console.ReadLine(), out pX1);
            Console.Write(" - Y: ");
            Double.TryParse(Console.ReadLine(), out pY1);

            Console.WriteLine("Punto 2:");

            Console.Write(" - X: ");
            Double.TryParse(Console.ReadLine(), out pX2);
            Console.Write(" - Y: ");
            Double.TryParse(Console.ReadLine(), out pY2);

            Console.WriteLine("Punto 3:");

            Console.Write(" - X: ");
            Double.TryParse(Console.ReadLine(), out pX3);
            Console.Write(" - Y: ");
            Double.TryParse(Console.ReadLine(), out pY3);

            Console.WriteLine("Perimetro: " + fachada.PerimetroTriangulo(pX1, pY1,pX2,pY2,pX3,pY3));
            Console.WriteLine("Area: " + fachada.AreaTriangulo(pX1, pY1, pX2, pY2, pX3, pY3));

            Console.ReadKey();


        }

    }
}


