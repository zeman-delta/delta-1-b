// Prvni uloha
double[] poleF = { 50, 32, 68, 86, 53.6, 64.4, 25.7, 92.3 };
double[] poleC = new double[poleF.Length];

double soucet = 0;
int pocetVetsichNezPrumer = 0;

for (int i = 0; i < poleF.Length; i++)
{
    poleC[i] = (poleF[i] - 32) * 5 / 9;
    poleC[i] = Math.Round(poleC[i], 2);
    Console.WriteLine($"{poleF[i]}°F = {poleC[i]}°C");
    
    soucet += poleC[i];
}

double prumer = soucet / poleC.Length;
Console.WriteLine($"Průměr: {prumer}");

for (int i = 0; i < poleC.Length; i++)
{
    if (poleC[i] > prumer)
    {
        pocetVetsichNezPrumer++;

        Console.WriteLine($"hodnota {poleC[i]} na indexu {i} je vetsi jak prumer");
    }    
}

Console.WriteLine($"Počet hodnot větších než průměr: {pocetVetsichNezPrumer}");

double max = 0;
int maxIndex = 0;
double max2 = 0;
int max2Index = 0;

for (int i = 0; i < poleC.Length; i++)
{
    if (poleC[i] > max)
    {
        max2 = max;
        max = poleC[i];

        max2Index = maxIndex;
        maxIndex = i;
    } else if (poleC[i] > max2)
    {
        max2 = poleC[i];

        max2Index = i;
    }
}

Console.WriteLine($"2. nejvetsi hodnota: {max2}, hodnota je na indexu {max2Index}");

// max = poleC.Max();
// max2 = 0;
//
// for (int i = 0; i < poleC.Length; i++)
// {
//     if (poleC[i] > max2 && poleC[i] != max)
//     {
//         max2 = poleC[i];
//         max2Index = i;
//     }
// }

double nej = 1000000;
int nejIndex = 0;

for (int i = 0; i < poleC.Length; i++)
{
    if (Math.Abs(poleC[i] - prumer) < Math.Abs(nej - prumer))
    {
        nej = poleC[i];
        nejIndex = i;
    }
}

Console.WriteLine($"Nejblizsi hodnota k prumeru: {nej}, hodnota je na indexu {nejIndex}");










