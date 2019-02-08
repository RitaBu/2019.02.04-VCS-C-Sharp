### ```if``` sąlygos

1. Duoti du skaičiai a ir b. Parašykite programą, kuri nustatytų, ar šių skaičių suma yra lygi 5.

```c#
int a = 2;
int b = 3;

if(a + b == 5)
{
    Console.WriteLine("Suma lygi 5.");
}
```

2. Duotas skaičius a. Parašykite programą, kuri nustatytų, ar šis skaičius dalijasi iš 3 be liekanos.

```c#
int sk = 6;

if(sk % 3 == 0)
{
    Console.WriteLine("Skaicius dalinasi is 3-ju.");
}
```

3. Parašykite programą, kuri išvestų į ekraną duotą skaičių x padidintą 2 kartus, jei jis didesnis už 10.

```c#
int x = 15;

if(x > 10)
{
    Console.WriteLine(x*2);
}
```

4. Parašykite programą, kuri nustatytų, ar terminale įvestas skaičius yra teigiamas, neigiamas ar nulinis.

```c#
Console.WriteLine("Iveskite skaicius:");
int sk = int.Parse(Console.ReadLine());

if(sk > 0)
{
    Console.WriteLine("Skaicius yra teigiamas.");
}
else if(sk < 0)
{
    Console.WriteLine("Skaicius yra neigiamas.");
}
else
{
    Console.WriteLine("Skaicius yra lygus 0.");
}
```

5. Duotas keturženklis skaičius x. Parašykite programą, kuri nustatytų, ar šio skaičiaus pirmasis skaitmuo yra lyginis skaičius.

```c#
int keturzenklis = 1234;

//cia dalinant kompiuteris numeta liekana, nes operuojame sveikais skaiciais
//tada mus ir lieka pirmas skaitmuo - kuris nusako, kiek tukstanciu yra skaiciuje
int pirmasSkaitmuo = keturzenklis / 1000; 

if(pirmasSkaitmuo % 2 == 0)
{
    Console.WriteLine("Pirmas skaitmuo yra lyginis.");
}
else 
{
    Console.WriteLine("Pirmas skaitmuo yra nelyginis.");
}
```

6. Pirmosios olimpinės ţaidynės įvyko 1896 metais ir toliau organizuojamos kas ketveri metai. Jei žaidynės neįvyksta, tie metai vis tiek laikomi olimpiniais, o žaidynėms skiriamas eilės numeris. Parašykite programą, kuri surastų m-tųjų metų olimpinių žaidynių numerį n. Jei metai neolimpiniai, turi būti spausdinama „Metai neolimpiniai“. ‘

```c#

```

### ```while``` ciklai

1. Parašykite programą, kuri suskaičiuotų, kiek skaitmenų turi duotas skaičius a.

```c#
```

2. Martynas labai mėgsta saldainius. Mamos slėptuvėje jis rado m saldainių. Pirmą dieną jis suvalgė 1 saldainį, antrąją – 2, trečiąją – 3. Kiekvieną kitą dieną jis suvalgydavo vienu saldainiu daugiau negu prieš tai buvusią dieną. Per kelias dienas d Martynas suvalgys visus saldainius? Paskutinei dienai gali likti mažiau saldainių. 
Pvz.: Kai m = 11, turėtumėte gauti d = 5.

```c#
```

3. Parašykite programą klaviatūra renkamos skaičių sekos aritmetiniam vidurkiui rasti. Sekos pabaigos požymis – nulis. 
Pvz.: Jei seka yra 2, -6, 5, 9, -1, tai jos aritmetinis vidurkis yra 1.8.

```c#
```

4. Parašykite programą klaviatūra renkamai teigiamų skaičių sekai analizuoti: suskaičiuokite, kiek yra šioje sekoje lyginių ir nelyginių skaičių. Sekos pabaigos požymis – nulis. 
Pvz.: Jei seka yra 2, 6, 5, 9, 1, 7, tai sekoje yra 2 lyginiai skaičiai ir 4 nelyginiai skaičiai.

```c#
int lyginiuSk = 0;
int nelyginiuSk = 0;


while ((lyginiuSk + nelyginiuSk) < 6)
{
    Console.WriteLine("Iveskite skaiciu:");
    int sk = int.Parse(Console.ReadLine());


    bool rez = sk % 2 == 0;

    if(sk % 2 == 0)
    {
        lyginiuSk++;
    }
    else 
    {
        nelyginiuSk++;
    }
}

Console.WriteLine("Lyginiu sk: " + lyginiuSk);
Console.WriteLine("Nelyginiu sk: " + nelyginiuSk);
```



