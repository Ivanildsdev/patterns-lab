using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    internal class RespostaEmCsv : Resposta
    {
        public Resposta OutraResposta { get ; set ; }

        public RespostaEmCsv(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmCsv()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else if (OutraResposta != null)
            { 
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
