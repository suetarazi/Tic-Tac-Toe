using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// DisplayBoard method: Output the board to console
        /// </summary>
        /// 
		public void DisplayBoard()
		{
			// Loop through first array of 3 obj
			for (int i = 0; i < GameBoard.GetLength(0); i++)
			{
				string displayRow = "";

				// Loop through each subarray
				for (int j = 0; j < GameBoard.GetLength(1); j++)
				{
					displayRow += ($"  {GameBoard[i, j]}  |");
				}
				Console.WriteLine("-------------------");
				Console.WriteLine($"|{displayRow}");
			}
			Console.WriteLine("-------------------");

			//TODO: Output the board to the console
        }
    }
}