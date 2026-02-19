using System;

namespace Banka
{
    public class BankovniUcet
    {
        public string CisloUctu;
        public Osoba Vlastnik; // Změna z string na Osoba
        private decimal _zustatek;
        private int _pin;

        // Historie transakcí
        private string[] _historie;
        private int _pocetTransakci;

        public BankovniUcet(string cisloUctu, Osoba vlastnik, int pin)
        {
            CisloUctu = cisloUctu;
            Vlastnik = vlastnik;
            _pin = pin;
            _zustatek = 0;

            // Inicializace historie
            _historie = new string[5];
            _pocetTransakci = 0;
        }

        public void Vlozit(decimal castka)
        {
            if (castka <= 0)
            {
                Console.WriteLine("Nelze vložit zápornou nebo nulovou částku.");
            }
            else
            {
                _zustatek += castka;
                ZapisDoHistorie($"+{castka}");
                Console.WriteLine("Peníze vloženy.");
            }
        }

        public void Vybrat(decimal castka)
        {
            if (castka <= 0)
            {
                Console.WriteLine("Nelze vybrat zápornou nebo nulovou částku.");
            }
            else if (_zustatek < castka)
            {
                Console.WriteLine("Nedostatek prostředků na účtu.");
            }
            else
            {
                _zustatek -= castka;
                ZapisDoHistorie($"-{castka}");
                Console.WriteLine("Peníze vybrány.");
            }
        }

        public decimal GetZustatek(int pin)
        {
            if (pin == _pin)
            {
                return _zustatek;
            }
            Console.WriteLine("Chybný PIN.");
            return 0; // Nebo vyhodit výjimku, ale dle zadání vracíme 0
        }

        public decimal GetZustatek()
        {
            return _zustatek;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Účet: {CisloUctu}, Vlastník: {Vlastnik.Jmeno} {Vlastnik.Prijmeni}, Zůstatek: {_zustatek}");
        }

        private void ZapisDoHistorie(string zaznam)
        {
            if (_pocetTransakci < _historie.Length)
            {
                _historie[_pocetTransakci] = zaznam;
                _pocetTransakci++;
            }
            else
            {
                // Posun historie (FIFO)
                for (int i = 0; i < _historie.Length - 1; i++)
                {
                    _historie[i] = _historie[i + 1];
                }
                _historie[_historie.Length - 1] = zaznam;
            }
        }

        public void VypisHistorii()
        {
            Console.WriteLine($"Historie transakcí pro účet {CisloUctu}:");
            for (int i = 0; i < _pocetTransakci; i++)
            {
                Console.WriteLine(_historie[i]);
            }
        }
        
        public void StahnoutPoplatek(decimal kolik)
        {
            _zustatek -= kolik;
            ZapisDoHistorie($"Poplatek: -{kolik}");
        }
    }
}