using System;

namespace EJ2
{
    class Program
    {

        static private AdmCuentas iAdmCuentas = new AdmCuentas();

        static void Main(string[] args)
        {

            {
                MenuCliente();
                Inicializar();


                char opc;

                do
                {
                    Console.Clear();

                    Console.WriteLine("Ingrese una opcion:");
                    Console.WriteLine("1 - Gestion cuentas.");
                    Console.WriteLine("2 - Datos del cliente.");
                    Console.WriteLine("3 - Administracion.");
                    Console.WriteLine("0 - Salir.");

                    opc = Console.ReadKey().KeyChar;

                    switch (opc)
                    {
                        case '1':
                            {
                                GestionCuentas();
                                break;
                            }
                        case '2':
                            {
                                DatosCliente();
                                break;
                            }
                        case '3':
                            {
                                MenuAdministracion();
                                break;
                            }
                    }


                }

                while (opc != '0');

            }

        }

        private static void GestionCuentas()
        {
            Console.Clear();

            if (iAdmCuentas.ExisteCajaAhorro() || iAdmCuentas.ExisteCuentaCorriente())
            {
                double saldo;
                char opc;

                do
                {

                    Console.Clear();

                    Console.WriteLine("Saldos actuales:");
                    Console.WriteLine();
                    if (iAdmCuentas.ExisteCuentaCorriente())
                        Console.WriteLine("--Cuenta Corriente:  {0}", iAdmCuentas.SaldoCuentaCorriente());
                    if (iAdmCuentas.ExisteCajaAhorro())
                        Console.WriteLine("--Caja Ahorro:  {0}", iAdmCuentas.SaldoCajaAhorro());
                    Console.WriteLine();
                    Console.WriteLine("Ingrese una opcion:");
                    Console.WriteLine("1 - Transferir de caja de ahorro a cuenta corriente.");
                    Console.WriteLine("2 - Transferir de cuenta corriente a caja de ahorro.");
                    Console.WriteLine("0 - Salir");
                    Console.Write("Opcion seleccionada:");
                    opc = Console.ReadKey().KeyChar;
                    Console.WriteLine();


                    switch (opc)
                    {
                        case '1':
                            {
                                Console.Write("Ingrese el saldo a transferir: ");
                                Double.TryParse(Console.ReadLine(), out saldo);
                                if (!iAdmCuentas.TransferirACuentaCorriente(saldo))
                                    Console.WriteLine("No se pudo realizar la operacion.");
                                Console.ReadKey();
                                break;
                            }
                        case '2':
                            {
                                Console.Write("Ingrese el saldo a transferir: ");
                                Double.TryParse(Console.ReadLine(), out saldo);
                                if (!iAdmCuentas.TransferirACajaAhorro(saldo))
                                  Console.WriteLine("No se pudo realizar la operacion.");
                                Console.ReadKey();
                                break;
                            }
                    }


                }
                while (opc != '0');
            }
            else
            {
                Console.Write("No existe ninguna cuenta con ese cliente.");
                Console.ReadKey();
            }

        }

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

            Console.WriteLine("Ingrese el tipo de documento (0-DNI, 1-CUIT, 2-CUIL, 3-LE, 4-LC)");
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

        }

    private static void DatosCliente()
    {
            Console.Clear();
            Console.WriteLine("Datos del cliente");

            Console.Write(" - Nombre: ");
            Console.WriteLine(iAdmCuentas.Cliente.Nombre);
            Console.Write(" - Numero documento: ");
            Console.WriteLine(iAdmCuentas.Cliente.NroDocumento);

            Console.Write(" - Tipo documento:");
            Console.WriteLine(iAdmCuentas.Cliente.TipoDocumento.ToString());

            Console.ReadKey();
    }

        private static void MenuAdministracion()
        {

            {
                char opc;

                do
                {
                    Console.Clear();

                    Console.WriteLine("Ingrese una opcion (para el cliente actual):");
                    Console.WriteLine("1 - Crear caja ahorro.");
                   Console.WriteLine("2 - Crear cuenta corriente.");
                    //Console.WriteLine("3 - Administrar clientes.");
                    Console.WriteLine("0 - Salir.");

                    opc = Console.ReadKey().KeyChar;

                    switch (opc)
                    {
                        case '1':
                            {
                                CrearCajaAhorro();
                                break;
                            }
                        case '2':
                            {
                                CrearCuentaCorriente();
                                break;
                            }
                    }
                }

                while (opc != '0');

            }

        }

        private static void CrearCajaAhorro()
        {
            if (!iAdmCuentas.ExisteCajaAhorro())
            {
                int mSaldoInicial, mAcuerdo;
                Cuenta mCajaAhorro = null;

                Console.Clear();

                    Console.WriteLine("Creacion de cuentas:");
                    Console.WriteLine("Caja de ahorro.");
                    Console.Write("Saldo inicial: ");
                    int.TryParse(Console.ReadLine(), out mSaldoInicial);
                    Console.Write("Acuerdo: ");
                    int.TryParse(Console.ReadLine(), out mAcuerdo);

                    mCajaAhorro = iAdmCuentas.CrearCuenta(mSaldoInicial, mAcuerdo);
                    iAdmCuentas.CrearCuentas(iAdmCuentas.Cliente, iAdmCuentas.CuentaCorriente, mCajaAhorro);

            }
                        else
                {
                    Console.Write("Ya existe una caja de ahorro.");
                    Console.ReadKey();
            }
}

        private static void CrearCuentaCorriente()
        {
            if (!iAdmCuentas.ExisteCuentaCorriente())
            {
                int mSaldoInicial, mAcuerdo;
                Cuenta mCuentaCorriente;

                Console.WriteLine("Creacion de cuentas:");
                Console.WriteLine("Caja de ahorro.");
                Console.Write("Saldo inicial:");
                int.TryParse(Console.ReadLine(), out mSaldoInicial);
                Console.Write("Acuerdo:");
                int.TryParse(Console.ReadLine(), out mAcuerdo);

                mCuentaCorriente = iAdmCuentas.CrearCuenta(mSaldoInicial, mAcuerdo);
                iAdmCuentas.CrearCuentas(iAdmCuentas.Cliente, mCuentaCorriente, iAdmCuentas.CajaDeAhorro);

            }
            else
            {
                Console.Write("Ya existe una cuenta corriente.");
                Console.ReadKey();
            }
        }

        private static void Inicializar()
        {
                Cuenta mCajaAhorro = null;
                Cuenta mCuentaCorriente = null;

                iAdmCuentas.CrearCuentas(iAdmCuentas.Cliente, mCuentaCorriente, mCajaAhorro);
        }
    }
}
