using ArenaHerois.Classes;

namespace ArenaHerois.Models;

class Personagem
{
    public string                       Nome         { get; set; } = "";
    public ClasseBase                   Classe       { get; set; } = null!;
    public Dictionary<string, Atributo> Atributos    { get; set; } = new();
    public int                          PontosDeVida { get; set; }

    public void ExibirFicha()
    {
        string linha = new string('=', 48);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n" + linha);
        Console.WriteLine("   FICHA DE PERSONAGEM — ARENA DOS HERÓIS");
        Console.WriteLine(linha);
        Console.ResetColor();

        Console.WriteLine($"  Nome  : {Nome}");
        Console.WriteLine($"  Classe: {Classe.Nome}");
        Console.WriteLine($"  PV    : {PontosDeVida}  (1d{Classe.DadoDeVida} + Mod. Resistência)");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  ── ATRIBUTOS " + new string('─', 34));
        Console.ResetColor();

        foreach (var atr in Atributos.Values)
            Console.WriteLine(atr);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  ── SOBRE A CLASSE " + new string('─', 29));
        Console.ResetColor();
        Console.WriteLine($"  {Classe.Descricao}");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n  ── HABILIDADES " + new string('─', 32));
        Console.ResetColor();

        foreach (var hab in Classe.Habilidades)
            Console.WriteLine($"  • {hab}");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n" + linha);
        Console.ResetColor();
    }
}
