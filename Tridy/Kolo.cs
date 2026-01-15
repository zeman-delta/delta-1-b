namespace Tridy;

public class Kolo
{
    public string nazev;
    
    public int poziceX;
    public int poziceY;
    
    public Kolo(int x, int y)
    {
        poziceX = x;
        poziceY = y;
    }
    
    public void VypisPozici()
    {
        Console.WriteLine("Pozice kola " + nazev + ": [" + poziceX + ", " + poziceY + "]");
    }
    
    public void UpravPozici(int x, int y)
    {
        if (x < 0)
        {
            x = -1;
        } else if (x > 0)
        {
            x = 1;
        }

        if (y < 0)
        {
            y = -1;
        } else if (y > 0)
        {
            y = 1;
        }
        
        poziceX += x;
        poziceY += y;
    }
}