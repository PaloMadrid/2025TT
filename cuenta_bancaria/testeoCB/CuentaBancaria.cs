using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeoCB
{
    class CuentaBancaria
    {
        private int numeroCuenta;
        private string titular;
        private double saldo;

        public CuentaBancaria(int numeroCuenta, string titular, double saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public bool Depositar(string monto)
        {
            bool retorno = false;

            if (double.TryParse(monto, out double valor)&&(valor%100==0))
            {
                this.saldo += valor;
                retorno = true;

            }
            return retorno;
        }

        public bool Retirar(string monto)
        {
            bool retorno = false;

            if (double.TryParse(monto,out double valor) &&(this.saldo > valor))
            {
                retorno=true;
                this.saldo -= valor;
            }

            return retorno;
        }

        public double ConsultarSaldo()
        {
            return this.saldo;
        }

        public string MostrarInfo()
        {
            return $"Numero de cuenta: {this.numeroCuenta}, Titular: {this.titular}, Saldo: {this.saldo}";
        }


    }
}
