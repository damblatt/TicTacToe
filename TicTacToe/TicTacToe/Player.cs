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
        public int Score { get; set; }
        public bool HasTurn { get; set; }
        public string Symbol { get; set; }
        public bool HasWon { get; set; }

        public void GetInput()
        {

        }

        public void AddScore(int _score)
        {
            Score += _score;
        }
    }
}
