using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Vendedor: Empleado
    {
        double cantidadVentas;
        int porcentajeComision;

        public Vendedor(double cantidadVentas, int porcentajeComision, string nombre, int legajo, double salarioBase):base( nombre, legajo,salarioBase  )
        {
            this.cantidadVentas = cantidadVentas;
            this.porcentajeComision = porcentajeComision;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario()+(cantidadVentas*porcentajeComision/100);
        }

        public override string MostrarInfo()//polimorfismo
        {
            StringBuilder sb=new StringBuilder();   
            sb.Append(base.MostrarInfo());
            sb.AppendLine("Cantidad de ventas: " + cantidadVentas);
            sb.AppendLine("Salario final: "+this.CalcularSalario());

            return sb.ToString();
        }



    }
}
