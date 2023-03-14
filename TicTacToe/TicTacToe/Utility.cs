using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Utility
    {
        public int ReadInt(int min, string instructionMessage = "")
        {
            string? _input;
            int _n;
            bool _criteria;
            while (_criteria = (!Int32.TryParse(_input = Console.ReadLine(), out _n) || _n < min))
            {
                if (instructionMessage == "" || _criteria) { instructionMessage = $"{_input} is an invalid number.\nPlease enter a valid number: "; }
                Console.Write(instructionMessage);
            }
            return _n;
        }
    }
}
