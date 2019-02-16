using System;
using System.Collections.Generic;
using System.Linq;

namespace _9Pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //kartojam metodus
            DaugybosLentele();
            StaciakampioPerimetras(4, 5);
            int plotas = StaciakampioPlotas(10, 9);

            //kartojam linQ
            var skaiciai = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var lyginiuSkKiekis = skaiciai.Count(x => x % 2 == 0);
            var intervalas = skaiciai.Where(x => x > 15 && x < 40).ToList();
            var didesniuUz40suma = skaiciai.Where(x => x > 40).Sum();

            //klases
            Skruzdeda mazaSkruzdeda = new Skruzdeda();
            mazaSkruzdeda.Svoris = 1;
            mazaSkruzdeda.Spalva = "rozine";
            Console.WriteLine("Mazos skruzdedos spalva: " + mazaSkruzdeda.Spalva);

            Skruzdeda dideleSkruzdeda = new Skruzdeda();
            mazaSkruzdeda.Svoris = 5;
            mazaSkruzdeda.KojuSk = 3;
            Console.WriteLine("Dideles skruzdedos koju skaicius: " + mazaSkruzdeda.KojuSk);

            //klases su konstruktoriais
            var s1 = new Staciakampis(1, 19);
            s1.PaskaiciuokPlota();
            s1.PaskaiciuokPerimetra();

            Zmogus jonas = new Zmogus("Jonas", "Jonaitis", "9092190380");
            Zmogus ona = new Zmogus("Ona", "Onaite", "872637846");

            //ojektai sarase
            var studentai = new List<Zmogus> ();
            studentai.Add(ona);
            studentai.Add(jonas);
            studentai.Add(new Zmogus("Petras", "Petrenas", "892398479823"));

            for (int i = 0; i < studentai.Count; i++)
            {
                studentai[i].AtspausdinkInformaciją();
            }

        }

        public static void DaugybosLentele()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }
        }

        public static void StaciakampioPerimetras(int a, int b)
        {
            var perimetras = 2 * (a + b);
            Console.WriteLine(perimetras);
        }

        public static int StaciakampioPlotas(int a, int b)
        {
            return a * b;
        }
    }
}
