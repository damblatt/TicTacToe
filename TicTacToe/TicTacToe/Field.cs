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

            Generate();
        }

        public void Generate()
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

        public void SetCell(Player _player, int[] _position)
        {

        }

        public void CheckState()
        {

        }
    }
}