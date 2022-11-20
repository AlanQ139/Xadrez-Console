using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            //instanciando a posição
            P = new Posicao (3, 4);

            Console.WriteLine("Posi: " + P);

            Console.ReadLine();
        }
    }
}
