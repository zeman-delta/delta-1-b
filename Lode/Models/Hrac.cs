namespace Lode.Models;

public class Hrac
{
    public string Name { get; set; }
    
    public int Score {get; set;}
    
    public More _more;
    
    public Hrac(string name)
    {
        Name = name;
        Score = 0;
    }

}