using System;
using System.Collections.Generic;
using System.Linq;

namespace AstuntaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodai
            SkaiciaiNuo100Iki1();
            SkaiciaiNuo1IkiX(10);
            int sandauga = Sandauga(9, 0);
            Console.WriteLine(sandauga);

            //metodai kitame faile
            PagalbiniaiMetodai.AtspausdinkTekstus(new string[] {"vienas", "du", "trys"}); 
            PagalbiniaiMetodai.AtspausdinkSkaicius(new int[] {1, 2, 3, 4, 5 }); 
            var vienasTekstas = PagalbiniaiMetodai.GrazinkVienaTeksta(new string[] {"vienas", "du", "trys", "keturi"}); 
            Console.WriteLine(vienasTekstas);

            //sarasai ir metodai kitame faile
            var skaiciai = new List<int> { 1, 99, 0, 50, 6, 78, 3, 4, 2 };
            var suma = PagalbiniaiMetodai.PaskaiciuokSarasoSuma(skaiciai);
            Console.WriteLine("saraso suma: " + suma);

            var vidurkis = PagalbiniaiMetodai.PaskaiciuokSarasoVidurki(skaiciai);
            Console.WriteLine("saraso vidurkis: " + vidurkis);

            PagalbiniaiMetodai.SurusiuokSarasaMazejimoTvarka(skaiciai);

            //LinQ
            var balai = new List<int> { 1, 99, 0, 50, 6, 78, 3, 4, 4, 2, 99, 100, 100 };
            var baluSuma = balai.Sum();
            var min = balai.Min();
            var max = balai.Max();
            var baluVidurkis = balai.Average();
            var pirmasElementas = balai.First();
            var paskutinisElementas = balai.Last();
            var nesikartojantysBalai = balai.Distinct();
            var poaibis = balai.Skip(4).Take(5).ToList();

            var lyginiaiSk = balai.Where(b => b % 2 == 0).ToList();
            var didesniUz10MazesniUz20 = balai.Where(b => b > 10 && b < 20).ToList();
            var skaiciuKvadratai = balai.OrderByDescending(b => b)
                                        .Select(b => $"Skaicius = {b}, Kvadratas = {b * b}")
                                        .ToList();

            Console.Read();
        }



        //1. Parašyti metodą, kuris nieko negrąžina ir atspausdina skaičius nuo 100 iki 1.
        public static void SkaiciaiNuo100Iki1()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        //2.  Parašyti metodą, kuris nieko negrąžina, bet gauna sveiką skaičių x ir atspausdina skaičius vienoje eilutėje su tarpais nuo 1 iki x.
        public static void SkaiciaiNuo1IkiX(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }

        //3. Parašyti metodą, kuris gauna du sveikus skaičius ir grąžina jų sandaugą.Parašyti metodą, kuris gauna du tekstus ir grąžina juos sujungtus į vieną.
        public static int Sandauga(int a, int b)
        {
            return a * b;
        }
    }
}
