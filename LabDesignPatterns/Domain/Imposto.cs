namespace LabDesignPatterns.Domain
{
    public abstract class Imposto
    {
        private Imposto OutroImposto { get; set; }

        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            return OutroImposto == null ? 0 : OutroImposto.CalculaOutroImposto(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}