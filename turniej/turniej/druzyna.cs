using System;
using System.Collections.Generic;
using System.Text;
//testxd

namespace turniej
{
    public class druzyna
    {
       
        protected string nazwadruzyny;
        public druzyna()
        {
            nazwadruzyny = Console.ReadLine();
            listagraczy = new List<gracz>();
        }

        List<gracz> listagraczy;
        public List<gracz> zwrocdruzyna()
        {
            return listagraczy;
        }

        public void dodajgracza(gracz player)
        {
            listagraczy.Add(player);
        }


    }
}
