﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }

        public int colunas { get; set; }

        private Peca[,] pecas;

        //construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo para retornar o valor da peça por posição
        public Peca peca (int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }
    }
}
