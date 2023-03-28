using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }
        public bool HasTurn { get; set; } = false;
        public bool HasWon { get; set; } = false;
        public Game Game{ get; set; }

        public Player(string _name, char _symbol)
        {
            Name = _name;
            Symbol = _symbol;
        }

        /// <summary>
        /// Adds the player to the game
        /// </summary>
        /// <param name="_game">The game to add the player to</param>
        public void AddPlayerToGame(Game _game)
        {
            Game = _game;
        }

        public (Game.InputType, object) GetInputAndType()
        {
            bool _isValid;
            string _input;
            Coordinate _coordinate;
            Utility.Write($"{Name}, enter field or type 'back' to undo the last move: ");
            do
            {
                _input = Console.ReadLine().Trim().ToLower();
                if (_input == "back")
                {
                    return (Game.InputType.Back, "back");
                }
                else
                {
                    (_isValid, _coordinate) = Coordinate.TryCreateCoordinate(_input);
                }
            } while (!_isValid);
            return (Game.InputType.Coordinate, _coordinate);
        }
    }
}
