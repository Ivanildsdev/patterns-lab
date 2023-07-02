using LabDesignPatterns.Domain.Template;

namespace LabDesignPatterns.Domain
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<string> listaItem = new List<string>();

            foreach (var item in orcamento.Itens)
            {
                if (listaItem.Contains(item.Nome))
                    return true;
                else
                    listaItem.Add(item.Nome);
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
