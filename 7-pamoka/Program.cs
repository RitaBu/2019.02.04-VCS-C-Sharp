using System;
using System.Collections.Generic;

namespace ManoPamokos
{
    class Program
    {
        static void Main()
        {
            int[] skaiciai = new int[] { 1, 9, 10, 8, 7, 10, 6, 4, 1 };
            SpausdinkMasyva(skaiciai);

            int maxPaz = Max(skaiciai);
            Console.WriteLine("Didziausias skaicius: " + maxPaz);

            int kadaPenktadienis = KadaPenktadienis();
            Console.WriteLine("Penktadienis bus uz: " + maxPaz + " dienu(-os).");

            ///1. Aprašykite metodą, kuris nieko negrąžina, tiesiog priima string parametrą - vardą 
            /// ir išveda į Console tokią žinutę - “Labas, [vardas]”
            ManoMetodai.Pasisveikink();

            ///2. Aprašykite metodą, kuris kaip parametrą priima skaičių masyvą, 
            /// naudodamas foreach arba for ciklą visus skaičius iš masyvo 
            /// susumuoja ir grąžina sumą.
            int skaiciuSuma = ManoMetodai.Suma(skaiciai);
            Console.WriteLine("skaiciu suma: " + skaiciuSuma);

            ///3. Aprašykite metodą, kuris priima skaičių int kaip 
            /// parametrą - masyvo dydį ir grąžiną sukurtą tokio dydžio masyvą.
            int[] naujasMasyvas = ManoMetodai.SukurMasyva(10);

            ///4. Aprašykite metodą, kuris priima skaičių int - indeksą bei masyvą int[] 
            /// kaip parametrus ir grąžina masyvą su nunulintu skaičiumi tuo indeksu.
            skaiciai = ManoMetodai.NunulinkElementa(2, skaiciai);

            ///Sąrašai

            ///2.1 Nuskaityti iš konsolės n įvestų vaiko pažymių
            List<int> pazymiai = PazymiuMetodai.NuskaitykPazymius();

            ///2.2 Suskaičiuoti pažymių vidurkį
            var vidurkis = PazymiuMetodai.PaskaiciuokVidurki(pazymiai);
            Console.WriteLine("Pazymiu vidurkis: " + vidurkis);

            ///2.3 Suskaičiuoti pažymių medianą
            var mediana = PazymiuMetodai.PaskaiciuokMediana(pazymiai);
            Console.WriteLine("Pazymiu vidurkis: " + mediana);

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
