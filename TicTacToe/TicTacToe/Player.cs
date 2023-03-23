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
        public int Score { get; set; } = 0;
        public bool HasTurn { get; set; } = false;
        public bool HasWon { get; set; } = false;
        public Game Game{ get; set; }

        public Player(string _name, char _symbol)
        {
            Name = _name;
            Symbol = _symbol;
        }

        public void AddPlayerToGame(Game _game)
        {
            Game = _game;
        }

        public Coordinate GetInput()
        {
            bool _isValid = false;
            string input;
            Coordinate _coordinate;
            int[] position = new int[2];
            Utility.Write($"{Name}, enter field: ");
            do
            {
                input = Console.ReadLine();
                (_isValid, _coordinate) = Coordinate.TryCreateCoordinate(input, 3);
            } while (!_isValid);
            return _coordinate;
        }

        public void CustomizePlayerProfiles()
        {
            // name
            {
                Utility.Write($"{Name}, you can now enter a custom name if you want to: ");
                string? _newPlayerName = Console.ReadLine().Trim();
                if (_newPlayerName != null && _newPlayerName != "")
                {
                    Name = _newPlayerName;
                }
            }

            // symbol
            {
                Utility.Write($"{Name}, please enter a symbol: ");
                Symbol = Utility.ReadSymbol();
            }

            Game.SetIndividualPlayerInformation();
        }

        public void AddScore(int _score)
        {
            Score += _score;
        }
    }
}
