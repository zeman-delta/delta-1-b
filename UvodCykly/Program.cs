Random rnd = new Random();

// For
{
    // i++ == i = i + 1
    // i-- == i = i - 1
    
    for (int i = 0; i <= 30; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("konec");
    
    for (int i = 0; i < 10; i++)
    {
        int nahodneCislo = rnd.Next(1, 11);
        Console.WriteLine(nahodneCislo);
        Console.WriteLine(i);
        
        Console.WriteLine(i * nahodneCislo);
    
        Console.WriteLine("--------");
    }
}

// While
{
    int i = 0;
    Console.WriteLine(i);
    
    while (i != 0)
    {
        i = rnd.Next(-10, 11);
        Console.WriteLine(i);
    }
    
    
    while (true)
    {
        Console.WriteLine("input:");
        string vstup = Console.ReadLine();
        
        if (vstup == "exit")
        {
            break;
        }
    
        Console.WriteLine("Ahoj!");
    }


    int iterace = 0;
    
    while (true)
    {
        iterace++;
        
        int a = rnd.Next(-10, 11);
        int b = rnd.Next(-10, 11);
        
        if (a == b)
        {
            break;
        }
        
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine(a+b);
    }

    Console.WriteLine(iterace);


    while (true)
    {
        Console.WriteLine("zadej operaci: +, -, *, /, exit pro ukonceni");
        string vstup = Console.ReadLine();
        
        if (vstup == "exit")
        {
            break;
        }

        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("a: ");
        int b = Convert.ToInt32(Console.ReadLine());

        switch (vstup)
        {
            case "+":
                Console.Write("Addition: ");
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.Write("Subtraction: ");
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.Write("Multiplication: ");
                Console.WriteLine(a * b);
                break;
            case "/":
                Console.Write("Division: ");
                Console.WriteLine(a / b);
                break;
            default:
                Console.WriteLine("Invalid input: ");
                break;
        }
    }
    
}

// Do While
{
    int i = 0;
    Console.WriteLine(i);
    
    do
    {
        i = rnd.Next(-10, 11);
        Console.WriteLine(i);
    }
    while (i != 0);
}
