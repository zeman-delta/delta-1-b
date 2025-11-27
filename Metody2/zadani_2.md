## 2. Úroveň: Práce s parametry (Vstupy)
*Tyto metody přijímají data zvenčí (parametry), zpracují je a vypíší výsledek do konzole.*

- [ ] **1. Opakovač textu:**  
   `OpakujZpravu(zprava, pocet)`.  
   Vypíše zadanou `zpravu` tolikrát, kolik udává `pocet`.  


- [ ] **2. Výpočet věku:**  
   `VypisVek(rokNarozeni)`  
   Přijme rok narození, spočítá aktuální věk (k roku 2025) a vypíše: *"Je ti přibližně X let."*
  - bonus: ne k roku 25 ale k aktuálnímu roku (ber rok dinamicky)


- [ ] **3. Převod měny:**  
   `PrevedNaEura(koruny)`  
   Přijme částku v CZK a vypíše hodnotu v EUR (kurz např. 25.0).  
   *Výstup: "X Kč je Y Eur."*


- [ ] **4. Porovnání čísel:**  
  `VypisVetsi(a, b)`  
  Porovná dvě čísla a vypíše to, které je větší.


- [ ] **5. Tankování:**  
   `Tankovani(typPaliva, mnozstvi, cena)`  
   *Výstup: "Natankováno [mnozstvi] litrů paliva [typPaliva]. Cena za litr je: [cena]. Celková cena: [...]."*

---

### Oprava chyb: 

- [ ] **1.**  
```csharp
static void VypisPozdrav(string jmeno)
{
    Console.WriteLine($"Ahoj {jmeno}!");
}

static void Main(string[] args)
{
    int vek = 30;
    VypisPozdrav(vek); 
}
```


- [ ] **2.**
```csharp
static void VypocitejSoucet(int a, int b)
{
    int soucet = a + b;
    Console.WriteLine($"Součet je: {soucet}");
}

static void Main(string[] args)
{
    VypocitejSoucet(10); 
}
```
