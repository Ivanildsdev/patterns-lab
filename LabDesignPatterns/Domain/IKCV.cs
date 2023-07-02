using LabDesignPatterns.Domain.Template;

namespace LabDesignPatterns.Domain
{
    public class IKCV : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);
        }


        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue100Reais(Orcamento orcamento)
        {
            return orcamento.Itens.Any(p => p.Valor > 100);
        }
    }
}
