namespace TicTacToe.Test
{
    [TestClass]
    public class WinCheckerTest
    {
        [TestMethod]
        public void SetCurrentStateTest_VerticalLine()
        {
            Player _playerOne = new Player("Player 1", 'X');
            Player _playerTwo = new Player("Player 2", '0');
            Game _game = new Game(_playerOne, _playerTwo);

            _game.Field.Cells[0, 0].Symbol = 'X';
            _game.Field.Cells[1, 0].Symbol = 'X';
            _game.Field.Cells[2, 0].Symbol = 'X';

            WinChecker.SetCurrentState(_game);

            Assert.IsTrue(_game._state == Game.State.OVER);
        }

        [TestMethod]
        public void SetCurrentStateTest_HorizontalLine()
        {
            Player _playerOne = new Player("Player 1", 'X');
            Player _playerTwo = new Player("Player 2", '0');
            Game _game = new Game(_playerOne, _playerTwo);
            Field _field = new Field();
            _game.Field.Cells[0, 0].Symbol = 'X';
            _game.Field.Cells[0, 1].Symbol = 'X';
            _game.Field.Cells[0, 2].Symbol = 'X';

            WinChecker.SetCurrentState(_game);

            Assert.IsTrue(_game._state == Game.State.OVER);
        }

        [TestMethod]
        public void SetCurrentStateTest_DiagonalLine()
        {
            Player _playerOne = new Player("Player 1", 'X');
            Player _playerTwo = new Player("Player 2", '0');
            Game _game = new Game(_playerOne, _playerTwo);
            _game.Field.Cells[0, 0].Symbol = 'X';
            _game.Field.Cells[1, 1].Symbol = 'X';
            _game.Field.Cells[2, 2].Symbol = 'X';

            WinChecker.SetCurrentState(_game);

            Assert.IsTrue(_game._state == Game.State.OVER);
        }
    }
}