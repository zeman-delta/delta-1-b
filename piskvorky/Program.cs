using System;

namespace piskvorky
{
    class Program
    {
        static char[,] pole = new char[6,3];
        static char aktualniHrac = 'X';

        static void Main(string[] args)
        {
            InicializovatPole();
            
            while (true)
            {
                VykreslitPole();
                TahHrace();

                if (JeVyhra())
                {
                    VykreslitPole();
                    Console.WriteLine($"Hráč {aktualniHrac} vyhrál!");
                    break;
                }

                if (JeRemiza())
                {
                    VykreslitPole();
                    Console.WriteLine("Remíza!");
                    break;
                }

                // Vystřídání hráčů
                aktualniHrac = (aktualniHrac == 'X') ? 'O' : 'X';
            }
        }

        static void InicializovatPole()
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[0, 3] = 'R';
                }
            }
        }

        static void VykreslitPole()
        {
            Console.Clear();
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    Console.Write(pole[i, j] + "|");
                }
            }
        }

        static void TahHrace()
        {
            int radek, sloupec;
            while (true)
            {
                Console.WriteLine($"Hraje hráč {aktualniHrac}. Zadej souřadnice (řádek sloupec):");
                string[] vstup = Console.ReadLine().Split(' ');

                if (vstup.Length == 2 &&
                    int.TryParse(vstup[0], out radek) &&
                    int.TryParse(vstup[1], out sloupec) &&
                    radek >= 0 && radek < 3 &&
                    sloupec >= 0 && sloupec < 3 &&
                    pole[radek, sloupec] == ' ')
                {
                    pole[radek, sloupec] = aktualniHrac;
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatný tah, zkus to znovu.");
                }
            }
        }

        static bool JeVyhra()
        {
            // Kontrola řádků a sloupců
            for (int i = 0; i < 3; i++)
            {
                if ((pole[i, 0] == aktualniHrac && pole[i, 1] == aktualniHrac && pole[i, 2] == aktualniHrac) ||
                    (pole[0, i] == aktualniHrac && pole[1, i] == aktualniHrac && pole[2, i] == aktualniHrac))
                {
                    return true;
                }
            }

            // Kontrola diagonál
            if ((pole[0, 0] == aktualniHrac && pole[1, 1] == aktualniHrac && pole[2, 2] == aktualniHrac) ||
                (pole[0, 2] == aktualniHrac && pole[1, 1] == aktualniHrac && pole[2, 0] == aktualniHrac))
            {
                return true;
            }

            return false;
        }

        static bool JeRemiza()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (pole[i, j] == ' ')
                    {
                        return false; // Našel se volný prostor, hra nekončí
                    }
                }
            }
            return true; // Všechna pole jsou plná
        }
    }
}