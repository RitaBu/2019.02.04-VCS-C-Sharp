using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavosAparatoProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            var ritosKavosAparatas = new KavosAparatas(0, 5, 10, 6);
            ritosKavosAparatas.IsveskProduktuInformacija();
            ritosKavosAparatas.GaminkKava();
            ritosKavosAparatas.IsveskProduktuInformacija();

            Console.Read();
        }
    }
}
