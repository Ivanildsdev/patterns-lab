using LabDesignPatterns.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesignPatterns.Domain
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo {get; set;}

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5)
                return orcamento.Valor * 0.1;

            return Proximo.Desconta(orcamento);
        }
    }
}
