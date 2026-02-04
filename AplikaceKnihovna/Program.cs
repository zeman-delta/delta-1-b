namespace AplikaceKnihovna;

class Program
{
    static void Main(string[] args)
    {
        Knihovna knihovna1 = new Knihovna(3);
        
        Kniha kniha1 = new Kniha("Hobbit");
        knihovna1.PridatKnihu(kniha1);
        
        Kniha kniha2 = new Kniha("Kniha2");
        knihovna1.PridatKnihu(kniha2);
        
        // Kniha kniha3 = new Kniha("Kniha3");
        // knihovna1.PridatKnihu(kniha3);
        //
        // Kniha kniha4 = new Kniha("Kniha4");
        // knihovna1.PridatKnihu(kniha4);
        
        knihovna1.VypisVsechnyKnihy();
        
    }
    
}