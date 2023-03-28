using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Coordinate
    {
        private static Regex _regex = new Regex("^(([a-c][1-3]?)|([1-3]?[a-c]))$");
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int _row, int _column)
        {
            Row = _row;
            Column = _column;
        }

        /// <summary>
        /// processes the input and returns a created coordinate if the input is valid. else return null
        /// </summary>
        /// <param name="_input"></param>
        /// <returns>coordinate or null and state of function (successful or not)</returns>
        public static (bool, Coordinate?) TryCreateCoordinate(string _input)
        {
            _input = _input.Trim().ToLower();
            bool _isInputValid = _regex.Match(_input).Success;

            if (_isInputValid)
            {
                int _firstCharacterAsInt = _input[0];
                char _char;
                int _number;

                if (_firstCharacterAsInt >= '1' && _firstCharacterAsInt <= '9')
                {
                    _char = _input[^1];
                    _number = int.Parse(_input[..^1]);
                }

                else
                {
                    _char = _input[0];
                    _number = int.Parse(_input[1..]);
                }

                int _row = _number - 1;
                int _column = _char - 'a';
                Coordinate coordinate = new Coordinate(_row, _column);
                return (true, coordinate);
            }
            else
            {
                Utility.Write("This field does not exist. Enter a valid coordinate: ");
                return (false, null);
            }
        }
    }
}
