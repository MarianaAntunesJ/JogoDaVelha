using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            tabuleiro.ExibirTabu();
            tabuleiro.PreencherCasa("A1", 'X');
            tabuleiro.ExibirTabu();
            tabuleiro.PreencherCasa("3c", 'O');
            tabuleiro.ExibirTabu();
        }
    }
}
