
namespace Metody2;

class Program
{
    static void Main(string[] args)
    {
        OpakujZpravu("zprava Ahoj", 10);
    }


    public static void OpakujZpravu(string zprava, int pocet)
    {
        for (int i = 0; i < pocet; i++)
        {
            Console.WriteLine(zprava);
        }
    }


    public static void VypisVek(int rokNarozeni)
    {
        int vek = 2025 - rokNarozeni;
        Console.WriteLine($"Je ti přibližně {vek} let.");
    }
    
}
