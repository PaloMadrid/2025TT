namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> lista = new List<Object> { 1, 2, 6, 4, 6, 15 };
            List<int> enteros = new List<int>();


            //string numeroString=Console.ReadLine();
            //bool parsear = int.TryParse(numeroString, out int numero);

            //Console.WriteLine(parsear);
            //Console.WriteLine(numero);


            try
            {
                CargarNumeros(lista, enteros);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Objeto no valido: " + ex.ObjetoError.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                foreach (int numero in enteros)
                {
                    Console.WriteLine(numero);
                }
            }

        }

        static void CargarNumeros(List<object> lista,List<int> enteros)
        {
            foreach (object item in lista)
            {           
                                                
                if (item is int)
                {
                    if (10 > int.Parse(item.ToString()))
                    {
                    enteros.Add((int)item);

                    }
                    else
                    {
                        throw new MyException("el numero debe ser menor a 10 ",item);
                    }
                    
                }
                else 
                {
                    throw new MyException("no se pudo convertir a entero ",item);
                }

            }
        }
    }
}
