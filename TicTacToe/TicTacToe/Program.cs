using System.Text;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player _gameOnePlayerOne = new Player("Player 1", 'X');
            Player _gameOnePlayerTwo = new Player("Player 2", 'O');
            Player _gameTwoPlayerOne = new Player("Player 3", 'X');
            Player _gameTwoPlayerTwo = new Player("Player 4", 'O');
            Game _gameOne = new Game(_gameOnePlayerTwo, _gameOnePlayerTwo);
            Game _gameTwo = new Game(_gameTwoPlayerTwo, _gameTwoPlayerTwo);
            _gameOne.Start();
        }
    }
}