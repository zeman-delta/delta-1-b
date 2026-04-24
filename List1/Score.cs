namespace List1;

public class Score
{
    private List<int> score;
    
    public Score()
    {
        score = new List<int>();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Zadej vstup:");
            string vstup = Console.ReadLine();

            if (vstup == "stop")
            {
                break;
            }
            
            if (int.TryParse(vstup, out int cislo))
            {
                PridejScore(cislo);
            }
            else
            {
                Console.WriteLine("toto není číslo");
                continue;
            }
            
            Console.Clear();
            
            VypisScore(cislo);
        }
    }

    private void VypisScore()
    {
        for (int i = 0; i < score.Count && i < 3; i++)
        {
            Console.WriteLine($"{i + 1}. {score[i]}");
        }
    }

    private void VypisScore(int newScore)
    {
        VypisScore();

        Console.WriteLine();
        
        int pozice = score.IndexOf(newScore);
        
        Console.WriteLine($"{pozice + 1}. {score[pozice]}");
    }

    private void PridejScore(int newScore)
    {
        score.Add(newScore);
        
        score.Sort();
        score.Reverse();
    }
}