namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        //constutor
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null; 
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();

        public void incrementarQtdMovimentos() 
        {
            qtdMovimentos++; 
        }
    }
}
