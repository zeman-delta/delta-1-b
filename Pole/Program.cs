int[] pole2 = new int[10];

Console.WriteLine("Velikost pole " + pole2.Length);

pole2[0] = 1;
pole2[1] = 3;
pole2[2] = 6;
pole2[3] = 12;
pole2[4] = 24;

// Console.WriteLine(pole2[0]);
// Console.WriteLine(pole2[1]);
// Console.WriteLine(pole2[2]);

for (int i = 0; i < pole2.Length; i++)
{
    Console.WriteLine(i + ": " + pole2[i]);
}

// 1)
// vytvoř pole o deseti prvcích, které bude mít náhodné hodnoty 0...100 a pole vypiš

// 2) 
// vyrvoř pole o 50 prvcích, které bude mít náhodné hodnoty 0...100
// pole vypiš do jednoho řádku Console.Write()
// najdi v poli maximum a minimum a vypiš je
// spočítej průměr a vypiš ho
