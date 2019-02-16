using System;
namespace _9Pamoka
{
    public class Staciakampis
    {
        public int AKrastine { get; set; }
        public int BKrastine { get; set; }

        public Staciakampis(int a, int b)
        {
            AKrastine = a;
            BKrastine = b;
        }

        public void PaskaiciuokPerimetra()
        {
            Console.WriteLine($"Perimetras: {2*AKrastine + 2*BKrastine}");
        }

        public void PaskaiciuokPlota()
        {
            Console.WriteLine($"Plotas: {AKrastine*BKrastine}");
        }
    }
}
