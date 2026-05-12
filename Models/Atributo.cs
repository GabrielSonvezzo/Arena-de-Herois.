namespace ArenaHerois.Models;

class Atributo
{
    public string Nome  { get; }
    public int    Valor { get; set; }

    public int Modificador => Valor switch
    {
        <= 3  => -3,
        <= 5  => -2,
        <= 8  => -1,
        <= 12 =>  0,
        <= 15 => +1,
        <= 17 => +2,
        _     => +3
    };

    public Atributo(string nome, int valor)
    {
        Nome  = nome;
        Valor = valor;
    }

    public override string ToString()
    {
        string sinal = Modificador >= 0 ? "+" : "";
        return $"  {Nome,-15} {Valor,2}   (Mod: {sinal}{Modificador})";
    }
}
