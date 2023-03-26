using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class WinChecker
    {
        public static Field Field { get; set; }
        public static int Depth { get; set; } = 0;
        public static bool IsWon { get; set; } = false;

        public static bool IsGameWon()
        {
            if (CheckHorizontalLine()) return IsWon;
            if (CheckVerticalLine()) return IsWon;
            CheckDiagonalLine();
            return IsWon;
        }

        private static bool CheckHorizontalLine()
        {
            for (int _row = 0; _row < Field.Size; _row++)
            {
                IsWon = AreEqual(Field.Cells[_row, 0].Symbol, Field.Cells[_row, 1].Symbol, Field.Cells[_row, 2].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool CheckVerticalLine()
        {
            for (int _column = 0; _column < Field.Size; _column++)
            {
                IsWon = AreEqual(Field.Cells[0, _column].Symbol, Field.Cells[1, _column].Symbol, Field.Cells[2, _column].Symbol);
                if (IsWon) break;
            }
            return IsWon;
        }

        private static bool CheckDiagonalLine()
        {
            IsWon = AreEqual(Field.Cells[0, 0].Symbol, Field.Cells[1, 1].Symbol, Field.Cells[2, 2].Symbol);
            if (IsWon) return IsWon;
            IsWon = AreEqual(Field.Cells[2, 0].Symbol, Field.Cells[1, 1].Symbol, Field.Cells[0, 2].Symbol);
            return IsWon;
        }

        private static bool AreEqual(object a, object b, object c)
        {
            return (a.Equals(b) && b.Equals(c) && !a.Equals(' '));
        }
    }
}
