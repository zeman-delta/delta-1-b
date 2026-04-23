namespace Lode.Models;

public class TypLod : Lod
{
    public string Nazev { get; }

    public TypLod(string nazev, int velikost) : base(velikost)
    {
        Nazev = nazev;
    }
}