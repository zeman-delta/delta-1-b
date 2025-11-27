// int[] pole2 = new int[10];
//
// Console.WriteLine("Velikost pole " + pole2.Length);
//
// pole2[0] = 1;
// pole2[1] = 3;
// pole2[2] = 6;
// pole2[3] = 12;
// pole2[4] = 24;
//
// // Console.WriteLine(pole2[0]);
// // Console.WriteLine(pole2[1]);
// // Console.WriteLine(pole2[2]);
//
// for (int i = 0; i < pole2.Length; i++)
// {
//     Console.WriteLine(i + ": " + pole2[i]);
// }
//
// // 1)
// // vytvoř pole o deseti prvcích, které bude mít náhodné hodnoty 0...100 a pole vypiš
// Random rnd = new Random();
//
// int[] pole = new int[10];
//
// for (int i = 0; i < pole.Length; i++)
// {
//     pole[i] = rnd.Next(0, 101);
//
//     Console.WriteLine(pole[i]);
// }
//
//
// // 2) 
// // vyrvoř pole o 50 prvcích, které bude mít náhodné hodnoty 0...100
// // pole vypiš do jednoho řádku Console.Write()
// // najdi v poli maximum a minimum a vypiš je
// // spočítej průměr a vypiš ho
// Console.WriteLine("----------------------------------------------");
//
// int[] pole3 = new int[50];
//
// for (int i = 0; i < pole3.Length; i++)
// {
//     pole3[i] = rnd.Next(0, 501);
//     Console.Write(pole3[i] + ", ");
// }
//
// Console.WriteLine();
//
// int min = Int32.MaxValue;
// int max = Int32.MinValue;
// int soucet = 0;
//
// for (int i = 0; i < pole3.Length; i++)
// {
//     if (pole3[i] < min)
//     {
//         min = pole3[i];
//     }
//
//     if (pole3[i] > max)
//     {
//         max = pole3[i];        
//     }
//
//     soucet = soucet + pole3[i];
// }
//
// int prumer = soucet / pole3.Length;
//
// Console.WriteLine($"Minimum: {min}, Maximum {max}, Průměr: {prumer}");

Random rnd = new Random();

// Pro následující úlohy si vždy na začátek vyzkoušíme úlohu s polem
int[] test = new [] { -5, -3, -2, 1, 4, 6};
// vygenerujeme nové pole o velikosti 10 a v rozmezí -10 až 10

// 1️⃣ Vypiš pole pozpátku

Console.WriteLine("----------------");

int[] pole1 = new int[10];

for (int i = 0; i < pole1.Length; i++)
{
    pole1[i] = rnd.Next(-10, 11);
    
    Console.Write($"{pole1[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = pole1.Length -1; i >= 0; i--)
{
    Console.WriteLine(pole1[i]);
}

for (int i = test.Length -1; i >= 0; i--)
{
    Console.WriteLine(test[i]);
}

Console.WriteLine("----------------");

// 2️⃣ Spočítej, kolik je v poli sudých čísel

int[] pole2 = new int[10];
int pocetSudych = 0;

for (int i = 0; i < pole2.Length; i++)
{
    pole2[i] = rnd.Next(-10, 11);
    Console.Write($"{pole2[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = 0; i < pole2.Length; i++)
{
    if (pole2[i] % 2 == 0)
    {
        pocetSudych++; // pocetSudych = pocetSudych + 1; pocetSudych += 1;
    }
}

Console.WriteLine(pocetSudych);

pocetSudych = 0;

for (int i = 0; i < test.Length; i++)
{
    if (test[i] % 2 == 0)
    {
        pocetSudych++;
    }
}

Console.WriteLine(pocetSudych);

Console.WriteLine("----------------");

// 3️⃣ Spočítej, kolik čísel je větších než 0

int[] pole3 = new int[10];
int pocetVetsichNezNula = 0;

for (int i = 0; i < pole3.Length; i++)
{
    pole3[i] = rnd.Next(-10, 11);
    Console.Write($"{pole3[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = 0; i < pole3.Length; i++)
{
    if (pole3[i] > 0)
    {
        pocetVetsichNezNula++;
    }
}

Console.WriteLine(pocetVetsichNezNula);
pocetVetsichNezNula = 0;

for (int i = 0; i < test.Length; i++)
{
    if (test[i] > 0)
    {
        pocetVetsichNezNula++;
    }
}

Console.WriteLine(pocetVetsichNezNula);

Console.WriteLine("----------------");

// 4️⃣ Spočítej součet jen záporných čísel

int[] pole4 = new int[10];
int soucetZapornych = 0;

for (int i = 0; i < pole4.Length; i++)
{
    pole4[i] = rnd.Next(-10, 11);
    Console.Write($"{pole4[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = 0; i < pole4.Length; i++)
{
    if (pole4[i] < 0)
    {
        soucetZapornych += pole4[i]; // soucetZapornych = soucetZapornych + pole4[i]
    }
}

Console.WriteLine(soucetZapornych);
soucetZapornych = 0;

for (int i = 0; i < test.Length; i++)
{
    if (test[i] < 0)
    {
        soucetZapornych += test[i];
    }
}

Console.WriteLine(soucetZapornych);
Console.WriteLine("----------------");

// 5️⃣ Poznej, jestli je pole seřazené vzestupně
// Pole: { 1, 2, 3, 4, 5 } → ano
// Pole: { 1, 3, 2, 5 } → ne

int[] pole5 = new int[10];
bool jeSerazeno = true;

for (int i = 0; i < pole5.Length; i++)
{
    pole5[i] = rnd.Next(-10, 11);
    Console.Write($"{pole5[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = 0; i < pole5.Length - 1; i++)
{
    if (pole5[i] > pole5[i + 1])
    {
        jeSerazeno = false;
        
        break;
    }
}

if (jeSerazeno)
{
    Console.WriteLine("Pole je seřazené.");
}
else
{
    Console.WriteLine("Pole není seřazené.");
}


jeSerazeno = true;
for (int i = 0; i < test.Length - 1; i++)
{
    if (test[i] > test[i + 1])
    {
        jeSerazeno = false;
        
        break;
    }
}
Console.WriteLine(jeSerazeno);

Console.WriteLine("----------------");

// -------------------------------------------------------
// 6️⃣ Vypiš čísla na sudých indexech
// Pole: { 10, 20, 30, 40, 50, 60 }
// Indexy: 0,2,4 → 10, 30, 50

int[] pole6 = new int[10];
for (int i = 0; i < pole6.Length; i++)
{
    pole6[i] = rnd.Next(-10, 11);
    Console.Write($"{pole6[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

for (int i = 0; i < pole6.Length; i += 2)
{
    Console.Write($"{pole6[i]}, "); // pole1[i] + ", "
}

Console.WriteLine();

Console.WriteLine("----------------");

// 7️⃣ Najdi součet všech lichých čísel
// Pole: { 5, 2, 9, 1, 8 } → 5 + 9 + 1 = 15

int[] pole7 = new int[10];
int soucetLichych = 0;

for (int i = 0; i < pole7.Length; i++)
{
    pole7[i] = rnd.Next(-10, 11);
    Console.Write(pole7[i] + ", ");
}

Console.WriteLine();

for (int i = 0; i < pole7.Length; i++)
{
    int jeLiche = pole7[i] % 2;
    if (jeLiche == 1 || jeLiche == -1) // jeLiche != 0
    {
        soucetLichych += pole7[i]; // soucetLichych = soucetLichych + pole7[i]
    }
}

Console.WriteLine(soucetLichych);

Console.WriteLine("----------------");

// 8️⃣ Vyměň první a poslední prvek pole
// Pole před: { 1, 2, 3, 4 }
// Pole po: { 4, 2, 3, 1 }

int[] pole8 = { 1, 2, 3, 4 };

int pomocna = pole8[0];

pole8[0] = pole8[pole8.Length - 1];
pole8[pole8.Length - 1] = pomocna;

for (int i = 0; i < pole8.Length; i++)
{
    Console.Write(pole8[i] + ", ");
}

pomocna = pole8[0];
pole8[0] = pole8[1];
pole8[1] = pomocna;

for (int i = 0; i < pole8.Length; i++)
{
    Console.Write(pole8[i] + ", ");
}

// 9️⃣ Najdi počet výskytů zadaného čísla v poli
// Pole: { 4, 2, 4, 7, 4 }
// Uživatel zadá: 4
// Výstup: 3×

int[] pole9 = new int[10];

for (int i = 0; i < pole9.Length; i++)
{
    pole9[i] = rnd.Next(-10, 11);
}

int hledaneCislo = Convert.ToInt32(Console.ReadLine());
int pocetVyskytu = 0;

for(int i = 0; i < pole9.Length; i++)
{
    if (pole9[i] == hledaneCislo)
    {
        pocetVyskytu++;
    }
}

Console.WriteLine(pocetVyskytu);


