﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre (tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 9));
            tab.colocarPeca(new Rei(tab,Cor.Preta), new Posicao(0, 2));

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
        }
    }
}