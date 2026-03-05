namespace Pole2DUvod;

class Program
{
    static void Main(string[] args)
    {
        // int[,] pole1 = new int[3, 3];
        //
        // int[,] pole =
        // {
        //     {1, 2, 3},
        //     {4, 5, 6},
        //     {7, 8, 9}
        // };
        //
        // int[] pole2 = { 1, 3, 6 };
        //
        // for (int i = 0; i < pole.GetLength(0); i++)
        // {
        //     for (int j = 0; j < pole.GetLength(1); j++)
        //     {
        //         Console.Write(pole[i, j] + " ");
        //     }
        //     
        //     Console.WriteLine();
        // }
        
        int[,] pole5 = Pole();
        VypisPole(pole5);
    }


    public static int[,] Pole()
    {
        int[,] pole = new int[3, 3];

        for (int i = 0; i < pole.GetLength(0); i++)
        {
            for (int j = 0; j < pole.GetLength(1); j++)
            {
                pole[i, j] = 0;
            }
        }
        
        return pole;
    }


    public static void VypisPole(int[,] pole)
    {
        for (int i = 0; i < pole.GetLength(0); i++)
        {
            for (int j = 0; j < pole.GetLength(1); j++)
            {
                Console.Write(pole[i, j] + "; ");
            }

            Console.WriteLine();
        }
    }
    
    
}