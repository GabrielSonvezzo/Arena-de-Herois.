namespace ArenaHerois.Classes;

class Assassino : ClasseBase
{
    public override string Nome       => "Assassino";
    public override int    DadoDeVida => 8;
    public override string Descricao  =>
        "Sombra letal que combina Velocidade e Agilidade " +
        "para eliminar alvos antes que percebam sua presença.";

    public override List<string> Habilidades => new()
    {
        "Ataque Furtivo  : dano dobrado ao atacar de surpresa",
        "Sombra Viva     : move-se sem ser detectado no escuro",
        "Veneno          : aplica dano contínuo por 3 turnos após o ataque"
    };
}
