namespace AplikaceKnihovna;

public class Knihovna
{
    
    private Kniha[] seznamKnih;
    private int pocetKnih = 0;
    
    public Knihovna(int kapacita)
    {
        seznamKnih = new Kniha[kapacita];
    }
    
    public void PridatKnihu(Kniha novaKniha)
    {
        if (pocetKnih < seznamKnih.Length)
        {
            seznamKnih[pocetKnih] = novaKniha;
            pocetKnih++;
            Console.WriteLine("Kniha přidána!");
        }
        else
        {
            Console.WriteLine("Knihovna je plna!");
        }
    }


    public void VypisVsechnyKnihy()
    {
        for (int i = 0; i < pocetKnih; i++)
        {
            Kniha aktualniKniha = seznamKnih[i];
            
            aktualniKniha.VypisInfo();
        }
    }
    
}