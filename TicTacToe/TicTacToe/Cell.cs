using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// (single) cell from a field
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// symbol of the cell (default = ' ')
        /// </summary>
        public char Symbol { get; set; } = ' ';

        /// <summary>
        /// state of the cell whether it's free or not
        /// </summary>
        public bool Free { get; set; } = true;

        private Coordinate Coordinate { get; set; }

        private int Row { get { return Coordinate.Row; } }

        private int Column { get { return Coordinate.Column; } }

        /// <summary>
        /// creates a cell with the given coordinates
        /// </summary>
        /// <param name="_row"></param>
        /// <param name="_column"></param>
        public Cell(int _row, int _column)
        {
            Coordinate = new Coordinate(_row, _column);
        }

        /// <summary>
        /// creates and returns a deep copy of the cell
        /// </summary>
        /// <returns>deep copy of the cell</returns>
        public object Clone()
        {
            Cell _cell = new Cell(Row, Column);
            _cell.Symbol = Symbol;
            _cell.Free = Free;
            return _cell;
        }
    }
}
