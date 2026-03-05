# Procvičování C#: Dvourozměrná pole (Základy)

## 1. Nulová matice a výpis
* Vytvořte 2D pole celých čísel (`int`) o velikosti 3x3.
* Pomocí dvou vnořených cyklů `for` ho celé naplňte hodnotou `0`.
* Vytvořte metodu (např. `VypisPole(int[,] pole)`), která pomocí dalších dvou cyklů `for` vypíše toto pole do konzole jako úhlednou tabulku. Tuto metodu pak budete používat i u dalších úloh.

---

## 2. Hlavní diagonála
* Vytvořte 2D pole o velikosti 4x4.
* Naplňte ho samými `0`, ale na **hlavní diagonálu** vložte hodnotu `1`.
* > **Nápověda:** Hlavní diagonála je tam, kde se index řádku rovná indexu sloupce (tedy pozice [0,0], [1,1], [2,2], [3,3]). Využijte k tomu podmínku `if` uvnitř cyklů.

---

## 3. Šachovnice
* Vytvořte 2D pole znaků (`char`) o velikosti 8x8.
* Naplňte jej střídavě znaky `'X'` a `'O'` tak, aby vytvořily vzor šachovnice.
* > **Nápověda k zamyšlení:** Zkuste sečíst index řádku a sloupce (např. `i + j`). Co mají společného políčka, kde má být `'X'` a kde `'O'`, když se podíváte na to, zda je tento součet sudý nebo lichý? (Využijte operátor modulo `%`).

---

## 4. Součet hodnot v řádcích
* Vytvořte 2D pole 3x4 (3 řádky, 4 sloupce) a rovnou do něj při vytvoření "natvrdo" zapište nějaká čísla (nebo ho naplňte náhodně).
* Projděte pole a **pro každý řádek zvlášť** spočítejte součet jeho čísel.
* Do konzole vypište výsledky ve formátu: *"Součet 0. řádku je: [výsledek]"*, *"Součet 1. řádku je: ..."* atd.

---

## 5. Hledání největšího prvku
* Vytvořte pole 5x5 a naplňte ho náhodnými čísly od 1 do 100.
* Pole vypište do konzole, abyste čísla viděli.
* Následně pole projděte a najděte **největší číslo**.
* Do konzole vypište nejen to, jaké je to číslo, ale i na jakých indexech (řádek a sloupec) se nachází.

---

## 6. Rámeček
* Vytvořte 2D pole o velikosti 6x6.
* Všechny prvky, které tvoří **okraj pole** (tedy nultý řádek, poslední řádek, nultý sloupec a poslední sloupec) nastavte na hodnotu `1`.
* Všechna čísla uvnitř (tedy "výplň") nastavte na `0`.
* Pole úhledně vypište do konzole.

---

## 7. Součet hodnot ve sloupcích
* Vytvořte 2D pole 4x3 (4 řádky, 3 sloupce) a naplňte ho libovolnými čísly.
* Projděte pole a **pro každý sloupec zvlášť** spočítejte součet jeho čísel.
* Do konzole vypište výsledky ve formátu: *"Součet 0. sloupce je: [výsledek]"* atd.
* > **Nápověda:** Na rozdíl od součtu řádků zde musí být **vnější cyklus přes sloupce** a vnitřní přes řádky. Rozmyslete si, který index v `pole[i, j]` říká řádek a který sloupec.

---

## 8. Transpozice matice
* Vytvořte čtvercové 2D pole o velikosti 4x4 a naplňte ho libovolnými čísly. Pole vypište.
* Vytvořte **nové** pole stejné velikosti a do něj uložte **transpozici** původního pole – tedy hodnota na pozici `[i, j]` v původním poli skončí na pozici `[j, i]` v novém poli.
* Transponované pole vypište a porovnejte s originálem.
* > **Nápověda:** Transponovat znamená „překlopit přes hlavní diagonálu". Řádky se stanou sloupci a sloupce řádky.

---

## 9. Sčítání dvou matic
* Vytvořte dvě 2D pole celých čísel stejné velikosti (např. 3x3) a naplňte je libovolnými čísly. Obě pole vypište.
* Vytvořte třetí pole stejné velikosti, do kterého uložíte **součet** obou matic – tedy na pozici `[i, j]` bude součet hodnot `a[i, j] + b[i, j]`.
* Výsledné pole vypište.
* > **Nápověda:** Budete potřebovat tři sady vnořených cyklů: jednu pro naplnění prvního pole, druhou pro druhé pole a třetí pro výpočet součtu.

---

## 10. Pascalův trojúhelník
* Vytvořte 2D pole `int` o velikosti 8x8 a inicializujte ho nulami.
* Naplňte ho tak, aby první sloupec každého řádku a diagonála (pozice `[i, i]`) byly `1`. Ostatní hodnoty spočítejte ze dvou prvků nad ním.
* Výsledek vypište – jako tabulku.

---

## 11. Sedlový bod
* Vytvořte pole 4x4 a naplňte ho náhodnými čísly od 1 do 50. Pole vypište.
* Hledejte **sedlový bod** – prvek, který je zároveň **nejmenší ve svém řádku** a **největší ve svém sloupci**.
* Pokud takový prvek existuje, vypište jeho hodnotu a souřadnice. Pokud ne, napište, že nebyl nalezen.

---

## 12. Rotace matice o 90° doprava
* Vytvořte čtvercové pole `N x N` (např. 4x4) s čísly od 1 do N². Pole vypište.
* Vytvořte **nové** pole stejné velikosti a naplňte ho tak, aby představovalo původní pole **otočené o 90° doprava**.
* Otočené pole vypište a porovnejte s originálem.

---

## 13. Spirálový výpis
* Vytvořte pole 5x5 a naplňte ho čísly od 1 do 25 po řádcích (tedy `[0,0]=1`, `[0,1]=2`, ..., `[4,4]=25`). Pole vypište.
* Vypište všechna čísla z pole **po spirále** – začněte v levém horním rohu, jděte doprava, pak dolů, pak doleva, pak nahoru, pak zase doprava atd., dokud nevypíšete všechny prvky.

---

## 14. Násobení matic
* Vytvořte matici `A` o velikosti 2x3 a matici `B` o velikosti 3x4. Obě naplňte libovolnými čísly a vypište je.
* Vypočítejte jejich **součin C = A × B**. Výsledná matice `C` bude mít velikost 2x4.
* > **Připomenutí:** Prvek `C[i, j]` se spočítá jako skalární součin `i`-tého řádku matice A a `j`-tého sloupce matice B: `C[i, j] = A[i,0]*B[0,j] + A[i,1]*B[1,j] + A[i,2]*B[2,j]`.