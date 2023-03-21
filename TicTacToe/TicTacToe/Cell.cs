using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public Coordinate Position { get; set; }
        public char Symbol { get; set; } = ' ';
        public bool Free { get; set; } = true;
    }
}
