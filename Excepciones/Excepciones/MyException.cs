using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class MyException:Exception
    {
        Object objetoError;

        public MyException(string mensaje, Object objetoError):base(mensaje)//usamos el constructor base para "pisar" el mensjae de error original
        {
            this.objetoError= objetoError;//informar que genero el error
        }

        public object ObjetoError { get => objetoError;}
    }
}
