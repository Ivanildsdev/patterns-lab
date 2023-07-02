namespace LabDesignPatterns.Domain.Interfaces
{
    public interface Desconto
    {
        Desconto Proximo { get; set;  }
        double Desconta(Orcamento orcamento);
    }
}
