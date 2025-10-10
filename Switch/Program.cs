// zadej a, b.
// pokud je a > b tak čísla vynásob a výsledek vypiš.
// pokud je rovno, sečti a výsledek vypiš.
// pokud a < b pak b vyděl pomocí a, výsledek vypiš.

/*
Console.WriteLine("Zadej cislo a:");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 0:
        Console.WriteLine("nula");
        
        break;
    case 1:
        Console.WriteLine("1");
        
        break;
    default:
        Console.WriteLine("jiné");
        
        break;
}
*/

// Zadej číslo měsíce, poté vypiš slovně název daného měsíce. ošetři pokud měsíc neexistuje.

/*
Console.WriteLine("zadej číslo měsíce:");
int mesicSwitch = Convert.ToInt32(Console.ReadLine());

switch (mesicSwitch)
{
    case 1:
        Console.WriteLine("leden");
        break;
    case 2:
        Console.WriteLine("únor");
        break;
    case 3:
        Console.WriteLine("březen");
        break;
    case 4:
        Console.WriteLine("duben");
        break;
    case 5:
        Console.WriteLine("květen");
        break;
    case 6:
        Console.WriteLine("červen");
        break;
    case 7:
        Console.WriteLine("cervenec");
        break;
    case 8:
        Console.WriteLine("srpen");
        break;
    case 9:
        Console.WriteLine("září");
        break;
    case 10:
        Console.WriteLine("říjen");
        break;
    case 11:
        Console.WriteLine("listopad");
        break;
    case 12:
        Console.WriteLine("prosinec");
        break;
    default:
        Console.WriteLine("nauč se měsíce");
        break;
}


switch (mesicSwitch)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("zima");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("jaro");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("léto");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("podzim");
        break;
    default:
        Console.WriteLine("nauč se měsíce");
        break;
}
*/

/*
 Kalkulačka
 zadej x, y
 zadej operaci (+, -, *, /, ^)
 vypiš výsledek
*/

using System.Globalization;

Console.WriteLine("x:");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("y:");
int y = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("znamenko:");
char znamenko = Convert.ToChar(Console.ReadLine());

switch (znamenko)
{
    case '+':
        Console.WriteLine(x + y);
        break;
    case '-':
        Console.WriteLine(x - y);
        break;
    case '*':
        Console.WriteLine(x * y);
        break;
    case '/':
        Console.WriteLine(x / y);
        break;
    case '^':
        Console.WriteLine(Math.Pow(x, y));
        break;
    default:
        Console.WriteLine("Neznám operace.");
        break;
}





















// Console.WriteLine("x:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y:");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("operace:");
// char znamenko = Convert.ToChar(Console.ReadLine());
//
// switch (znamenko)
// {
//     case '+':
//         Console.WriteLine(x+y);
//         break;
//     case '-':
//         Console.WriteLine(x - y);
//         break;
//     case '*':
//         Console.WriteLine(x * y);
//         break;
//     case '/':
//         Console.WriteLine(x / y);
//         break;
//     case '^':
//         Console.WriteLine(x ^ y);
//         break;
//     default:
//         Console.WriteLine("neznámá operace");
//         break;
// }


