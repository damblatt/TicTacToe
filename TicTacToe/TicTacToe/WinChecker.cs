using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// win checker
    /// </summary>
    public class WinChecker
    {
        private static bool IsWon { get; set; } = false;
        private static Game? Game { get; set; }

        /// <summary>
        /// sets the state of the game to over if a player won the game
        /// </summary>
        /// <param name="_game">game (game)</param>
        public static void SetCurrentState(Game _game)
        {
            Game = _game;
            if (IsWonByHorizontalLine() || IsWonByVerticalLine() || IsWonByDiagonalLine()) {
                Game._state = Game.State.OVER;
            }
        }

        private static bool IsWonByHorizontalLine()
        {
            for (int _row = 0; _row < Game.Field.Size; _row++)
            {
                IsWon = AreEqual(Game.Field.Cells[_row, 0].Symbol, Game.Field.Cells[_row, 1].Symbol, Game.Field.Cells[_row, 2].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool IsWonByVerticalLine()
        {
            for (int _column = 0; _column < Game.Field.Size; _column++)
            {
                IsWon = AreEqual(Game.Field.Cells[0, _column].Symbol, Game.Field.Cells[1, _column].Symbol, Game.Field.Cells[2, _column].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool IsWonByDiagonalLine()
        {
            IsWon = AreEqual(Game.Field.Cells[0, 0].Symbol, Game.Field.Cells[1, 1].Symbol, Game.Field.Cells[2, 2].Symbol);
            if (IsWon) return IsWon;
            IsWon = AreEqual(Game.Field.Cells[2, 0].Symbol, Game.Field.Cells[1, 1].Symbol, Game.Field.Cells[0, 2].Symbol);
            return IsWon;
        }

        private static bool AreEqual(object a, object b, object c)
        {
            return (a.Equals(b) && b.Equals(c) && !a.Equals(' '));
        }
    }
}
