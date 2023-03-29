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
        public Field Field { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        private Player _currentPlayer;
        private StateOfTheGame _state;
        private Stack<(Field, Player)> _history;
        private Player _winner;

        enum StateOfTheGame
        {
            IDLE, RUNNING, OVER
        }

        public enum InputType
        {
            Coordinate, Back, Unknown
        }

        /// <summary>
        /// creates a field, adds the players to the game and randomly sets the current player
        /// </summary>
        /// <param name="playerOne">Player one</param>
        /// <param name="playerTwo">Player two</param>
        public Game(Player playerOne, Player playerTwo)
        {
            CreateField();
            ShowStartScreen();
            
            AddPlayers(playerOne, playerTwo);
            SetCurrentPlayer();
            _history = new Stack<(Field, Player)>();
            _state = StateOfTheGame.IDLE;

            Field _field = (Field)Field.Clone();
            _history.Push((_field, _currentPlayer));
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            _state = StateOfTheGame.RUNNING;

            Random _random = new Random();
            _currentPlayer = _random.Next(100) < 50 ? PlayerOne : PlayerTwo;
            Game _game = this;

            while (_state == StateOfTheGame.RUNNING)
            {
                PrintField();

                (InputType _typeOfInput, object _input) = GetInputAndType();
                ProcessInput(_typeOfInput, _input);

                if (WinChecker.IsGameWon(_game))
                {
                    _winner = _currentPlayer;
                    Stop();
                    return;
                }

                SetCurrentPlayer();
            }
        }

        /// <summary>
        /// Stops the game
        /// </summary>
        public void Stop()
        {
            _state = StateOfTheGame.OVER;
            ShowEndScreen();
        }

        /// <summary>
        /// Creates a new game field
        /// </summary>
        private void CreateField()
        {
            Field = new Field();
        }

        /// <summary>
        /// customizes the players name and symbol. if no name is entered, the name stays the same
        /// </summary>
        public void CustomizePlayerProfile(Player _player)
        {
            // name
            {
                Utility.Write($"{_player.Name}, you can now enter a custom name if you want to: ");
                string? _newPlayerName = Console.ReadLine().Trim();
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

        /// <summary>
        /// Prints the start screen for a few seconds
        /// </summary>
        private void ShowStartScreen()
        {
            Console.Write(
                 "\r\n  _______ _   _______      _______             _       \r\n |__   __(_) |__   __|    |__   __|           (_)      \r\n    | |   _  ___| | __ _  ___| | ___   ___     _  __ _ \r\n    | |  | |/ __| |/ _` |/ __| |/ _ \\ / _ \\   | |/ _` |\r\n    | |  | | (__| | (_| | (__| | (_) |  __/   | | (_| |\r\n    |_|  |_|\\___|_|\\__,_|\\___|_|\\___/ \\___|   | |\\__,_|\r\n                                             _/ |      \r\n                                            |__/       \r\n"
            );
            Thread.Sleep( 1500 );
            Console.Clear();
        }

        /// <summary>
        /// Prints the end screen of the game
        /// </summary>
        private void ShowEndScreen()
        {
            Console.Clear();
            Console.Write(_winner.Name + " has won the game!");
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
            _history.Pop();
            (Field, _currentPlayer) = _history.Peek();
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
