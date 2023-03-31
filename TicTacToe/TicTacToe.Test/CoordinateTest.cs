namespace TicTacToe.Test
{
    [TestClass]
    public class CoordinateTest
    {
        [TestMethod]
        public void TryCreateCoordinate_InvalidInput()
        {
            Coordinate _coordinate;
            (bool _state, _coordinate) = Coordinate.TryCreateCoordinateFromString("test");
            Assert.AreEqual(false, _state);
        }

        [TestMethod]
        public void TryCreateCoordinate_Column()
        {
            Coordinate _coordinate;
            (bool _state, _coordinate) = Coordinate.TryCreateCoordinateFromString("A2");
            Assert.AreEqual(0, _coordinate.Column);
        }

        [TestMethod]
        public void TryCreateCoordinate_Row()
        {
            Coordinate _coordinate;
            (bool _state, _coordinate) = Coordinate.TryCreateCoordinateFromString("A2");
            Assert.AreEqual(1, _coordinate.Row);
        }
    }
}