using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    public class ViktorinosKlausimas
    {
        public string Klausimas { get; set; }
        public string[] GalimiAtsakymai { get; set; }
        public int TeisingasAtsakymas { get; set; }

        public ViktorinosKlausimas(string klausimas, string[] galimiAtsakymai, int teisingasAts)
        {
            Klausimas = klausimas;
            GalimiAtsakymai = galimiAtsakymai;
            TeisingasAtsakymas = teisingasAts;
        }

        public void AtspausdinkKlausima()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Klausimas);

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < GalimiAtsakymai.Length; i++)
            {
                Console.Write($"{i+1}) {GalimiAtsakymai[i]}    ");
            }
            Console.WriteLine();
        }

        public bool NuskaitykAtsakyma()
        {
            Console.WriteLine("Iveskite atsakyma:");
            int atsakymas = int.Parse(Console.ReadLine());
            if (atsakymas - 1 == TeisingasAtsakymas)
            {
                return true;
            }
            else return false;
            //return atsakymas - 1 == TeisingasAtsakymas;
        }
    }
}
