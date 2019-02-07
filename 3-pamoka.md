### ``for`` ciklas

1. Parašyti programą naudojant for ciklą, kuri prašo įvesti natūralųjį skaičių ir atspausdina visus žemesnius natūraliuosius skaičius mažėjančia tvarka.

```C#
Console.WriteLine("Iveskite skaiciu:");
int skaicius = int.Parse(Console.ReadLine());

for (int i = skaicius; i > 0; i--)
{
    Console.WriteLine(skaicius);
}
```

2. Parašyti programą naudojant for ciklą, kuri prašo įvesti skaičių ir atspausdina jo daugybos lentelę, pvz.:
```5*1=1, 5*2=10, … , 5*10 = 50```

```C#
Console.WriteLine("Iveskite skaiciu:");
int skaicius = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    string rezultatas = skaicius + " * " + i + " = " + skaicius * i;
    Console.WriteLine(rezultatas);
}
```
3. Parašyti programą naudojant for ciklą, kuri prašo įvesti piramidės aukštį ir atspausdina skaičių piramidę tokiu formatu:

```
1
2 3
4 5 6
7 8 9 10
```

```C#
Console.WriteLine("Iveskite piramides auksti:");
int aukstis = int.Parse(Console.ReadLine());

int isvedamasSk = 1;

for (int i = 1; i <= aukstis; i++)
{
   for (int j = 1; j <= i; j++)
    {
        Console.Write(isvedamasSk + " ");
        isvedamasSk++;
    }
    Console.WriteLine();
}
```

### Masyvai ir ciklai

1. Parašyti programą, kuri:
a. nuskaito iš Consolės 10 skaičių į masyvą ir jį atspausdina:

```C#
int[] manoMasyvas = new int[10];

for (int i = 0; i < manoMasyvas.Length; i++)
{
    Console.WriteLine("Iveskite skaiciu:");
    int skaicius = int.Parse(Console.ReadLine());

    manoMasyvas[i] = skaicius;
}

for (int i = 0; i < manoMasyvas.Length; i++)
{
    Console.WriteLine(manoMasyvas[i]);
}
```
b. atspausdina kas antrą masyvo elementą:

```C#
for (int i = 0; i < manoMasyvas.Length; i = i + 2)
{
    Console.WriteLine(manoMasyvas[i]);
}
```

c. Atspausdina tik tuos skaičius, kurie yra teigiami ir mažesni už 10:

```C#
for (int i = 0; i < manoMasyvas.Length; i++)
{
    if(manoMasyvas[i] < 10)
    {
        Console.WriteLine(manoMasyvas[i]);
    }
}
```

d. Suskaičiuoja visų elementų sumą ir ją atspausdina:

```c#
int suma = 0;

for (int i = 0; i < manoMasyvas.Length; i++)
{
    suma = suma + manoMasyvas[i];
}

Console.WriteLine("Masyvo skaiciu suma yra: " + suma);
```

2. Parašyti programą, kuri prašo įvesti masyvo dydį ir tada nuskaito n elementų į masyvą ir atspausdina jį atvirkščiai.

```c#
Console.WriteLine("Iveskite masyvo dydi:");
int masyvoDydis = int.Parse(Console.ReadLine());

int[] manoMasyvas = new int[masyvoDydis];

for (int i = 0; i < manoMasyvas.Length; i++)
{
    Console.WriteLine("Iveskite skaiciu:");
    int skaicius = int.Parse(Console.ReadLine());

    manoMasyvas[i] = skaicius;
}

for (int i = manoMasyvas.Length - 1; i >= 0; i--)
{
    Console.WriteLine(manoMasyvas[i]);
}
```

3. Apibrėžti ir priskirti reikšmes dvimačiam bool masyvui, kuris turi 4 eilutes ir 7 stulpelius ir atspausdinti jį ekrane. (Jei elemento reikšmė true - tai *, jei false, tai -).

```
---*---
--*-*--
-*-*-*-
*-*-*-*
```
```c#
bool[,] manoMasyvas = new bool[4, 7] 
{
    { false, false, false, true, false, false, false },
    { false, false, true, false, true, false, false },
    { false, true, false, true, false, true, false },
    { true, false, true, false, true, false, true}
};

for (int i = 0; i < 4; i++){
    for (int j = 0; j < 7; j++)
    {
        Console.Write($"{(manoMasyvas[i,j] ? "*": "-")}");
    }
    Console.WriteLine();
}

Console.ReadLine();
```

