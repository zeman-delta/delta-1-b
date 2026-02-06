namespace Banka;

class Program
{
    static void Main(string[] args)
    {
        
        BankovniUcet ucet1 = new BankovniUcet("123456", "Jiri", 1234);
        
        ucet1.Vlozit(1000);
        
        Console.WriteLine(ucet1.GetZustatek(1234));

        ucet1.Vlastnik = "Karel";
    }
}