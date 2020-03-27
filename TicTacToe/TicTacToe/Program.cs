using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe");
            StartTheGame();
        }

        /// <summary>
        /// Player instantiation, Setting up X and O, Setup new game, Get winner, display winner or if its draw.
        /// </summary>
        static void StartTheGame()
        {

            Board board = new Board();

            Player PlayerX = new Player();
            Console.WriteLine("Enter your Name as player 1");
            PlayerX.Name = Console.ReadLine();
            PlayerX.Marker = "X";

            Player PlayerO = new Player();
            Console.WriteLine("Enter your Name as player 2");
            PlayerO.Name = Console.ReadLine();
            PlayerO.Marker = "O";

            Game game = new Game(PlayerX, PlayerO);

            Player winner = game.Play();

            if (winner != null)
                Console.WriteLine($"Winner is {winner.Name}.");
            else
                Console.WriteLine("It's a draw");


        }
    }
}