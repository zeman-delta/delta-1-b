using System;

namespace Banka
{
    public class Banka
    {
        private BankovniUcet[] _seznamUctu;
        private int _pocetUctu;
        private PlatebniKarta[] _seznamKaret;
        private int _pocetKaret;

        public Banka(int kapacitaUctu, int kapacitaKaret)
        {
            _seznamUctu = new BankovniUcet[kapacitaUctu];
            _pocetUctu = 0;
            _seznamKaret = new PlatebniKarta[kapacitaKaret];
            _pocetKaret = 0;
        }

        public void ZalozitUcet(BankovniUcet novyUcet)
        {
            if (_pocetUctu < _seznamUctu.Length)
            {
                _seznamUctu[_pocetUctu] = novyUcet;
                _pocetUctu++;
            }
            else
            {
                Console.WriteLine("Banka je plná.");
            }
        }

        public void VydatKartu(PlatebniKarta novaKarta)
        {
            if (_pocetKaret < _seznamKaret.Length)
            {
                _seznamKaret[_pocetKaret] = novaKarta;
                _pocetKaret++;
            }
            else
            {
                Console.WriteLine("Nelze vydat další kartu.");
            }
        }

        public PlatebniKarta? NajdiKartu(string cisloKarty)
        {
            for (int i = 0; i < _pocetKaret; i++)
            {
                if (_seznamKaret[i].Cislo == cisloKarty)
                {
                    return _seznamKaret[i];
                }
            }
            return null;
        }

        public BankovniUcet? NajdiUcet(string cisloUctu)
        {
            for (int i = 0; i < _pocetUctu; i++)
            {
                if (_seznamUctu[i].CisloUctu == cisloUctu)
                {
                    return _seznamUctu[i];
                }
            }
            
            Console.WriteLine($"Účet {cisloUctu} nebyl nalezen.");
            
            return null;
        }

        public void Prevod(string cisloZdroj, string cisloCil, decimal castka)
        {
            BankovniUcet? zdroj = NajdiUcet(cisloZdroj);
            BankovniUcet? cil = NajdiUcet(cisloCil);

            if (zdroj != null && cil != null)
            {
                if (zdroj.GetZustatek() >= castka)
                {
                    zdroj.Vybrat(castka);
                    cil.Vlozit(castka);
                    Console.WriteLine("Převod úspěšný.");
                }
                else
                {
                    Console.WriteLine("Nedostatek prostředků na zdrojovém účtu.");
                }
            }
            else
            {
                Console.WriteLine("Jeden z účtů nebyl nalezen.");
            }
        }

        public void NajdiNejbohatsiho()
        {
            if (_pocetUctu == 0)
            {
                Console.WriteLine("Banka nemá žádné účty.");
                return;
            }

            BankovniUcet nejbohatsi = _seznamUctu[0];
            for (int i = 1; i < _pocetUctu; i++)
            {
                if (_seznamUctu[i].GetZustatek() > nejbohatsi.GetZustatek())
                {
                    nejbohatsi = _seznamUctu[i];
                }
            }
            Console.WriteLine($"Nejbohatší klient: {nejbohatsi.Vlastnik.Jmeno} {nejbohatsi.Vlastnik.Prijmeni}, Zůstatek: {nejbohatsi.GetZustatek()}");
        }

        public void SmazatUcet(string cisloUctu)
        {
            int indexKeSmazani = -1;
            for (int i = 0; i < _pocetUctu; i++)
            {
                if (_seznamUctu[i].CisloUctu == cisloUctu)
                {
                    indexKeSmazani = i;
                    break;
                }
            }

            if (indexKeSmazani != -1)
            {
                for (int i = indexKeSmazani; i < _pocetUctu - 1; i++)
                {
                    _seznamUctu[i] = _seznamUctu[i + 1];
                }
                _seznamUctu[_pocetUctu - 1] = null;
                _pocetUctu--;
                Console.WriteLine($"Účet {cisloUctu} byl smazán.");
            }
            else
            {
                Console.WriteLine($"Účet {cisloUctu} nebyl nalezen.");
            }
        }

        public void CelkovyKapital()
        {
            decimal celkem = 0;
            for (int i = 0; i < _pocetUctu; i++)
            {
                celkem += _seznamUctu[i].GetZustatek();
            }
            Console.WriteLine($"Celkový kapitál banky: {celkem}");
        }

        public void StrhnoutPoplatekUcetnictvi(decimal kolik)
        {
            for (int i = 0; i < _pocetUctu; i++)
            {
                _seznamUctu[i].StahnoutPoplatek(kolik);
            }
        }
    }
}