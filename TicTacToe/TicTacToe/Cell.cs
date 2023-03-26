using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public Coordinate Coordinate { get; set; }
        public int Row { get { return Coordinate.Row; } }
        public int Column { get { return Coordinate.Column; } }
        public char Symbol { get; set; } = ' ';
        public bool Free { get; set; } = true;

        public Cell(int _row, int _column)
        {
            Coordinate = new Coordinate(_row, _column);
        }

        public object Clone()
        {
            Cell newCell = new Cell(Row, Column);
            newCell.Symbol = Symbol;
            newCell.Free = Free;
            return newCell;
        }
    }
}
