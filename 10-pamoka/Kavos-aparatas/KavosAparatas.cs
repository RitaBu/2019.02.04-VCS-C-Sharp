using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavosAparatoProjektas
{
    public class KavosAparatas
    {
        const int MaxPanaudojimuSkaicius = 15;

        public double PienoKiekisL { get; set; }
        public double CukrausKiekisKg { get; set; }
        public double VandensKiekisL { get; set; }
        public double KavosKiekisKg { get; set; }
        public int PanaudojimuSkaicius { get; set; }

        public KavosAparatas(double pienoKiekis, double cukrausKiekis,
            double vandensKiekis, double kavosKiekis)
        {
            PienoKiekisL = pienoKiekis;
            CukrausKiekisKg = cukrausKiekis;
            VandensKiekisL = vandensKiekis;
            KavosKiekisKg = kavosKiekis;
            PanaudojimuSkaicius = 0;
        }

        public void IsveskProduktuInformacija()
        {
            Console.WriteLine("================= STATUSAS ==============");
            Console.WriteLine($"Pieno kiekis (l): {PienoKiekisL}");
            Console.WriteLine($"Cukraus kiekis (kg): {CukrausKiekisKg}");
            Console.WriteLine($"Vandens kieks (l): {VandensKiekisL}");
            Console.WriteLine($"Kavos kiekis (kg): {KavosKiekisKg}");
            Console.WriteLine("-------------------------------------------");
        }

        public void IsplaukAparata()
        {
            PanaudojimuSkaicius = 0;
        }

        public void GaminkKava()
        {
            Console.WriteLine("Ivesk kavos pavadinima:");
            string kava = Console.ReadLine();

            switch (kava)
            {
                case "juoda":
                    GaminkKonkreciaKava(0.1, 0, 0.05, 0.1);
                    break;
                case "su pienu":
                    GaminkKonkreciaKava(0.1, 0.1, 0.05, 0.1);
                    break;
                case "latte":
                    GaminkKonkreciaKava(0.1, 0.2, 0.05, 0.1);
                    break;
                default:
                    Console.WriteLine($"{kava} kavos gaminti nemoku!");
                    break;
            } 
        }

        private void GaminkKonkreciaKava(double kavosKiekis, double pienoKiekis,
                double cukrausKiekis, double vandensKiekis)
        {
            if (KavosKiekisKg >= kavosKiekis && VandensKiekisL >= vandensKiekis
                        && PienoKiekisL >= pienoKiekis && CukrausKiekisKg >= cukrausKiekis)
            {
                Console.WriteLine("Gaminu kava");

                //visko uztenka, tai minusuoju
                KavosKiekisKg -= kavosKiekis;
                VandensKiekisL -= vandensKiekis;
                CukrausKiekisKg -= cukrausKiekis;
                PienoKiekisL -= pienoKiekis;

                //pagaminau, tai padidinu panaudojimu skaiciu
                PanaudojimuSkaicius++;
            }
            else Console.WriteLine("Nepakanka produktu!");
        }
    }
}
