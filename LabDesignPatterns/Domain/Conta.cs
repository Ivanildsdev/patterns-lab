using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesignPatterns.Domain
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public void Deposita(string titular, double valor)
        {
            this.Titular = titular;
            this. Saldo += valor;
        }
    }
}
