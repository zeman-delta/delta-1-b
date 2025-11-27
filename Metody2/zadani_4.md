## 4. Úroveň: Logické úlohy a komplexnější scénáře
*Kombinace podmínek, cyklů a návratových hodnot.*

- [ ] **1. Faktoriál:**  
  Metoda `long SpocitejFaktorial(int n)`  
  Vrátí faktoriál čísla n.


- [ ] **2. Kalkulačka:**  
  Metoda `double Vypocet(double a, double b, string operace)`.
  Operace: `"+"`, `"-"`, `"*"` nebo `"/"`  
  Metoda vrátí výsledek výpočtu.


- [ ] **3. Generátor hesla:**  
  Metoda `string GenerujHeslo(int delka)`  
  Vrátí náhodný řetězec znaků o zadané délce (využijte `Random`).


- [ ] **4. Den v týdnu:**  
  Metoda `string NazevDne(int cisloDne)`  
  Pro 1 vrátí "Pondělí" ... pro neplatné číslo vrátí "Chyba".

---

### Oprava chyb:

- [ ] **1.**
```csharp
static int ZjistiVetsi(int a, int b)
{
    if (a > b)
    {
        int vetsi = a;
    }
    else
    {
        int vetsi = b;
    }
    
    return vetsi;
}
```


- [ ] **2.**
```csharp
static int SpocitejFactorial(int limit)
{
    int soucin = 0; 

    for (int i = 0; i <= limit; i++)
    {
        soucin = soucin * i;
    }
    return soucin;
}

static void Main(string[] args)
{
    int x = SpocitejSoucin(5); 
}
```