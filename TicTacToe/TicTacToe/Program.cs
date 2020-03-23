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
        }


        public static Player player()
        {
            Player PlayerX = new Player();
            Console.WriteLine("Enter your Name as player 1");
            PlayerX.Name = Console.ReadLine();
            PlayerX.Marker = "X";

            Player PlayerO = new Player();
            PlayerO.Name = // insert your name
            PlayerO.Marker = "O";


        }
        //Instantiate the Game class
        //We have Game method

        

        // TODO: Setup your game.


        // You are requesting a Winner to be returned,
        // Determine who the winner is output the celebratory message to the correct player.
        // If it's a draw, tell them that there is no winner. 
    }
}