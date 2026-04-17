namespace Lode.Models;

public class VodaBod: Policko
{
    
    public override bool Zasah()
    {
        _potopena = true;
        
        return false;
    }

    public override void Vykresli()
    {
        if (_potopena)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write('҈');
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write('~');
        }
    }
    
}