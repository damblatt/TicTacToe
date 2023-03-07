using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Spielfeldgrösse 3*3
            **/
            int _fieldSize = 3;
            string[,] _field = new string[_fieldSize, _fieldSize];

            StringBuilder sb = new StringBuilder();

            Console.Clear();

            //Console.WriteLine();
            sb.Append(Environment.NewLine);
            char[] _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //Console.Write("     ");
            sb.Append("     ");

            // print letters
            for (int i = 0; i < _field.GetLength(1); i++)
            {
                Console.Write("  " + _alpha[i] + " ");
            }

            Console.WriteLine();
            Console.Write("     -");
            for (int y = 0; y < _field.GetLength(1); y++)
            {
                Console.Write("----");
            }
            Console.WriteLine("");
            for (int x = 0; x < _field.GetLength(0); x++)
            {
                Console.Write("  " + (x + 1).ToString("00") + " | ");

                for (int y = 0; y < _field.GetLength(1); y++)
                {
                    var field = _field[x, y];
                    Console.Write(" ");
                    Console.Write(" | ");
                    double waiting = ((3000 / _field.GetLength(0)) - 70) / _field.GetLength(0);
                    int waitingTime = Convert.ToInt32(waiting);
                    System.Threading.Thread.Sleep(waitingTime);
                }
                Console.WriteLine("");
                Console.Write("     -");
                for (int y = 0; y < _field.GetLength(1); y++)
                {
                    Console.Write("----");
                }
                Console.WriteLine("");
                System.Threading.Thread.Sleep(70);
            }
        }
    }
}