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

        private Utility _helper = new Utility();

        public Player(int numberOfPlayer)
        {
            Name = $"Player {numberOfPlayer}";
            if (numberOfPlayer == 1)
            {
                Symbol = 'X';
            } else if (numberOfPlayer == 2)
            {
                Symbol = 'O';
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

        public int[] GetInput()
        {
            int[] position = new int[2];
            position[0] = _helper.ReadInt(1);
            position[1] = _helper.ReadInt(1);
            return position;
        }

        public void AddScore(int _score)
        {
            Score += _score;
        }
    }
}
