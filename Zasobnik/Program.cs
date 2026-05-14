namespace Zasobnik;

class Program
{
    
    static void Main(string[] args)
    {
        Stack<string> slova = new Stack<string>();

        while (true)
        {
            if (slova.Count == 0)
            {
                Console.WriteLine("Zasobnik je prázdný.");
            }
            else
            {
                Console.WriteLine($"Poslední zadané slovo je: {slova.Peek()}");
            }
            
            Console.WriteLine("Zadej slovo:");
            string slovo = Console.ReadLine();

            if (slovo == "stop")
            {
                break;
            }
            
            if (slovo == "CtrlZ")
            {
                string vytazeneSlovo = slova.Pop();

                Console.WriteLine($"Slovo: \"{vytazeneSlovo}\" bylo odstraněno");
            }
            else
            {
                slova.Push(slovo);
            }
        }
    }

    public int[] OtocPole(int[] vstup)
    {
        Stack<int> pomocnyZasobnik = new Stack<int>();
        
        // 1. krok naházes vstup do Stack
        for (int i = 0; i < vstup.Length; i++)
        {
            pomocnyZasobnik.Push(vstup[i]);
        }
        
        // 2. krok vytvořit nové pole o stejné velikosti
        int[] vystup = new int[vstup.Length];
        
        // 3. krok naplnit pole položkami vytahovanými ze Stack
        for (int i = 0; i < vystup.Length; i++)
        {
            vystup[i] = pomocnyZasobnik.Pop();
        }

        return vystup;
    }
    
    
    
}