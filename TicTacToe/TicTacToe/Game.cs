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
        public int FieldSize { get; set; }
        private Field _field;
        private List<Player> _listOfPlayers = new List<Player>();
        private Player _playerOne;
        private Player _playerTwo;
        private Stack<Field> _history;
        private GameState _state;
        private Utility _helper = new Utility();
        private Player _currentPlayer;

        enum GameState
        {
            RUNNING, OVER
        }

        /// <summary>
        /// Creating a (new) game creates a field and adds players to the game.
        /// </summary>
        public Game()
        {
            FieldSize = GetFieldSize();
            CreateField();
<<<<<<< HEAD
            GetPlayers();
            this._history = new Stack<Field>();
            this._state = GameState.OVER;

            Random rnd = new Random();
            this._currentPlayer = rnd.Next(100) < 50 ? _player1 : _player2;
=======
            AddPlayers();
            _history = new Stack<Field>();
>>>>>>> 7a633ccc2edc2c0c01d0d5e0bf451c62c5b0dc18
        }

        public void Start()
        {
            this._state = GameState.RUNNING;

            Console.Clear();

            // Game Loop
            while (this._state == GameState.RUNNING)
            {
                this._field.Draw();

                int[] position = this._currentPlayer.GetInput();

                position[0] = Math.Clamp(position[0], 0, this.FieldSize - 1);
                position[1] = Math.Clamp(position[0], 0, this.FieldSize - 1);

                this._field.SetCell(this._currentPlayer, position);

                if (this._currentPlayer == this._player1)
                    this._currentPlayer = this._player2;
                else 
                    this._currentPlayer = _player1;

                Console.Clear();
            }
        }

        public void Stop()
        {

        }

        private void AddPlayers()
        {
            _playerOne = new Player(1);
            _playerTwo = new Player(2);
            _listOfPlayers.Add(_playerOne);
            _listOfPlayers.Add(_playerTwo);

            CustomizePlayerProfiles();
            SetIndividualPlayerInformation();
            if (_playerTwo.Name == _playerOne.Name) _playerTwo.Name = "Player 2";
        }

        public void CustomizePlayerProfiles()
        {
            foreach (Player player in _listOfPlayers)
            {
                // get name
                {
                    _helper.Write($"{player.Name}, you can now enter a custom name if you want to: ");
                    string? playerName = Console.ReadLine().Trim();
                    if (playerName != null && playerName != "")
                    {
                        player.Name = playerName;
                    }
                }

                // get symbol
                {
                    _helper.Write($"{player.Name}, please enter a symbol: ");
                    player.Symbol = _helper.ReadSymbol();
                }
            }
        }

        public void SetIndividualPlayerInformation()
        {
            if (_playerTwo.Name == _playerOne.Name && _playerOne.Name != "Player 2") _playerTwo.Name = "Player 2";
            else if (_playerTwo.Name == _playerOne.Name && _playerOne.Name == "Player 2") _playerOne.Name = "Player 1";
        }

        public int GetFieldSize()
        {
            _helper.Write("Enter the field size: ");
            return _helper.ReadInt(3);
        }

        public void CreateField()
        {
            _field = new Field(FieldSize);
        }
    }
}
