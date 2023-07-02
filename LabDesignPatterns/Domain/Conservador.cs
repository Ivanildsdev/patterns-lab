using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
