namespace LabDesignPatterns.Domain
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(string nome, int valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

    }
}