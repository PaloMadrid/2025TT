using Empleado;
using System.Diagnostics.SymbolStore;
namespace Empleado
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado e1=new TrabajadorPorHora(30,1000,"Trabajador por hora",1,1000);
            Empleado e2 = new Vendedor(2000, 10, "Vendedor", 2, 1000);
            //Empleado e3 = new Empleado("empleado",3,2000);
            
            Console.WriteLine(e1.MostrarInfo());
            Console.WriteLine(e2.MostrarInfo());
            //Console.WriteLine(e3.MostrarInfo());
        }
    }
}
