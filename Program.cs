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
                        opcao = char.Parse(Console.ReadLine().ToUpper());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Opção inválida, tente novamente");
                    }
                }
            } while (opcao != 'S');
            ExibirResultadoFinal();

            void ExibirResultadoFinal()
            {
                Console.Clear();
                Console.WriteLine("\nRESULTADO FINAL:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Jogador X = {jogo.VitoriasX}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Jogador O = {jogo.VitoriasO}");
                Console.ResetColor();
            }
        }
    }
}
