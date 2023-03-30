using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Utility
    {
        /// <summary>
        /// reads a symbol from the console
        /// </summary>
        /// <returns>the symbol</returns>
        public static char ReadSymbol()
        {
            string? _input;
            char _char;
            bool _isValid;
            while (!(_isValid = !char.TryParse(_input = Utility.ReadLine(), out _char)))
            {
                Console.Write($"{_input} is an invalid symbol. \nPlease enter a valid symbol (one character): ");
            }
            return _char;
        }

        /// <summary>
        /// prints the given word to the console
        /// </summary>
        /// <param name="word">word (string)</param>
        public static void Write(string word)
        {
            Console.Write(word);
        }

        /// <summary>
        /// reads a string from the console
        /// </summary>
        /// <returns>input (string)</returns>
        public static string ReadLine()
        {
            return Utility.ReadLine();
        }
    }
}
