# Opakování dynamických kolekcí — projektové zadání

## Pravidla pro oba projekty

- Každá třída má **vlastní soubor** (např. `Polozka.cs`).
- Třídy musí mít **vlastnosti**, **konstruktor** a alespoň jednu **metodu**.
- V `Program.cs` musí být **interaktivní menu** v `while`-cyklu, ze kterého jdou všechny funkce vyzkoušet.
- Po každé akci program **vypíše stav** (např. obsah inventáře, frontu, počty).

---

## Téma A — RPG: Inventář hrdiny a aréna nepřátel

Vytvoříš jednoduchou textovou RPG hru. Hrdina prochází arénou, kde na něj v určitém pořadí útočí nepřátelé. Hrdina sbírá předměty, používá lektvary a může vrátit poslední provedenou akci.

### Třídy k vytvoření


| Třída    | Vlastnosti                                                                            | Použité kolekce       |
| ---------- | ------------------------------------------------------------------------------------- | ----------------------- |
| `Predmet`  | `Nazev`, `Typ` (zbraň/lektvar/poklad), `Hodnota`                                     | —                      |
| `Nepritel` | `Jmeno`, `Zivoty`, `Utok`                                                             | —                      |
| `Hrdina`   | `Jmeno`, `Zivoty`, `Inventar` (List), `Suroviny` (Dictionary), `HistorieAkci` (Stack) | List, Dictionary, Stack |
| `Hra`      | `Hrdina`, `Arena` (Queue<Nepritel>)                                                   | Queue                   |

### Použití jednotlivých kolekcí (povinné)

- **`List<Predmet> Inventar`** — předměty, které hrdina sebral. Funkce: přidat, vypsat, najít podle názvu, odstranit.
- **`Dictionary<string, int> Suroviny`** — počty surovin (`"zlato"`, `"šípy"`, `"lektvar"` …). Funkce: přičíst, ubrat, vypsat, zjistit počet.
- **`Stack<string> HistorieAkci`** — textový záznam posledních akcí (např. „Sebral meč", „Zaútočil na skřeta"). Funkce: `Push` po každé akci, `Pop` jako **Undo poslední akce** (vrátí jen text — popis efektu, nemusí stav reálně vracet zpět).
- **`Queue<Nepritel> Arena`** — nepřátelé čekající na souboj. Funkce: přidat na konec, vytáhnout dalšího (`Dequeue`), zobrazit pořadí.

### Povinné funkce v menu

1. Vypsat stav hrdiny (životy, suroviny, inventář).
2. Sebrat předmět (vloží do `List`).
3. Použít předmět z inventáře (např. lektvar → `+20` životů).
4. Přidat nepřítele do arény.
5. Souboj s prvním nepřítelem ve frontě (`Dequeue`).
6. Zobrazit pořadí nepřátel v aréně.
7. Vrátit poslední akci (`Stack.Pop` → vypiš).
8. Konec hry.

### Bonus

- **Náhodný souboj** s `Random` — útok hrdiny i nepřítele má rozptyl ±20 %.
- **Obchod** — utratit suroviny (`zlato`) za předmět; kontrola, jestli má hrdina dost.
- **Drop z nepřítele** — pridej do inventáře po souboji
- **Statistika boje** — `Dictionary<string, int>` „kolikrát jsi porazil druh nepřítele".

---

## Téma B — Kavárna: Objednávky a sklad

Vytvoříš systém pro správu kavárny. Hosté zadávají objednávky, ty se řadí do fronty, barista je postupně připravuje. Hotové objednávky lze v případě reklamace stornovat (vrátit poslední).

### Třídy k vytvoření


| Třída      | Vlastnosti                                                                 | Použité kolekce              |
| ------------ | -------------------------------------------------------------------------- | ------------------------------ |
| `Polozka`    | `Nazev`, `Cena`, `Kategorie` (káva/jídlo/dezert)                         | —                             |
| `Objednavka` | `Cislo`, `Stul`, `Polozky` (List)                                          | List                           |
| `Kavarna`    | `Menu` (List), `Cekajici` (Queue), `Hotove` (Stack), `Prodej` (Dictionary) | List, Queue, Stack, Dictionary |

### Použití jednotlivých kolekcí (povinné)

- **`List<Polozka> Menu`** — nabídka kavárny. Funkce: přidat, odstranit, vypsat podle kategorie, najít podle názvu.
- **`Queue<Objednavka> Cekajici`** — objednávky čekající na přípravu (FIFO). Funkce: přidat objednávku, připravit další (`Dequeue` → přesun do `Hotove`).
- **`Stack<Objednavka> Hotove`** — hotové objednávky. Funkce: `Pop` jako **storno poslední objednávky**, výpis.
- **`Dictionary<string, int> Prodej`** — kolik kusů každé položky se prodalo. Při dokončení objednávky se počty navýší.

### Povinné funkce v menu

1. Vypsat menu (případně podle kategorie).
2. Přidat novou položku do menu.
3. Vytvořit objednávku (zadat číslo stolu, vybírat položky z menu, dokud uživatel neukončí).
4. Zobrazit frontu čekajících objednávek.
5. Připravit další objednávku (`Queue.Dequeue` → `Stack.Push`, navýšit `Prodej`).
6. Stornovat poslední hotovou objednávku (`Stack.Pop`, snížit `Prodej`).
7. Vypsat statistiku prodeje (top 3 nejprodávanější).
8. Spočítat celkovou tržbu.
9. Konec.

### Bonus

- **Tržby podle stolů** — `Dictionary<int, decimal>` (klíč = číslo stolu, hodnota = útrata).
- **Sklad surovin** — `Dictionary<string, int>` (např. mléko, zrnková káva); při přípravě objednávky odečítej, hlas „nelze připravit", pokud nejsou suroviny.
- **Slevový kupón** — při zadání kódu sleva x % na celou objednávku.
