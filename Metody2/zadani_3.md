## 3. Úroveň: Návratové hodnoty (Výstupy)
*⚠️ Pozor: Tyto metody nic nevypisují (žádný Console.WriteLine)! Místo toho vrací hodnotu pomocí `return`.*

- [ ] **1. Absolutní hodnota:**  
  `int ZiskejAbsolutniHodnotu(cislo)`  
  Vrátí absolutní hodnotu čísla.


- [ ] **2. Spojování jmen:**  
  `string VytvorCeleJmeno(jmeno, prijmeni)`  
  Vrátí řetězec ve formátu: *"Příjmení, Jméno"*.


- [ ] **3. Výpočet slevy:**  
  `double VypocitejCenuPoSleve(cena, slevaProcenta)`  
  Vrátí novou cenu zboží po slevě.


- [ ] **4. Kontrola plnoletosti:**  
  `bool JePlnolety(vek)`  
  Vrátí `true`, pokud je věk >= 18, jinak `false`.

---

### Oprava chyb:

- [ ] **1.**
```csharp
static int VypocitejObsahCtverce(int strana)
{
    int obsah = strana * strana;
    Console.WriteLine($"Obsah je {obsah}");
}

static void Main(string[] args)
{
    int vysledek = VypocitejObsahCtverce(5);
}
```


- [ ] **2.**
```csharp
static void Ukonceni(bool chyba)
{
    if (chyba)
    {
        Console.WriteLine("Chyba nastala, ukončuji...");
        return 0; 
    }
    
    Console.WriteLine("Ukončeno bez chyb.");
}
```