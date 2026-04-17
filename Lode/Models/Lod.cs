namespace Lode.Models;

public abstract class Lod
{
    public bool Potopena { get; set; }
    
    public LodBod[] Body { get; }

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