namespace TicTacToe.Test
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void OccupyCell()
        {
            Player _player = new Player("Player 1", 'X');
            Coordinate _coordinate = new Coordinate(0, 0);
            Field _field = new Field();

            _field.OccupyCell(_player, _coordinate);

            Assert.AreEqual(_field.Cells[_coordinate.Row, _coordinate.Column].Symbol, 'X');
        }
    }
}