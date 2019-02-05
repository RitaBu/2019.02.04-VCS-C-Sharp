
## Sąlygos

1. Parašyti programą, kuri prašo įvesti 3 skaičius ir nustato didžiausią iš jų.

```c#
Console.WriteLine("Iveskite pirma skaiciu:");
var skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite antra skaiciu:");
var skaicius2 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite trecia skaiciu:");
var skaicius3 = int.Parse(Console.ReadLine());

if(skaicius1 > skaicius2 && skaicius1 > skaicius3)
{
  Console.WriteLine($"{skaicius1} yra didziausias.");
}
else if(skaicius2 > skaicius1 && skaicius2 > skaicius3)
{
  Console.WriteLine($"{skaicius2} yra didziausias.");
}
else 
{
  Console.WriteLine($"{skaicius3} yra didziausias.");
}

Console.ReadLine();
```

2. Parašyti programą, kuri nuskaito įvestą skaičių ir patikrina ar jis yra lyginis ar nelyginis.

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

var lyginis = skaicius % 2 == 0;

if(lyginis)
{
    Console.WriteLine("Skaicius yra lyginis.");
}
else 
{
    Console.WriteLine("Skaicius yra nelyginis.");
}
```
galima ir šitaip, išnaudojant [trinarį operatorių](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator):

```c#
Console.WriteLine("Iveskite naturaluji skaiciu: ");
int skaicius = int.Parse(Console.ReadLine());

Console.WriteLine("Skaicius yra " + (skaicius % 2 == 0 ? "lyginis" : "nelyginis"));

Console.ReadLine();
```

3. Parašyti programą, kuri:
* paprašo vartotojo įvesti du skaičius - x ir y koordinates
* Nuskaito šias koordinates ir išsisaugo kintamuosiuose
* Tuomet pagal gautas koordinates turi išvesti, kuriame koordinačių sistemos ketvirtyje tos koordinatės yra.

```c#
Console.WriteLine("Iveskite x:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite y:");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Pirmas kvadrantas.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Antras kvadrantas.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Trecias kvadrantas.");
}
else
{
    Console.WriteLine("Ketvirtas kvadrantas");
}
```

4. Parašyti programą, kuri paprašo įvesti savo amžių ir pagal jį grąžina kino teatro bilieto kainą. 
Jei amžius yra mažesnis arba lygus 10 arba yra didesnis už 65, tai turi pranešti vartotojui, kad bilietas kainuos 5 eurus.
Kitu atveju, turi pranešti, kad bilietas kainuos 10 eurų.

```c#
Console.WriteLine("Iveskite amziu:");
int amzius = int.Parse(Console.ReadLine());

if(amzius <= 10 || amzius > 65)
{
    Console.WriteLine("Bilieto kaina - 5 eurai");
}
else
{
    Console.WriteLine("Bilieto kaina - 10 euru");
}
```

5. Parašyti programą, kuri prašo įvesti mokinio pažymį ir ekrane išspausdina jo apibūdinimą. (10 – puiku, 9-8 – labai gerai, 7-6- gerai, 5 - vidutiniškai, 4 – bent teigiamas, 3-2-1 – labai blogai)

```c#
Console.WriteLine("Iveskite vaiko pazymi:");
var pazymys = int.Parse(Console.ReadLine());

switch(pazymys) 
{
  case 10:
    Console.WriteLine("Puiku!");
    break;
  case 9:
  case 8:
    Console.WriteLine("Laba gerai");
    break;
  case 7:
  case 6:
    Console.WriteLine("Gerai");
    break;
  case 5:
    Console.WriteLine("Vidutiniškai");
    break;
  case 4:
    Console.WriteLine("Teigiamas");
    break;
  case 3: case 2: case 1: //kad uzimtu maziau vietos, galime case surasyt i viena eilute sitaip
    Console.WriteLine("Labai blogai!");
    break;
  default:
    Console.WriteLine("Tokio pazymio nera vertinimo sistemoje.");
    break;
}

Console.ReadLine();
```

6. Parašyti programą, kuri nuskaito savaitės dienos numerį ir atspausdina jos žodinį pavadinimą ekrane.

```c#
Console.WriteLine("Iveskite savaites dienos numeri: ");
int savDienosNr = int.Parse(Console.ReadLine());

switch(savDienosNr){
    case 1:
        Console.WriteLine("Pirmadienis");
        break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Treciadienis");
        break;
    case 4:
        Console.WriteLine("Ketvirtadienis");
        break;
    case 5:
        Console.WriteLine("Penktadienis");
        break;
    case 6:
        Console.WriteLine("Sestadienis");
        break;
    case 7:
        Console.WriteLine("Sekmadienis");
        break;
    default:
        Console.WriteLine("Savaiteje yra tik septynios dienos!!!");
        break;
}

Console.ReadLine();
```

7. Parašyti programą kalkuliatorių, kuri nuskaito 2 skaičius, nuskaito matematinį veiksmą, atlieka veiksmą ir atspausdina rezultatą ekrane tokiu formatu:
```c# 
{pirmas skaicius} {matematinis veiksmas} {antras skaičius} = {rezultatas}
```

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

switch(operacija){
    case "+":
        Console.WriteLine(skaicius1 + " + " + skaicius2 + " = " + (skaicius1 + skaicius2));
        break;
    case "-":
        Console.WriteLine(skaicius1 + " - " + skaicius2 + " = " + (skaicius1 + skaicius2));
        break;
    case "*":
        Console.WriteLine(skaicius1 + " * " + skaicius2 + " = " + (skaicius1 + skaicius2));
        break;
    case "/":
        Console.WriteLine(skaicius1 + " / " + skaicius2 + " = " + (skaicius1 + skaicius2));
        break;
    case "%":
        Console.WriteLine(skaicius1 + " % " + skaicius2 + " = " + (skaicius1 + skaicius2));
        break;
    case "^":
        Console.WriteLine(skaicius1 + " ^ " + skaicius2 + " = " + Math.Pow(skaicius1, skaicius2));
        break;
    default:
        Console.WriteLine("Nesuprantu tokios operacijos.");
        break;
}

Console.ReadLine();
```

galima ir taip, bet VS turėtų siūlyti paversti į `switch`:

```c# 
Console.WriteLine("Iveskite pirma skaiciu: ");
int skaicius1 = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite operacija:");
string operacija = Console.ReadLine();

Console.WriteLine("Iveskite antra skaiciu:");
int skaicius2 = int.Parse(Console.ReadLine());

double rezultatas = 0;

if(operacija == "+") 
{
    rezultatas = skaicius1 + skaicius2;
}
else if(operacija == "-") 
{
    rezultatas = skaicius1 - skaicius2;
}
else if (operacija == "*")
{
    rezultatas = skaicius1 * skaicius2;
}
else if (operacija == "/")
{
    rezultatas = skaicius1 / skaicius2;
}
else if (operacija == "%")
{
    rezultatas = skaicius1 % skaicius2;
}
else if (operacija == "^")
{
    rezultatas = Math.Pow(skaicius1, skaicius2);
}

Console.WriteLine(skaicius1 + " " + operacija + " " + skaicius2 + " = " + rezultatas);

Console.ReadLine();
```

## Ciklai

1. Parašyti programą naudojant while ciklą, kuri 20 kartų išveda jūsų pasirinktą sakinį į Console.

```c#
int i = 0;

while(i < 20)
{
    Console.WriteLine("Labas");
    i++;
}
```
2. Parašykite programą naudojant while ciklą, kuri išveda į Console iš naujos eilutės skaičius nuo 1 iki 25.

```c#
int i = 1;

while(i <= 25)
{
    Console.WriteLine(i);
    i++;
}
```

3. Parašykite programą su amžinu ciklu naudojant while ciklą, kuri amžinai išvedinėtų vis didėjanti skaičių nuo 1 iki begalybės.

```c#
int i = 1;

while(true)
{
    Console.WriteLine(i);
    i++;
}
```

4. Parašykite programą naudojant while ciklą, kuri nuskaitinėja įvestus skaičius ir juos sumuoja tol, kol nebūna įvestas neigiamas skaičius. Programos pabaigoje turi išvesti gautą sumą.

```c#
int suma = 0;
bool sustoti = false;

while(!sustoti)
{
    Console.WriteLine("Iveskite skaiciu:");
    int skaicius = int.Parse(Console.ReadLine());
    if(skaicius >= 0)
    {
        suma += skaicius;
    }
    else
    {
        sustoti = true;
    }
}

Console.WriteLine("suma = " + suma);
```

5. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau 50.

```c#
int sum = 0;
while(sum < 50) 
{
  int number = int.Parse(Console.ReadLine());
  sum += number;
  Console.WriteLine($"suma: {sum} ");
}
Console.ReadLine();
```

6. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja paspaustus klavišus ir išveda jų pavadinimus tol, kol nepaspaudžiamas ESC klavišas. 

```c#
while(true) 
{
  var key = Console.ReadKey().Key;
  if(key == ConsoleKey.Escape)
  {
    break;
  } 
  else 
  {
    Console.WriteLine(key.ToString());
  }
}
```
7. Parašykite programą naudojant for ciklą, kuri paprašo įvesti teigiamą skaičių n ir iš eilės atspausdina skaičius nuo 1 iki n.

```c#
Console.WriteLine("Iveskite skaiciu:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}
```

8. Parašyti programą naudojant for ciklą, kuri paprašo įvesti natūralųjį skaičių ir atspausdina vienoje eilutėje 10 naturaliųjų skaičių iš eilės pradedant nuo įvesto skaičiaus, pvz.: įvedus skaičių 5, turėtų atspausdinti šitaip - 
```5 6 7 8 9 10 11 12 13 14```

```c#
Console.WriteLine("Iveskite skaiciu:");
int n = int.Parse(Console.ReadLine());

for (int i = n; i < n + 10; i++)
{
    Console.Write(i + " ");
}
```

9. Parašyti programą naudojant `for` ciklą, kuri suskaičiuoja pirmų 10 natūraliųjų skaičių sumą.

```c#
int sum = 0;
for (var i = 1; i <= 10; i++)
{
  sum += i;
}
Console.WriteLine("sum: " + sum);
```

