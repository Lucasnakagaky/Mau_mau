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


            List<string> dados = new List<string>();
            Stack<string> lixo = new Stack<string>();

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
                    _jogador.Jogadores.Enqueue(i.ToString());
                }
                Console.Write("fila de jogadores " + _jogador.Jogadores.Count());
                Console.Write("=============================");
            }

            var concatenar = dados[2] + (" ") + dados[3] + (" ") + dados[4];

            var stringDeCartas = _metodosDaCarta.JuntarAsCartas(concatenar);

            var baralho = _metodosDaCarta.Baralho(stringDeCartas);

            Console.WriteLine(baralho);

            // Agora é pegar cada jogador e acrescentar a mão de cartas dele.


        }
    }
}
