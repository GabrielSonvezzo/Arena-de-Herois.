
using ArenaHerois.Factory;
using ArenaHerois.Models;
using ArenaHerois.Strategies;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] nomesAtributos = { "Força", "Agilidade", "Velocidade", "Resistência", "Inteligência", "Percepção" };

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("================================================");
Console.WriteLine("     ARENA DOS HERÓIS — Criação de Personagem  ");
Console.WriteLine("================================================");
Console.ResetColor();

Console.Write("\n  Nome do personagem: ");
string nome = Console.ReadLine()?.Trim() ?? "Herói";

Console.WriteLine("\n  Escolha a CLASSE:\n");
ClasseFactory.ExibirMenu();
Console.Write("\n  Opção (1-4): ");
var classe = ClasseFactory.Criar(LerInt(1, 4));

Console.WriteLine("\n  Como distribuir os ATRIBUTOS?\n");
Console.WriteLine("    1 -> Aleatório     (rola 2d6 por atributo)");
Console.WriteLine("    2 -> Livre         (você gasta 60 pontos)");
Console.WriteLine("    3 -> Pré-definido  (escolhe um perfil pronto)");
Console.Write("\n  Opção (1-3): ");

IDistribuicao metodo = LerInt(1, 3) switch
{
    1 => new MetodoAleatorio(),
    2 => new MetodoLivre(),
    3 => new MetodoPredefinido(),
    _ => new MetodoAleatorio()
};

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n  Método: {metodo.Nome}");
Console.WriteLine($"  {metodo.Descricao}");
Console.ResetColor();

var valores = metodo.Distribuir(nomesAtributos);

var atributos = new Dictionary<string, Atributo>();
foreach (var kv in valores)
    atributos[kv.Key] = new Atributo(kv.Key, kv.Value);

int modResistencia = atributos["Resistência"].Modificador;
int pv = classe.RolarPV(modResistencia);

var personagem = new Personagem
{
    Nome         = nome,
    Classe       = classe,
    Atributos    = atributos,
    PontosDeVida = pv
};

personagem.ExibirFicha();

Console.WriteLine("  Pressione qualquer tecla para sair...");
Console.ReadKey();

static int LerInt(int min, int max)
{
    int v;
    while (!int.TryParse(Console.ReadLine(), out v) || v < min || v > max)
        Console.Write($"  Digite entre {min} e {max}: ");
    return v;
}
