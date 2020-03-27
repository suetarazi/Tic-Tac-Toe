using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace UnitTesting_tictactoe
{
    public class UnitTest1
    {
        /// <summary>
        /// Line: 16-17 Instantiate New Players
        /// Line: 19 Setup new game
        /// Line: 20-25 Winning Condition
        /// </summary>
        [Fact]
        public void TestForWinningConditionRow()
        {
            Player playerX = new Player();
            Player playerO = new Player();
            Game newGame = new Game(playerX, playerO);

            Position p1 = new Position(0, 0);
            Position p2 = new Position(0, 1);
            Position p3 = new Position(0, 2);
            newGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            newGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            newGame.Board.GameBoard[p3.Row, p3.Column] = "X";

            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestForWinningConditionColumn()
        {
            Player playerX = new Player();
            Player playerO = new Player();
            Game newGame = new Game(playerX, playerO);

            Position p1 = new Position(0, 0);
            Position p2 = new Position(1, 0);
            Position p3 = new Position(2, 0);
            newGame.Board.GameBoard[p1.Row, p1.Column] = "O";
            newGame.Board.GameBoard[p2.Row, p2.Column] = "O";
            newGame.Board.GameBoard[p3.Row, p3.Column] = "O";

            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        /// <summary>
        /// Line: 41-43 inside the game, invoke call SwitchPlayer and compare both value
        /// </summary>
        [Fact]
        public void TestForPlayerSwitch()
        {
            Player playerX = new Player();
            Player playerO = new Player();
            Game newGame = new Game(playerX, playerO);

            Player playerXTurn = newGame.NextPlayer();
            newGame.SwitchPlayer();
            Player playerOTurn = newGame.NextPlayer();

            Assert.NotEqual(playerXTurn, playerOTurn);
        }

        /// <summary>
        /// Choosing #1 at the board, check for corresponding PositionForNumber
        /// </summary>
        [Fact]
        public void TestForTheCorrectPlayerInput()
        {
            int locationOnBoard = 1;
            Position position = Player.PositionForNumber(locationOnBoard);
            Assert.True(position.Row == 0 && position.Column == 0);
        }
    }
}
