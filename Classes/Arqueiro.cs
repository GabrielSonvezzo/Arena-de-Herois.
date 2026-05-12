namespace ArenaHerois.Classes;

class Arqueiro : ClasseBase
{
    public override string Nome       => "Arqueiro";
    public override int    DadoDeVida => 8;
    public override string Descricao  =>
        "Atirador de elite que usa Agilidade e Percepção " +
        "para acertar inimigos a longa distância sem ser visto.";

    public override List<string> Habilidades => new()
    {
        "Tiro Preciso    : +2 de acerto quando estiver parado",
        "Chuva de Flechas: ataca até 3 inimigos ao mesmo tempo",
        "Camuflagem      : fica invisível em terreno aberto por 1 turno"
    };
}
