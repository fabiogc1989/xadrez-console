namespace Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca()
        {
            QteMovimentos = 0;
        }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) : this()
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
        }
    }
}
