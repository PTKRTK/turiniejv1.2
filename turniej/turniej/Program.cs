using System;

namespace turniej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            druzyna druzyna1 = new druzyna();
            gracz gracz1 = new gracz();
            druzyna1.dodajgracza(gracz1);
            gracz gracz2 = new gracz();
            druzyna1.dodajgracza(gracz2);
            wypiszzawodnikow(druzyna1);
        }

        private static void wypiszzawodnikow(druzyna team)
        {
            foreach (gracz item in team.zwrocdruzyna())
            {
                Console.WriteLine(item.zwrocimie());
                Console.WriteLine(item.zwrocnaziwsko());
                Console.WriteLine(item.zwrocwiek());
            }
        }
    }
}
