using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        private string titular { get; set; }
        private int numeroConta;
        private double saldo;
        private double taxaDeSaque = 5.00;
        
        public Conta(string titular, int numeroConta)
        {
            this.titular = titular;
            this.numeroConta = numeroConta;
        }

        public void deposito(double value)
        {
            saldo += value;
        }

        public void saque(double value)
        {
            saldo -= value;
            saldo -= taxaDeSaque;
        }

        public override string ToString()
        {
            return "Conta " + numeroConta + ", Titular: " + titular + ", Saldo: R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
