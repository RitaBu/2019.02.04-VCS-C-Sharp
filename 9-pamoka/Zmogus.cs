using System;
namespace _9Pamoka
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Telefonas { get; set; }

        public Zmogus(string vardas, string pavarde, string telefonas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Telefonas = telefonas;
        }

        public void AtspausdinkInformaciją()
        {
            Console.WriteLine($"{Vardas} {Pavarde} {Telefonas}");
        }
    }
}
