using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// game of tic tac toe
    /// </summary>
    public class Game
    {
        public enum GameState
        {
            Idle, Running, Won, Draw
        }

        public enum InputType
        {
            Coordinate, Back, Unknown
        }

        /// <summary>
        /// field
        /// </summary>
        public Field Field { get; set; }

        /// <summary>
        /// player number one
        /// </summary>
        public Player PlayerOne { get; set; }

        /// <summary>
        /// player number two
        /// </summary>
        public Player PlayerTwo { get; set; }

        /// <summary>
        /// state of the game
        /// </summary>
        public GameState State { get; set; }

        private Player _currentPlayer { get; set; }

        private Stack<(Field, Player)> _history { get; set; }

        private Player _winner { get; set; }

        /// <summary>
        /// creates a field, adds the players to the game and randomly sets the current player
        /// </summary>
        /// <param name="playerOne">Player one</param>
        /// <param name="playerTwo">Player two</param>
        public Game(Player playerOne, Player playerTwo)
        {
            State = GameState.Idle;

            CreateField();
            AddPlayers(playerOne, playerTwo);
            SetCurrentPlayer();

            _history = new Stack<(Field, Player)>();
            _history.Push(((Field)Field.Clone(), _currentPlayer));
        }

        /// <summary>
        /// starts the game
        /// </summary>
        public void Start()
        {
            ShowStartScreen();
            State = GameState.Running;

            Field _field = (Field)Field.Clone();
            _history.Push((_field, _currentPlayer));

            while (State == GameState.Running)
            {
                PrintField();

                (InputType _typeOfInput, object _input) = GetInputAndType();
                ProcessInput(_typeOfInput, _input);

                WinChecker.SetCurrentState(this);
                if (State == GameState.Won)
                {
                    break;
                }

                SetCurrentPlayer();
            }

            _winner = _currentPlayer;
            Stop();
        }

        /// <summary>
        /// stops the game
        /// </summary>
        public void Stop()
        {
            if (State == GameState.Won)
            {
                ShowWinScreen();
            }
            else if (State == GameState.Draw)
            {
                ShowDrawScreen();
            }
        }

        /// <summary>
        /// customizes the players name and symbol. if no name is entered, the name stays the same
        /// </summary>
        public void CustomizePlayerProfile(Player _player)
        {
            // name
            {
                Utility.Write($"{_player.Name}, you can now enter a custom name if you want to: ");
                string? _newPlayerName = Utility.ReadLine().Trim();
                if (_newPlayerName != null && _newPlayerName != "")
                {
                    _player.Name = _newPlayerName;
                }
            }

            // symbol
            {
                Utility.Write($"{_player.Name}, please enter a symbol: ");
                _player.Symbol = Utility.ReadSymbol();
            }

            SetIndividualPlayerInformation();
        }

        private void CreateField()
        {
            Field = new Field();
        }

        private void ShowStartScreen()
        {
            Console.Clear();
            string _startScreenPath = "./StartScreen.txt";
            Utility.Write((File.ReadAllText(_startScreenPath)));
            Thread.Sleep( 2000 );
        }

        private void ShowWinScreen()
        {
            Console.Clear();
            Utility.Write(_winner.Name + " has won the game!");
        }

        private void ShowDrawScreen()
        {
            Console.Clear();
            Utility.Write("Draw!");
        }

        private void SetCurrentPlayer()
        {
            // first call
            if (_currentPlayer == null)
            {
                Random _random = new Random();
                _currentPlayer = _random.Next(100) < 50 ? PlayerOne : PlayerTwo;
            }

            if (_currentPlayer == PlayerOne)
            {
                _currentPlayer = PlayerTwo;
            }
            else
            {
                _currentPlayer = PlayerOne;
            }
        }

        private void PrintField()
        {
            Console.Clear();
            Field.Print();
        }

        private (InputType, object) GetInputAndType()
        {
            object _input;
            bool _isValid;
            InputType _typeOfInput;
            Coordinate _coordinate;

            do
            {
                (_typeOfInput, _input) = _currentPlayer.GetInputAndType();
                if (_typeOfInput == InputType.Coordinate)
                {
                    _coordinate = (Coordinate)_input;
                    _isValid = Field.Cells[_coordinate.Row, _coordinate.Column].Free;
                } 
                else if (_typeOfInput == InputType.Back)
                {
                    _isValid = (_history.Count > 1);
                    if (!_isValid)
                    {
                        Utility.Write("No moves have been made yet.\n");
                    }
                } 
                else
                {
                    _isValid = false;
                }
            } while (!_isValid);
            return (_typeOfInput, _input);
        }

        private void ProcessInput(InputType _typeOfInput, object _input)
        {
            if (_typeOfInput == InputType.Coordinate)
            {
                OccupyCell((Coordinate)_input);
            }
            else if (_typeOfInput == InputType.Back)
            {
                Back();
            }
        }

        private void OccupyCell(Coordinate _coordinate)
        {
            Field.OccupyCell(_currentPlayer, _coordinate);
            Field _field = (Field)Field.Clone();
            _history.Push((_field, _currentPlayer));
        }

        private void Back()
        {
            State = GameState.Running;
            _history.Pop();
            (Field _field, _currentPlayer) = _history.Peek();
            Field = (Field)_field.Clone();
        }

        private void AddPlayers(Player _playerOne, Player _playerTwo)
        {
            PlayerOne = _playerOne;
            PlayerTwo = _playerTwo;
        }

        private void SetIndividualPlayerInformation()
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
    }
}
