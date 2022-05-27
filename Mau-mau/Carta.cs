using System;
using System.Collections.Generic;
using System.Linq;

namespace Mau_mau
{
    class Carta
    {
        public Carta()
        {
            string valor;
            string naipe;
        }
        public string valor { get; set; }
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

        public Stack<string> JuntarAsCartas(string concatenar)
        {
            Stack<string> stringDeCartas = new Stack<string>();

            foreach (string cartaIndivudial in concatenar.Split(' '))
            {
                stringDeCartas.Push(cartaIndivudial);
            }
            return stringDeCartas;
        }

        public Stack<string> Baralho(Stack<string> stringDeCartas)
        {
            Carta _carta = new Carta();
            Stack<string> baralho = new Stack<string>();
            List<string> listaValor = new List<string>();
            List<string> listanaipe = new List<string>();

            foreach (var carta in stringDeCartas)
            {
                var separaCarta = carta.ToCharArray();

                _carta.naipe = separaCarta[0].ToString();
                _carta.valor = separaCarta[1].ToString();
                listanaipe.Add(_carta.naipe);
                listaValor.Add(_carta.valor);
            }

            var listaValorEmbaralhado = _carta.EmbaralharListaValor(listaValor);
            var listaNipeEmbaralhado = _carta.EmbaralharListaNaipe(listanaipe);

            while (listaValorEmbaralhado.Count() > 0 || listaNipeEmbaralhado.Count() > 0)
            {
                var juntar = listaValorEmbaralhado[0] + listaNipeEmbaralhado[0];
                listaValorEmbaralhado.RemoveAt(0);
                listaNipeEmbaralhado.RemoveAt(0);

                baralho.Push(juntar);
            }
            return baralho;
        }
    }


}
