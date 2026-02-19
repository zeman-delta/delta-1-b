using System;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Vytvoření banky
            Banka banka = new Banka(10, 10);

            // 2. Vytvoření osob
            Osoba osoba1 = new Osoba("Jan", "Novák", 1990);
            Osoba osoba2 = new Osoba("Petr", "Svoboda", 1985);

            // 3. Vytvoření účtů
            BankovniUcet ucet1 = new BankovniUcet("123456", osoba1, 1234);
            BankovniUcet ucet2 = new BankovniUcet("654321", osoba2, 4321);

            // 4. Přidání účtů do banky
            banka.ZalozitUcet(ucet1);
            banka.ZalozitUcet(ucet2);

            // 5. Vytvoření karet
            PlatebniKarta karta1 = new PlatebniKarta("1111-2222-3333-4444", 123, "12/25", ucet1, osoba1);
            banka.VydatKartu(karta1);

            // 6. Testování
            ucet1.Vlozit(5000);
            ucet2.Vlozit(1000);

            Console.WriteLine("Před platbou:");
            ucet1.VypisInfo();
            ucet2.VypisInfo();

            // 7. Platba kartou
            PlatbaKartou(banka, ucet2, 2000, "1111-2222-3333-4444");

            Console.WriteLine("Po platbě:");
            ucet1.VypisInfo();
            ucet2.VypisInfo();
        }

        static void PlatbaKartou(Banka banka, BankovniUcet cilovyUcet, decimal castka, string cisloKarty)
        {
            Console.WriteLine($"\nZahajuji platbu kartou {cisloKarty} na částku {castka}...");

            // Najít kartu
            PlatebniKarta? karta = banka.NajdiKartu(cisloKarty);
            if (karta == null)
            {
                Console.WriteLine("Karta nenalezena.");
                return;
            }

            // Získat údaje od uživatele
            Console.Write("Zadejte CVV: ");
            int zadaneCVV = int.Parse(Console.ReadLine());

            Console.Write("Zadejte datum platnosti (MM/YY): ");
            string zadaneDatum = Console.ReadLine();

            // Ověření údajů
            if (zadaneCVV == karta.CVV && zadaneDatum == karta.DatumPlatnosti)
            {
                BankovniUcet zdrojovyUcet = karta.GetUcet();
                if (zdrojovyUcet.GetZustatek() >= castka)
                {
                    zdrojovyUcet.Vybrat(castka);
                    cilovyUcet.Vlozit(castka);
                    Console.WriteLine("Platba proběhla úspěšně.");
                }
                else
                {
                    Console.WriteLine("Nedostatek prostředků na účtu karty.");
                }
            }
            else
            {
                Console.WriteLine("Chybné údaje karty.");
            }
        }
    }
}