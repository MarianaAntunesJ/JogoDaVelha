using System;

namespace JogoDaVelha
{
    class Jogo
    {
        private Tabuleiro _tabuleiro = new Tabuleiro();
        public int VitoriasX { get; private set; } = 0;
        public int VitoriasO { get; private set; } = 0;

        public void IniciarJogo()
        {
            char[] jogadores = new char[] {'X', 'O'};
            char jogador;
            int posicao = 0;
            while (true)
            {
                jogador = jogadores[posicao];
                Jogada(jogador);
                if (_tabuleiro.VerificarVitoria(jogador))
                {
                    _tabuleiro.ExibirTabu();
                    Console.WriteLine($"Vitória do jogador {jogador}!");
                    AdicionarVitoria(jogador);
                    break;
                }
                if (_tabuleiro.VerificaVelha())
                {
                    _tabuleiro.ExibirTabu();
                    Console.WriteLine("Deu velha!");
                    break;
                }
                if (posicao == 0)
                    posicao = 1;
                else
                    posicao = 0;
            }
        }

        private void AdicionarVitoria(char jogador)
        {
            if (jogador == 'X')
                VitoriasX++;
            else if (jogador == 'O')
                VitoriasO++;
        }

        private void Jogada(char jogador)
        {
            string mensagemErro = string.Empty;
            do
            {
                Exibir(jogador, mensagemErro);
                string posicao = Console.ReadLine();
                Console.Clear();
                try
                {
                    _tabuleiro.PreencherCasa(posicao, jogador);
                    return;
                }
                catch (ArgumentException e)
                {
                    mensagemErro = ($"Jogada invalida! {e.Message}");
                }
                catch (Exception)
                {
                    mensagemErro = ($"Jogada invalida!");
                }
            } while (true);
        }

        private void Exibir(char jogador, string mensagemErro)
        {
            Console.WriteLine("PARTIDA INICIADA");
            _tabuleiro.ExibirTabu();
            Console.WriteLine(mensagemErro);
            Console.Write($"Vez do jogador {jogador}, digite a posição: ");
        }
    }
}
