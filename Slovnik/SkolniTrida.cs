namespace Slovnik;

public class SkolniTrida
{

    private Dictionary<int, Student> trida;
    
    public SkolniTrida()
    {
        trida = new Dictionary<int, Student>();
    }
    
    public void PridejStudenta(Student student, int id)
    {
         trida.Add(id, student);
    }
    
    // OdeberStudenta
    
    // UpravPrumer
    
    // UpravAbsenci
    
    // VypisStudenty

}