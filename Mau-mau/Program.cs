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
            Jogador _jogador = new Jogador();
            Carta _carta = new Carta();
            MetodosDaCarta _metodosDaCarta = new MetodosDaCarta();


            List<string> nomes = new List<string>();
            Queue<string> Jogadores = new Queue<string>();
            List<string> dados = new List<string>();
            Stack<string> lixo = new Stack<string>();

            nomes.Add("Lucas");
            nomes.Add("Adriano");
            nomes.Add("Ferds");
            nomes.Add("Iago");
            nomes.Add("Gregorio");
            nomes.Add("Edvan Haley");
            nomes.Add("Herlan");
            nomes.Add("Cabral");
            nomes.Add("Soares me ajuda");
            nomes.Add("Eduardo Bolsonaro");

            Console.WriteLine(nomes);

            using (StreamReader reader = new StreamReader(@"C:\Users\Invent032\\Desktop\\arquivoDoMau_mau.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("================");
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
                    Console.WriteLine(i);

                    if (i = nomes)
                    {

                        Jogadores.Enqueue(i.ToString());
                    }

                }
                Console.WriteLine("fila de jogadores ");
                Console.WriteLine(Jogadores.Count());
                Console.Write("===========================");
            }

            var concatenar = dados[2] + (" ") + dados[3] + (" ") + dados[4];

            var stringDeCartas = _metodosDaCarta.JuntarAsCartas(concatenar);

            var baralho = _metodosDaCarta.Baralho(stringDeCartas);



            // Agora é pegar cada jogador e acrescentar a mão de cartas dele.


            var jogador1 = Jogadores.ToArray()[0];
            Console.WriteLine(jogador1);

            IDictionary<string, List<string>> dic1 = new Dictionary<string, List<string>>();


            foreach (var jogad in Jogadores.ToArray())
            {

                Console.WriteLine(jogad);

                while (_jogador.Mao.Count() < 5)
                {
                    var carta = baralho.Pop();
                    _jogador.Mao.Add(carta);
                }

                dic1.Add(jogad, _jogador.Mao);
            }
            Console.WriteLine(dic1.Count);

        }
    }
}
