using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {

        static private AdmCuentas iAdmCuentas = new AdmCuentas();

        static void Main(string[] args)
        {

            {
                char opc;

                do
                {
                    Console.WriteLine("Ingrese una opcion:");
                    Console.WriteLine("1 - Gestion cuentas.");
                    //Console.WriteLine("2 - Actualizar datos cliente.");
                    Console.WriteLine("0 - Salir.");

                    opc = Console.ReadKey().KeyChar;

                    Console.Clear();

                    switch (opc)
                    {
                        case '1':
                            {
                                MenuCuenta();
                                break;
                            }
                        case '2':
                            {
                                //MenuCliente();
                                break;
                            }
                    }


                }

                while (opc != '0');

            }

        }

        private static void MenuCuenta()
        {
            double saldo;
            char opc;



            do
            {
                Console.WriteLine("Saldos actuales:");
                Console.WriteLine();
                Console.WriteLine("--Cuenta Corriente:  {0}", iAdmCuentas.SaldoCuentaCorriente());
                Console.WriteLine("--Caja Ahorro:  {0}", iAdmCuentas.SaldoCajaAhorro());
                Console.WriteLine();
                Console.WriteLine("Ingrese una opcion:");
                Console.WriteLine("1 - Transferir a cuenta corriente.");
                Console.WriteLine("2 - Transferir a caja de ahorro.");
                Console.WriteLine("0 - Salir");

                opc = Console.ReadKey().KeyChar;

                Console.Clear();

                switch (opc)
                {
                    case '1':
                        {
                            Console.Write("Ingrese el saldo a transferir: ");
                            Double.TryParse(Console.ReadLine(), out saldo);
                            iAdmCuentas.TransferirACuentaCorriente(saldo);
                            break;
                        }
                    case '2':
                        {
                            Console.Write("Ingrese el saldo a transferir: ");
                            Double.TryParse(Console.ReadLine(), out saldo);
                            iAdmCuentas.TransferirACajaAhorro(saldo);
                            break;
                        }
                }


            }
            while (opc != '0');


        }
        /*
        private static void MenuCliente()
        {
            int intNumeroDoc;
            TipoDocumento tipoDocumento;
            string nombre, numeroDocumento;

            Console.WriteLine("Ingrese los datos del cliente:");

            Console.Write(" - Nombre: ");
            nombre = Console.ReadLine();
            Console.Write(" - Numero documento: ");
            numeroDocumento = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de documento (0-DNI, 1-CUIT, 2-CUIL, 3-LE, 4-LC");
            int.TryParse(Console.ReadLine(), out intNumeroDoc);

            switch (intNumeroDoc)
            {
                case 0:
                    {
                        tipoDocumento = TipoDocumento.DNI;
                        break;
                    }
                case 1:
                    {
                        tipoDocumento = TipoDocumento.CUIT;
                        break;
                    }
                case 2:
                    {
                        tipoDocumento = TipoDocumento.CUIL;
                        break;
                    }
                case 3:
                    {
                        tipoDocumento = TipoDocumento.LE;
                        break;
                    }
                case 4:
                    {
                        tipoDocumento = TipoDocumento.LC;
                        break;
                    }
                default:
                    {
                        tipoDocumento = TipoDocumento.DNI;
                        break;
                    }
            }

            iAdmCuentas.CrearCliente(tipoDocumento, numeroDocumento, nombre);

            Console.ReadKey();

        }
        */

    }
}
