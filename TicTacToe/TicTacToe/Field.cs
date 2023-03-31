using System.Data.Common;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// tic tac toe field
    /// </summary>
    public class Field
    {
        /// <summary>
        /// size of the field
        /// </summary>
        public int Size { get; set; } = 3;

        /// <summary>
        /// array of cells
        /// </summary>
        public Cell[,] Cells { get; set; }

        /// <summary>
        /// creates a field filled with cells
        /// </summary>
        public Field()
        {
            Cells = new Cell[Size, Size];
            FillFieldWithCells();
        }

        /// <summary>
        /// prints the field
        /// </summary>
        public void Print()
        {
            StringBuilder _stringBuilder = new StringBuilder();
            char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            _stringBuilder.Append($"{Environment.NewLine}    ");

            {
                for (int _column = 0; _column < Size; _column++)
                {
                    _stringBuilder.Append("  " + _alphabet[_column] + " ");
                }
                AppendHorizontalLine(_stringBuilder);
            }

            {
                _stringBuilder.Append(Environment.NewLine);
                for (int _row = 0; _row < Size; _row++)
                {
                    _stringBuilder.Append("  " + (_row + 1).ToString("0") + " | ");

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
        /// changes the symbol of the (empty) cell to the players symbol and sets its status to occupied
        /// </summary>
        /// <param name="_player">player (player)</param>
        /// <param name="_position">coordinate (coordinate)</param>
        public void OccupyCell(Player _player, Coordinate _coordinate)
        {
            Cell cell = Cells[_coordinate.Row, _coordinate.Column];
            cell.Symbol = _player.Symbol;
            cell.Free = false;
        }

        /// <summary>
        /// creates and returns a deep copy of the field
        /// </summary>
        /// <returns>Clone of the field</returns>
        public object Clone()
        {
            Field _field = new Field();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    _field.Cells[i, j] = (Cell)Cells[i, j].Clone();
                }
            }
            return _field;
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
        }

        private StringBuilder AppendHorizontalLine(StringBuilder _stringBuilder)
        {
            _stringBuilder.Append($"{Environment.NewLine}    -");
            for (int _column = 0; _column < Size; _column++)
            {
                _stringBuilder.Append("----");
            }
            return _stringBuilder;
        }
    }
}