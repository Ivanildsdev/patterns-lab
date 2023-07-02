using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    public class CalculadorDeImpostos
    {
        //Chain of responsability
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valorImpoosto = imposto.Calcula(orcamento);
           Console.WriteLine($"valor imposto ({orcamento.Valor})= " + valorImpoosto.ToString()); 
        }
    }
}
