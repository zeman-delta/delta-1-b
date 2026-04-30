namespace Slovnik;

public class Sklad
{

    private Dictionary<string, int> zasoby;

    public Sklad()
    {
        zasoby = new Dictionary<string, int>();
    }

    public void PridejPolozku(string polozka)
    {
        // zasoby.Add(polozka, 0);
        //
        // Console.WriteLine($"Položka {0} byla přidána do skladu", polozka);
        
        PridejPolozku(polozka, 0);
    }
    
    public void PridejPolozku(string polozka, int pocet)
    {
        zasoby.Add(polozka, pocet);
        
        Console.WriteLine($"Položka {polozka} byla přidána do skladu s počtem kusů {pocet}");
    }

    public void OdeberPolozku(string polozka)
    {
        zasoby.Remove(polozka);

        Console.WriteLine($"Položka {polozka} byla odebrána ze skladu");
    }

    public void VypsatZasoby()
    {
        if (zasoby.Count == 0)
        {
            Console.WriteLine("Sklad je prázdný.");
            
            return;
        }
        
        foreach (KeyValuePair<string, int> polozka in zasoby)
        {
            Console.WriteLine($"{polozka.Key}: {polozka.Value}");
        }
    }

    public void UpravitPolozku(string polozka, int změna)
    {
        if (!zasoby.ContainsKey(polozka))
        {
            Console.WriteLine("Neplatný klíč.");
            
            return;
        }
        
        zasoby[polozka] += změna;

        if (zasoby[polozka] < 0)
        {
            zasoby[polozka] = 0;
        }

        Console.WriteLine($"Položka {polozka} byla upravena a nový počet kusů je {zasoby[polozka]}");
    }
    
}