namespace Slovnik;

public class Student
{
    
    public string Jmeno
    {
        get { return field;}
        set
        {
            if (value != null && value.Length > 0)
            {
                field = value;
            }
        }
    }

    private int _vek;
    public int Vek
    {
        get { return _vek;}
        set
        {
            if (value >= 14 && value <= 19)
            {
                _vek = value;
            }
        }
    }

    public double Prum;
    public double Absence;

    public Student(double prum, double absence, string jmeno, int vek)
    {
        Prum = prum;
        Absence = absence;
        Jmeno = jmeno;
        Vek = vek;
    }
}