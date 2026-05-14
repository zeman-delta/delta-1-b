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
    
    public void OdeberStudenta(int id)
    {
        trida.Remove(id);
    }

    public void UpravitPrumer(int id, double prumer)
    {
        if (trida.ContainsKey(id))
        {
            trida[id].Prum = prumer;
        }
    }

    public void UpravitAbsenci(int id, double absence)
    {
        if (trida.ContainsKey(id))
        {
            trida[id].Absence = absence;
        }
    }

    public void VypisStudenty()
    {
        foreach (KeyValuePair<int, Student> keyValuePair in trida)
        {
            Console.WriteLine($"Student {keyValuePair.Value.Jmeno} s ID {keyValuePair.Key} má průměr {keyValuePair.Value.Prum} a absenci {keyValuePair.Value.Absence}");
        }
    }

}