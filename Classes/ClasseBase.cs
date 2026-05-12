namespace ArenaHerois.Classes;

abstract class ClasseBase
{
    public abstract string       Nome        { get; }
    public abstract string       Descricao   { get; }
    public abstract int          DadoDeVida  { get; }   
    public abstract List<string> Habilidades { get; }

    public int RolarPV(int modResistencia)
    {
        int rolo = new Random().Next(1, DadoDeVida + 1);
        return Math.Max(1, rolo + modResistencia);
    }
}
