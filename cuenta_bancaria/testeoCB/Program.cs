namespace testeoCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            CuentaBancaria miCuenta = new CuentaBancaria(1, "Juan Gomez", 100000);
            string monto;
            do
            {
                Console.WriteLine("------MENU DE BANCO------");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Mostrar informacion de cuenta");
                Console.WriteLine("0. Salir");
                seleccion = int.Parse(Console.ReadLine());


                switch (seleccion)
                {
                    case 0:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                        break;
                    case 1:
                        Console.WriteLine("Cuanto desea depositar?");
                        monto = (Console.ReadLine());

                        if (miCuenta.Depositar(monto))
                        {
                            Console.WriteLine($"Se depositaron ${monto}. Su saldo es {miCuenta.ConsultarSaldo()}");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Cuanto desea retirar?");
                        monto = (Console.ReadLine());
                        if (miCuenta.Retirar(monto))
                        {
                            Console.WriteLine($"Se retiraron ${monto}. Su saldo es {miCuenta.ConsultarSaldo()}");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Su saldo es {miCuenta.ConsultarSaldo()}");
                        break;
                    case 4:
                        Console.WriteLine(miCuenta.MostrarInfo());
                        break;
                    default:
                        Console.WriteLine("ingrese un numero del menu");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (seleccion != 0);

        }
    }
}
