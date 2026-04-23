using Lode.Models;

namespace Lode;

class Program
{
    static readonly (string nazev, int velikost)[] DefiniceLodi =
    {
        ("Letadlová loď", 5),
        ("Bitevní loď", 4),
        ("Křižník", 3),
        ("Ponorka", 3),
        ("Torpédoborec", 2)
    };

    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("╔══════════════════╗");
        Console.WriteLine("║      LODĚ        ║");
        Console.WriteLine("╚══════════════════╝");
        Console.WriteLine();

        var hrac = new Hrac("Hráč");
        var pocitac = new Hrac("Počítač");

        UmistiLodeHrace(hrac);
        UmistiLodeNahodne(pocitac);

        Console.WriteLine("Počítač rozmístil lodě. Hra začíná!");
        Console.WriteLine("Stiskněte Enter...");
        Console.ReadLine();

        bool hracNaTahu = true;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("=== Vaše moře ===");
            hrac.More.Vykresli(true);
            Console.WriteLine();
            Console.WriteLine("=== Soupeřovo moře ===");
            pocitac.More.Vykresli(false);
            Console.WriteLine();

            if (hracNaTahu)
            {
                Console.Write("Váš tah - zadejte souřadnice (např. A5): ");

                int x, y;
                while (true)
                {
                    string? vstup = Console.ReadLine()?.Trim().ToUpper();
                    if (vstup != null && ParsujSouradnice(vstup, out x, out y))
                    {
                        if (pocitac.More.JeZasazeno(x, y))
                        {
                            Console.Write("Sem jste už stříleli. Zadejte jiné souřadnice: ");
                            continue;
                        }
                        break;
                    }
                    Console.Write("Neplatný vstup. Zadejte písmeno A-J a číslo 0-9 (např. A5): ");
                }

                bool zasah = pocitac.More.Strel(x, y);
                if (zasah)
                {
                    hrac.Score++;
                    Console.WriteLine(">>> ZÁSAH! <<<");
                }
                else
                {
                    Console.WriteLine("Vedle.");
                }

                if (pocitac.More.VsechnyPotopeny())
                {
                    Console.Clear();
                    Console.WriteLine("=== Soupeřovo moře ===");
                    pocitac.More.Vykresli(false);
                    Console.WriteLine();
                    Console.WriteLine($"VYHRÁLI JSTE! Počet zásahů: {hrac.Score}");
                    break;
                }
            }
            else
            {
                int x, y;
                do
                {
                    x = random.Next(More.Velikost);
                    y = random.Next(More.Velikost);
                } while (hrac.More.JeZasazeno(x, y));

                bool zasah = hrac.More.Strel(x, y);
                if (zasah)
                    pocitac.Score++;

                Console.WriteLine($"Počítač střílí na {(char)('A' + x)}{y}: {(zasah ? ">>> ZÁSAH! <<<" : "Vedle.")}");

                if (hrac.More.VsechnyPotopeny())
                {
                    Console.Clear();
                    Console.WriteLine("=== Vaše moře ===");
                    hrac.More.Vykresli(true);
                    Console.WriteLine();
                    Console.WriteLine("PROHRALI JSTE! Počítač potopil všechny vaše lodě.");
                    break;
                }
            }

            hracNaTahu = !hracNaTahu;
            Console.WriteLine("Stiskněte Enter pro pokračování...");
            Console.ReadLine();
        }
    }

    static bool ParsujSouradnice(string vstup, out int x, out int y)
    {
        x = y = -1;
        if (vstup.Length < 2 || vstup.Length > 3)
            return false;

        x = vstup[0] - 'A';
        if (x < 0 || x >= More.Velikost)
            return false;

        if (!int.TryParse(vstup.Substring(1), out y))
            return false;
        if (y < 0 || y >= More.Velikost)
            return false;

        return true;
    }

    static void UmistiLodeHrace(Hrac hrac)
    {
        Console.WriteLine("Rozmístěte své lodě na hrací plochu.");
        Console.WriteLine("Zadávejte souřadnice a směr: H = horizontálně, V = vertikálně");
        Console.WriteLine();

        foreach (var (nazev, velikost) in DefiniceLodi)
        {
            while (true)
            {
                Console.Clear();
                hrac.More.Vykresli(true);
                Console.WriteLine();
                Console.Write($"{nazev} (velikost {velikost}) - zadejte pozici a směr (např. A0 H): ");

                string? vstup = Console.ReadLine()?.Trim().ToUpper();
                if (vstup == null) continue;

                string[] casti = vstup.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (casti.Length != 2)
                {
                    Console.WriteLine("Zadejte souřadnice a směr (např. A0 H).");
                    Console.ReadLine();
                    continue;
                }

                if (!ParsujSouradnice(casti[0], out int x, out int y))
                {
                    Console.WriteLine("Neplatné souřadnice.");
                    Console.ReadLine();
                    continue;
                }

                if (casti[1] != "H" && casti[1] != "V")
                {
                    Console.WriteLine("Směr musí být H (horizontálně) nebo V (vertikálně).");
                    Console.ReadLine();
                    continue;
                }

                bool horizontalni = casti[1] == "H";
                var lod = new TypLod(nazev, velikost);

                if (hrac.More.UmistiLod(lod, x, y, horizontalni))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Loď nelze umístit (mimo plochu nebo kolize s jinou lodí).");
                    Console.ReadLine();
                }
            }
        }

        Console.Clear();
        Console.WriteLine("Vaše lodě jsou rozmístěny:");
        hrac.More.Vykresli(true);
        Console.WriteLine();
    }

    static void UmistiLodeNahodne(Hrac hrac)
    {
        foreach (var (nazev, velikost) in DefiniceLodi)
        {
            while (true)
            {
                int x = random.Next(More.Velikost);
                int y = random.Next(More.Velikost);
                bool horizontalni = random.Next(2) == 0;

                var lod = new TypLod(nazev, velikost);
                if (hrac.More.UmistiLod(lod, x, y, horizontalni))
                    break;
            }
        }
    }
}