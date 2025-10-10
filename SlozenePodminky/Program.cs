// zadej číslo a vypiš pokud je v rozsahu 1 až 10

int cislo = Convert.ToInt32(Console.ReadLine());

if (cislo > 1 && cislo < 10)
{
    Console.WriteLine("číslo je mezi 1 a 10");
}



// zadej číslo, a vypiš jestli je sudé, a zároveň mezi 1 až 10
int sude = cislo % 2;

// if (cislo > 1 && cislo < 10 && (cislo % 2) == 0)
if (cislo > 1 && cislo < 10 && sude == 0)
{
    Console.WriteLine("číslo je mezi 1 a 10 a je sudé");
}

// =============== 1) VSTUP DO KLUBU ==================
// kontrola vstupu do klubu.
// zadej rok narození, a jestli má návštěvník vstupenku.
// pokud oboje platí, vypiš, že může do klubu 
// pokud nemůže vypiš proč

Console.WriteLine("Zadej rok narození:");
int rokNarozeni = int.Parse(Console.ReadLine());

Console.WriteLine("Máš vstupenku? (ano/ne)");
string vstupenka = Console.ReadLine();

int vek = DateTime.Now.Year - rokNarozeni;

if (vek >= 18 && vstupenka.ToLower() == "ano")
{
    Console.WriteLine("Můžeš do klubu ✅");
}
else
{
    if (vek < 18)
        Console.WriteLine("Nemáš 18 let ❌");
    if (vstupenka.ToLower() != "ano")
        Console.WriteLine("Nemáš vstupenku ❌");
}


// =============== 2) PŘESTUPNÝ ROK ==================
// Zadej rok a vypiš jestli je přestupný
// (je dělitelný 4 A není dělitelný 100) NEBO (je dělitelný 400)

Console.WriteLine("\nZadej rok pro kontrolu přestupnosti:");
int rok = int.Parse(Console.ReadLine());

if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
{
    Console.WriteLine($"{rok} je přestupný rok ✅");
}
else
{
    Console.WriteLine($"{rok} není přestupný rok ❌");
}


// =============== 3) PŘIHLÁŠENÍ ==================
// je úspěšné, pokud uživatelské jméno je „admin“ A heslo je „tajne“
// NEBO uživatelské jméno je „student“ A heslo je „1234“.
// možnosti výstupu: "jsi přihlášen", "neexistující uživatel", "nesprávné heslo"

Console.WriteLine("\nZadej uživatelské jméno:");
string username = Console.ReadLine();

Console.WriteLine("Zadej heslo:");
string password = Console.ReadLine();

if (username == "admin")
{
    if (password == "tajne")
    {
        Console.WriteLine("Jsi přihlášen ✅");
    }
    else
    {
        Console.WriteLine("Nesprávné heslo ❌");
    }
}
else if (username == "student")
{
    if (password == "1234")
    {
        Console.WriteLine("Jsi přihlášen ✅");
    }
    else
    {
        Console.WriteLine("Nesprávné heslo ❌");
    }
}
else
{
    Console.WriteLine("Neexistující uživatel ❌");
}