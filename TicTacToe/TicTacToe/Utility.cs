using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Utility
    {
        /// <summary>
        /// Reads an integer from console, with safety checks
        /// </summary>
        /// <param name="min">minimum required int</param>
        /// <returns>the int</returns>
        public static int ReadInt(int min)
        {
            string? _input;
            int _n;
            bool _criteria;
            while (_criteria = (!Int32.TryParse(_input = Console.ReadLine(), out _n) || _n < min))
            {
                Console.Write($"{_input} is an invalid number.\nPlease enter a valid number: ");
            }
            return _n;
        }

        /// <summary>
        /// Reads a symbol from console
        /// </summary>
        /// <returns>the symbol</returns>
        public static char ReadSymbol()
        {
            string? _input;
            char _chr;
            bool _criteria;
            while (_criteria = (!Char.TryParse(_input = Console.ReadLine(), out _chr)))
            {
                Console.Write($"{_input} is an invalid symbol. \nPlease enter a valid symbol (one character): ");
            }
            return _chr;
        }

        /// <summary>
        /// prints the given word
        /// </summary>
        /// <param name="word"></param>
        public static void Write(string word)
        {
            Console.Write(word);
        }
    }
}
