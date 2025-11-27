## 5. Úroveň: Pole a Metody
*Práce s kolekcemi dat v metodách.*

- [ ] **1. Součet pole:**  
  `int SectiPole(int[] cisla)`  
  Vrátí součet všech prvků v poli.


- [ ] **2. Hledání textu:**  
  `bool ObsahujeSlovo(string[] slova, string hledane)`  
  Vrátí `true`, pokud pole obsahuje hledaný výraz.


- [ ] **3. Počet sudých:**  
  `int PocetSudychCisel(int[] cisla)`  
  Vrátí počet sudých čísel v poli.


- [ ] **4. Velká písmena:**  
  `void VypisVelkym(string[] slova)`  
  Vypíše každé slovo z pole velkými písmeny na nový řádek.

---

### Oprava chyb:

- [ ] **1.**
```csharp
static void VypisPole(int[] pole)
{
    for (int i = 0; i <= pole.Length; i++) 
    {
        Console.WriteLine(pole[i]);
    }
}

static void Main(string[] args)
{
    int[] cisla = { 10, 20 };
    VypisPole(cisla);
}
```