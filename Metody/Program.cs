namespace Metody;
    
class Program
{

    public static void Main( string[] args )
    {
        int[] pole = VytvorPole();
        uloha1(pole);
        
        Console.WriteLine("----------------");

        int[] pole2 = VytvorPole();
        int pocetSudych = uloha2(pole2);
        
        Console.WriteLine(pocetSudych);
        
        Console.WriteLine("----------------");

    }


    public static void VypisPole(int[] poleProVypis)
    {
        for (int i = 0; i < poleProVypis.Length - 1; i++)
        {
            Console.Write(poleProVypis[i] + ", ");
        }
        
        Console.WriteLine(poleProVypis[poleProVypis.Length - 1]);
    }
    
    
    public static int[] VytvorPole()
    {
        int velikostPole = 10;
        int min = -10;
        int max = 10;
        
        Random rnd = new Random();

        int[] pole = new int[velikostPole];

        for (int i = 0; i < pole.Length; i++)
        {
            pole[i] = rnd.Next(min, max + 1);
        }
        
        VypisPole(pole);
        
        return pole;
    }
    
    
    public static void uloha1(int[] pole)
    {
        // vypiš pole pozpátku
        
        for (int i = pole.Length -1; i >= 0; i--)
        {
            Console.Write(pole[i] + ", ");
        }
    }
    
    
    public static int uloha2(int[] pole)
    {
        int pocetSudych = 0;
        
        for (int i = 0; i < pole.Length; i++)
        {
            if (pole[i] % 2 == 0)
            {
                pocetSudych++;
            }
        }

        return pocetSudych;
    }

}