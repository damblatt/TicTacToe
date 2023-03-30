using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        /// <summary>
        /// name of the player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// symbol of the player
        /// </summary>
        public char Symbol { get; set; }

        /// <summary>
        /// creates a player with the given nane and symbol
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_symbol"></param>
        public Player(string _name, char _symbol)
        {
            Name = _name;
            Symbol = _symbol;
        }

        /// <summary>
        /// reads the players input and returns the type of the operation with the according object
        /// </summary>
        /// <returns>input type (inputtype) and object (coordinate/string)</returns>
        public (Game.InputType, object) GetInputAndType()
        {
            bool _isValid;
            string _input;
            Coordinate _coordinate;
            Utility.Write($"{Name}, enter field or type 'back' to undo the last move: ");
            do
            {
                _input = Utility.ReadLine().Trim().ToLower();
                if (_input == "back")
                {
                    return (Game.InputType.Back, "back");
                }
                else
                {
                    (_isValid, _coordinate) = Coordinate.TryCreateCoordinateFromString(_input);
                }
            } while (!_isValid);
            return (Game.InputType.Coordinate, _coordinate);
        }
    }
}
