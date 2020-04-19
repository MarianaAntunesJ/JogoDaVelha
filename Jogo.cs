using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    class Jogo
    {
        private Tabuleiro _tabuleiro = new Tabuleiro();

        public void IniciarJogo()
        {
            Console.WriteLine("*******JOGO INICIADO*******\n");
            while (true)
            {
                Jogada('X');
            }
        }

        private void Jogada(char jogador)
        {
            do
            {
                Console.WriteLine($"Vez do jogador: {jogador}");
                _tabuleiro.ExibirTabu();
                Console.WriteLine("Digite a posicao: ");
                string posicao = Console.ReadLine();
                try
                {
                    _tabuleiro.PreencherCasa(posicao, jogador);
                    return;
                }
                catch
                {
                    Console.WriteLine("Jogada invalida!!!!!!!");
                }
            } while (true);
        }
    }
}
