using System;
using tabuleiro;
using Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();


                Tela.imprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }



           
























        }
    }
}