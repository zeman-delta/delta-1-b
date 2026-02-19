# Projekt: Banka - Rozšíření (Objekty a Karty)

## 1. Část: Třída `Osoba`
Tato třída reprezentuje klienta banky (majitele účtu).

### Požadavky:
- [ ] **Data (Fields / Proměnné):**
  - `Jmeno` (text - string): **public**.
  - `Prijmeni` (text - string): **public**.
  - `RokNarozeni` (celé číslo - int): **public**.
  - `_seznamUctu` (pole BankovniUcet[]): **private**.
    * *Důvod:* Jedna osoba může mít více účtů.
- [ ] **Metoda `VypisInfo()`:**
  - Vypíše jméno, příjmení a rok narození.
- [ ] **Metoda `PridatUcet(BankovniUcet ucet)`:**
  - Přidá účet do seznamu účtů osoby.

---

## 2. Část: Úprava třídy `BankovniUcet`
Úprava existující třídy, aby byla propojena s třídou `Osoba`.

### Požadavky:
- [ ] **Změna vlastníka:**
  - Původní `string Vlastnik` změň na `Osoba Vlastnik`.
  - Vlastník se přiřadí v **konstruktoru** a nepůjde už změnit (read-only).

---

## 3. Část: Třída `PlatebniKarta`
Třída reprezentující platební kartu k účtu.

### Požadavky:
- [ ] **Data (Fields / Proměnné):**
  - `Cislo` (text - string): **public**.
  - `CVV` (celé číslo - int): **public**.
  - `DatumPlatnosti` (text nebo datum): **public**.
  - `_ucet` (BankovniUcet): **private**.
    * *Důvod:* Karta musí vědět, ze kterého účtu čerpat peníze.
  - `_majitel` (Osoba): **private**.
    * *Důvod:* Karta patří konkrétní osobě.

---

## 4. Část: Úprava třídy `Banka`
Banka nyní eviduje i vydané karty.

### Požadavky:
- [ ] **Data:**
  - `_seznamKaret` (pole PlatebniKarta[]): **private**.
    * *Důvod:* Banka musí mít přehled o všech vydaných kartách.

---

## 5. Část: Hlavní program (`Program.cs`)

### Požadavky:
- [ ] **Metoda `PlatbaKartou(...)`:**
  - **Parametry:**
    - `BankovniUcet cilovyUcet` (kam peníze přijdou).
    - `decimal castka` (kolik platíme).
    - `string cisloKarty` (číslo karty, kterou platíme).
  - **Logika uvnitř metody:**
    1. Zeptá se uživatele na **CVV** a **Datum platnosti** (vstup z konzole).
    2. Najde kartu podle `cisloKarty` (bude potřeba přístup k seznamu karet v Bance).
    3. Pokud se zadané údaje shodují s údaji na kartě (a zároveň platí i další potřebné předpoklady) provedeme převod peněz.
    4. Jinak vypíše odpovídající chybu.