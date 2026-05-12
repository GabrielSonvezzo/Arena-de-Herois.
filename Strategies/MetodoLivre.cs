namespace ArenaHerois.Strategies;

class MetodoLivre : IDistribuicao
{
    public string Nome      => "Distribuição Livre (60 pontos)";
    public string Descricao => "Você tem 60 pontos para distribuir (mín 2 / máx 12 cada).";

    public Dictionary<string, int> Distribuir(string[] nomes)
    {
        var resultado = new Dictionary<string, int>();
        int restantes = 60;

        Console.WriteLine($"\n  Pontos disponíveis: {restantes}  (mín 2 / máx 12)\n");

        for (int i = 0; i < nomes.Length; i++)
        {
            int maxPermitido = Math.Min(12, restantes - (nomes.Length - i - 1) * 2);
            Console.Write($"    {nomes[i],-15} (restam {restantes,2} pts, máx {maxPermitido}): ");

            int valor;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= 2 && valor <= maxPermitido)
                    break;
                Console.Write($"    Use entre 2 e {maxPermitido}: ");
            }

            resultado[nomes[i]] = valor;
            restantes -= valor;
        }
        return resultado;
    }
}
