﻿using tabuleiro;

namespace xadrez
{
    internal class PocicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PocicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
