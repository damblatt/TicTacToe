using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player _gameOnePlayerOne = new Player("Player 1", 'X');
            Player _gameOnePlayerTwo = new Player("Player 2", 'O');
            Game _gameOne = new Game(_gameOnePlayerOne, _gameOnePlayerTwo);
            _gameOne.Start();
        }
    }
}