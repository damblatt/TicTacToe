﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public bool HasTurn { get; set; } = false;
        public string Symbol { get; set; }
        public bool HasWon { get; set; } = false;

        private Utility _helper = new Utility();

        public Player(String _name, String _symbol)
        { 
            this.Name = _name;
            this.Symbol = _symbol;
        }
        public int[] GetInput()
        {
            int[] position = new int[2];
            position[0] = _helper.ReadInt(1, $"Player {this.Name}, X: ");
            position[1] = _helper.ReadInt(1, $"Player {this.Name}, Y: ");
            return position;
        }

        public void AddScore(int _score)
        {
            Score += _score;
        }
    }
}
