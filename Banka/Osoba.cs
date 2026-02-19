using System;

namespace Banka
{
    public class Osoba
    {
        public string Jmeno;
        public string Prijmeni;
        public int RokNarozeni;

        private BankovniUcet[] _seznamUctu;
        private int _pocetUctu;

        public Osoba(string jmeno, string prijmeni, int rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
            _seznamUctu = new BankovniUcet[10]; // Kapacita pro 10 účtů
            _pocetUctu = 0;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"Osoba: {Jmeno} {Prijmeni}, Ročník: {RokNarozeni}");
        }

        public void PridatUcet(BankovniUcet ucet)
        {
            if (_pocetUctu < _seznamUctu.Length)
            {
                _seznamUctu[_pocetUctu] = ucet;
                _pocetUctu++;
            }
            else
            {
                Console.WriteLine("Tato osoba má již příliš mnoho účtů.");
            }
        }
    }
}