using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            char opcao;
            do
            {
                Console.Clear();
                jogo.IniciarJogo();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Deseja finalizar jogo? (S)Sim; (N)Não.");
                        opcao = char.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Opção inválida, tente novamente");
                    } 
                }
            } while (opcao != 'S');
            Console.Clear();
            Console.WriteLine($"\nRESULTADO FINAL:" +
                              $"\nJogador X = {jogo.VitoriasX}" +
                              $"\nJogador O = {jogo.VitoriasO}");
        }
    }
}
