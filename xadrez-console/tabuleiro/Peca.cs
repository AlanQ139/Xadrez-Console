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

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tabuleiro.linhas; i++) 
            {
                for(int j=0; j<tabuleiro.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
        public void decrementarQtdMovimentos()
        {
            qtdMovimentos--;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
    }
}
