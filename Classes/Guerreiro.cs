namespace ArenaHerois.Classes;

class Guerreiro : ClasseBase
{
    public override string Nome       => "Guerreiro";
    public override int    DadoDeVida => 10;
    public override string Descricao  =>
        "Combatente brutal forjado nas batalhas da Arena. " +
        "Usa Força e Resistência para dominar o campo de luta.";

    public override List<string> Habilidades => new()
    {
        "Golpe Poderoso  : causa dano extra baseado na Força",
        "Pele de Ferro   : reduz 1 ponto de dano recebido por turno",
        "Provocar        : força o inimigo a te atacar por 1 turno"
    };
}
