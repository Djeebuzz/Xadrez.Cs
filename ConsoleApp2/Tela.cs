using System;
using tabuleiro;
using Xadrez;
using System.Collections.Generic;

namespace XadrezConsole;

internal class Tela
{
    public static void imprimirPartida(PartidaDeXadrez partida)
    {
        imprimirTabuleiro(partida.tab);
        Console.WriteLine();
        imprimirPecasCapturadas(partida);
        Console.WriteLine();
        Console.WriteLine("Turno: " + partida.turno);
        if (!partida.terminada)
        {
            Console.WriteLine("Agurdando a jogada da " + partida.jogadorActual);
            if (partida.xeque)
            {
                Console.WriteLine("Xeque!!!");
            }
        }
        else
        {
            Console.WriteLine("Xeque-Mate");
            Console.WriteLine("Vencedor: " + partida.jogadorActual);
        }
    }

    public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
    {
        Console.WriteLine("Pecas Capturadas: ");
        Console.Write("Brancas: ");
        imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
        Console.Write("Pretas: ");
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
        Console.ForegroundColor = aux;
        Console.WriteLine();
    }

    public static void imprimirConjunto(HashSet<Peca> conjunto)
    {
        Console.Write("[");
        foreach (Peca x in conjunto)
        {
            Console.Write(x + " ");
        } 
        Console.WriteLine("]");
    }
    public static void imprimirTabuleiro(Tabuleiro tab)
    {
        for (int i = 0; i < tab.linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < tab.colunas; j++)
            {

                    Console.Write(" ");
                    imprimirPeca(tab.peca(i, j));
                    Console.Write(" ");
            }           
            Console.WriteLine();
        }
        Console.Write("   A   B   C   D   E   F   G   H");
        Console.WriteLine();
    }
    public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoePossiveis)
    {
        ConsoleColor fundoOriginal = Console.BackgroundColor;
        ConsoleColor fundoAlterado = ConsoleColor.DarkGray;


        for (int i = 0; i < tab.linhas; i++)
        {
            Console.Write(8 - i + " ");
           
            for (int j = 0; j < tab.colunas; j++)
            {
                if (posicoePossiveis[i, j])
                {
                    Console.BackgroundColor = fundoAlterado;
                }
                else
                {
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.Write(" ");
                imprimirPeca(tab.peca(i, j));
                Console.Write(" ");
                Console.BackgroundColor = fundoOriginal;
            }

            Console.WriteLine();
        }
        Console.Write("   A   B   C   D   E   F   G   H");
        Console.BackgroundColor = fundoOriginal;
        Console.WriteLine();
        
    } 
    public static PosicaoXadrez lerPosicaoXadrez()
    {
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);

    }




    public static void imprimirPeca(Peca peca)
    {
        if (peca == null)
        {
            Console.Write
                ("- ");
        }
        else
        {
            if (peca.cor == Cor.Branca)
            {
               
                Console.Write(peca);
                Console.Write(" ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.Write(peca);
                Console.Write(" ");

                Console.ForegroundColor = aux;
            }


        }
    }

}



