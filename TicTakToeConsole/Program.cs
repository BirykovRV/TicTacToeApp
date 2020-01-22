using System;
using System.Threading;
using TicTacToe.Core;

namespace TicTakToeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            board.CreateBoard();
            var game = new GameManager(board);
            
            Console.WriteLine("Старт игры!");
            Console.WriteLine(game.DisplayBoard());
            string key;
            do
            {
                Console.WriteLine("Ходит: " + game.GetPlayer);
                key = Console.ReadLine();
                for (int i = 0; i < board.Squares.Length; i++)
                {
                    if (i + 1 == Convert.ToInt32(key))
                    {
                        game.FillSquare(i, game.GetPlayer);
                        game.IsNext = !game.IsNext;
                    }
                }
                Console.WriteLine(game.DisplayBoard());
                if (!string.IsNullOrEmpty(game.GetWiner()))
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Победитель: {game.GetWiner()}!\r\n");
                    Console.WriteLine("Начать заново? [y/n]: ");
                    var result = Console.ReadLine();
                    if (result == "n")
                    {
                        break;
                    }
                    else
                    {
                        board.CreateBoard();
                        game.IsNext = true;
                        Console.WriteLine(game.DisplayBoard());
                    }
                }                                

                if (key == "q") break;

                Thread.Sleep(200);

            } while (true);
        }
    }
}
