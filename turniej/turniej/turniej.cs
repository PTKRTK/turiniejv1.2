using System;
using System.Collections.Generic;
using System.Text;

namespace turniej
{
    class turniej
    {
        protected string nazwaturnieju;
            public turniej()
            {
                nazwaturnieju = Console.ReadLine();
                listadruzyn = new List<druzyna>();
                listasedziow = new List<sedzia>();
            }

        List<sedzia> listasedziow;
        List<druzyna> listadruzyn;
        public void dodajdruzyne(druzyna team)
            {
                listadruzyn.Add(team);
            }
        public void dodajsedziego(sedzia refree)
        {
            listasedziow.Add(refree);
        }

        public List<druzyna> zwrocdruzyny()
            {
                return listadruzyn;
            }
       

    }
}
