namespace ArenaHerois.Strategies;

interface IDistribuicao
{
    string Nome      { get; }
    string Descricao { get; }

    Dictionary<string, int> Distribuir(string[] nomesAtributos);
}
