namespace Tridy;

class Program
{

    public static void Main(string[] args)
    {
        Auto auto1 = new Auto(1, 3, 6);
        auto1.VypisPozici();
        
        auto1.nazev = "Fiat 500";
        auto1.VypisPozici();
        
        Auto auto2 = new Auto(6, 1, 10);
        auto2.nazev = "Skoda Fabia";
        auto2.VypisPozici();

        Kolo kolo1 = new Kolo(2, 6);
        kolo1.nazev = "Kolo 1";
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\nCyklus " + i + ":");
            
            auto1.VypisPozici();
            auto1.UpravPozici(50,0);
            auto1.VypisPozici();
        
            auto2.VypisPozici();
            auto2.UpravPozici(0,50);
            auto2.VypisPozici();
        
            kolo1.VypisPozici();
            kolo1.UpravPozici(0, -50);
            kolo1.VypisPozici();
        }
    }

}