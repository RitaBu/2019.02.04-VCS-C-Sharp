### ```for``` ciklas

1. Parašykite programą, kuri išvestų į ekraną 5 kartus tą patį žodį.

```c#
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Labas");
}
```

2. Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki 100.

```c#
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
```

3. Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki įvesto skaičiaus x.

```c#
Console.WriteLine("Iveskite skaiciu:");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    Console.WriteLine(i);
}
```

4. Parašykite programą, kuri išveda į ekraną skaičius nuo įvesto skaičiaus x iki x+10.

```c#
Console.WriteLine("Iveskite skaiciu:");
int x = int.Parse(Console.ReadLine());

for (int i = x; i <= x + 10; i++)
{
    Console.WriteLine(i);
}
```

5. Parašykite programą, kuri išvestų skaičius nuo m iki n.

```c#
Console.WriteLine("Iveskite skaiciu m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu n:");
int n = int.Parse(Console.ReadLine());

for (int i = m; i <= n; i++)
{
    Console.WriteLine(i);
}
```

6. Parašykite programą, kuri suskaičiuotų skaičių nuo m iki n sumą 
```s = m + (m+1) +... + n```
Pvz.: kai m = 5, n = 10, tai s = 45.

```c#
Console.WriteLine("Iveskite skaiciu m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu n:");
int n = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = m; i <= n; i++)
{
    suma += i;
}

Console.WriteLine("Skaiciu nuo m iki n suma yra " + suma);
```

7. Parašykite programą, kuri suskaičiuotų skaičiaus n faktorialą 
```s= 1 * 2 *... * n.```

```c#
Console.WriteLine("Iveskite skaiciu:");
int n = int.Parse(Console.ReadLine());

int faktorialas = 0;

for (int i = 1; i <= n; i++)
{
    faktorialas *= i;
}

Console.WriteLine("Faktorialas: " + faktorialas);
```

8. Parašykite programą, kuri suskaičiuotų, kiek yra triženklių skaičių, besidalinančių iš keturių ir išvestų juos į ekraną.

```c#
var besidalinanciuIs4Sk = 0;

for (int i = 100; i <= 999; i++)
{
    if(i % 4 == 0)
    {
        besidalinanciuIs4Sk++;
    }
}

Console.WriteLine("Trizenkliu skaiciu, nesidalinanciu is keturiu yra: " + besidalinanciuIs4Sk);
```

9. Parašykite programą, kuri:
* paprašytų įvesti 5 skaičius naudojantis ciklu;
* Suskaičiuotų skaičių sumą;
* Suskaičiuotų skaičių  aritmetinį vidurkį;
* Surastų, kiek buvo neigiamų skaičių ir kiek teigiamų.

```c#
int[] skaiciai = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iveskite skaiciu:");
    int skaicius = int.Parse(Console.ReadLine());
    skaiciai[i] = skaicius;
}

double suma = 0;
int teigiamuSk = 0;
int neigiamuSk = 0;

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] > 0)
    {
        teigiamuSk++;
    }
    else if(skaiciai[i] < 0)
    {
        neigiamuSk++;
    }
    suma += skaiciai[i];
}

double vidurkis = suma / skaiciai.Length;

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Vidurkis: " + vidurkis);
Console.WriteLine("Teigiamu skaiciu: " + teigiamuSk);
Console.WriteLine("Neigiamu skaiciu: " + neigiamuSk);
```

10. Klaviatūra renkama skaičių seka (kaip 5-oje užduotyje). Jos ilgis nurodomas skaičiumi n. Parašykite programą, didžiausiam ir mažiausiam sekos skaičiui išrinkti.

```c#
Console.WriteLine("Iveskite, kiek bus skaiciu:");
int n = int.Parse(Console.ReadLine());

int[] skaiciai = new int[n];

for (int i = 0; i < skaiciai.Length; i++)
{
    Console.WriteLine("Iveskite skaiciu:");
    int skaicius = int.Parse(Console.ReadLine());
    skaiciai[i] = skaicius;
}

double min = int.MaxValue;
double max = int.MinValue;

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] > max)
    {
        max = skaiciai[i];
    }
    if(skaiciai[i] < min)
    {
        min = skaiciai[i];
    }
}

Console.WriteLine("maziausias: " + min);
Console.WriteLine("didziausias: " + max);
```

11. Architektas suprojektavo salę, kurioje bus n eilių. Pirmoje eilėje stovės k kėdžių, o kiekvienoje kitoje – 2 kėdėmis daugiau, negu prieš tai buvusioje. Parašykite programą, kuri apskaičiuotų, kiek iš viso kėdžių s reikia užsakyti, kad architekto sumanymas būtų įgyvendintas.
Pvz., kai n = 3, o k = 8, turi būti išvesta: Reikia užsakyti s = 30 kėdžių.


```c#

```

12. Keliamieji metai turi 366 dienas, paprastieji – 365.  Jeigu metai nėra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 4; Jeigu metai yra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 400 (pvz., 2000 ir 2400 metai yra keliamieji, o 2100, 2200, 2300 metai – ne keliamieji). Parašykite programą, kuri ekrane parodytų keliamuosius metus laikotarpio, kuris prasideda m-aisiais, o baigiasi n-aisiais metais. 
Pvz., kai m = 1898, o n = 1910, tai turi būti išvesta: Keliamieji metai yra 1904, 1908.

```c#
```

### ```array``` / masyvas

1. Deklaruokite sveikų skaičių masyvą kuriame bus 10 skaičių. Įdėkite į masyvą skaičius, šitaip masyvas[0] = 10; 

```c#
int[] skaiciai = new int[10];
skaiciai[0] = 1;
skaiciai[1] = 10;
skaiciai[2] = 19;
skaiciai[3] = 78;
skaiciai[4] = 1;
skaiciai[5] = 16;
skaiciai[6] = 14;
skaiciai[7] = 3;
skaiciai[8] = 12;
skaiciai[9] = 9;
```

2. Deklaruokite tekstų masyvą, kuriame bus 5 tekstai (string). Deklaruojant iš karto ir nurodykite šių tekstų reikšmes (tarp riestinių skliaustų).

```c#
string[] tekstai = { "vienas", "du", "trys", "keturi", "penki" };
```

3. Atspausdinkite kiekvieną tekstų masyvo elementą naudojantis for ciklu.

```c#
for (int i = 0; i < tekstai.Length; i++)
{
    Console.WriteLine(tekstai[i]);
}
```

4. Atspausdinkite kiekvieną skaičių masyvo elementą pakeltą kvadratų, t.y. Jei masyve turite skaičius 1, 2 , 3 ir t.t., tai atspausdini turite 1, 4, 9 ir t.t.

```c#
for (int i = 0; i < skaiciai.Length; i++)
{
    Console.WriteLine(skaiciai[i]*skaiciai[i]);
}
```

5. Lietuvos hidrometeorologijos tarnyba kaupia įvairiose Lietuvos vietovėse vasarą iškritusių kritulių stebėjimo duomenis. 
Parenkite programą, kuri pateiktų informaciją apie lietingas dienas:
* Kiek mm iškrito kiekvieną iš dienų;
* Kiek mm kritulių iškrito iš viso;
* Kiek dienų nelijo;
* Kiek mm kritulių vidutiniškai iškrito tomis dienomis, kai lijo.;
Duomenys: ```10, 20, 0, 0, 0, 45, 25, 30, 50, 25```

```c#
```

6. Duoti klasės mokinių ūgiai centimetrais, merginų ūgiai - teigiami, o vaikinų - neigiami.
Parašykite tokią programą, kuri remdamasi duotais duomenimis:
* Paskaičiuotų klasės mokinių ūgių vidurkį
* Paskaičiuotų merginų ugių vidurkį
* Paskaičiuotų vaikinų ūgių vidurkį
* Išvestų pranešimą, ar galima sudaryti iš klasės merginų ir vaikinų krepšinio komandas. Reikalavimai krepšinio komandai: ūgis ne mažesnis nei 175cm, komandoje turi būti 7 žaidėjai (5 pagrindiniai ir 2 atsarginiai).

Duomenys: ```-178, 175, -186, 172, 173, 175, -185, -180, -169, 165, 176, 172, -180, 176, -190, 176, -174, 177, -172, 178```





