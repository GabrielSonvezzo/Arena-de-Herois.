using ArenaHerois.Classes;

namespace ArenaHerois.Factory;

static class ClasseFactory
{
    static readonly Dictionary<int, Func<ClasseBase>> catalogo = new()
    {
        { 1, () => new Guerreiro() },
        { 2, () => new Arqueiro()  },
        { 3, () => new Mago()      },
        { 4, () => new Assassino() },
    };

    public static ClasseBase Criar(int opcao)
    {
        if (catalogo.TryGetValue(opcao, out var criar))
            return criar();
        throw new ArgumentException("Opção de classe inválida.");
    }

    public static void ExibirMenu()
    {
        Console.WriteLine("    1 -> Guerreiro  (d10)  — tanque corpo a corpo");
        Console.WriteLine("    2 -> Arqueiro    (d8)  — atirador à distância");
        Console.WriteLine("    3 -> Mago         (d6)  — conjurador arcano");
        Console.WriteLine("    4 -> Assassino   (d8)  — especialista furtivo");
    }
}
