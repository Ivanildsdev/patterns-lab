using LabDesignPatterns.Domain.Interfaces;

namespace LabDesignPatterns.Domain
{
    internal class RespostaEmXml : Resposta
    {
        public Resposta OutraResposta { get ; set ; }

        public RespostaEmXml(Resposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmXml()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else if (OutraResposta != null)
            { 
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
