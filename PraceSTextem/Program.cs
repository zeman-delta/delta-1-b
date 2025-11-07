// 1. zadám text 
// 2. je zadaný text palindrom?


string slovo = Console.ReadLine();
string pomoc = "";

for (int i = slovo.Length - 1; i >= 0; i--)
{
    pomoc += slovo[i];
}


if (slovo == pomoc)
{
    Console.WriteLine("palindrom");
}
else
{
    Console.WriteLine("není palindrom");
}

// ------------------------------------------

bool jePalindrom = true;

for (int i = 0; i < slovo.Length / 2; i++)
{
    if (slovo[i] != slovo[slovo.Length - 1 - i])
    {
        jePalindrom = false;
    }
}
if (jePalindrom)
{
    Console.WriteLine("palindrom");
}
else
{
    Console.WriteLine("není palindrom");
}

