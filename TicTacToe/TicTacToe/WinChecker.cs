using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class WinChecker
    {
        public static int Depth { get; set; } = 0;
        public static bool IsWon { get; set; } = false;
        public static Game? Game { get; set; }

        /// <summary>
        /// checks and return whether the game is won or not
        /// </summary>
        /// <param name="_game">game to be checked</param>
        /// <returns></returns>
        public static bool IsGameWon(Game _game)
        {
            Game = _game;
            if (CheckHorizontalLine()) return IsWon;
            if (CheckVerticalLine()) return IsWon;
            CheckDiagonalLine();
            return IsWon;
        }

        private static bool CheckHorizontalLine()
        {
            for (int _row = 0; _row < Game.Field.Size; _row++)
            {
                IsWon = AreEqual(Game.Field.Cells[_row, 0].Symbol, Game.Field.Cells[_row, 1].Symbol, Game.Field.Cells[_row, 2].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool CheckVerticalLine()
        {
            for (int _column = 0; _column < Game.Field.Size; _column++)
            {
                IsWon = AreEqual(Game.Field.Cells[0, _column].Symbol, Game.Field.Cells[1, _column].Symbol, Game.Field.Cells[2, _column].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool CheckDiagonalLine()
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
