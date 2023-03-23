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
        public int Y { get; }
        public int X { get; }

        public Coordinate(int y, int x)
        {
            Y = y;
            X = x;
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
                int _firstCharacterAsInt = (int)_input[0];
                char _char;
                int _number;

                // first is digit
                if (_firstCharacterAsInt > 48 && _firstCharacterAsInt < 58)
                {
                    _char = _input[^1];
                    _number = int.Parse(_input[..^1]);
                }
                // first is chr
                else
                {
                    _char = _input[0];
                    _number = int.Parse(_input[1..]);
                }

                // create coordinate with the processed input information
                int y = _number - 1;
                int x = _char - 'a';
                Coordinate coordinate = new Coordinate(y, x);
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
