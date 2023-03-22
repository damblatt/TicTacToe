using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public static int FieldSize { get; set; } = 3;
        private Field _field;
        private List<Player> _listOfPlayers = new List<Player>();
        public Player PlayerOne;
        public Player PlayerTwo;
        private Player _currentPlayer;
        private GameState _state;
        private Stack<Field> _history;

        enum GameState
        {
            IDLE, RUNNING, OVER
        }

        /// <summary>
        /// Creating a (new) game creates a field and adds the players to the game.
        /// </summary>
        /// <param name="playerOne">Player one</param>
        /// <param name="playerTwo">Player two</param>
        public Game(Player playerOne, Player playerTwo)
        {
            CreateField();
            AddPlayers(playerOne, playerTwo);
            _history = new Stack<Field>();
            _state = GameState.IDLE;

            SetCurrentPlayer();
        }

        public void Start()
        {
            _state = GameState.RUNNING;
            
            Console.Clear();
            SetCurrentPlayer();

            while (_state == GameState.RUNNING)
            {
                _field.PrintField();
                Coordinate _coordinate;
                bool _isAvailable;
                do
                {
                    _coordinate = _currentPlayer.GetInput();
                    _isAvailable = _field.Cells[_coordinate.Y, _coordinate.X].Free;
                } while (!_isAvailable);

                _field.SetCell(_currentPlayer, _coordinate);

                if (_currentPlayer == PlayerOne)
                    _currentPlayer = PlayerTwo;
                else 
                    _currentPlayer = PlayerOne;

                Console.Clear();
            }
        }

        public void Stop()
        {

        }

        private void AddPlayers(Player _playerOne, Player _playerTwo)
        {
            PlayerOne = _playerOne;
            PlayerTwo = _playerTwo;
            _listOfPlayers.Add(PlayerOne);
            _listOfPlayers.Add(PlayerTwo);
        }

        private void AddPlayers(List<Player> _players)
        {
            PlayerOne = _players[0];
            PlayerTwo = _players[1];
            foreach (Player _player in _players)
            {
                _listOfPlayers.Add(_player);
                _player.AddPlayerToGame(this);
            }
        }

        public void SetIndividualPlayerInformation()
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

        public void SetCurrentPlayer()
        {
            Random rnd = new Random();
            _currentPlayer = rnd.Next(100) < 50 ? PlayerOne : PlayerTwo;
            _history = new Stack<Field>();
        }

        public int GetFieldSize()
        {
            Utility.Write("Enter the field size: ");
            return Utility.ReadInt(3);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
