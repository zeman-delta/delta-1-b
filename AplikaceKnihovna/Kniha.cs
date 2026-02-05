namespace AplikaceKnihovna;

public class Kniha
{
    
    private string _nazev;
    private string _autor;
    private int _rokVydani;

    // TODO naplnit ostatní atributy třídy
    public Kniha(string nazev)
    {
        _nazev = nazev;
    }
    
    public void VypisInfo()
    {
        Console.WriteLine($"Kniha se jmenuje {_nazev}");
    }
    
}