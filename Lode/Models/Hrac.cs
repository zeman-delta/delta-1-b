namespace Lode.Models;

public class Hrac
{
    public string Name { get; set; }
    public int Score { get; set; }
    public More More { get; }

    public Hrac(string name)
    {
        Name = name;
        Score = 0;
        More = new More();
    }
}