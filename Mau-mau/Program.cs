using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mau_mau
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, jogador;

            Jogador maos = new Jogador();
            Baralho baralho = new Baralho();

            List<string> dados = new List<string>();
            Queue<string> fila = new Queue<string>();
            Stack<string> stringDeCartas = new Stack<string>();
            Stack<string> lixo = new Stack<string>();

            using (StreamReader reader = new StreamReader(@"C:\Users\\Invent032\\Desktop\\arquivoDoMau_mau.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    dados.Add(line);
                }
            }

            if (int.Parse(dados[1]) < 2 || int.Parse(dados[1]) > 10)
            {
                Console.WriteLine("Quantidade de jogadores invalida");
            }
            else
            {
                for (int i = 0; i < int.Parse(dados[1]); i++)
                {
                    fila.Enqueue(i.ToString());
                }
                Console.Write("fila de jogadores " + fila.Count());
            }

            var concatenar = dados[2] + (" ") + dados[3] + (" ") + dados[4];

            foreach (string cartaIndivudial in concatenar.Split(' '))
            {
                stringDeCartas.Push(cartaIndivudial);
            }
            Console.WriteLine(stringDeCartas);

            List<string> listaValor = new List<string>();
            List<string> listanipe = new List<string>();


            foreach (var carta in stringDeCartas)
            {
                Console.WriteLine(carta);
                var separaCarta = carta.ToCharArray();

                var valor = separaCarta[0].ToString();
                var nipe = separaCarta[1].ToString();
                listaValor.Add(valor);
                listanipe.Add(nipe);
            }
            Random random = new Random();
            var arr = listaValor.OrderBy(x => random.Next()).ToArray();
            foreach (var i in arr)
            {
                Console.WriteLine(arr);
                listaValor.Add(arr.ToString());
            }
            Console.WriteLine(listaValor);

        }
    }
}
