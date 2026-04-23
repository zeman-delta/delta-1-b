namespace Lode.Models;

public abstract class Lod
{
    public bool Potopena { get; set; }

    public LodBod[] Body { get; }

    protected Lod(int velikost)
    {
        Potopena = false;
        Body = new LodBod[velikost];
        for (int i = 0; i < velikost; i++)
        {
            Body[i] = new LodBod(this);
        }
    }

    public bool JsouBodyPotopeny()
    {
        foreach (LodBod bod in Body)
        {
            if (bod.Potopena == false)
            {
                return false;
            }
        }
        
        return true;
    }
    
}