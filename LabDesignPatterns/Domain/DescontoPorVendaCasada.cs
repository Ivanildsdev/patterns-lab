using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (IsVendaCasada(orcamento))
                return orcamento.Valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        private bool IsVendaCasada(Orcamento orcamento)
        {
            return orcamento.Existe("Caneta") && orcamento.Existe("Lapis");
        }
    }
}
