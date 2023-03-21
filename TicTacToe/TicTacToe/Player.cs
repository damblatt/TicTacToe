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

        private Utility _helper = new Utility();

        public Player(int numberOfPlayer)
        {
            Name = $"Player {numberOfPlayer}";
            if (numberOfPlayer == 1)
            {
                Symbol = 'X'; // default
            } else if (numberOfPlayer == 2)
            {
                Symbol = 'O'; // default
            }
            switch (numberOfPlayer)
            {
                case 1: Symbol = 'X'; break;
                case 2: Symbol = 'O'; break;
                default: throw new Exception($"Illegal player number: {numberOfPlayer}");
            }
        }

        public Player(string _name, char _symbol)
        {
            Name = _name;
            Symbol = _symbol;
        }

        public Coordinate GetInput()
        {
            bool _isValid = false;
            Coordinate _coordinate;
            int[] position = new int[2];
            Utility.Write($"{Name}, enter field: ");
            string input = Console.ReadLine();
            do
            {
                (_isValid, _coordinate) = Coordinate.TryCreateCoordinate(input, 3);
            } while (!_isValid);
            return _coordinate;
        }

        public void AddScore(int _score)
        {
            Score += _score;
        }
    }
}
