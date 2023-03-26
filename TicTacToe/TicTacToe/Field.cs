using System.Data.Common;
using System.Text;

namespace TicTacToe
{
    public class Field
    {
        public int Size { get; set; }
        public Cell[,] Cells { get; set; }

        public Field(int _size)
        {
            Size = _size;
            Cells = new Cell[Size, Size];
            FillFieldWithCells();
        }

        /// <summary>
        /// prints the current field
        /// </summary>
        public void Print()
        {
            StringBuilder _stringBuilder = new StringBuilder();
            char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            _stringBuilder.Append($"{Environment.NewLine}     ");

            // column header (letters)
            {
                for (int _column = 0; _column < Size; _column++)
                {
                    _stringBuilder.Append("  " + _alphabet[_column] + " ");
                }
                AppendHorizontalLine(_stringBuilder);
            }

            // rows (numbers and fields)
            {
                _stringBuilder.Append(Environment.NewLine);
                for (int _row = 0; _row < Size; _row++)
                {
                    _stringBuilder.Append("  " + (_row + 1).ToString("00") + " | ");

                    for (int _column = 0; _column < Size; _column++)
                    {
                        _stringBuilder.Append($"{Cells[_row, _column].Symbol} | ");
                    }
                    AppendHorizontalLine(_stringBuilder);
                    _stringBuilder.Append(Environment.NewLine);
                }
            }
            Utility.Write($"{_stringBuilder}\n");
        }

        /// <summary>
        /// sets a cell to the provided player's desired position.
        /// </summary>
        /// <param name="_player">The player</param>
        /// <param name="_position">The cell position</param>
        public void OccupyCell(Player _player, Coordinate _coordinate)
        {
            Cell cell = Cells[_coordinate.Row, _coordinate.Column];
            cell.Symbol = _player.Symbol;
            cell.Free = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_coordinate"></param>
        /// <returns></returns>
        public Cell GetCellByCoordinate(Coordinate _coordinate)
        {
            return Cells[_coordinate.Row, _coordinate.Column];
        }

        private void FillFieldWithCells()
        {
            for (int _row = 0; _row < Size; _row++)
            {
                for(int _column = 0; _column < Size; _column++)
                {
                    Cells[_row, _column] = new Cell(_row, _column);
                }
            }

            SetNeighboringCells();
        }

        private void SetNeighboringCells()
        {
            foreach (Cell cell in Cells)
            {
                var _top = cell.Row > 0 ? Cells[cell.Row - 1, cell.Column] : null;
                var _right = cell.Column + 1 < Size ? Cells[cell.Row, cell.Column + 1] : null;
                var _bottom = cell.Row + 1 < Size ? Cells[cell.Row + 1, cell.Column] : null;
                var _left = cell.Column > 0 ? Cells[cell.Row, cell.Column - 1] : null;

                Cells[cell.Row, cell.Column].SetNeighboringCells(_top, _right, _bottom, _left);
            }
        }

        private StringBuilder AppendHorizontalLine(StringBuilder _stringBuilder)
        {
            _stringBuilder.Append($"{Environment.NewLine}     -");
            for (int _column = 0; _column < Size; _column++)
            {
                _stringBuilder.Append("----");
            }
            return _stringBuilder;
        }

        // old code
        //public void CheckState()
        //{

        //}

        //public void CheckHorizontalLine()
        //{

        //}

        //public void CheckVerticalLine()
        //{

        //}

        //public void CheckDiagonalLine()
        //{

        //}
    }
}