using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mau_mau
{
    class Baralho
    {
        public string carta { get; set; }
        public string naipe { get; set; }


        public List<string> EmbaralharListaValor(List<string> listaValor)
        {
            Random random = new Random();
            var valores = listaValor.OrderBy(x => random.Next()).ToArray();
            while (listaValor.Count() > 0)
            {
                listaValor.RemoveAt(0);
            }

            foreach (var impilhar in valores)
            {
                listaValor.Add(impilhar);
            }
            return listaValor;
        }

        public List<string> EmbaralharListaNaipe(List<string> listanaipe)
        {
            Random random = new Random();
            var nipes = listanaipe.OrderBy(x => random.Next()).ToArray();
            while (listanaipe.Count() > 0)
            {
                listanaipe.RemoveAt(0);
            }

            foreach (var impilhar in nipes)
            {
                listanaipe.Add(impilhar);
            }
            return listanaipe;
        }
    }


}
