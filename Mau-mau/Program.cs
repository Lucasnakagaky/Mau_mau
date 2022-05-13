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

            Queue<string> fila = new Queue<string>();

            try
            {
                StreamWriter x;

                string Caminho = @"C:\\arquivoDoMau_mau.txt";

                x = File.AppendText(Caminho);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }



            Console.WriteLine("Define a quantide de jogadores");
            jogador = int.Parse(Console.ReadLine());

            if (jogador < 2 || jogador > 10)
            {
                Console.WriteLine("Quantidade de jogadores invalida");
            }
            else
            {
                for (int i = 0; i < jogador; i++)
                {
                    fila.Enqueue(i.ToString());
                }

                Console.Write("fila " + fila.Count());
            }





        }
    }
}
