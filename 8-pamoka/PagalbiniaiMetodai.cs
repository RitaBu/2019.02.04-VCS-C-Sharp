using System;
using System.Collections.Generic;

namespace AstuntaPamoka
{
    public class PagalbiniaiMetodai
    {
        //1. Sukurti metodą, kuris nieko negrąžina ir atspausdina gautą tekstų masyvą, kiekvienas elementas turi būti atskirtas kableliais.
        public static void AtspausdinkTekstus(string[] tekstai)
        {
            for (int i = 0; i < tekstai.Length; i++)
            {
                Console.Write($"{tekstai[i]}, ");
            }
        }

        //2. Sukurti metodą, kuris nieko negrąžina ir atspausdiną gautą skaičių masyvą, kiekvienas elementas turi būti atskirtas kableliais.
        public static void AtspausdinkSkaicius(int[] skaiciai)
        {
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write($"{skaiciai[i]}, ");
            }
        }

        //3. Sukurti metodą, kuris gauna tekstų masyvą ir grąžina tuos tekstus suklijuotus į vieną ir atskirtus kableliais.
        public static string GrazinkVienaTeksta(string[] tekstai)
        {
            string vienasTekstas = "";

            for (int i = 0; i < tekstai.Length; i++)
            {
                vienasTekstas += $"{tekstai[i]}, ";
            }

            return vienasTekstas;
        }

        //2. PagalbiniaiMetodai.cs faile sukurkite metodą, kuris moka paskaičiuoti duoto sąrašo sumą.
        public static int PaskaiciuokSarasoSuma(List<int> skaiciai)
        {
            int suma = 0;

            foreach (var skaicius in skaiciai)
            {
                suma += skaicius;
            }

            return suma;
        }

        //3. PagalbiniaiMetodai.cs faile sukurkite metodą, kuris moka paskaičiuoti duoto skaičių sąrašo vidurkį. (Šis metodas galėtų kviesti sumą skaičiuojantį metodą)
        public static double PaskaiciuokSarasoVidurki(List<int> skaiciai)
        {
            double suma = PaskaiciuokSarasoSuma(skaiciai);
            double vidurkis = suma / skaiciai.Count;
            return vidurkis;
        }

        //4. Sukurkite metodą, kuris duotą skaičių sąrašą surūšiuoja mažėjimo tvarka.
        public static void SurusiuokSarasaMazejimoTvarka(List<int> skaiciai)
        {
            skaiciai.Sort();
            skaiciai.Reverse();
        }
    }
}
