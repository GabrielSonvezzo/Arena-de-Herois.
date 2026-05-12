namespace ArenaHerois.Classes;

class Mago : ClasseBase
{
    public override string Nome       => "Mago";
    public override int    DadoDeVida => 6;
    public override string Descricao  =>
        "Mestre das artes arcanas que transforma Inteligência " +
        "em poder destrutivo capaz de arrasar exércitos inteiros.";

    public override List<string> Habilidades => new()
    {
        "Bola de Fogo    : dano em área atingindo todos os inimigos próximos",
        "Escudo Mágico   : absorve até 5 pontos de dano por turno",
        "Teletransporte  : move-se instantaneamente até 10 metros"
    };
}
