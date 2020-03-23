﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	class Player
	{
		public string Name { get; set; }
		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }


		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

        // Positioning X or O in the board(DisplayBoard)
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

        // process of turn taking
		public void TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name} it is your turn");

            // instantiating a new board everytime a position is picked by a player
            // calling the GetPosition Method and updated board.
			Position position = GetPosition(board);

            // When player put a mark:
			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
                // console will put a mark on board
				board.GameBoard[position.Row, position.Column] = Marker;
			}
			else
			{   // players cant put the same position twice
				Console.WriteLine("This space is already occupied");
			}
		}
	}
}