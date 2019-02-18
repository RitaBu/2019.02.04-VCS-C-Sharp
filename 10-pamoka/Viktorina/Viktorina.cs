using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    public class Viktorina
    {
        public List<ViktorinosKlausimas> Klausimai { get; set; }
        public int Taskai { get; set; }

        public Viktorina(List<ViktorinosKlausimas> klausimai)
        {
            Klausimai = klausimai;
            Taskai = 0;
        }

        public void PradetiZaidima()
        {
            for (int i = 0; i < Klausimai.Count; i++)
            {
                Klausimai[i].AtspausdinkKlausima();
                bool arTeisingas = Klausimai[i].NuskaitykAtsakyma();
                Console.WriteLine(arTeisingas);
                if (arTeisingas)
                {
                    Taskai++;
                }
            }
        }

        public void ParodykRezultata()
        {
            Console.WriteLine("Surinkote tiek tasku: " + Taskai);
        }
    }
}
