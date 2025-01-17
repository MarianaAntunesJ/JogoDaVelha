﻿using System;

namespace JogoDaVelha
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
            Console.WriteLine("\n " + new string('_', 15) + "\n");
            Console.WriteLine($"|    1   2   3  |");
            ExibirLinhas('A', 0);
            Console.WriteLine("\n|   ----------- |");
            ExibirLinhas('B', 1);
            Console.WriteLine("\n|   ----------- |");
            ExibirLinhas('C', 2);
            Console.WriteLine("\n " + new string('_', 15) + "\n");
        }

        private void ExibirLinhas(char letra, int linha)
        {
            ExibirColuna(letra);
            for(int i = 0; i < 3; i++)
            {
                ExibirCasas(linha, i);
                if(i < 2)
                    ExibirPipe();
                else
                    ExibirPipe(" ");
            } 
        }

        private void ExibirPipe(string op = "") => Console.Write($"{op} | ");

        private void ExibirColuna(char letra) => Console.Write($"| {letra}  ");

        private void ExibirCasas(int linha, int coluna)
        {
            if(_casas[linha, coluna] == ' ')
            {
                Console.Write(_casas[linha, coluna]);
                return;
            }
            if(_casas[linha, coluna] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(_casas[linha, coluna]);
            }
            else if (_casas[linha, coluna] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(_casas[linha, coluna]);
            }
            Console.ResetColor();
        }

        public void PreencherCasa(string posicao, char jogador)
        {
            TrataPosicao(posicao, out int linha, out int coluna);
            _casas[linha, coluna] = jogador;
        }

        private void TrataPosicao(string posicaoEntrada, out int linha, out int coluna)
        {
            char[] vetPosicao = posicaoEntrada.ToUpper().ToCharArray();
            if (vetPosicao.Length != 2)
                throw new ArgumentException(message: "Digite posição válida. Ex: A3");
            var soma = (int)vetPosicao[0] + (int)vetPosicao[1];
            if (soma < 'A' + '1' || soma > 'C' + '3')
                throw new ArgumentException(message: "Posição inexistente no tabuleiro");
            if ((int)vetPosicao[0] > '3')
            {
                linha = (int)vetPosicao[0] - 'A';
                coluna = vetPosicao[1] - '1';
            }
            else
            {
                linha = (int)vetPosicao[1] - 'A';
                coluna = vetPosicao[0] - '1';
            }
            if (_casas[linha, coluna] != ' ')
                throw new ArgumentException(message: "Posição já preenchida!");
        }

        public bool VerificarVitoria(char jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (_casas[i, 0] == jogador && _casas[i, 1] == jogador && _casas[i, 2] == jogador)
                    return true;
                if (_casas[0, i] == jogador && _casas[1, i] == jogador && _casas[2, i] == jogador)
                    return true;
            }
            if (_casas[0, 0] == jogador && _casas[1, 1] == jogador && _casas[2, 2] == jogador)
                return true;
            if (_casas[0, 2] == jogador && _casas[1, 1] == jogador && _casas[2, 0] == jogador)
                return true;
            return false;
        }

        public bool VerificaVelha()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (_casas[i, j] == ' ')
                        return false;
            return true;
        }
    }
}
