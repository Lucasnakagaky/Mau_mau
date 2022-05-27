using System.Collections.Generic;

namespace Mau_mau
{
    public class Jogador
    {
        public Jogador()
        {
            Mao = new List<string>();
            Jogadores = new Queue<string>();
            string Nome;
        }

        public List<string> Mao { get; set; }
        public Queue<string> Jogadores { get; set; }
        public string Nome { get; set; }
    }
}
