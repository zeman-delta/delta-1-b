# Projekt: Správce Malé Knihovny

## 1. Část: Třída `Kniha`
Vytvoř třídu, která bude sloužit jako "šablona" pro jednu knihu.

### Požadavky:
- [ ] **Data (Vlastnosti/Atributy):**
    - `Nazev` (text - string)
    - `Autor` (text - string)
    - `RokVydani` (celé číslo - int)
- [ ] **Konstruktor:**
    - Přijímá 3 parametry (název, autor, rok) a uloží je do vlastností třídy.
- [ ] **Metoda `VypisInfo()`:**
    - Nevrací nic (`void`).
    - Vypíše do konzole informace o knize v hezkém formátu, např.:
      > `Harry Potter - J.K. Rowling (1997)`

---

## 2. Část: Třída `Knihovna`
Vytvoř třídu, která bude fungovat jako "manažer". Bude vlastnit pole knih a starat se o ně.

### Požadavky:
- [ ] **Data (Privátní):**
    - `_seznamKnih`: Pole typu `Kniha[]`.
    - `_pocetKnih`: Celé číslo (`int`), které si pamatuje, kolik knih je aktuálně v poli uloženo.
- [ ] **Konstruktor:**
    - Přijme číslo `kapacita` (jak velké má být pole).
    - Inicializuje pole `_seznamKnih` na tuto velikost.
    - Nastaví `_pocetKnih` na 0.
- [ ] **Metoda `PridatKnihu(Kniha novaKniha)`:**
    - Zkontroluje, zda je v poli ještě místo (porovná `_pocetKnih` a délku pole).
    - **Pokud je místo:**
        1. Vloží knihu na index `_pocetKnih`.
        2. Zvýší `_pocetKnih` o 1.
        3. Vypíše potvrzení ("Kniha přidána").
    - **Pokud není místo:**
        1. Vypíše chybovou hlášku ("Knihovna je plná").
- [ ] **Metoda `VypisVsechnyKnihy()`:**
    - Použije cyklus `for`.
    - Na každé uložené knize zavolá její metodu `VypisInfo()`.

---

## 3. Část: Hlavní program (`Program.cs`)
V metodě `Main` otestuj funkčnost svého kódu.

### Scénář testování:
1. [ ] Vytvoř instanci `Knihovna` s kapacitou **3** knihy.
2. [ ] Vytvoř **4** různé instance třídy `Kniha` (např. Hobit, 1984, Zaklínač, Duna).
3. [ ] Zavolej metodu `PridatKnihu` pro první 3 knihy.
4. [ ] Zavolej metodu `PridatKnihu` pro 4. knihu (měl by vypsat, že je plno).
5. [ ] Zavolej metodu `VypisVsechnyKnihy()` a zkontroluj, zda se vypsaly správně.

---
1. **Pozor na NullReferenceException:**
---

## Část 4: rozšíření funkčnosti

Pokud máš hotovo a vše funguje, zkus přidat do třídy `Knihovna`:

* **Metoda `NajdiKnihu(string nazev)`:** Projde uložené knihy a pokud najde shodu názvu, vypíše detaily. Pokud ne, vypíše "Nenalezeno".
* **Metoda `SmazatKnihovnu()`:** Vymaže všechny knihy z knihovny. 