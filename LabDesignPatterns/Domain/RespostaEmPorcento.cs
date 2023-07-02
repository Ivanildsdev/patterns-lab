using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    internal class RespostaEmPorcento : Resposta
    {
        public Resposta OutraResposta { get ; set ; }

        public RespostaEmPorcento(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else if (OutraResposta != null)
            { 
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
