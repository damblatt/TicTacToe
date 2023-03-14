using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Cell
    {
        public int[] Position { get; set; }
        public string Symbol { get; set; }
        public bool Free { get; set; } = false;
    }
}
