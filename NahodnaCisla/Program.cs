Random rnd = new Random();
/*
{
    int cislo = rnd.Next(1, 101);
    Console.WriteLine(cislo);

    Console.WriteLine("desetiné číslo: ");
    double b = rnd.NextDouble();
    Console.WriteLine(b);
    b = b * 100;
    Console.WriteLine(b);
    b = Math.Round(b, 2);
    Console.WriteLine(b);
}
*/

// 1. vyšší číslo - zadej x, vygeneruj a (1-100) vypiš které je vyšší
{
    Console.WriteLine("Zadej cislo x:");
    int x = Convert.ToInt32(Console.ReadLine());

    int a = rnd.Next(1, 101);
    Console.WriteLine(a);

    if (x > a)
    {
        Console.WriteLine("x je vyssi");
    }
    else if (a > x)
    {
        Console.WriteLine("a je vyssi");
    }
    else
    {
        Console.WriteLine("jsou si rovne");
    }
}


// 2. Náhodně vygeneruj teplotu od −10 do +35 °C a napiš, jaké je počasí.
{
    int teplota = rnd.Next(-10, 36);
    Console.WriteLine(teplota);

    if (teplota < 0)
    {
        Console.WriteLine("mrzne");
    }
    else if (teplota > 0 && teplota < 15)
    {
        Console.WriteLine("je zima");
    }
    else if (teplota > 15 && teplota < 25)
    {
        Console.WriteLine("je příjemně");
    }
    else if (teplota > 25 && teplota < 35)
    {
        Console.WriteLine("je vedro");
    }
    else
    {
        Console.WriteLine("nehnu se z bazénu");
    }
}


// 3. Kostky
//    2 hráči, každý 3 kostky, kdo hodí víc vyhrál.

{
    Console.WriteLine("Hráč 1:   (stiskni libovolnou klávesu)");
    Console.ReadKey();

    int hrac11 = rnd.Next(1, 7);
    int hrac12 = rnd.Next(1, 7);
    int hrac13 = rnd.Next(1, 7);
    int hrac1Soucet = hrac11 + hrac12 + hrac13;

    Console.WriteLine($"Hráč 1: {hrac11} + {hrac12} + {hrac13} = {hrac1Soucet}");

    Console.WriteLine("Hráč 2:   (stiskni libovolnou klávesu)");
    Console.ReadKey();

    int hrac21 = rnd.Next(1, 7);
    int hrac22 = rnd.Next(1, 7);
    int hrac23 = rnd.Next(1, 7);
    int hrac2Soucet = hrac21 + hrac22 + hrac23;

    Console.WriteLine($"Hráč 1: {hrac21} + {hrac22} + {hrac23} = {hrac2Soucet}");

    if (hrac1Soucet > hrac2Soucet)
    {
        Console.WriteLine("Hráč 1 vyhrál!");
    }
    else if (hrac2Soucet > hrac1Soucet)
    {
        Console.WriteLine("Hráč 2 vyhrál!");
    }
    else
    {
        Console.WriteLine("Je to remíza!");
    }
}

