using System;
using System.Collections.Generic;
using System.Text;

namespace turniej
{
    public class osoba
    {
        protected string imie, nazwisko;
        protected int wiek;
        public osoba()
        {
            imie = Console.ReadLine();
            nazwisko = Console.ReadLine();
            wiek = int.Parse(Console.ReadLine());
        }
        public string zwrocimie()
        {
            return imie;
        }
        public string zwrocnaziwsko()
        {
            return nazwisko;
        }
        public int zwrocwiek()
        {
            return wiek;
        }


    }
}
