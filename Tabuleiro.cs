using System;
using System.Collections.Generic;
using System.Text;

namespace AmorJogoVelha
{
    class Tabuleiro
    {
        private char[,] _casas = new char[3, 3];

        public Tabuleiro() => IniciarCasas(); 

        private void IniciarCasas()
        {
            for(int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _casas[i, j] = ' ';
        }

        public void ExibirTabu()
        {
            Console.WriteLine($"   1   2   3\n" +
                              $"A  {_casas[0, 0]} | {_casas[0, 1]} | {_casas[0, 2]}\n" +
                              $"  -----------\n" +
                              $"B  {_casas[1, 0]} | {_casas[1, 1]} | {_casas[1, 2]}\n" +
                              $"  -----------\n" +
                              $"C  {_casas[2, 0]} | {_casas[2, 1]} | {_casas[2, 2]}\n");
        }

        public void PreencherCasa(string posicao, char jogador)
        {
            TrataPosicao(posicao, out int linha, out int coluna);

        }

        private void TrataPosicao(string posicaoEntrada, out int linha, out int coluna)
        {
            char[] vetPosicao = posicaoEntrada.ToCharArray();
            if(vetPosicao.Length)
        }
    }
}
