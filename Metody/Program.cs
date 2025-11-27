namespace Metody;
    
class Program
{

    public static void Main( string[] args )
    {
        int[] pole = VytvorPole();
        
        VypisPole(pole);
        
        for (int i = pole.Length -1; i >= 0; i--)
        {
            Console.Write(pole[i] + ", ");
        }
        
        Console.WriteLine("----------------");

        int[] pole2 = VytvorPole();
        VypisPole(pole2);
        
        int pocetSudych = 0;
        for (int i = 0; i < pole2.Length; i++)
        {
            if (pole2[i] % 2 == 0)
            {
                pocetSudych++;
            }
        }
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
        
        return pole;
    }

}