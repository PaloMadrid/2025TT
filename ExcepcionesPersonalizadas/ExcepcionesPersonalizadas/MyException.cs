using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class MyException : Exception
    {
        Object objetoError;
        public MyException(string mensaje, Object objetoError) : base(mensaje)
        {
            this.objetoError = objetoError;
        }

        public Object Error
        {
            get { return objetoError; }
        }


    }
}
