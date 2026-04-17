namespace Lode.Models;

public class LodBod: Policko
{
    
    public Lod Lod { get; }

    
    public LodBod(Lod lod)
    {
        _potopena = false;
        Lod = lod;
    }
    

    public override bool Zasah()
    {
        _potopena = true;

        if (Lod.JsouBodyPotopeny())
        {
            Lod.Potopena = true;
        }
        
        return true;
    }

    public override void Vykresli()
    {
        if (_potopena)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write('҉');
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write('~');
        }
    }
}