namespace Lode.Models;

public class More
{
    public const int Velikost = 10;
    private Policko[,] _hraciPlocha;
    private List<Lod> _lode;

    public More()
    {
        _hraciPlocha = new Policko[Velikost, Velikost];
        _lode = new List<Lod>();

        for (int y = 0; y < Velikost; y++)
            for (int x = 0; x < Velikost; x++)
                _hraciPlocha[y, x] = new VodaBod();
    }

    public bool UmistiLod(Lod lod, int x, int y, bool horizontalni)
    {
        int delka = lod.Body.Length;

        for (int i = 0; i < delka; i++)
        {
            int nx = horizontalni ? x + i : x;
            int ny = horizontalni ? y : y + i;

            if (nx < 0 || nx >= Velikost || ny < 0 || ny >= Velikost)
                return false;

            for (int dy = -1; dy <= 1; dy++)
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    int cx = nx + dx, cy = ny + dy;
                    if (cx >= 0 && cx < Velikost && cy >= 0 && cy < Velikost)
                    {
                        if (_hraciPlocha[cy, cx] is LodBod)
                            return false;
                    }
                }
            }
        }

        for (int i = 0; i < delka; i++)
        {
            int nx = horizontalni ? x + i : x;
            int ny = horizontalni ? y : y + i;
            _hraciPlocha[ny, nx] = lod.Body[i];
        }

        _lode.Add(lod);
        return true;
    }

    public bool JeZasazeno(int x, int y)
    {
        return _hraciPlocha[y, x].Potopena;
    }

    public bool Strel(int x, int y)
    {
        return _hraciPlocha[y, x].Zasah();
    }

    public bool VsechnyPotopeny()
    {
        return _lode.Count > 0 && _lode.All(l => l.Potopena);
    }

    public void Vykresli(bool zobrazLode)
    {
        Console.Write("   ");
        for (int x = 0; x < Velikost; x++)
            Console.Write((char)('A' + x) + " ");
        Console.WriteLine();

        for (int y = 0; y < Velikost; y++)
        {
            Console.ResetColor();
            Console.Write($"{y,2} ");
            for (int x = 0; x < Velikost; x++)
            {
                if (zobrazLode && _hraciPlocha[y, x] is LodBod lodBod && !lodBod.Potopena)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write('■');
                }
                else
                {
                    _hraciPlocha[y, x].Vykresli();
                }
                Console.ResetColor();
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
}