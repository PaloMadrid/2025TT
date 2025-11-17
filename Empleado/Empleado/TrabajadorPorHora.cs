using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class TrabajadorPorHora:Empleado
    {
        int horasTrabajadas;
        double valorHora;

        public TrabajadorPorHora(int horasTrabajadas, double valorHora, string nombre, int legajo, double salarioBase=0):base(nombre,legajo, salarioBase)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }

        public override double CalcularSalario()
        {
            return this.horasTrabajadas*this.valorHora;
        }

        public override string MostrarInfo()//polimorfismo
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine("Horas trabajadas: " + this.horasTrabajadas);
            sb.AppendLine("Valor hora: " + this.valorHora);
            sb.AppendLine("Salario final: " + this.CalcularSalario());

            return sb.ToString();
        }

    }
}
