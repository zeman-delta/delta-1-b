namespace List1;

public class Nakup
{
    
    private List<string> nakup;
    
    public Nakup()
    {
        nakup = new List<string>();

        while (true)
        {
            Console.WriteLine("Zadej vstup:");
            string? vstup = Console.ReadLine();
            
            if (String.IsNullOrEmpty(vstup))
            {
                Console.WriteLine("Nic jsi nezadal.");
                continue;
            }
            if (vstup == "stop")
            {
                break;
            }
            
            if (vstup[0] == '-')
            {
                OdeberPolozku(vstup.Substring(1), nakup);
            }
            else
            {
                PridejPolozku(vstup, nakup);
            }

            Console.Clear();
            
            VypisSeznam(nakup);
        }
        
    }

    private static void PridejPolozku(string polozka, List<string> seznam)
    {
        seznam.Add(polozka);
    }
    
    private static void OdeberPolozku(string polozka, List<string> seznam)
    {
        bool nalezeno = seznam.Remove(polozka);

        if (!nalezeno)
        {
            Console.WriteLine("Položka nenalezena.");
        }
    }

    private static void VypisSeznam(List<string> seznam)
    {
        foreach (string polozka in seznam)
        {
            Console.WriteLine(polozka);
        }

        Console.WriteLine();
        Console.WriteLine("Počet položek v seznamu: {0}", seznam.Count);
    }
}