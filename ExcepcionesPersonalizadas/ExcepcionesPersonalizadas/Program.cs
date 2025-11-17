using System.ComponentModel;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> list = new List<Object> { 1, 2, 6, 4, "PERRO", 5 };
            List<int> enteros = new List<int>();

            try
            {
                CargarLista(list, enteros);
            }
            catch (MyException ex)
            {
                Console.WriteLine($"Intento agregar el elemento: {ex.Error.ToString()}\n"+ex.Message );
            }
            finally
            {

                foreach (int i in enteros)
                {
                    Console.WriteLine(i);
                }

            }






        }

        static void CargarLista(List<Object> lista, List<int> enteros)
        {

            foreach (Object elemento in lista)
            {
                if (elemento is int)
                {
                    enteros.Add((int)elemento);//unboxing
                }
                else
                {
                    throw new MyException("Imposible agregar un elemento a la lista.", elemento);
                }
            }

        }







    }

}

