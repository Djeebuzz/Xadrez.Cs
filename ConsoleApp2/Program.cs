using System;
using tabuleiro;
using Xadrez;

namespace XadrezConsole {
    class Program
    {
        static void Main(string[] args)
        {

            
            

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 2));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 4)); 
             
            Tela.imprimirTabuleiro(tab);


        }
    }
}