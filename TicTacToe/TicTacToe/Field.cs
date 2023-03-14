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
        }

        // REWRITE
        public void Draw()
        {
            StringBuilder sb = new StringBuilder();
            string _emptyField = " ";
            char[] _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            sb.Append($"{ Environment.NewLine}     ");

            // letters
            for (int i = 0; i < Cells.GetLength(1); i++)
            {
                sb.Append("  " + _alpha[i] + " ");
            }

            // horizontal lines
            sb.Append($"{Environment.NewLine}     -");
            for (int y = 0; y < Cells.GetLength(1); y++)
            {
                sb.Append("----");
            }
            sb.Append(Environment.NewLine);
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                sb.Append("  " + (x + 1).ToString("00") + " | ");

                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    var field = Cells[x, y];

                    if (field != null && !field.Free)
                        sb.Append($"{field.Symbol} | ");
                    else
                        sb.Append($"{_emptyField} | ");

                    double waiting = ((3000 / Cells.GetLength(0)) - 70) / Cells.GetLength(0);
                }
                sb.Append(Environment.NewLine);
                sb.Append("     -");
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    sb.Append("----");
                }
                sb.Append(Environment.NewLine);

            }
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// Sets a cell to the provided player's desired position.
        /// </summary>
        /// <param name="_player">The player</param>
        /// <param name="_position">The cell position</param>
        public void SetCell(Player _player, int[] _position)
        {
            Cell cell = this.Cells[_position[0], _position[1]];

            if (cell != null)
            {
                if (cell.Free) { 
                    cell.Symbol = _player.Symbol;
                    cell.Position = _position;
                    cell.Free = false;
                }
            } else
            {
                this.Cells[_position[0], _position[1]] = new Cell();
                this.Cells[_position[0], _position[1]].Symbol = _player.Symbol;
                this.Cells[_position[0], _position[1]].Position = _position;
                this.Cells[_position[0], _position[1]].Free = false;
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