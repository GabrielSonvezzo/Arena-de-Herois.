namespace ArenaHerois.Strategies;

class MetodoPredefinido : IDistribuicao
{
    public string Nome      => "Perfil Pré-definido";
    public string Descricao => "Escolha um perfil de herói já montado.";

    static readonly int[][] perfis =
    {
        new[] { 12, 10,  8,  8,  6,  6 },  
        new[] {  8,  8, 12, 10,  6,  6 },  
        new[] {  6,  8,  6,  6, 12, 12 },  
        new[] {  8, 10,  8, 10,  8,  6 }, 
    };

    static readonly string[] nomesPerfis =
    {
        "Tanque      (Força 12, Agilidade 10...)",
        "Ágil        (Velocidade 12, Percepção 10...)",
        "Sábio       (Inteligência 12, Percepção 12...)",
        "Balanceado  (todos entre 6 e 10)"
    };

    public Dictionary<string, int> Distribuir(string[] nomes)
    {
        Console.WriteLine("\n  Escolha um perfil:\n");
        for (int i = 0; i < nomesPerfis.Length; i++)
            Console.WriteLine($"    {i + 1} -> {nomesPerfis[i]}");

        Console.Write("\n  Perfil (1-4): ");
        int escolha = LerInt(1, 4);
        int[] valores = perfis[escolha - 1];

        var resultado = new Dictionary<string, int>();
        Console.WriteLine();
        for (int i = 0; i < nomes.Length; i++)
        {
            resultado[nomes[i]] = valores[i];
            Console.WriteLine($"    {nomes[i],-15} -> {valores[i]}");
        }
        return resultado;
    }

    static int LerInt(int min, int max)
    {
        int v;
        while (!int.TryParse(Console.ReadLine(), out v) || v < min || v > max)
            Console.Write($"  Digite entre {min} e {max}: ");
        return v;
    }
}
