// See https://aka.ms/new-console-template for more information

using LabDesignPatterns.Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculaDescontos();

        //CalculaImposto();

        Console.ReadKey();
        //Console.WriteLine("Hello, World!");
    }

    private static void CalculaDescontos()
    {
        CalculadorDeDescontos calculador = new CalculadorDeDescontos();

        Orcamento orcamento = new(500);
        orcamento.AdicionaItem(new Item("Caneta", 250));
        orcamento.AdicionaItem(new Item("Lapis", 250));
        orcamento.AdicionaItem(new Item("Geradeira", 250));
        orcamento.AdicionaItem(new Item("Fogao", 250));
        orcamento.AdicionaItem(new Item("Microondas", 250));
        orcamento.AdicionaItem(new Item("Caneca", 250));

        double desconto = calculador.Calcula(orcamento);
        Console.WriteLine(desconto);
    }

    //Chains of Responsability
    private static void CalculaImposto()
    {
        var impostoIss = new ISS();
        var impostoIcms = new ICMS();
        Orcamento orcamento = new Orcamento(500);

        CalculadorDeImpostos calculador = new CalculadorDeImpostos();

        calculador.RealizaCalculo(orcamento, impostoIcms);
        calculador.RealizaCalculo(orcamento, impostoIss);
    }
}