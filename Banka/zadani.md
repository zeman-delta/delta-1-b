# Projekt: Banka

## 1. Část: Třída `BankovniUcet`
Tato třída reprezentuje jeden účet.

### Požadavky:
- [ ] **Data (Fields / Proměnné):**
  - `CisloUctu` (text - string): **public**.
    * *Důvod:* Nebudeme kontrolovat formát, prostě ho tam uložíme a kdykoliv přečteme.
  - `Vlastnik` (text - string): **public**.
    * *Důvod:* Jméno můžeme číst i měnit bez omezení.
  - `_zustatek` (desetinné číslo - decimal): **private**.
    * *Důvod:* Zde je nutná logika (nesmí jít do mínusu bez kontroly), proto musí být skrytý.
  - `_pin` (celé číslo - int): **private**.
    * *Důvod:* Toto číslo musí být skrytý, protože je důležité pro bezpečnost.

- [ ] **Konstruktor:**
  - Přijímá 3 parametry (`cisloUctu`, `vlastnik`, `pin`).
  - Uloží je přímo do veřejných proměnných `CisloUctu` a `Vlastnik`.
  - `_zustatek` nastaví na 0.
  - `_pin` nastaví na `pin`.
- [ ] **Metoda `Vlozit(decimal castka)`:**
  - Pokud `castka > 0`, přičte ji k `_zustatek`.
  - Jinak vypíše chybu.
- [ ] **Metoda `Vybrat(decimal castka)`:**
  - Pokud je `castka > 0` A ZÁROVEŇ `_zustatek >= castka`, odečte peníze.
  - Jinak vypíše chybu.
- [ ] **Metoda `GetZustatek(int pin)`:**
  - Protože je `_zustatek` private, nemůžeš ho zvenčí (z Program.cs nebo z Banky) přečíst.
  - Vytvoř metodu `public decimal GetZustatek()`, která jen vrátí hodnotu `_zustatek`.
  - pokud je `pin` shodný s `_pin`, vrátí `_zustatek`.
  - Jinak vypíše chybu.
- [ ] **Metoda `VypisInfo()`:**
  - Vypíše všechna data do konzole.

---

## 2. Část: Třída `Banka`
Třída, která spravuje pole účtů.

### Požadavky:
- [ ] **Data (Fields / Proměnné):**
  - `_seznamUctu` (pole BankovniUcet[]): **private**.
    * *Důvod:* Pole má pevnou délku a my musíme hlídat, na jaký index zapisujeme. Kdyby bylo public, někdo by mohl pole přepsat nebo smazat data.
  - `_pocetUctu` (int): **private**.
    * *Důvod:* Toto číslo musí přesně odpovídat počtu uložených účtů. Musíme ho zvyšovat jen my uvnitř třídy.
- [ ] **Konstruktor:**
  - Přijme kapacitu a inicializuje pole `_seznamUctu`.
- [ ] **Metoda `ZalozitUcet(BankovniUcet novyUcet)`:**
  - Pokud je `_pocetUctu` menší než délka pole:
    1. Uloží `novyUcet` do pole na index `_pocetUctu`.
    2. Zvýší `_pocetUctu` o 1.
  - Jinak vypíše "Banka je plná".
- [ ] **Metoda `CelkovyKapital()`:**
  - Vypíše součet peněz na všech účtech.

---

## 3. Část: Hlavní program (`Program.cs`)

### Scénář testování:
1. [ ] Vytvoř instanci `Banka` (kapacita 3).
2. [ ] Vytvoř instanci `BankovniUcet` (např. `ucet1`).
3. [ ] **Práce s public fields:**
  - Zkus změnit jméno vlastníka přímo: `ucet1.Vlastnik = "Karel";` (Mělo by to fungovat).
  - Zkus vypsat číslo účtu: `Console.WriteLine(ucet1.CisloUctu);` (Mělo by to fungovat).
4. [ ] **Práce s private fields:**
  - Zkus napsat `ucet1._zustatek = 1000;` -> **Tohle musí podtrhnout červeně (chyba), tak je to správně.**
  - Použij metodu: `ucet1.Vlozit(1000);`.
5. [ ] Vlož účet do banky a zavolej výpis kapitálu.

---

## Část 4: Rozšíření funkčnosti (Výzva)

* **Metoda `NajdiUcet(string cisloUctu)`:**
  - Procházíš pole účtů.
  - Porovnáváš hledaný string s `_seznamUctu[i].CisloUctu` (zde přistupuješ k public fieldu uvnitř objektu v poli).
  - Vrátí nalezený účet nebo `null`.

* **Metoda `Prevod(...)`:**
  - Stejný princip. Najdeš dva účty.
  - Z jednoho zavoláš `.Vybrat()`, na druhém `.Vlozit()`.

* **Metoda `NajdiNejbohatsiho()` (Třída Banka):**
  - zeptej se jak přetížit metodu get zustatek.
  - Projde všechny účty v bance.
  - Najde ten, který má nejvyšší zůstatek (budeš si muset pamatovat `pomocnyUcet` a `maxZustatek`).
  - Na konci vypíše jméno vlastníka a kolik má peněz.

* **Metoda `SmazatUcet(string cisloUctu)` (Třída Banka):**
  - *Toto je těžká úloha na procvičení logiky polí.*
  - Najde index účtu, který chceme smazat.
  - Pokud ho najde, musíš "zalepit díru" v poli. To znamená:
    1. Všechny účty, které jsou v poli *za* smazaným účtem, musíš posunout o jedno místo doleva (na nižší index).
    2. Snížíš `_pocetUctu`.
    3. Poslední místo v poli (kde je teď duplikát) vyčistíš (nastavíš na `null`).

* **Rozšíření: Historie transakcí (Třída BankovniUcet):**
  - Přidej do třídy `BankovniUcet` nové soukromé pole: `private string[] _historie`.
  - V konstruktoru ho inicializuj na velikost 5.
  - Přidej soukromé počítadlo `private int _pocetTransakci`.
  - Uprav metody `Vlozit` a `Vybrat`:
    - Pokaždé, když transakce proběhne úspěšně, ulož textový záznam (např. "+500") do pole `_historie`.
    - Jednodušší varianta: Pokud je historie plná, buď nejstarší záznam přepiš, nebo prostě další nezapisuj.
    - Pokročilejší varianta: Pokud je historie plná, posun všechny záznamy o jedno místo doleva a vlož nový na konec.
  - Vytvoř metodu `VypisHistorii()`, která vypíše posledních 5 akcí.

* **Metoda `StrhnoutPoplatek(decimal castka)` (Třída Banka i BankovniUcet):**
  - Nejprve přidej metodu do `BankovniUcet`: `StahnoutPoplatek(decimal kolik)`, která natvrdo odečte peníze (i do mínusu - banka si své peníze vždy vezme!).
  - Poté přidej metodu do `Banka`: `StrhnoutPoplatekUcetnictvi(decimal kolik)`.
  - Tato metoda v Bance projde všechny klienty a každému strhne poplatek za vedení účtu.