namespace Slovnik;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Sklad sklad = new Sklad();

        sklad.VypsatZasoby();
        
        sklad.PridejPolozku("rohlik", 15);
        sklad.PridejPolozku("houska");
        
        sklad.VypsatZasoby();
        
        sklad.UpravitPolozku("houska", 30);
        sklad.UpravitPolozku("chleba", 30);
        sklad.OdeberPolozku("rohlik");
        
        sklad.VypsatZasoby();
    }
}