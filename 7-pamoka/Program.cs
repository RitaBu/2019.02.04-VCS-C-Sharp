using System;

namespace ManoPamokos
{
    class Program
    {
        static void Main()
        {
            int[] pazymiai = new int[] { 1, 9, 10, 8, 7, 10, 6, 4, 1 };
            SpausdinkMasyva(pazymiai);

            int maxPaz = Max(pazymiai);
            Console.WriteLine("Didziausias pazymys: " + maxPaz);

            int kadaPenktadienis = KadaPenktadienis();
            Console.WriteLine("Penktadienis bus uz: " + maxPaz + " dienu(-os).");

            Console.ReadLine();
        }

        ///1. Parašykite metodą, kuris atspausdina gautą skaičių masyvą 
        /// į vieną eilutę su tarpais.
        static void SpausdinkMasyva(int[] masyvas)
        {
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i] + " ");
            }

            Console.WriteLine();
        }

        ///2. Parašykite metodą Max, kuris priima skaičių masyvą ir grąžiną didžiausią skaičių. 
        ///(reikės naudoti for ciklą ir sąlygas, bet ne Math biblioteką!)
        static int Max(int[] masyvas)
        {
            int max = 0;

            for (int i = 0; i < masyvas.Length; i++)
            {
                if(masyvas[i] > max)
                {
                    max = masyvas[i];
                }
            }
            return max;
        }

        ///3. Parašyti metodą, kuris atspausdina, 
        /// kokia dabar savaitės diena ir suskaičiuoja už kiek dienų bus penktadienis. 
        /// Rezultato pvz.: „Today is Thursday, Friday is in 1 day“.
        public static int KadaPenktadienis()
        {
            DateTime siandiena = DateTime.Now;
            var savaitesDiena = (int)siandiena.DayOfWeek;

            if (savaitesDiena <= 5)
            {
                return 5 - savaitesDiena;
            }
            else
            {
                return (7 - savaitesDiena) + 5;
            }
        }
    }
}
