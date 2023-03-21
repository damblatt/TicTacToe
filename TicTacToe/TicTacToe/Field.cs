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

        public void FillFieldWithCells()
        {
            for (int y = 0; y < Size; y++)
            {
                for(int x = 0; x < Size; x++)
                {
                    Cells[x, y] = new Cell();
                }
            }
        }

        public void PrintField()
        {
            StringBuilder sb = new StringBuilder();
            string _emptyField = " ";
            char[] _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            sb.Append($"{Environment.NewLine}     ");

            // column header (letters)
            {
                for (int i = 0; i < Cells.GetLength(1); i++)
                {
                    sb.Append("  " + _alpha[i] + " ");
                }

                sb.Append($"{Environment.NewLine}     -");
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    sb.Append("----");
                }
            }

            // rows (numbers and fields)
            {
                sb.Append(Environment.NewLine);
                for (int x = 0; x < Cells.GetLength(0); x++)
                {
                    sb.Append("  " + (x + 1).ToString("00") + " | ");

                    for (int y = 0; y < Cells.GetLength(1); y++)
                    {
                        sb.Append($"{Cells[x, y].Symbol} | ");
                    }
                    sb.Append(Environment.NewLine);
                    sb.Append("     -");
                    for (int y = 0; y < Cells.GetLength(1); y++)
                    {
                        sb.Append("----");
                    }
                    sb.Append(Environment.NewLine);

                }
            }
            Utility.Write($"{sb.ToString()}\n");
        }

        /// <summary>
        /// Sets a cell to the provided player's desired position.
        /// </summary>
        /// <param name="_player">The player</param>
        /// <param name="_position">The cell position</param>
        public void SetCell(Player _player, Coordinate _coordinate)
        {
            Cell cell = Cells[_coordinate.Y, _coordinate.X];
            if (cell != null && cell.Free){
                cell.Symbol = _player.Symbol;
                cell.Position = _coordinate;
                cell.Free = false;
            } else
            {
                Cells[_coordinate.Y, _coordinate.X] = new Cell();
                Cells[_coordinate.Y, _coordinate.X].Symbol = _player.Symbol;
                Cells[_coordinate.Y, _coordinate.X].Position = _coordinate;
                Cells[_coordinate.Y, _coordinate.X].Free = false;
            }
        }

        /// <summary>
        /// Checks if there is any winner in the game.
        /// </summary>
        public void CheckState()
        {

        }
    }
}