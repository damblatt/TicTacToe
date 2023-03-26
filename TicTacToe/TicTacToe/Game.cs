namespace TicTacToe
{
    public class Game
    {
        public static int FieldSize { get; set; } = 3;
        public Field Field;
        public Player PlayerOne;
        public Player PlayerTwo;
        private Player? _currentPlayer = null;
        private GameState _state;
        private Stack<Field> _history;

        enum GameState
        {
            IDLE, RUNNING, OVER
        }

        /// <summary>
        /// creates a field, adds the players to the game and randomly sets the current player
        /// </summary>
        /// <param name="playerOne">Player one</param>
        /// <param name="playerTwo">Player two</param>
        public Game(Player playerOne, Player playerTwo)
        {
            _history = new Stack<Field>();
            _state = GameState.IDLE;

            AddField();
            AddPlayers(playerOne, playerTwo);
            SetCurrentPlayer();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            _state = GameState.RUNNING;
            WinChecker.Field = Field;

            SetCurrentPlayer();

            while (_state == GameState.RUNNING)
            {
                PrintField();

                // turn
                Coordinate _coordinate = GetCoordinate();
                OccupyCell(_coordinate);

                // win check
                if (WinChecker.IsGameWon())
                {
                    PrintField();
                    Utility.Write("Win");
                    _state = GameState.OVER;
                };

                // player rotation
                SetCurrentPlayer();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Stop()
        {

        }

        private void PrintField()
        {
            Console.Clear();
            Field.Print();
        }

        private Coordinate GetCoordinate()
        {
            Coordinate _coordinate;
            bool _isAvailable;

            do
            {
                _coordinate = _currentPlayer.GetInput();
                _isAvailable = Field.Cells[_coordinate.Row, _coordinate.Column].Free;
            } while (!_isAvailable);

            return _coordinate;
        }

        private void OccupyCell(Coordinate _coordinate)
        {
            Field.OccupyCell(_currentPlayer, _coordinate);
        }

        private void AddPlayers(Player _playerOne, Player _playerTwo)
        {
            PlayerOne = _playerOne;
            PlayerOne.AddPlayerToGame(this);

            PlayerTwo = _playerTwo;
            PlayerTwo.AddPlayerToGame(this);
        }

        public void SetIndividualPlayerInformation() // maybe migrate to player class?
        {
            SetIndividualNames();
            SetIndividualSymbols();
        }

        private void SetIndividualNames()
        {
            if (PlayerTwo.Name == PlayerOne.Name && PlayerOne.Name != "Player 2") PlayerTwo.Name = "Player 2";
            else if (PlayerTwo.Name == PlayerOne.Name && PlayerOne.Name == "Player 2") PlayerOne.Name = "Player 1";
        }

        private void SetIndividualSymbols()
        {
            if (PlayerTwo.Symbol == PlayerOne.Symbol && PlayerOne.Symbol != 'O') PlayerTwo.Symbol = 'O';
            else if (PlayerTwo.Symbol == PlayerOne.Symbol && PlayerOne.Symbol == 'O') PlayerOne.Symbol = 'X';
        }

        private void SetCurrentPlayer()
        {
            if (_currentPlayer == PlayerOne)
            {
                _currentPlayer = PlayerTwo;
            } 
            else if (_currentPlayer == PlayerTwo) {
                _currentPlayer = PlayerOne;
            }
            else
            {
                Random rnd = new Random();
                _currentPlayer = rnd.Next(100) < 50 ? PlayerOne : PlayerTwo;
                _history = new Stack<Field>();
            }
        }

        private void AddField()
        {
            Field = new Field(FieldSize);
        }
    }
}
