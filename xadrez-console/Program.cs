using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teste
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine("");
                    Console.Write("Origem: ");
                    Posicao origim = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origim, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
