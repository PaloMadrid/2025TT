
using System.Text;

namespace Empleado
{
    public abstract class Empleado
    {
       private  string nombre;
        private int legajo;
        private double salarioBase;

        public Empleado(string nombre, int legajo, double salarioBase)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.salarioBase = salarioBase;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }

        public virtual string MostrarInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"-----------------------------------");
            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Legajo: {Legajo}");
            stringBuilder.AppendLine($"Salario Base: {SalarioBase}");

            return stringBuilder.ToString();
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
