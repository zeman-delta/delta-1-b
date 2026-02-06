using System.Globalization;

namespace Banka;

public class BankovniUcet
{
    
    public string CisloUctu;
    public string Vlastnik;
    private decimal _zustatek;
    private int _pin;

    public BankovniUcet(string cisloUctu, string vlastnik, int pin)
    {
        CisloUctu = cisloUctu;
        Vlastnik = vlastnik;
        _pin = pin;
        _zustatek = 0;
    }
    
    public void Vlozit(decimal castka)
    {
        if (castka < 0)
        {
            Console.WriteLine("Nelze vložit záporné číslo.");
        }
        else
        {
            _zustatek += castka;
            Console.WriteLine("peníze vloženy");
        }
    }

    public void Vybrat(decimal castka)
    {
        if (castka < 0 || _zustatek < castka)
        {
            Console.WriteLine("chyba");
        }
        else
        {
            _zustatek -= castka;
        }
    }
    
    public decimal GetZustatek(int pin)
    {
        if (pin == _pin)
        {
            return _zustatek;
        }

        return 0;
    }
    
    
    public decimal GetZustatek()
    {
        return _zustatek;
    }
    
}