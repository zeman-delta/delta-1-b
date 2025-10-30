// 1)
// Vygeneruj 5 nahodných čísel (-10, 20) a vypiš je
// pro těchto 5 čísel poté vypiš
//      součet
//      průměr
//      maximum
//      minimum

Random rnd = new Random();
int soucet = 0;
int maximum = -100;
int minimum = 200;

for (int i = 0; i < 5; i++)
{
    int cislo = rnd.Next(-10, 21);
    Console.WriteLine(cislo);
    
    soucet = soucet + cislo;

    if (maximum < cislo)
    {
        maximum = cislo;
    }

    if (minimum > cislo)
    {
        minimum = cislo;
    }
}

Console.WriteLine("------------");
Console.WriteLine(soucet);
Console.WriteLine(minimum);
Console.WriteLine(maximum);
Console.WriteLine(soucet / 5.0);


// 2) 
// Vygeneruj 10 nahodných čísel (-273.15, 100)
// vygenerovaná hodnota je ve °C
// převeď hodnoty na °F a vypiš je
// převeď hodnoty na K a vypiš je

// double min = 50;
// double max = 150;
//
// for (int i = 0; i < 10; i++)
// {
//     double rndCislo = rnd.NextDouble();
//     Console.WriteLine(rndCislo);
//     
//     double target = (rndCislo * (max - min)) + min;
//     Console.WriteLine(target);
//
//     Console.WriteLine("--------");
// }

double minC = -273.15;
double maxC = 100;

for (int i = 0; i < 10; i++)
{
    double rndCislo = rnd.NextDouble();
    Console.WriteLine(rndCislo);

    double target = rndCislo * (maxC - minC) + minC;
    Console.WriteLine(target);

    Console.WriteLine("--------");
}


// 3) 
// generuj 2 náhodná čísla (-30, 30)
// pokud součet čísel bude nula, ukonči smyču
// vypiš počet opakování který byl proveden

// 4)
// generuj 4 náhodná čísla (-30, 30)
// pokud součet čísel bude nula, ukonči smyču
// vypiš počet opakování který byl proveden






