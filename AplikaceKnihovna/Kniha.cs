namespace AplikaceKnihovna;

public class Kniha
{
    
    private string nazev;
    private string autor;
    private int rokVydani;

    // TODO naplnit ostatní atributy třídy
    public Kniha(string nazev)
    {
        this.nazev = nazev;
    }
    
    public void VypisInfo()
    {
        Console.WriteLine($"Kniha se jmenuje {nazev}");
    }
    
}