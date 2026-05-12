namespace ArenaHerois.Strategies;

class MetodoAleatorio : IDistribuicao
{
    static readonly Random rng = new();

    public string Nome      => "Aleatório (rola 2d6)";
    public string Descricao => "O sistema rola 2 dados de 6 para cada atributo.";

    public Dictionary<string, int> Distribuir(string[] nomes)
    {
        var resultado = new Dictionary<string, int>();
        Console.WriteLine("\n  Rolando dados...\n");
        foreach (var n in nomes)
        {
            int valor = rng.Next(1, 7) + rng.Next(1, 7);
            resultado[n] = valor;
            Console.WriteLine($"    {n,-15} -> {valor}");
        }
        return resultado;
    }
}
