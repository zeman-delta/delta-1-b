using System;

namespace Banka
{
    public class PlatebniKarta
    {
        public string Cislo;
        public int CVV;
        public string DatumPlatnosti;
        private BankovniUcet _ucet;
        private Osoba _majitel;

        public PlatebniKarta(string cislo, int cvv, string datumPlatnosti, BankovniUcet ucet, Osoba majitel)
        {
            Cislo = cislo;
            CVV = cvv;
            DatumPlatnosti = datumPlatnosti;
            _ucet = ucet;
            _majitel = majitel;
        }

        public BankovniUcet GetUcet()
        {
            return _ucet;
        }

        public Osoba GetMajitel()
        {
            return _majitel;
        }
    }
}