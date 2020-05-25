﻿namespace Tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] _pecas;
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Tabuleiro()
        {
        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }
    }
}
