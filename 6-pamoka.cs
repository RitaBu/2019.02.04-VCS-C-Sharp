using System;

namespace ManoPamokos
{
    class Program
    {
        static void Main()
        {
            Pasisveikink();
            Pasisveikink("Labas, as krabas");

            PatikrinkSkaiciu(1);
            PatikrinkSkaiciu(-1);
            PatikrinkSkaiciu(0);

            int kvadratas = PakelkKvadartu(-3);
            Console.WriteLine(kvadratas);

            int suma = Suma(99, 1);
            Console.WriteLine(suma);

            NustatykZmogausFizBukle(100, 2);

            Console.ReadLine();
        }

        static void Pasisveikink()
        {
            Console.WriteLine("Labas");
        }

        static void Pasisveikink(string pasisveikinimas)
        {
            Console.WriteLine(pasisveikinimas);
        }

        static void PatikrinkSkaiciu(int sk)
        {
            if(sk > 0)
            {
                Console.WriteLine("Teigiamas");
            }
            else if(sk < 0)
            {
                Console.WriteLine("Neigiamas");
            }
            else 
            {
                Console.WriteLine("Nulis");
            }
        }

        static int PakelkKvadartu(int sk)
        {
            return sk * sk;
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static double KMI(double svorisKg, double ugisM)
        {
            return svorisKg / (ugisM * ugisM);
        }

        static void NustatykZmogausFizBukle(double svorisKg, double ugisM)
        {
            double kmi = KMI(svorisKg, ugisM);

            if (kmi < 15)
            {
                Console.WriteLine("Badaujantis žmogus");
            }
            else if (kmi < 18.5)
            {
                Console.WriteLine("Liesas žmogus");
            }
            else if (kmi < 25)
            {
                Console.WriteLine("Normalaus svorio žmogus");
            }
            else if (kmi < 30)
            {
                Console.WriteLine("Turintis viršsvorio žmogus");
            }
            else if (kmi < 40)
            {
                Console.WriteLine("Nutukęs žmogus");
            }
            else
            {
                Console.WriteLine("Ligotai nutukęs žmogus");
            }
        }

        static void AtspausdinkMasyva(int[] masyvas)
        {
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i] + " ");
            }
        }
    }
}
