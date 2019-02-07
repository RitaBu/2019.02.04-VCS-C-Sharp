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

```1
2 3
4 5 6
7 8 9 10```

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



```C#
```




```C#
```




```C#
```
