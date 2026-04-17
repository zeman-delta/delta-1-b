namespace Lode.Models;

public abstract class Policko
{
    
    protected bool _potopena;

    public bool Potopena
    {
        get { return _potopena; }
    }

    abstract public bool Zasah();

    abstract public void Vykresli();

}