
### Sąlygos ```if/else```

1. Duoti du skaičiai a ir b. Parašykite programą, kuri nustatytų, ar šių skaičių skirtumas yra lygus -3.

```c#
int a = 1;
int b = 2;

if(a+b == 3)
{
    Console.WriteLine("Suma lygi 3.");
}
```

2. Parašykite programą, kuri išvestų į ekraną duotą skaičių x pakeltą kvadratu, jei jis didesnis už 5 arba padalintą iš 10, jei jis mažesnis už 5.

```c#
int skaicius = 6;

if(skaicius > 5)
{
    Console.WriteLine(skaicius * skaicius);
}
else if(skaicius < 5)
{
    Console.WriteLine(skaicius/10);
}
```

3. Duotas keturženklis skaičius x. Parašykite programą, kuri nustatytų jo pirmų dviejų skaitmenų sumą, pvz.: 1234 pirmų skaitmenų suma - 1 + 2 = 3.

```c#
int keturzenklis = 1234;
int pirmasSkaitmuo = keturzenklis / 1000;
int antrasSkaitmuo = (keturzenklis - pirmasSkaitmuo * 1000) / 100;

if(pirmasSkaitmuo + antrasSkaitmuo == 3)
{
    Console.WriteLine("Pirmus skaitmenu suma lygi 3.");
}
```

4. Parašykite programą, kuri nustatytų, ar tarp trijų duotųjų skaičių a, b, ir c yra neigiamų skaičių.

```c#
int a = 0;
int b = 2;
int c = -4;

if(a < 0 || b < 0 || c < 0)
{
    Console.WriteLine("Neigiamu skaiciu yra.");
}
```

5. Laurynas žino, kad mokytoja jam gali duoti spręsti vieną iš trijų kontrolinio darbo variantų. Atlikdamas užduotį jis gaus du skaičius a ir b, o jam reikės apskaičiuoti x reikšmę pagal vieną iš trijų formulių:
* Pirmas variantas: x = ab+3;
* Antras variantas: x = 2a+b;
* Trečias variantas: x = a-3b.
Parašykite programą, kuri padėtų Laurynui pasitikrinti, ar jis teisingai skaičiuoja x reikšmę spręsdamas kiekvieno varianto užduotį.

```c#
int a = 10;
int b = 5;
int variantoNr = 1;

switch (variantoNr)
{
    case 1:
        Console.WriteLine((a + b)*3);
        break;
    case 2: 
        Console.WriteLine(2*a + b);
        break;
    case 3: 
        Console.WriteLine(a - 3*b);
        break;
    default:
        Console.WriteLine("Tokio varianto nera.");
        break;
}
```

### ```while``` ciklas

1. Parašykite programą, kuri nuskaito skaičių x ir atspausdina, kiek rado lyginių skaičių intervale [1 ;x]



2. Parašykite programą, kuri nuskaito skaičių x ir atspausdina visus skaičius nuo x iki 1-o mažėjančia tvarka.


3. Nurodytas natūralusis skaičius n. Parašykite programą, nustatančią, ar jis lygus iš eilės einančių natūraliųjų skaičių (pradedant vienetu) sumai. Pvz.: jei n = 15, tai turi būti išvesta: TAIP. Jei n =12, tai turi būti išvesta: NE.



