## První úloha
je zadáno pole naměřených hodnot
{59; 50; 32; 68; 86; 53.6; 64.4; 25.7; 92.3}  
pole představuje naměřené teploty v °F  
°C = (°F - 32) * 5/9

1. jaká je průměrná teplota ve °C
2. kolik je v poly nadprůměrných hodnot?
- vypiš počet
- vypiš konkrétní hodnoty a jejich indexy
3. najdi a vypiš 2. největší hodnotu v poli (+ index)
4. najdi a vypiš nejbližší hodnotu k průměru v poli (+ index)
```
double[] poleF = { 59, 50, 32, 68, 86, 53.6, 64, 4, 25.7, 92.3 };  
double[] poleC = new double[poleF.Length];
```
## Druhá úloha 
Je zadán libovolný text.
1. vypiš délku textu
2. vypiš prvních 5 znaků
3. vypiš posledních 5 znaků
4. zeptej se na libovolný znak a poté vypiš kolikrát se v textu nachází.
    * zkus napsat bod 4 tak, aby pokračoval dokud nezadím 'Q'

