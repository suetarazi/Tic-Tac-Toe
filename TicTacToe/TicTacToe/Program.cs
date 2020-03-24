using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // A: Call that method in your Main method.
            // A: Create a new method that creates your players and instantiates the game class.
            // US: call the player() method - instantiate/create players
            // US: call all the Game() method - inside it there is Play(); - inside it call CheckForWinner();
            Console.WriteLine("TicTacToe");
            StartTheGame();


        }

        /// <summary>
        /// Player instantiation, Setting up X and O
        /// </summary>
        static void StartTheGame()
        {
            Player PlayerX = new Player();
            Console.WriteLine("Enter your Name as player 1");
            PlayerX.Name = Console.ReadLine();
            PlayerX.Marker = "X";

            Player PlayerO = new Player();
            Console.WriteLine("Enter your Name as player 2");
            PlayerO.Name = Console.ReadLine();
            PlayerO.Marker = "O";

            StartNewGame(PlayerX, PlayerO);

        }
        
        /// <summary>
        /// Run the Game with player X and player O
        /// </summary>
        /// <param name="X"></param>
        /// <param name="O"></param>
        static void StartNewGame(Player X, Player O)
        {
            Game game = new Game(X, O);
            game.Play();
        }

    
        //Instantiate the Game class
        //We have Game method

        

        // TODO: Setup your game.


        // You are requesting a Winner to be returned,
        // Determine who the winner is output the celebratory message to the correct player.
        // If it's a draw, tell them that there is no winner. 
    }
}