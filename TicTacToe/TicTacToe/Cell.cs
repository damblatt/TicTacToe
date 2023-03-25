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
        public Cell CellToTheTop;
        public Cell CellToTheRight;
        public Cell CellToTheBottom;
        public Cell CellToTheLeft;

        public Cell(int _row, int _column)
        {
            Coordinate = new Coordinate(_row, _column);
        }

        public void SetNeighboringCells(Cell? _top, Cell? _right, Cell? _bottom, Cell? _left)
        {
            CellToTheTop = _top;
            CellToTheRight = _right;
            CellToTheBottom = _bottom;
            CellToTheLeft = _left;
        }
    }
}
