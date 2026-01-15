namespace Tridy;

public class Auto
{

    public string nazev;
    public int vykon;
    
    public int poziceX;
    public int poziceY;


    public Auto(int x, int y, int vykon)
    {
        poziceX = x;
        poziceY = y;

        this.vykon = vykon;
    }


    public void VypisPozici()
    {
        Console.WriteLine("Pozice auta " + nazev + ": [" + poziceX + ", " + poziceY + "]");
    }
    
    public void UpravPozici(int x, int y)
    {
        if (x > vykon)
        {
            x = vykon;
        } else if (x < -vykon)
        {
            x = -vykon;
        }
        
        poziceX += x; // poziceX = poziceX + x;
        poziceY += y; // poziceY = poziceY + y;
    }

}