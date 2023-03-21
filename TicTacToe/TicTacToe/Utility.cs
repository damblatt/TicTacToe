using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Utility
    {
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

        public static void Write(string word)
        {
            Console.Write(word);
        }
    }
}
