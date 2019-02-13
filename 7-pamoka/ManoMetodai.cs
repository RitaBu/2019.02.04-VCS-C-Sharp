using System;

namespace ManoPamokos
{

    public class ManoMetodai
    {
        public static void Pasisveikink()
        {
            Console.WriteLine("Labas, kebabas");
        }

        public static void PasisveikinkSuVardu(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);
        }

        public static int Suma(int[] masyvas)
        {
            int suma = 0;

            for (int i = 0; i < masyvas.Length; i++)
            {
                suma += masyvas[i];
            }

            return suma;
        }

        public static int[] SukurMasyva(int masyvoDydis)
        {
            return new int[masyvoDydis];
        }

        public static int[] NunulinkElementa(int elementoIndeksas, int[] masyvas)
        {
            masyvas[elementoIndeksas] = 0;
            return masyvas;
        }
    }
}
